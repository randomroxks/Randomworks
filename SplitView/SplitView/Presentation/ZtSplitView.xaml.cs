using System.Collections;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.UI;

namespace ZtClientFramework;

public partial class ZtSplitView : ZtControlBase
{
   public ZtSplitView()
   {
      InitializeComponent();
   }

   public double OpenPaneLength
   {
      get => (double)GetValue(OpenPaneLengthProperty);
      set => SetValue(OpenPaneLengthProperty, value);
   }

   public static readonly DependencyProperty OpenPaneLengthProperty =
       DependencyProperty.Register(
           nameof(OpenPaneLength),
           typeof(double),
           typeof(ZtSplitView),
           new PropertyMetadata(
               256,
               (s, e) => ((ZtSplitView)s)?.OpenPaneLengthPropertyChanged(e))
       );

   void OpenPaneLengthPropertyChanged(DependencyPropertyChangedEventArgs e)
   {
      // Method intentionally left empty.
      Console.WriteLine(e.NewValue);
   }

   public double CompactPaneLength
   {
      get => (double)GetValue(CompactPaneLengthProperty);
      set => SetValue(CompactPaneLengthProperty, value);
   }

   public static readonly DependencyProperty CompactPaneLengthProperty =
       DependencyProperty.Register(
           nameof(CompactPaneLength),
           typeof(double),
           typeof(ZtSplitView),
           new PropertyMetadata(
               48,
               (s, e) => ((ZtSplitView)s)?.CompactPaneLengthPropertyChanged(e))
       );

   void CompactPaneLengthPropertyChanged(DependencyPropertyChangedEventArgs e)
   {
      // Method intentionally left empty.
      Console.WriteLine(e.NewValue);
   }

   public SplitViewDisplayMode DisplayMode
   {
      get => (SplitViewDisplayMode)GetValue(DisplayModeProperty);
      set => SetValue(DisplayModeProperty, value);
   }

   public static readonly DependencyProperty DisplayModeProperty =
       DependencyProperty.Register(
           nameof(DisplayMode),
           typeof(SplitViewDisplayMode),
           typeof(ZtSplitView),
           new PropertyMetadata(
               SplitViewDisplayMode.Inline,
               (s, e) => ((ZtSplitView)s)?.DisplayModePropertyChanged(e))
       );

   void DisplayModePropertyChanged(DependencyPropertyChangedEventArgs e)
   {
      // Method intentionally left empty.
      Console.WriteLine(e.NewValue);
   }


   public Brush PaneBackground
   {
      get => (Brush)GetValue(PaneBackgroundProperty);
      set => SetValue(PaneBackgroundProperty, value);
   }
   public static readonly DependencyProperty PaneBackgroundProperty =
       DependencyProperty.Register(
           nameof(PaneBackground),
           typeof(Brush),
           typeof(ZtControlBase),
           new PropertyMetadata(
               new SolidColorBrush()
               {
                  Color = Colors.Transparent
               },
               (s, e) => ((ZtSplitView)s)?.PaneBackgroundPropertyChanged(e))
       );

   protected virtual void PaneBackgroundPropertyChanged(DependencyPropertyChangedEventArgs e)
   {
      // Method intentionally left empty.
   }

   public bool IsPaneOpen
   {
      get => (bool)GetValue(IsPaneOpenProperty);
      set => SetValue(IsPaneOpenProperty, value);
   }
   public static readonly DependencyProperty IsPaneOpenProperty =
       DependencyProperty.Register(
           nameof(IsPaneOpen),
           typeof(bool),
           typeof(ZtControlBase),
           new PropertyMetadata(
               true,
               (s, e) => ((ZtSplitView)s)?.IsPanelOpenPropertyChanged(e))
       );

   protected virtual void IsPanelOpenPropertyChanged(DependencyPropertyChangedEventArgs e)
   {
      // Method intentionally left empty.
   }

   // PanePlacement

   public SplitViewPanePlacement PanePlacement
   {
      get => (SplitViewPanePlacement)GetValue(PanePlacementProperty);
      set => SetValue(PanePlacementProperty, value);
   }
   public static readonly DependencyProperty PanePlacementProperty =
       DependencyProperty.Register(
           nameof(PanePlacement),
           typeof(SplitViewPanePlacement),
           typeof(ZtControlBase),
           new PropertyMetadata(
               SplitViewPanePlacement.Left,
               (s, e) => ((ZtSplitView)s)?.PanePlacementPropertyChanged(e))
       );

   protected virtual void PanePlacementPropertyChanged(DependencyPropertyChangedEventArgs e)
   {
      // Method intentionally left empty.
   }

   public UIElement Pane
   {
      get => (UIElement)this.GetValue(PaneProperty);
      set => this.SetValue(PaneProperty, (object)value);
   }

   public static DependencyProperty PaneProperty { get; } = DependencyProperty.Register(nameof(Pane), typeof(UIElement), typeof(ZtSplitView), new PropertyMetadata(null,
      (PropertyChangedCallback)((s, e) => ((ZtSplitView)s)?.OnPaneChanged(e))));

   private void OnPaneChanged(DependencyPropertyChangedEventArgs e)
   {
   }

   public new UIElement Content
   {
      get => (UIElement)this.GetValue(ContentProperty);
      set => this.SetValue(ContentProperty, (object)value);
   }

   public new static DependencyProperty ContentProperty { get; } = DependencyProperty.Register(nameof(Content), typeof(UIElement), typeof(ZtSplitView),
      new PropertyMetadata(null, (PropertyChangedCallback)((s, e) => ((ZtSplitView)s)?.OnContentChanged(e))));

   private void OnContentChanged(DependencyPropertyChangedEventArgs e)
   {
      // InvalidateMeasure();
   }

}
