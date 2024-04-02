using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonkKey
{
    public partial class AddCommandForm : Form
    {
        private string[] supported = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                                       "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Home", "Insert", "Delete", "PageUp", "PageDown" };

        public bool Hooking = false;
        public string CurrenKey = "";
        public string Prefix = "";

        public AddCommandForm()
        {
            InitializeComponent();
        }

        private void HookButton_Click(object sender, EventArgs e)
        {
            this.Focus();
            this.KeyPreview = true;
            HookButton.Text = "Нажмите";
            if(!Hooking)
            {
                KeyCodeString.Text = "";
                CurrenKey = "";
                Prefix = "";
            }
            Hooking = true;
            Honk.HookKey = true;
        }

        private void AddCommandForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (Honk.HookKey)
            {   
                switch (e.KeyCode)
                {
                    case Keys.ControlKey:
                        Prefix = "Control";
                        KeyCodeString.Text = "Control + ";
                        HookButton.Text = "Захват";
                        return;
                    case Keys.Menu:
                        Prefix = "Alt";
                        KeyCodeString.Text = "Alt + ";
                        HookButton.Text = "Захват";
                        return;
                    case Keys.ShiftKey:
                        Prefix = "Shift";
                        KeyCodeString.Text = "Shift + ";
                        HookButton.Text = "Захват";
                        return;



                    case Keys.D0: CurrenKey = "Num0"; break;
                    case Keys.D1: CurrenKey = "Num1"; break;
                    case Keys.D2: CurrenKey = "Num2"; break;
                    case Keys.D3: CurrenKey = "Num3"; break;
                    case Keys.D4: CurrenKey = "Num4"; break;
                    case Keys.D5: CurrenKey = "Num5"; break;
                    case Keys.D6: CurrenKey = "Num6"; break;
                    case Keys.D7: CurrenKey = "Num7"; break;
                    case Keys.D8: CurrenKey = "Num8"; break;
                    case Keys.D9: CurrenKey = "Num9"; break;

                    case Keys.NumPad0: CurrenKey = "NumpadNum0"; break;
                    case Keys.NumPad1: CurrenKey = "NumpadNum1"; break;
                    case Keys.NumPad2: CurrenKey = "NumpadNum2"; break;
                    case Keys.NumPad3: CurrenKey = "NumpadNum3"; break;
                    case Keys.NumPad4: CurrenKey = "NumpadNum4"; break;
                    case Keys.NumPad5: CurrenKey = "NumpadNum5"; break;
                    case Keys.NumPad6: CurrenKey = "NumpadNum6"; break;
                    case Keys.NumPad7: CurrenKey = "NumpadNum7"; break;
                    case Keys.NumPad8: CurrenKey = "NumpadNum8"; break;
                    case Keys.NumPad9: CurrenKey = "NumpadNum9"; break;

                    default:
                        foreach(var ck in supported)
                        {
                            if (ck == e.KeyCode.ToString())
                                CurrenKey += ck;
                        }
                        break;
                }
                KeyCodeString.Text += CurrenKey;
                HookButton.Text = "Захват";
                Honk.HookKey = false;
                Hooking = false;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (KeyCodeString.Text == "")
                return;
            KeyBinds newkey = new KeyBinds();
            newkey.Key = CurrenKey;
            newkey.Prefix = Prefix;
            switch(CommandType.SelectedIndex)
            {
                case 0:
                    newkey.Type = "Command";
                    break;
                case 1:
                    newkey.Type = "State";
                    break;
                case 2:
                    newkey.Type = "Toggle";
                    break;
                default:
                    newkey.Type = "Command";
                    break;
            }
            switch(ModeString.SelectedIndex)
            {
                case 0:
                    newkey.Mode = "say ";
                    newkey.CMD = CMD.Text;
                    break;
                case 1:
                    newkey.Mode = "whisper ";
                    newkey.CMD = CMD.Text;
                    break;
                case 2:
                    newkey.Mode = "me ";
                    switch(EmoString.SelectedIndex)
                    {
                        case 0: newkey.CMD = CMD.Text;break;
                        case 1: newkey.CMD = "кричит"; break;
                        case 2: newkey.CMD = "смеётся"; break;
                        case 3: newkey.CMD = "хихикает"; break;
                        case 4: newkey.CMD = "вздыхает"; break;
                        case 5: newkey.CMD = "свистит"; break;
                        case 6: newkey.CMD = "рыдает"; break;
                        case 7: newkey.CMD = "хлопает"; break;
                        case 8: newkey.CMD = "щелкает пальцами"; break;
                        case 9: newkey.CMD = "отдаёт честь"; break;
                        case 10: newkey.CMD = "пердит"; break;
                        case 11: newkey.CMD = "мяукает"; break;
                        case 12: newkey.CMD = "някает"; break;
                        case 13: newkey.CMD = "рычит"; break;
                        case 14: newkey.CMD = "мурчит"; break;
                        case 15: newkey.CMD = "шипит"; break;
                        case 16: newkey.CMD = "хлюпает"; break;
                        case 17: newkey.CMD = "жужжит"; break;
                        case 18: newkey.CMD = "cкрипит"; break;
                        case 19: newkey.CMD = "бурлит"; break;
                    }
                    break;
                case 3:
                    switch(ChanelRadio.SelectedIndex)
                    {
                        case 0: newkey.Mode = ";"; break;
                        case 1: newkey.Mode = ":к "; break;
                        case 2: newkey.Mode = ":о "; break;
                        case 3: newkey.Mode = ":и "; break;
                        case 4: newkey.Mode = ":м "; break;
                        case 5: newkey.Mode = ":н "; break;
                        case 6: newkey.Mode = ":с "; break;
                        case 7: newkey.Mode = ":в "; break;
                        case 8: newkey.Mode = ":т "; break;
                        case 9: newkey.Mode = ":ц "; break;
                    }
                    newkey.CMD = CMD.Text;
                    break;
                default:
                    newkey.Mode = "";
                    break;
            }
            
            Honk.AddKey(newkey);
            this.Close();
        }

        private void ModeString_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label5.Location = new Point(375, 105);
            this.ChanelRadio.Location = new Point(375, 101);
            this.label6.Location = new Point(375, 105);
            this.EmoString.Location = new Point(375, 101);
            switch (ModeString.SelectedIndex)
            {
                case 2:
                    label6.Location = new Point(12, 105);
                    this.EmoString.Location = new Point(81, 101);
                    break;
                case 3:
                    this.label5.Location = new Point(12, 105);
                    this.ChanelRadio.Location = new Point(81, 101);
                    break;
            }
        }

        private void AddCommandForm_Load(object sender, EventArgs e)
        {
            CommandType.SelectedIndex = 0;
            ModeString.SelectedIndex = 0;
            ChanelRadio.SelectedIndex = 0;
            EmoString.SelectedIndex = 0;
        }
    }
}
