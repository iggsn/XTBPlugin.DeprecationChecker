
using System.ComponentModel.Composition;

using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace XTBPlugin.DeprecationChecker
{
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Deprecation Checker"),
        ExportMetadata("Description", "Checks for current Deprecations and helps to rate them."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", null),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", null),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class DeprecationChecker : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new DeprecationCheckerControl();
        }
    }
}
