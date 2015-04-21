namespace EnumExample
{
    using System.ComponentModel;

    public enum DaysEnum { 

        [Description("Sunday")]
        Sun, // = 0
        [Description("Monday")]
        Mon, // = 1
        [Description("Tuesday")]
        Tue, // = 2
        [Description("Wednesday")]
        Wed, // = 3
        [Description("Thursday")]
        Thu, // = 4
        [Description("Friday")]
        Fri, // = 5
        [Description("Saturday")]
        Sat // = 6
    };


}