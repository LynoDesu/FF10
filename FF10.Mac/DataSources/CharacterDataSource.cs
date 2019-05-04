using System;
using System.Collections.Generic;
using AppKit;
using FF10.Core.Models;

namespace FF10.Mac.DataSources
{
    public class CharacterDataSource : NSTableViewSource
    {
        public Dictionary<uint, string> Characters = new Dictionary<uint, string>();

        public CharacterDataSource()
        {
        }

        public override nint GetRowCount(NSTableView tableView)
        {
            return Characters.Count;
        }
    }
}
