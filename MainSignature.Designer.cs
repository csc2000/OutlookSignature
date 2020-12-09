namespace OutlookCorporateSignature
{
    partial class MainSignature
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSignature));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox_additionalText = new System.Windows.Forms.CheckBox();
            this.button_save4all = new System.Windows.Forms.Button();
            this.button_save4user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_bold = new System.Windows.Forms.Button();
            this.button_italic = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_blue = new System.Windows.Forms.Button();
            this.button_darkblue = new System.Windows.Forms.Button();
            this.button_yellow = new System.Windows.Forms.Button();
            this.button_darkred = new System.Windows.Forms.Button();
            this.button_green = new System.Windows.Forms.Button();
            this.Button_black = new System.Windows.Forms.Button();
            this.button_closeapplication = new System.Windows.Forms.Button();
            this.checkBox_Outlook = new System.Windows.Forms.CheckBox();
            this.checkBox_em = new System.Windows.Forms.CheckBox();
            this.button_addnewusers = new System.Windows.Forms.Button();
            this.button_userdel = new System.Windows.Forms.Button();
            this.button_useredit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 287);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 176);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // checkBox_additionalText
            // 
            this.checkBox_additionalText.AutoSize = true;
            this.checkBox_additionalText.Checked = true;
            this.checkBox_additionalText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_additionalText.Location = new System.Drawing.Point(12, 230);
            this.checkBox_additionalText.Name = "checkBox_additionalText";
            this.checkBox_additionalText.Size = new System.Drawing.Size(84, 17);
            this.checkBox_additionalText.TabIndex = 1;
            this.checkBox_additionalText.Text = "Zusatztext? ";
            this.checkBox_additionalText.UseVisualStyleBackColor = true;
            this.checkBox_additionalText.CheckedChanged += new System.EventHandler(this.CheckBoxAdditionalText_CheckedChanged);
            // 
            // button_save4all
            // 
            this.button_save4all.Location = new System.Drawing.Point(12, 469);
            this.button_save4all.Name = "button_save4all";
            this.button_save4all.Size = new System.Drawing.Size(385, 23);
            this.button_save4all.TabIndex = 2;
            this.button_save4all.Text = "Für alle Benutzer speichern";
            this.button_save4all.UseVisualStyleBackColor = true;
            this.button_save4all.Click += new System.EventHandler(this.ButtonSave4All_Click);
            // 
            // button_save4user
            // 
            this.button_save4user.Location = new System.Drawing.Point(403, 469);
            this.button_save4user.Name = "button_save4user";
            this.button_save4user.Size = new System.Drawing.Size(385, 23);
            this.button_save4user.TabIndex = 3;
            this.button_save4user.Text = "Für ausgewählte Benutzer speichern";
            this.button_save4user.UseVisualStyleBackColor = true;
            this.button_save4user.Click += new System.EventHandler(this.ButtonSave4User_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Verfügbare Benutzer:";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(115, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(673, 212);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Position";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Durchwahl";
            this.columnHeader4.Width = 131;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Benutzername";
            this.columnHeader5.Width = 112;
            // 
            // button_bold
            // 
            this.button_bold.Location = new System.Drawing.Point(632, 259);
            this.button_bold.Name = "button_bold";
            this.button_bold.Size = new System.Drawing.Size(75, 23);
            this.button_bold.TabIndex = 7;
            this.button_bold.Text = "Fett";
            this.button_bold.UseVisualStyleBackColor = true;
            this.button_bold.Click += new System.EventHandler(this.ButtonBold_Click);
            // 
            // button_italic
            // 
            this.button_italic.Location = new System.Drawing.Point(713, 259);
            this.button_italic.Name = "button_italic";
            this.button_italic.Size = new System.Drawing.Size(75, 23);
            this.button_italic.TabIndex = 8;
            this.button_italic.Text = "Kursiv";
            this.button_italic.UseVisualStyleBackColor = true;
            this.button_italic.Click += new System.EventHandler(this.ButtonItalic_Click);
            // 
            // button_red
            // 
            this.button_red.BackColor = System.Drawing.Color.Red;
            this.button_red.Location = new System.Drawing.Point(283, 259);
            this.button_red.Name = "button_red";
            this.button_red.Size = new System.Drawing.Size(50, 23);
            this.button_red.TabIndex = 9;
            this.button_red.UseVisualStyleBackColor = false;
            this.button_red.Click += new System.EventHandler(this.ButtonColorRed_Click);
            // 
            // button_blue
            // 
            this.button_blue.BackColor = System.Drawing.Color.Blue;
            this.button_blue.Location = new System.Drawing.Point(171, 259);
            this.button_blue.Name = "button_blue";
            this.button_blue.Size = new System.Drawing.Size(50, 23);
            this.button_blue.TabIndex = 10;
            this.button_blue.UseVisualStyleBackColor = false;
            this.button_blue.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button_darkblue
            // 
            this.button_darkblue.BackColor = System.Drawing.Color.DarkBlue;
            this.button_darkblue.Location = new System.Drawing.Point(227, 259);
            this.button_darkblue.Name = "button_darkblue";
            this.button_darkblue.Size = new System.Drawing.Size(50, 23);
            this.button_darkblue.TabIndex = 11;
            this.button_darkblue.UseVisualStyleBackColor = false;
            this.button_darkblue.Click += new System.EventHandler(this.ButtonColorDarkblue_Click);
            // 
            // button_yellow
            // 
            this.button_yellow.BackColor = System.Drawing.Color.Yellow;
            this.button_yellow.Location = new System.Drawing.Point(115, 259);
            this.button_yellow.Name = "button_yellow";
            this.button_yellow.Size = new System.Drawing.Size(50, 23);
            this.button_yellow.TabIndex = 12;
            this.button_yellow.UseVisualStyleBackColor = false;
            this.button_yellow.Click += new System.EventHandler(this.ButtonColorYellow_Click);
            // 
            // button_darkred
            // 
            this.button_darkred.BackColor = System.Drawing.Color.DarkRed;
            this.button_darkred.Location = new System.Drawing.Point(339, 259);
            this.button_darkred.Name = "button_darkred";
            this.button_darkred.Size = new System.Drawing.Size(50, 23);
            this.button_darkred.TabIndex = 13;
            this.button_darkred.UseVisualStyleBackColor = false;
            this.button_darkred.Click += new System.EventHandler(this.ButtonColorDarkred_Click);
            // 
            // button_green
            // 
            this.button_green.BackColor = System.Drawing.Color.Green;
            this.button_green.Location = new System.Drawing.Point(395, 259);
            this.button_green.Name = "button_green";
            this.button_green.Size = new System.Drawing.Size(50, 23);
            this.button_green.TabIndex = 14;
            this.button_green.UseVisualStyleBackColor = false;
            this.button_green.Click += new System.EventHandler(this.ButtonColorGreen_Click);
            // 
            // Button_black
            // 
            this.Button_black.BackColor = System.Drawing.Color.Black;
            this.Button_black.Location = new System.Drawing.Point(451, 259);
            this.Button_black.Name = "Button_black";
            this.Button_black.Size = new System.Drawing.Size(50, 23);
            this.Button_black.TabIndex = 15;
            this.Button_black.UseVisualStyleBackColor = false;
            this.Button_black.Click += new System.EventHandler(this.ButtonColorBlack_Click);
            // 
            // button_closeapplication
            // 
            this.button_closeapplication.Location = new System.Drawing.Point(12, 96);
            this.button_closeapplication.Name = "button_closeapplication";
            this.button_closeapplication.Size = new System.Drawing.Size(97, 54);
            this.button_closeapplication.TabIndex = 16;
            this.button_closeapplication.Text = "Anwendung beenden";
            this.button_closeapplication.UseVisualStyleBackColor = true;
            // 
            // checkBox_Outlook
            // 
            this.checkBox_Outlook.AutoSize = true;
            this.checkBox_Outlook.Checked = true;
            this.checkBox_Outlook.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Outlook.Location = new System.Drawing.Point(12, 207);
            this.checkBox_Outlook.Name = "checkBox_Outlook";
            this.checkBox_Outlook.Size = new System.Drawing.Size(63, 17);
            this.checkBox_Outlook.TabIndex = 17;
            this.checkBox_Outlook.Text = "Outlook";
            this.checkBox_Outlook.UseVisualStyleBackColor = true;
            // 
            // checkBox_em
            // 
            this.checkBox_em.AutoSize = true;
            this.checkBox_em.Checked = true;
            this.checkBox_em.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_em.Location = new System.Drawing.Point(12, 184);
            this.checkBox_em.Name = "checkBox_em";
            this.checkBox_em.Size = new System.Drawing.Size(66, 17);
            this.checkBox_em.TabIndex = 18;
            this.checkBox_em.Text = "emClient";
            this.checkBox_em.UseVisualStyleBackColor = true;
            // 
            // button_addnewusers
            // 
            this.button_addnewusers.Location = new System.Drawing.Point(12, 36);
            this.button_addnewusers.Name = "button_addnewusers";
            this.button_addnewusers.Size = new System.Drawing.Size(97, 54);
            this.button_addnewusers.TabIndex = 19;
            this.button_addnewusers.Text = "Neue Benutzer laden";
            this.button_addnewusers.UseVisualStyleBackColor = true;
            this.button_addnewusers.Click += new System.EventHandler(this.ButtonAddNewUsers_Click);
            // 
            // button_userdel
            // 
            this.button_userdel.Location = new System.Drawing.Point(632, 3);
            this.button_userdel.Name = "button_userdel";
            this.button_userdel.Size = new System.Drawing.Size(156, 27);
            this.button_userdel.TabIndex = 20;
            this.button_userdel.Text = "Benutzer löschen";
            this.button_userdel.UseVisualStyleBackColor = true;
            this.button_userdel.Click += new System.EventHandler(this.ButtonUserDel_Click);
            // 
            // button_useredit
            // 
            this.button_useredit.Location = new System.Drawing.Point(470, 3);
            this.button_useredit.Name = "button_useredit";
            this.button_useredit.Size = new System.Drawing.Size(156, 27);
            this.button_useredit.TabIndex = 21;
            this.button_useredit.Text = "Benutzer bearbeiten";
            this.button_useredit.UseVisualStyleBackColor = true;
            this.button_useredit.Click += new System.EventHandler(this.ButtonUserEdit_Click);
            // 
            // MainSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.button_useredit);
            this.Controls.Add(this.button_userdel);
            this.Controls.Add(this.button_addnewusers);
            this.Controls.Add(this.checkBox_em);
            this.Controls.Add(this.checkBox_Outlook);
            this.Controls.Add(this.button_closeapplication);
            this.Controls.Add(this.Button_black);
            this.Controls.Add(this.button_green);
            this.Controls.Add(this.button_darkred);
            this.Controls.Add(this.button_yellow);
            this.Controls.Add(this.button_darkblue);
            this.Controls.Add(this.button_blue);
            this.Controls.Add(this.button_red);
            this.Controls.Add(this.button_italic);
            this.Controls.Add(this.button_bold);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save4user);
            this.Controls.Add(this.button_save4all);
            this.Controls.Add(this.checkBox_additionalText);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSignature";
            this.Text = "Corperate Signature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox_additionalText;
        private System.Windows.Forms.Button button_save4all;
        private System.Windows.Forms.Button button_save4user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_bold;
        private System.Windows.Forms.Button button_italic;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_blue;
        private System.Windows.Forms.Button button_darkblue;
        private System.Windows.Forms.Button button_yellow;
        private System.Windows.Forms.Button button_darkred;
        private System.Windows.Forms.Button button_green;
        private System.Windows.Forms.Button Button_black;
        private System.Windows.Forms.Button button_closeapplication;
        private System.Windows.Forms.CheckBox checkBox_Outlook;
        private System.Windows.Forms.CheckBox checkBox_em;
        private System.Windows.Forms.Button button_addnewusers;
        private System.Windows.Forms.Button button_userdel;
        private System.Windows.Forms.Button button_useredit;
    }
}

