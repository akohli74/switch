using System;
using System.Collections.Generic;
using System.Text;

namespace switchboard
{
	public class SwitchBoard
	{
		private static Dictionary<string, bool> switches { get; set; }

		static SwitchBoard()
		{
			switches = new Dictionary<string, bool>();

			switches["testswitch_a"] = true;
		}

		public static void Switch(string switchName, Action onAction, Action offAction)
		{
			if(switches[switchName])
			{
				onAction();
			} else
			{
				offAction();
			}
		}
	}
}
