namespace ZtClientFramework;

using Microsoft.UI.Xaml;
using System.Windows.Input;
using ZtFramework;


public partial class ZtControlBase : UserControl, IZtControlPermissions
{
   protected const int MinControlWidth = 44;
   protected const int MinControlHeight = 44;
   protected const int DefaultColumnSpacing = 5;
   protected const int DefaultRowSpacing = 5;
   protected const int DefaultMargin = 5;
   protected const int DefaultPadding = 5;
   protected ZtControlBase()
   {
      DefaultStyleKey = typeof(ZtControlBase);
      Unloaded += ControlLoaded;
   }
   
   ~ZtControlBase()
   {
      Unloaded -= ControlLoaded;
   }


   public ZtPermissions? ControlPermissions
   {
      get => (ZtPermissions)GetValue(ControlPermissionsProperty);
      set => SetValue(ControlPermissionsProperty, value);
   }

    public static readonly DependencyProperty ControlPermissionsProperty =
        DependencyProperty.Register(
            nameof(ControlPermissions),
            typeof(ZtPermissions),
            typeof(ZtControlBase),
            new PropertyMetadata(
                default(ZtPermissions),
                (s, e) => ((ZtControlBase)s)?.ZtControlPermissionsChanged(e))
        );

   private void ZtControlPermissionsChanged(DependencyPropertyChangedEventArgs e)
   {
      if (e.NewValue is not ZtPermissions permissions) return;
      switch (permissions.ControlPermissions)
      {
         case ZtControlPermissionsEnum.Hidden:
            Visibility = Visibility.Collapsed;
            IsEnabled = false;
            break;
         case ZtControlPermissionsEnum.ShowNotEdit:
            IsEnabled = false;
            Visibility = Visibility.Visible;
            break;
         default:
            IsEnabled = true;
            Visibility = Visibility.Visible;
            break;
      }
      UpdateLayout();
   }


    public string HeaderText
    {
        get => (string)GetValue(HeaderTextProperty);
        set => SetValue(HeaderTextProperty, value);
    }

    public static readonly DependencyProperty HeaderTextProperty =
        DependencyProperty.Register(
            nameof(HeaderText),
            typeof(string),
            typeof(ZtControlBase),
            new PropertyMetadata(
                default(string),
                (s, e) => ((ZtControlBase)s)?.HeaderTextPropertyChanged(e))
        );

    protected virtual void HeaderTextPropertyChanged(DependencyPropertyChangedEventArgs e)
    {
       // Method intentionally left empty.
    }

    public ICommand ValidationCommand
    {
        get => (ICommand)GetValue(ValidationCommandProperty);
        set => SetValue(ValidationCommandProperty, value);
    }

    public static readonly DependencyProperty ValidationCommandProperty =
        DependencyProperty.Register(
            nameof(ValidationCommand),
            typeof(ICommand),
            typeof(ZtControlBase),
            new PropertyMetadata(
                default(ZtPermissions),
                (s, e) => ((ZtControlBase)s)?.ValidationCommandChanged(e))
        );
    protected virtual void ValidationCommandChanged(DependencyPropertyChangedEventArgs e)
    {
       // Method intentionally left empty.
    }

   public Style ControlStyle
   {
      get => (Style)GetValue(ControlStyleProperty);
      set => SetValue(ControlStyleProperty, value);
   }
   public static readonly DependencyProperty ControlStyleProperty =
      DependencyProperty.Register(
         nameof(ControlStyle),
         typeof(Style),
         typeof(ZtControlBase),
         new PropertyMetadata(
            default(Style),
            (s, e) => ((ZtControlBase)s)?.ControlStyleChanged(s, e))
      );

    protected virtual void ControlStyleChanged(DependencyObject s, DependencyPropertyChangedEventArgs e)
    {
       // Method intentionally left empty.
    }
    
    public Style HeaderStyle
    {
       get => (Style)GetValue(HeaderStyleProperty);
       set => SetValue(HeaderStyleProperty, value);
    }
    public static readonly DependencyProperty HeaderStyleProperty =
       DependencyProperty.Register(
          nameof(HeaderStyle),
          typeof(Style),
          typeof(ZtControlBase),
          new PropertyMetadata(
             default(Style),
             (s, e) => ((ZtControlBase)s)?.HeaderControlStyleChanged(s, e))
       );

    protected virtual void HeaderControlStyleChanged(DependencyObject s, DependencyPropertyChangedEventArgs e)
    {
       // Method intentionally left empty.
    }
    
    public Style ErrorMessageStyle
    {
       get => (Style)GetValue(ErrorMessageStyleProperty);
       set => SetValue(ErrorMessageStyleProperty, value);
    }
    public static readonly DependencyProperty ErrorMessageStyleProperty =
       DependencyProperty.Register(
          nameof(ErrorMessageStyle),
          typeof(Style),
          typeof(ZtControlBase),
          new PropertyMetadata(
             default(Style),
             (s, e) => ((ZtControlBase)s)?.ErrorMessageStyleChanged(s, e))
       );

    protected virtual void ErrorMessageStyleChanged(DependencyObject s, DependencyPropertyChangedEventArgs e)
    {
       // Method intentionally left empty.
    }
    

   public string ErrorMessage
   {
      get => (string)GetValue(ErrorMessageProperty);
      set => SetValue(ErrorMessageProperty, value);
   }

   public static readonly DependencyProperty ErrorMessageProperty =
      DependencyProperty.Register(
         nameof(ErrorMessage),
         typeof(string),
         typeof(ZtControlBase),
         new PropertyMetadata(
            default(string),
            (s, e) => ((ZtControlBase)s)?.ErrorMessagePropertyChanged(s,e))
      );

   protected virtual void ErrorMessagePropertyChanged(object sender, DependencyPropertyChangedEventArgs e)
   {
      // Method intentionally left empty.
   }

   protected virtual void ControlLoaded(object sender, RoutedEventArgs e)
   {
      // Method intentionally left empty.
   }
}