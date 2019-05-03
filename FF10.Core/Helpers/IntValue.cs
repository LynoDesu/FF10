﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FF10.Core.Models;

namespace FF10.Core.Helpers
{
	public class IntValue
	{
		private readonly uint mAddress;
		private readonly uint mSize;

		public NameValueInfo Info { get; set; }

		public IntValue(uint address, uint size)
		{
			mAddress = address;
			mSize = size;
		}

		public uint Value
		{
			get { return SaveData.Instance().ReadNumber(mAddress, mSize); }
			set { SaveData.Instance().WriteNumber(mAddress, mSize, value); }
		}
	}
}
