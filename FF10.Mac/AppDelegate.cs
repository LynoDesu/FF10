using AppKit;
using FF10.Core.Models;
using Foundation;

namespace FF10.Mac
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        [Export("openDocument:")]
        void OpenDialog(NSObject sender)
        {
            var dlg = NSOpenPanel.OpenPanel;
            dlg.CanChooseFiles = true;
            dlg.CanChooseDirectories = false;
            dlg.AllowedFileTypes = new string[] { "bin", "" };

            if (dlg.RunModal() == 1)
            {
                var path = dlg.Url.Path;

                if (path != null)
                {
                    if (SaveData.Instance().Open(path, false) == false)
                    {
                        var alert = new NSAlert()
                        {
                            AlertStyle = NSAlertStyle.Critical,
                            InformativeText = "There was a problem trying to load the FFX save file. Please ensure that this is a Nintendo Switch save file.",
                            MessageText = "Unable to load save",
                        };
                        alert.RunModal();
                        return;
                    }
                }
            }
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
