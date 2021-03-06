﻿using System;
using System.Collections.Generic;

namespace FF10
{
	class Info
	{
		private static Info mThis;
		public List<NameValueInfo> Party { get; private set; } = new List<NameValueInfo>();
		public List<NameValueInfo> Items { get; private set; } = new List<NameValueInfo>();
		public List<NameValueInfo> KeyItems { get; private set; } = new List<NameValueInfo>();
		public List<NameValueInfo> Equipments { get; private set; } = new List<NameValueInfo>();
		public List<NameValueInfo> Abilities { get; private set; } = new List<NameValueInfo>();
		public List<NameValueInfo> Skills { get; private set; } = new List<NameValueInfo>();
		public List<NameValueInfo> OverDrives { get; private set; } = new List<NameValueInfo>();

		public List<NameValueInfo> Blitz_Player { get; private set; } = new List<NameValueInfo>();
		public List<NameValueInfo> Blitz_Skill { get; private set; } = new List<NameValueInfo>();

		public List<NameValueInfo> Monsters { get; private set; } = new List<NameValueInfo>();

		private Info() { }

		public static Info Instance()
		{
			if (mThis == null)
			{
				mThis = new Info();
				mThis.Init();
			}
			return mThis;
		}

		public NameValueInfo Search<Type>(List<Type> list, uint id)
			where Type : NameValueInfo, new()
		{
			int min = 0;
			int max = list.Count;
			for (; min < max;)
			{
				int mid = (min + max) / 2;
				if (list[mid].Value == id) return list[mid];
				else if (list[mid].Value > id) max = mid;
				else min = mid + 1;
			}
			return null;
		}

		private void Init()
		{
			AppendList("info\\character.txt", Party);
			AppendList("info\\item.txt", Items);
			AppendList("info\\key.txt", KeyItems);
			AppendList("info\\equipment.txt", Equipments);
			AppendList("info\\ability.txt", Abilities);
			AppendList("info\\skill.txt", Skills);
			AppendList("info\\overdrive.txt", OverDrives);

			AppendList("info\\blitz_player.txt", Blitz_Player);
			AppendList("info\\blitz_skill.txt", Blitz_Skill);

			AppendList("info\\monster.txt", Monsters);
		}

		private void AppendList<Type>(String filename, List<Type> items)
			where Type : ILineAnalysis, new()
		{
			if (!System.IO.File.Exists(filename)) return;
			String[] lines = System.IO.File.ReadAllLines(filename);
			foreach (String line in lines)
			{
				if (line.Length < 3) continue;
				if (line[0] == '#') continue;
				String[] values = line.Split('\t');
				if (values.Length < 2) continue;
				if (String.IsNullOrEmpty(values[0])) continue;
				if (String.IsNullOrEmpty(values[1])) continue;

				Type type = new Type();
				if(type.Line(values))
				{
					items.Add(type);
				}
			}

			items.Sort();
		}
	}
}
