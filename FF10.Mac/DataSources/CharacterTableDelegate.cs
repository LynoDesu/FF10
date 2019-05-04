using System;
using AppKit;
using Foundation;

namespace FF10.Mac.DataSources
{
    public class CharacterTableDelegate : NSTableViewDelegate
    {
        const string CellIdentifier = "CharacterCell";

        CharacterDataSource DataSource;

        public CharacterTableDelegate(CharacterDataSource dataSource)
        {
            DataSource = dataSource;
        }

        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);

            if (view == null)
            {
                view = new NSTextField
                {
                    Identifier = CellIdentifier,
                    BackgroundColor = NSColor.Clear,
                    Bordered = false,
                    Selectable = false,
                    Editable = false
                };
            }

            view.StringValue = DataSource.Characters[(uint)row];

            return view;
        }
    }
}
