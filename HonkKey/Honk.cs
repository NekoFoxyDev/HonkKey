using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonkKey
{
    internal static class Honk
    {
        private static MainForm Main;
        private static AddCommandForm AddForm;
        private static List<KeyBinds> Keys = new List<KeyBinds>();
        private static BinaryFormatter Serializ = new BinaryFormatter();
        public static bool HookKey = false;

        public static void Show()
        {
            Main = new MainForm();
            Main.ShowDialog();
            Main.Dispose();
        }

        public static void LoadKeys()
        {
            Main.StatusString.Text = "Load " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming\Space Station 14\data\keybinds.key";

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming\Space Station 14\data\keybinds.key"))
            {
                Main.StatusString.Text = "File not found " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming\Space Station 14\data\keybinds.key";
                return;
            }

            using (FileStream stream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming\Space Station 14\data\keybinds.key", FileMode.Open))
                Keys = (List<KeyBinds>)Serializ.Deserialize(stream);
            UpdateList();

            Main.DeleteKeyButton.Enabled = true;
            Main.SaveButton.Enabled = true;
            Main.AddButton.Enabled = true;
        }

        public static void SaveKeys()
        {
            using (FileStream stream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming\Space Station 14\data\keybinds.key", FileMode.OpenOrCreate))
                Serializ.Serialize(stream, Keys);
            if (Main != null)
                Main.StatusString.Text = "Saved " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming\Space Station 14\data\keybinds.key";
            GenerateConfig();
        }

        public static void ShowAdd()
        {
            AddForm = new AddCommandForm();
            AddForm.ShowDialog();
            AddForm.Dispose();

            UpdateList();
        }

        public static void UpdateList()
        {
            Main.KeyList.Items.Clear();
            foreach (var key in Keys)
                if(key.Prefix == "")
                    Main.KeyList.Items.Add("[" + key.Key + "] args >> " + key.Type + " " + key.Mode + " [" + key.CMD + "]");
                else
                    Main.KeyList.Items.Add("[" + key.Prefix + " + " + key.Key + "] args >> " + key.Type + " " + key.Mode + " [" + key.CMD + "]");
        }

        public static void AddKey(KeyBinds key)
        {
            Keys.Add(key);
            Main.StatusString.Text = "Keybind added [" + key.Key + "] args >> " + key.Type + " " + key.Mode + " [" + key.CMD + "]";
        }

        public static void DeleteKey(int ID)
        {
            if (ID < 0) return;
            Main.StatusString.Text = "Keybind deleted [" + Keys[ID].Key + "] args >> " + Keys[ID].Type + " " + Keys[ID].Mode + " [" + Keys[ID].CMD + "]";
            Keys.Remove(Keys[ID]);
            UpdateList();
        }

        public static void GenerateConfig()
        {
            string FileData = "version: 1\nbinds:\n";
            foreach(var key in Keys)
            {
                if(key.Prefix != "")
                {
                    FileData += "- modl: " + key.Prefix + "\n";
                    FileData += "  key: " + key.Key + "\n";
                }
                else
                    FileData += "- key: " + key.Key + "\n";
                FileData += "  type: " + key.Type + "\n";
                FileData += "  function: " + key.Mode + key.CMD + "\n";
            }
            FileData += "leaveEmpty: []\n...";
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming\Space Station 14\data\keybinds.yml", FileData);
        }
    }
}
