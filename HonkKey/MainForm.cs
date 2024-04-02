using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonkKey
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Honk.LoadKeys();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Honk.SaveKeys();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
  
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Honk.ShowAdd();
        }

        private void DeleteKeyButton_Click(object sender, EventArgs e)
        {
            Honk.DeleteKey(KeyList.SelectedIndex);
        }
    }
}
