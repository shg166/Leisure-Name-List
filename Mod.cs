using System;
using System.Reflection;
using UnityEngine;
using ColossalFramework.UI;
using ICities;

namespace JP_LeisureNameList
{
	public class JP_LeisureNameList : IUserMod
	{

		public string Name
		{
			get { return "JP Leisure Name List (CNL) v1.0"; }
		}

		public string Description
		{
			get { return "Custom Name Listsを使って、DLC Parklifeのパークエリア名を変更します"; }
		}

	}
}
