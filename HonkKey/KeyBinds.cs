using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonkKey
{
    [Serializable]
    internal struct KeyBinds
    {
        public string Key;
        public string Prefix;
        public string Type;
        public string Mode;
        public string CMD;
    }
}
