using System;
using System.Collections.ObjectModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace ZiiDMSApp.Common.TestViews
{
    public sealed partial class ZtSplitViewPage : Page
    {
        public ObservableCollection<NavLink> NavLinks { get; } =
        [
            new NavLink() { Label = "People", Symbol = Symbol.People },
            new NavLink() { Label = "Globe", Symbol = Symbol.Globe },
            new NavLink() { Label = "Message", Symbol = Symbol.Message },
            new NavLink() { Label = "Mail", Symbol = Symbol.Mail }
        ];

        public ZtSplitViewPage()
        {
            this.InitializeComponent();
        }

        private void PanePlacement_Toggled(object sender, RoutedEventArgs e)
        {
            var ts = sender as ToggleSwitch;
            if (ts?.IsOn == true)
            {
                SplitViewControl.PanePlacement = SplitViewPanePlacement.Right;
            }
            else
            {
                SplitViewControl.PanePlacement = SplitViewPanePlacement.Left;
            }
        }

        private void displayModeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SplitViewControl.DisplayMode = (SplitViewDisplayMode)Enum.Parse(typeof(SplitViewDisplayMode),
                (e.AddedItems[0] as ComboBoxItem)?.Content.ToString() ?? string.Empty);
        }

        private void paneBackgroundCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var colorString = (e.AddedItems[0] as ComboBoxItem)?.Content.ToString();

            VisualStateManager.GoToState(this, colorString, false);
        }
      private void NavLinksList_ItemClick(object sender, ItemClickEventArgs e)
      {
         SplitViewContent.Text = (e.ClickedItem as NavLink).Label + " Page";
      }
   }

    public class NavLink
    {
        public string? Label { get; set; }
        public Symbol Symbol { get; set; }
    }
}