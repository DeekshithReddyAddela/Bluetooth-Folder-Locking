using System.IO;
using System;
using System.Text;
using System.Diagnostics;
namespace btprox
{
    /// <summary>
    /// events logger
    /// </summary>
    internal sealed class Logger
    {
        /// <summary>
        /// name of the event log source name
        /// </summary>
        private const String EventLogSourceName = "BtProx";

        /// <summary>
        /// full path to log file
        /// </summary>
        private readonly string m_strPath;

        /// <summary>
        /// windows event log instance
        /// </summary>
        private EventLog m_winLog;

        /// <summary>
        /// enable or disable windows logger
        /// </summary>
        public bool UseWindowsLog
        {
            get
            {
                return m_winLog != null;
            }
            set
            {
                if (value && m_winLog == null)
                {
                    m_winLog = new EventLog
                    {
                        Source = EventLogSourceName
                    };
                }
                else
                {
                    m_winLog = null;
                }
            }
        }

        /// <summary>
        /// default constructor of the log, if the path is <c>null</c> or empty
        /// no log will be kept
        /// </summary>
        ///
        /// <param name="strPath">
        /// path used to store the log
        /// </param>
        ///
        /// <param name="useEventLog">
        /// should windows log be used as a default?
        /// </param>
        internal Logger(string strPath, bool useEventLog)
        {
            m_strPath = strPath;
            UseWindowsLog = useEventLog;
        }

        /// <summary>
        /// save single log event
        /// </summary>
        ///
        /// <param name="strAction">
        /// action to be saved (actual event message)
        /// </param>
        ///
        /// <param name="strDevice">
        /// name of the device affected
        /// </param>
        internal void Event(string strAction, string strDevice)
        {
            /* builder used to create the message */
            StringBuilder sb;

            sb = new StringBuilder(DateTime.Now.ToShortDateString());
            sb.Append(' ');
            sb.Append(DateTime.Now.ToShortTimeString());
            sb.Append(' ');
            sb.Append(strDevice);
            sb.Append(' ');
            sb.Append(strAction);
            sb.Append(Environment.NewLine);

            /* do nothing if the file cannot be created */
            if (!string.IsNullOrEmpty(m_strPath))
            {
                try
                {
                    File.AppendAllText(m_strPath, sb.ToString());
                }
                catch
                { }
            }

            /* save this event into windows log */
            if (m_winLog != null)
            {
                try
                {
                    m_winLog.WriteEntry(sb.ToString());
                }
                catch
                {
                    m_winLog = null;
                }
            }
        }
    }
}
