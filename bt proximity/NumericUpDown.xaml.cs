// Sample code developed by gautamg@microsoft.com
// Copyright (c) Microsoft Corporation. All rights reserved.

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Provider;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace btprox
{
    /// <summary>
    /// Interaction logic for NumericUpDown.xaml
    /// </summary>
    public partial class NumericUpDown
    {
        public NumericUpDown()
        {
            InitializeComponent();
        }

        #region Properties

        #region Value

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Identifies the Value dependency property.
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                "Value", typeof(double), typeof(NumericUpDown),
                new FrameworkPropertyMetadata(DefaultValue,
                    new PropertyChangedCallback(OnValueChanged),
                    CoerceValue
                )
            );

        private static void OnValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var control = (NumericUpDown)obj;

            var oldValue = (double)args.OldValue;
            var newValue = (double)args.NewValue;

            #region Fire Automation events
            if (AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged))
            {
                var peer =
                    UIElementAutomationPeer.FromElement(control) as NumericUpDownAutomationPeer;

                if (peer != null)
                {
                    peer.RaisePropertyChangedEvent(
                        RangeValuePatternIdentifiers.ValueProperty,
                        oldValue,
                        newValue);
                }
            }
            #endregion

            var e = new RoutedPropertyChangedEventArgs<double>(
                oldValue, newValue, ValueChangedEvent);

            control.OnValueChanged(e);
        }

        /// <summary>
        /// Raises the ValueChanged event.
        /// </summary>
        /// <param name="args">Arguments associated with the ValueChanged event.</param>
        protected virtual void OnValueChanged(RoutedPropertyChangedEventArgs<double> args)
        {
            RaiseEvent(args);
        }

        private static object CoerceValue(DependencyObject element, object value)
        {
            var newValue = (double)value;
            var control = (NumericUpDown)element;

            return Math.Max(control.Minimum, Math.Min(control.Maximum, newValue));
        }

        #endregion

        #region Minimum

        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register(
                "Minimum", typeof(double), typeof(NumericUpDown),
                new FrameworkPropertyMetadata(DefaultMinValue,
                    new PropertyChangedCallback(OnMinimumChanged), CoerceMinimum
                )
            );

        private static void OnMinimumChanged(DependencyObject element, DependencyPropertyChangedEventArgs args)
        {
            element.CoerceValue(MaximumProperty);
            element.CoerceValue(ValueProperty);
        }

        private static object CoerceMinimum(DependencyObject element, object value)
        {
            return value;
        }

        #endregion

        #region Maximum

        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(
                "Maximum", typeof(double), typeof(NumericUpDown),
                new FrameworkPropertyMetadata(DefaultMaxValue,
                    new PropertyChangedCallback(OnMaximumChanged),
                    CoerceMaximum
                )
            );

        private static void OnMaximumChanged(DependencyObject element, DependencyPropertyChangedEventArgs args)
        {
            element.CoerceValue(ValueProperty);
        }

        private static object CoerceMaximum(DependencyObject element, object value)
        {
            var control = (NumericUpDown)element;
            var newMaximum = (double)value;
            return Math.Max(newMaximum, control.Minimum);
        }

        #endregion

        #region Change

        public double Change
        {
            get { return (double)GetValue(ChangeProperty); }
            set { SetValue(ChangeProperty, value); }
        }

        public static readonly DependencyProperty ChangeProperty =
            DependencyProperty.Register(
                "Change", typeof(double), typeof(NumericUpDown),
                new FrameworkPropertyMetadata(DefaultChange,
                    new PropertyChangedCallback(OnChangeChanged),
                    CoerceChange),
                    ValidateChange
            );

        private static bool ValidateChange(object value)
        {
            var change = (double)value;
            return change > 0;
        }

        private static void OnChangeChanged(DependencyObject element, DependencyPropertyChangedEventArgs args)
        {
        }

        private static object CoerceChange(DependencyObject element, object value)
        {
            return value;
        }

        #endregion

        #endregion

        #region Events

        /// <summary>
        /// Identifies the ValueChanged routed event.
        /// </summary>
        public static readonly RoutedEvent ValueChangedEvent = EventManager.RegisterRoutedEvent(
            "ValueChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<double>), typeof(NumericUpDown));


        #endregion

        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return new NumericUpDownAutomationPeer(this);
        }

        private void UpButtonClick(object sender, RoutedEventArgs e)
        {
            Value++;
        }

        private void DownButtonClick(object sender, RoutedEventArgs e)
        {
            Value--;
        }

        private const double DefaultMinValue = 0;
        private const double DefaultValue = DefaultMinValue;
        private const double DefaultMaxValue = 100;
        private const double DefaultChange = 1;

        private class NumericUpDownAutomationPeer : FrameworkElementAutomationPeer, IRangeValueProvider
        {
            public NumericUpDownAutomationPeer(NumericUpDown control)
                : base(control)
            {
            }

            protected override string GetClassNameCore()
            {
                return "NumericUpDown";
            }

            protected override AutomationControlType GetAutomationControlTypeCore()
            {
                return AutomationControlType.Spinner;
            }

            public override object GetPattern(PatternInterface patternInterface)
            {
                if (patternInterface == PatternInterface.RangeValue)
                {
                    return this;
                }
                return base.GetPattern(patternInterface);
            }

            #region IRangeValueProvider Members

            bool IRangeValueProvider.IsReadOnly
            {
                get
                {
                    return !IsEnabled();
                }
            }

            double IRangeValueProvider.LargeChange
            {
                get { return MyOwner.Change; }
            }

            double IRangeValueProvider.Maximum
            {
                get { return MyOwner.Maximum; }
            }

            double IRangeValueProvider.Minimum
            {
                get { return MyOwner.Minimum; }
            }

            void IRangeValueProvider.SetValue(double value)
            {
                if (!IsEnabled())
                {
                    throw new ElementNotEnabledException();
                }

                if (value < MyOwner.Minimum || value > MyOwner.Maximum)
                {
                    throw new ArgumentOutOfRangeException("value");
                }

                MyOwner.Value = value;
            }

            double IRangeValueProvider.SmallChange
            {
                get { return MyOwner.Change; }
            }

            double IRangeValueProvider.Value
            {
                get { return MyOwner.Value; }
            }

            #endregion

            private NumericUpDown MyOwner
            {
                get
                {
                    return (NumericUpDown)Owner;
                }
            }
        }
    }

    internal class ValidIntegerRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var inputValue = value as string;
            int result;
            return new ValidationResult(
                int.TryParse(inputValue, NumberStyles.Integer, cultureInfo, out result), null);
        }
    }
}
