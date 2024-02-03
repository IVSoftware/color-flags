using System;
using System.ComponentModel;
using System.Reflection;

namespace color_flags
{
    sealed class SetColorAttribute : Attribute
    {
        public SetColorAttribute(string color) => Value = Color.FromName(color);
        public Color Value { get; }
    }

    /// <summary>
    /// Usage: LabelName setLabels = (LabelName) byteValue.
    /// </summary>
    [Flags]
    enum LabelName : byte // Casting 'any' byte to this enum instantly maps the bits. 
    {
        [SetColor("Red")]
        lblV10 = 0x01,

        [SetColor("Orange")]
        lblV50 = 0x02,

        [SetColor("Green")]
        lblV90 = 0x04,

        [SetColor("Green")]
        lblVBak = 0x08,

        [SetColor("Red")]
        lblW10 = 0x10,

        [SetColor("Orange")]
        lblW50 = 0x20,

        [SetColor("Green")]
        lblW90 = 0x40,

        [SetColor("Green")]
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
                            if (
                                typeof(LabelName)
                                .GetMember($"{name}")
                                .FirstOrDefault()?
                                .GetCustomAttribute(typeof(SetColorAttribute))
                                is
                                SetColorAttribute attr)
                            {
                                label.BackColor = attr.Value;
                            }
                            else label.BackColor = Color.Maroon; // Fallback
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
