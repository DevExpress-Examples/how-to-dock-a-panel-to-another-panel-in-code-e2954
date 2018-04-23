using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Layout.Core;
using DevExpress.Xpf.Docking;

namespace DXDocking_DockingInCode {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        #region #1
        private void Button1_Click(object sender, RoutedEventArgs e) {
            // Dock the Properties panel at the bottom of the Output panel.
            dockManager1.DockController.Dock(paneProperties, paneOutput, DockType.Bottom);
        }

        private void Button2_Click(object sender, RoutedEventArgs e) {
            // Dock the Properties panel to the Output panel, creating a tab container.
            dockManager1.DockController.Dock(paneProperties, paneOutput, DockType.Fill);
        }
        #endregion #1

        private void UserControl_Loaded(object sender, RoutedEventArgs e) {
            paneProperties = (LayoutPanel)dockManager1.GetItem("paneProperties");
            paneOutput = (LayoutPanel)dockManager1.GetItem("paneOutput");
        }
    }
}
