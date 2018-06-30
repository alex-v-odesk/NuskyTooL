using System;

namespace NuskyTool.Classes.Settings {
	public class Settings {
		public static void setSetting(Setting setting, string value) {
			Properties.Settings.Default[setting.ToString()] = value;
		}

		public static string getSetting(Setting setting) {
			return Properties.Settings.Default[setting.ToString()].ToString();
		}

		public static void saveSettings() {
			Properties.Settings.Default.Save();
			Properties.Settings.Default.Upgrade();
		}
	}

	public enum Setting {
		PathServer
	}
}
