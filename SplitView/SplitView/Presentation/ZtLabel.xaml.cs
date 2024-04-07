namespace ZtClientFramework;

using Microsoft.UI.Xaml;
using System;

public partial class ZtLabel : ZtControlBase
{
    public ZtLabel()
    {
        InitializeComponent();
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
            nameof(Text),
            typeof(string),
            typeof(ZtLabel),
            new PropertyMetadata(
                default(string),
                (s, e) => ((ZtLabel)s)?.TextPropertyChanged(e))
        );

    void TextPropertyChanged(DependencyPropertyChangedEventArgs e)
    {
        ContentControl.Text = e.NewValue.ToString();
        UpdateLayout();
    }

    public TextWrapping TextWrapping
    {
        get => (TextWrapping)GetValue(TextWrappingProperty);
        set => SetValue(TextWrappingProperty, value);
    }

    public static readonly DependencyProperty TextWrappingProperty =
        DependencyProperty.Register(
            nameof(TextWrapping),
            typeof(TextWrapping),
            typeof(ZtLabel),
            new PropertyMetadata(
                default(string),
                (s, e) => ((ZtLabel)s)?.TextWrappingPropertyChanged(e))
        );

    void TextWrappingPropertyChanged(DependencyPropertyChangedEventArgs e)
    {
        ContentControl.TextWrapping = (TextWrapping)e.NewValue;
        UpdateLayout();
    }


#if !__ANDROID__
    public TextAlignment TextAlignment
#else
    public new TextAlignment TextAlignment
#endif

    {
        get => (TextAlignment)GetValue(TextAlignmentProperty);
        set => SetValue(TextAlignmentProperty, value);
    }

    public static readonly DependencyProperty TextAlignmentProperty =
        DependencyProperty.Register(
            nameof(TextAlignment),
            typeof(TextAlignment),
            typeof(ZtLabel),
            new PropertyMetadata(
                default(string),
                (s, e) => ((ZtLabel)s)?.TextAlignmentPropertyChanged(e))
        );

    void TextAlignmentPropertyChanged(DependencyPropertyChangedEventArgs e)
    {
        ContentControl.TextAlignment = (TextAlignment)e.NewValue;
        UpdateLayout();
    }


    protected override void HeaderTextPropertyChanged(DependencyPropertyChangedEventArgs e)
    {
        base.HeaderTextPropertyChanged(e);
    }
}