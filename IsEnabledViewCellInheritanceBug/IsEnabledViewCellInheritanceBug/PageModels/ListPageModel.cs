using System;
using PropertyChanged;

namespace IsEnabledViewCellInheritanceBug.PageModels
{
    [ImplementPropertyChanged]
    public class ListPageModel
    {
        public DateTime TheDate { get; set; }

        public string LabelText { get; set; }

        public TestEnum FooEnum { get; set; }

        public ListPageModel()
        {
            LabelText = "The date:";
            FooEnum = TestEnum.Disabled;
            TheDate = new DateTime(1986, 9, 10);
        }
    }
}