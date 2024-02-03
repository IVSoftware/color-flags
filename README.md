## Use enum to map color flags.

One approach is that you can map the bits of a byte instantaneously to an `enum` that you set up for this purpose. Now you have a usable value representing the labels that are set.

`LabelName flags = (LabelName)serial.ReadExisting()`.

[![example][1]][1]

```csharp
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
```

___
##### SetColor attribute

In this case, we've made a simple custom attribute named `SetColor` to easily specify the background color that should be applied to the label when the flag is set. (This is optional.)

```
sealed class SetColorAttribute : Attribute
{
    public SetColorAttribute(string color) => Value = Color.FromName(color);
    public Color Value { get; }
}
```
##### Example

If the enumeration name is _also_ an exact match for the `Label` name on the form, you can use it to retrieve the `Control` using `tableLayoutPanel.Controls[name.ToString()]`. Here's a simple form that brings all the elements together.

```csharp
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
```
##### Simulate the received byte (sequentially or randomly)
```
    bool UseRandom { get; set; } = true;
    int count = 1;
    private byte MockReadExisting()
    {
        if(UseRandom) return Convert.ToByte(_rando.Next(0x100));
        else return Convert.ToByte(((count++) % 0xFF));
    }
    Random _rando = new Random(2);
}
```


  [1]: https://i.stack.imgur.com/bfJs1.png