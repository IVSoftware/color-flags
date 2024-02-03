using System;
using System.ComponentModel;
using System.Reflection;

namespace color_flags
{
    sealed class BackColorAttribute : Attribute
    {
        public BackColorAttribute(string color) => Value = Color.FromName(color);
        public Color Value { get; }
    }
    [Flags]
    enum LabelName : byte
    {
        [BackColor("Red")]
        lblV10 = 0x01,

        [BackColor("Orange")]
        lblV50 = 0x02,

        [BackColor("Green")]
        lblV90 = 0x04,

        [BackColor("Green")]
        lblVBak = 0x08,

        [BackColor("Red")]
        lblW10 = 0x10,

        [BackColor("Orange")]
        lblW50 = 0x20,

        [BackColor("Green")]
        lblW90 = 0x40,

        [BackColor("Green")]
        lblWbak = 0x80,
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonReadExisting.Click += (sender, e) =>
            {
                // Generate sim data byte
                byte data = MockReadExisting();
                labelByte.Text = $"0x{data:X2}";

                foreach (LabelName name in Enum.GetValues(typeof(LabelName)))
                {
                    if (tableLayoutPanel.Controls[$"{name}"] is Label label)
                    {
                        if (((LabelName)data).HasFlag(name))
                        {
                            if(
                                typeof(LabelName)
                                .GetMember($"{name}")
                                .FirstOrDefault()?
                                .GetCustomAttribute(typeof(BackColorAttribute))
                                is
                                BackColorAttribute attr)
                            {
                                label.BackColor = attr.Value;
                            }
                            else label.BackColor = Color.Maroon;
                        }
                        else label.BackColor = Color.Black;
                    }
                }
            };
        }
        bool UseRandom { get; set; } = true;
        int count = 1;
        private byte MockReadExisting()
        {
            if(UseRandom) return Convert.ToByte(_rando.Next(0x100));
            else return Convert.ToByte(((count++) % 0xFF));
        }
        Random _rando = new Random(2);
    }
}
