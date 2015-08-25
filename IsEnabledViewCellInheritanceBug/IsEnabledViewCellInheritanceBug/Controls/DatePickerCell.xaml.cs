using System;
using Xamarin.Forms;

namespace IsEnabledViewCellInheritanceBug.Controls
{
    public partial class DatePickerCell : ViewCell
    {
        public static readonly BindableProperty FormatProperty = BindableProperty.Create<DatePickerCell, string>(ctrl => ctrl.DatePickerControl.Format,
        defaultValue: "dd-MM-yyyy",
        defaultBindingMode: BindingMode.TwoWay,
        propertyChanging: (bindable, oldValue, newValue) =>
        {
            var ctrl = (DatePickerCell)bindable;
            ctrl.Format = newValue;
        });

        public string Format
        {
            get { return (string)GetValue(FormatProperty); }
            set
            {
                SetValue(FormatProperty, value);
                DatePickerControl.Format = value;
            }
        }

        public static readonly BindableProperty LabelProperty = BindableProperty.Create<DatePickerCell, string>(ctrl => ctrl.Label,
        defaultValue: string.Empty,
        defaultBindingMode: BindingMode.TwoWay,
        propertyChanging: (bindable, oldValue, newValue) =>
        {
            var ctrl = (DatePickerCell)bindable;
            ctrl.Label = newValue;
        });

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set
            {
                SetValue(LabelProperty, value);
                DescriptionLabel.Text = value;
            }
        }

        public static readonly BindableProperty DateProperty = BindableProperty.Create<DatePickerCell, DateTime>(ctrl => ctrl.Date,
        defaultValue: DateTime.Now,
        defaultBindingMode: BindingMode.TwoWay,
        propertyChanging: (bindable, oldValue, newValue) =>
        {
            var ctrl = (DatePickerCell)bindable;
            ctrl.Date = newValue;
        });

        public DateTime Date
        {
            get { return (DateTime)GetValue(DateProperty); }
            set
            {
                SetValue(DateProperty, value);
                DatePickerControl.Date = value;
            }
        }

        public static readonly BindableProperty MinimumDateProperty = BindableProperty.Create<DatePickerCell, DateTime>(ctrl => ctrl.DatePickerControl.MinimumDate,
        defaultValue: DateTime.Now,
        defaultBindingMode: BindingMode.TwoWay,
        propertyChanging: (bindable, oldValue, newValue) =>
        {
            var ctrl = (DatePickerCell)bindable;
            ctrl.MinimumDate = newValue;
        });

        public DateTime MinimumDate
        {
            get { return (DateTime)GetValue(MinimumDateProperty); }
            set
            {
                SetValue(DateProperty, value);
                DatePickerControl.MinimumDate = value;
            }
        }

        public static readonly BindableProperty MaximumDateProperty = BindableProperty.Create<DatePickerCell, DateTime>(ctrl => ctrl.DatePickerControl.MaximumDate,
        defaultValue: DateTime.Now,
        defaultBindingMode: BindingMode.TwoWay,
        propertyChanging: (bindable, oldValue, newValue) =>
        {
            var ctrl = (DatePickerCell)bindable;
            ctrl.MaximumDate = newValue;
        });

        public DateTime MaximumDate
        {
            get { return (DateTime)GetValue(MaximumDateProperty); }
            set
            {
                SetValue(DateProperty, value);
                DatePickerControl.MaximumDate = value;
            }
        }

        public DatePickerCell()
        {
            InitializeComponent();

            DatePickerControl.Format = "dd-MM-yyyy";
        }

        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            Date = e.NewDate;
        }
    }
}