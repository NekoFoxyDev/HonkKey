namespace HonkKey
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.LoadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteKeyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyList = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusString = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadButton,
            this.SaveButton,
            this.AddButton,
            this.DeleteKeyButton});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(507, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // LoadButton
            // 
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(45, 20);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(43, 20);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(41, 20);
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteKeyButton
            // 
            this.DeleteKeyButton.Enabled = false;
            this.DeleteKeyButton.Name = "DeleteKeyButton";
            this.DeleteKeyButton.Size = new System.Drawing.Size(52, 20);
            this.DeleteKeyButton.Text = "Delete";
            this.DeleteKeyButton.Click += new System.EventHandler(this.DeleteKeyButton_Click);
            // 
            // KeyList
            // 
            this.KeyList.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyList.FormattingEnabled = true;
            this.KeyList.ItemHeight = 15;
            this.KeyList.Location = new System.Drawing.Point(0, 27);
            this.KeyList.Name = "KeyList";
            this.KeyList.Size = new System.Drawing.Size(507, 484);
            this.KeyList.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(507, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusString
            // 
            this.StatusString.Name = "StatusString";
            this.StatusString.Size = new System.Drawing.Size(22, 17);
            this.StatusString.Text = "Ok";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 537);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.KeyList);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Honk Key - ver 1.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem LoadButton;
        public System.Windows.Forms.ToolStripMenuItem SaveButton;
        public System.Windows.Forms.ListBox KeyList;
        public System.Windows.Forms.ToolStripMenuItem AddButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel StatusString;
        public System.Windows.Forms.ToolStripMenuItem DeleteKeyButton;
    }
}