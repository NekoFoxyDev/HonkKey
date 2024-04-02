namespace HonkKey
{
    partial class AddCommandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCommandForm));
            this.label1 = new System.Windows.Forms.Label();
            this.HookButton = new System.Windows.Forms.Button();
            this.KeyCodeString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CommandType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModeString = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CMD = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ChanelRadio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmoString = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клавиша:";
            // 
            // HookButton
            // 
            this.HookButton.Location = new System.Drawing.Point(247, 12);
            this.HookButton.Name = "HookButton";
            this.HookButton.Size = new System.Drawing.Size(86, 24);
            this.HookButton.TabIndex = 1;
            this.HookButton.Text = "Захват";
            this.HookButton.UseVisualStyleBackColor = true;
            this.HookButton.Click += new System.EventHandler(this.HookButton_Click);
            // 
            // KeyCodeString
            // 
            this.KeyCodeString.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyCodeString.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyCodeString.Location = new System.Drawing.Point(97, 12);
            this.KeyCodeString.Multiline = true;
            this.KeyCodeString.Name = "KeyCodeString";
            this.KeyCodeString.ReadOnly = true;
            this.KeyCodeString.Size = new System.Drawing.Size(144, 20);
            this.KeyCodeString.TabIndex = 2;
            this.KeyCodeString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип:";
            // 
            // CommandType
            // 
            this.CommandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommandType.FormattingEnabled = true;
            this.CommandType.Items.AddRange(new object[] {
            "Command"});
            this.CommandType.Location = new System.Drawing.Point(65, 42);
            this.CommandType.Name = "CommandType";
            this.CommandType.Size = new System.Drawing.Size(268, 21);
            this.CommandType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Режим:";
            // 
            // ModeString
            // 
            this.ModeString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeString.FormattingEnabled = true;
            this.ModeString.Items.AddRange(new object[] {
            "Сказать",
            "Шепот",
            "Эмоции",
            "Связь",
            "Cmd"});
            this.ModeString.Location = new System.Drawing.Point(65, 69);
            this.ModeString.Name = "ModeString";
            this.ModeString.Size = new System.Drawing.Size(268, 21);
            this.ModeString.TabIndex = 6;
            this.ModeString.SelectedIndexChanged += new System.EventHandler(this.ModeString_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CMD:";
            // 
            // CMD
            // 
            this.CMD.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD.Location = new System.Drawing.Point(15, 174);
            this.CMD.Name = "CMD";
            this.CMD.Size = new System.Drawing.Size(318, 20);
            this.CMD.TabIndex = 8;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(167, 200);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(166, 29);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "Хонк !";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Канал:";
            // 
            // ChanelRadio
            // 
            this.ChanelRadio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChanelRadio.FormattingEnabled = true;
            this.ChanelRadio.Items.AddRange(new object[] {
            "Общий",
            "Командывание",
            "Шиткурити",
            "Инженерный",
            "Медицинский",
            "Научный",
            "Каргонский",
            "Сервисный",
            "Синдикат",
            "ЦК (ОБРыганы)"});
            this.ChanelRadio.Location = new System.Drawing.Point(444, 101);
            this.ChanelRadio.Name = "ChanelRadio";
            this.ChanelRadio.Size = new System.Drawing.Size(252, 21);
            this.ChanelRadio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Эмоция:";
            // 
            // EmoString
            // 
            this.EmoString.DropDownHeight = 160;
            this.EmoString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmoString.FormattingEnabled = true;
            this.EmoString.IntegralHeight = false;
            this.EmoString.Items.AddRange(new object[] {
            "Произвольная",
            "♫ Кричит (все)",
            "♫ Смеётся (все)",
            "♫ Хихикает (все)",
            "♫ Вздыхает (людские)",
            "♫ Свистит (людские)",
            "♫ Рыдает (людские)",
            "♫ Хлопает (людские)",
            "♫ Щелкает пальцами (людские)",
            "♫ Отдаёт честь (людские и дионы)",
            "♫ Жоска пердит (людские)",
            "♫ Мяукает (фелиниды)",
            "♫ Някает (фелиниды)",
            "♫ Рычит (фелиниды и унатхи)",
            "♫ Мурчит (фелиниды)",
            "♫ Шипит (фелиниды и унатхи)",
            "♫ Хлюпает (слаймолюд)",
            "♫ Жужжит (ниан)",
            "♫ Скрипит (ниан)",
            "♫ Бурлить (слаймолюд)"});
            this.EmoString.Location = new System.Drawing.Point(510, 51);
            this.EmoString.Name = "EmoString";
            this.EmoString.Size = new System.Drawing.Size(252, 21);
            this.EmoString.TabIndex = 13;
            // 
            // AddCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 239);
            this.Controls.Add(this.EmoString);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChanelRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CMD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModeString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CommandType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyCodeString);
            this.Controls.Add(this.HookButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCommandForm";
            this.Text = "Add honk...";
            this.Load += new System.EventHandler(this.AddCommandForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCommandForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HookButton;
        private System.Windows.Forms.TextBox KeyCodeString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CommandType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ModeString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CMD;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ChanelRadio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EmoString;
    }
}