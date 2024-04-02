using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonkKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Roaming\Space Station 14\data\keybinds.key"))
                Honk.SaveKeys();
            Honk.Show();
        }
    }
}
