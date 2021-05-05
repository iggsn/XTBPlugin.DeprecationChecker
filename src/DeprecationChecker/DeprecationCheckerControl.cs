using System;

using WeifenLuo.WinFormsUI.Docking;

using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Args;
using XrmToolBox.Extensibility.Interfaces;

namespace XTBPlugin.DeprecationChecker
{
    public partial class DeprecationCheckerControl : PluginControlBase, IGitHubPlugin, IStatusBarMessenger
    {
        #region IGitHubPlugin        
        public string RepositoryName => "XTBPlugin.DeprecationChecker";

        public string UserName => "iggsn";
        #endregion

        #region IStatusBarMessenger
        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;
        #endregion

        public DeprecationCheckerControl()
        {
            InitializeComponent();
            var theme = new VS2015LightTheme();
            dockPanel1.Theme = theme;
        }
    }
}
