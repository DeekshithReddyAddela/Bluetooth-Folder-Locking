using System;
using System.Windows.Forms;
using btprox.Properties;

namespace btprox
{
    /// <summary>
    /// delegate used to send new settings to listeners
    /// </summary>
    ///
    /// <param name="set">
    /// new settings
    /// </param>
    internal delegate void SettingsChangedDelegate(Settings set);

    class OptionsController
    {
        /// <summary>
        /// instance of options form
        /// </summary>
        private readonly OptionsForm m_form;

        /// <summary>
        /// local copy of settings
        /// </summary>
        private readonly Settings m_set;

        /// <summary>
        /// parent form
        /// </summary>
        private readonly Form m_parent;

        /// <summary>
        /// event thrown on changed settings
        /// </summary>
        private SettingsChangedDelegate m_settingsChanged;

        /// <summary>
        /// change of settings
        /// </summary>
        internal event SettingsChangedDelegate SettingsChanged
        {
            add { m_settingsChanged += value; }
            remove { m_settingsChanged -= value; }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        ///
        /// <param name="set">
        /// application settings
        /// </param>
        ///
        /// <param name="parent">
        /// parent form, used to run GUI operations in parent thread
        /// </param>
        internal OptionsController(Settings set, Form parent)
        {
            m_set = set;

            m_form = new OptionsForm(parent);
            m_form.SaveHandler += SaveSettingsHandler;

            /* initial settins */
            m_form.ShowBaloons = set.ShowBaloons;
            m_form.ScanPeriod = set.Period;
            m_form.Language = set.locale;
            m_form.SoundEnabled = set.soundEnabled;
            m_form.UseWindowsLog = set.useWindowsLog;

            m_parent = parent;
        }

        /// <summary>
        /// shows options form
        /// </summary>
        internal void ShowForm()
        {
            /* ensure we are running in parent's thread */
            if (m_parent != null &&
                !m_parent.Disposing &&
                m_parent.InvokeRequired)
            {
                m_parent.Invoke((MethodInvoker)ShowForm);
                return;
            }

            m_form.ShowDialog();
        }

        /// <summary>
        /// handler of settings change
        /// </summary>
        ///
        /// <param name="sender">
        /// sender of the event
        /// </param>
        ///
        /// <param name="arg">
        /// arguments of the event
        /// </param>
        internal void SaveSettingsHandler(object sender, EventArgs arg)
        {
            m_form.Hide();

            if (m_settingsChanged != null)
            {
                m_set.ShowBaloons = m_form.ShowBaloons;
                m_set.Period = m_form.ScanPeriod;
                if (m_set.locale != m_form.Language)
                {
                    ShowLanguageWarning();
                }
                m_set.locale = m_form.Language;
                m_set.soundEnabled = m_form.SoundEnabled;
                m_set.useWindowsLog = m_form.UseWindowsLog;
                m_settingsChanged(m_set);
            }
        }

        /// <summary>
        /// shows warning message requiring to restart the program
        /// </summary>
        private void ShowLanguageWarning()
        {
            var parent = (BtProxLock)m_parent;

            /* message shown to the user */
            MessageBox.Show(parent.GetMessage("languageWarning"));
        }
    }
}
