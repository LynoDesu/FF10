using System.ComponentModel;
using FF10.Core.Helpers;

namespace FF10.Core.Models
{
    public class Equipment : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public Equipment(uint address)
		{
			mAddress = address;
		}

		public uint ID
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 6, 2); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 6, 2, value);
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(ID)));
			}
		}

		public uint SlotCount
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 5, 1); }
			set { Util.WriteNumber(mAddress + 5, 1, value, 0, 4); }
		}

		public uint Abilitie1
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 8, 2); }
			set { SaveData.Instance().WriteNumber(mAddress + 8, 2, value); }
		}

		public uint Abilitie2
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 10, 2); }
			set { SaveData.Instance().WriteNumber(mAddress + 10, 2, value); }
		}

		public uint Abilitie3
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 12, 2); }
			set { SaveData.Instance().WriteNumber(mAddress + 12, 2, value); }
		}

		public uint Abilitie4
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 14, 2); }
			set { SaveData.Instance().WriteNumber(mAddress + 14, 2, value); }
		}

		private readonly uint mAddress;
	}
}
