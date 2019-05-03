﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FF10.Core.Models;

namespace FF10.Core.Helpers
{
	public class BitValue
	{
		private readonly uint mAddress;
		public NameValueInfo Info { get; set; }

		public BitValue(uint address, NameValueInfo info)
		{
			mAddress = address;
			Info = info;
		}

		public bool Have
		{
			get { return SaveData.Instance().ReadBit(mAddress + Info.Value / 8, Info.Value % 8); }
			set { SaveData.Instance().WriteBit(mAddress + Info.Value / 8, Info.Value % 8, value); }
		}
	}
}
