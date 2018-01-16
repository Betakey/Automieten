namespace AutosMieten
{
    partial class RocketForm
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
            this.AusleihButton = new System.Windows.Forms.Button();
            this.gangschaltartTextBox = new System.Windows.Forms.TextBox();
            this.CarListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gangschaltartLabel = new System.Windows.Forms.Label();
            this.markeTextBox = new System.Windows.Forms.TextBox();
            this.leistungTextBox = new System.Windows.Forms.TextBox();
            this.treibstoffTextBox = new System.Windows.Forms.TextBox();
            this.sitzplätzeTextBox = new System.Windows.Forms.TextBox();
            this.stadtTextBox = new System.Windows.Forms.TextBox();
            this.postleitzahlTextBox = new System.Windows.Forms.TextBox();
            this.anhängekuppelTextBox = new System.Windows.Forms.TextBox();
            this.kofferraumgrößeTextBox = new System.Windows.Forms.TextBox();
            this.straßeTextBox = new System.Windows.Forms.TextBox();
            this.klasseTextBox = new System.Windows.Forms.TextBox();
            this.leistunglabel = new System.Windows.Forms.Label();
            this.treibstoffLabel = new System.Windows.Forms.Label();
            this.markeLabel = new System.Windows.Forms.Label();
            this.stadtLabel = new System.Windows.Forms.Label();
            this.sitzplätzeLabel = new System.Windows.Forms.Label();
            this.postleitzahlLabel = new System.Windows.Forms.Label();
            this.anhängekuppelLabel = new System.Windows.Forms.Label();
            this.klasseLabel = new System.Windows.Forms.Label();
            this.KofferraumgrößeLabel = new System.Windows.Forms.Label();
            this.straßeLabel = new System.Windows.Forms.Label();
            this.hinzufügenButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.endTimetextBox = new System.Windows.Forms.TextBox();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.zurückgebenButton = new System.Windows.Forms.Button();
            this.autoTextBox = new System.Windows.Forms.TextBox();
            this.autoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AusleihButton
            // 
            this.AusleihButton.Location = new System.Drawing.Point(469, 286);
            this.AusleihButton.Name = "AusleihButton";
            this.AusleihButton.Size = new System.Drawing.Size(142, 28);
            this.AusleihButton.TabIndex = 0;
            this.AusleihButton.Text = "Ausleihen";
            this.AusleihButton.UseVisualStyleBackColor = true;
            this.AusleihButton.Click += new System.EventHandler(this.AusleihButton_Click);
            // 
            // gangschaltartTextBox
            // 
            this.gangschaltartTextBox.Location = new System.Drawing.Point(297, 23);
            this.gangschaltartTextBox.Name = "gangschaltartTextBox";
            this.gangschaltartTextBox.Size = new System.Drawing.Size(97, 20);
            this.gangschaltartTextBox.TabIndex = 1;
            // 
            // CarListBox
            // 
            this.CarListBox.FormattingEnabled = true;
            this.CarListBox.Location = new System.Drawing.Point(12, 24);
            this.CarListBox.Name = "CarListBox";
            this.CarListBox.Size = new System.Drawing.Size(120, 290);
            this.CarListBox.TabIndex = 2;
            this.CarListBox.SelectedIndexChanged += new System.EventHandler(this.CarListBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(154, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(94, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(151, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // gangschaltartLabel
            // 
            this.gangschaltartLabel.AutoSize = true;
            this.gangschaltartLabel.Location = new System.Drawing.Point(294, 7);
            this.gangschaltartLabel.Name = "gangschaltartLabel";
            this.gangschaltartLabel.Size = new System.Drawing.Size(73, 13);
            this.gangschaltartLabel.TabIndex = 5;
            this.gangschaltartLabel.Text = "Gangschaltart";
            // 
            // markeTextBox
            // 
            this.markeTextBox.Location = new System.Drawing.Point(154, 65);
            this.markeTextBox.Name = "markeTextBox";
            this.markeTextBox.Size = new System.Drawing.Size(94, 20);
            this.markeTextBox.TabIndex = 6;
            // 
            // leistungTextBox
            // 
            this.leistungTextBox.Location = new System.Drawing.Point(154, 116);
            this.leistungTextBox.Name = "leistungTextBox";
            this.leistungTextBox.Size = new System.Drawing.Size(94, 20);
            this.leistungTextBox.TabIndex = 7;
            // 
            // treibstoffTextBox
            // 
            this.treibstoffTextBox.Location = new System.Drawing.Point(297, 65);
            this.treibstoffTextBox.Name = "treibstoffTextBox";
            this.treibstoffTextBox.Size = new System.Drawing.Size(97, 20);
            this.treibstoffTextBox.TabIndex = 8;
            // 
            // sitzplätzeTextBox
            // 
            this.sitzplätzeTextBox.Location = new System.Drawing.Point(154, 170);
            this.sitzplätzeTextBox.Name = "sitzplätzeTextBox";
            this.sitzplätzeTextBox.Size = new System.Drawing.Size(94, 20);
            this.sitzplätzeTextBox.TabIndex = 9;
            // 
            // stadtTextBox
            // 
            this.stadtTextBox.Location = new System.Drawing.Point(296, 218);
            this.stadtTextBox.Name = "stadtTextBox";
            this.stadtTextBox.Size = new System.Drawing.Size(97, 20);
            this.stadtTextBox.TabIndex = 10;
            // 
            // postleitzahlTextBox
            // 
            this.postleitzahlTextBox.Location = new System.Drawing.Point(296, 170);
            this.postleitzahlTextBox.Name = "postleitzahlTextBox";
            this.postleitzahlTextBox.Size = new System.Drawing.Size(97, 20);
            this.postleitzahlTextBox.TabIndex = 11;
            // 
            // anhängekuppelTextBox
            // 
            this.anhängekuppelTextBox.Location = new System.Drawing.Point(297, 116);
            this.anhängekuppelTextBox.Name = "anhängekuppelTextBox";
            this.anhängekuppelTextBox.Size = new System.Drawing.Size(97, 20);
            this.anhängekuppelTextBox.TabIndex = 12;
            // 
            // kofferraumgrößeTextBox
            // 
            this.kofferraumgrößeTextBox.Location = new System.Drawing.Point(154, 218);
            this.kofferraumgrößeTextBox.Name = "kofferraumgrößeTextBox";
            this.kofferraumgrößeTextBox.Size = new System.Drawing.Size(94, 20);
            this.kofferraumgrößeTextBox.TabIndex = 14;
            // 
            // straßeTextBox
            // 
            this.straßeTextBox.Location = new System.Drawing.Point(297, 272);
            this.straßeTextBox.Name = "straßeTextBox";
            this.straßeTextBox.Size = new System.Drawing.Size(97, 20);
            this.straßeTextBox.TabIndex = 15;
            // 
            // klasseTextBox
            // 
            this.klasseTextBox.Location = new System.Drawing.Point(154, 272);
            this.klasseTextBox.Name = "klasseTextBox";
            this.klasseTextBox.Size = new System.Drawing.Size(94, 20);
            this.klasseTextBox.TabIndex = 16;
            // 
            // leistunglabel
            // 
            this.leistunglabel.AutoSize = true;
            this.leistunglabel.Location = new System.Drawing.Point(151, 100);
            this.leistunglabel.Name = "leistunglabel";
            this.leistunglabel.Size = new System.Drawing.Size(47, 13);
            this.leistunglabel.TabIndex = 17;
            this.leistunglabel.Text = "Leistung";
            // 
            // treibstoffLabel
            // 
            this.treibstoffLabel.AutoSize = true;
            this.treibstoffLabel.Location = new System.Drawing.Point(294, 49);
            this.treibstoffLabel.Name = "treibstoffLabel";
            this.treibstoffLabel.Size = new System.Drawing.Size(51, 13);
            this.treibstoffLabel.TabIndex = 18;
            this.treibstoffLabel.Text = "Treibstoff";
            // 
            // markeLabel
            // 
            this.markeLabel.AutoSize = true;
            this.markeLabel.Location = new System.Drawing.Point(151, 49);
            this.markeLabel.Name = "markeLabel";
            this.markeLabel.Size = new System.Drawing.Size(37, 13);
            this.markeLabel.TabIndex = 19;
            this.markeLabel.Text = "Marke";
            // 
            // stadtLabel
            // 
            this.stadtLabel.AutoSize = true;
            this.stadtLabel.Location = new System.Drawing.Point(294, 202);
            this.stadtLabel.Name = "stadtLabel";
            this.stadtLabel.Size = new System.Drawing.Size(32, 13);
            this.stadtLabel.TabIndex = 20;
            this.stadtLabel.Text = "Stadt";
            // 
            // sitzplätzeLabel
            // 
            this.sitzplätzeLabel.AutoSize = true;
            this.sitzplätzeLabel.Location = new System.Drawing.Point(151, 154);
            this.sitzplätzeLabel.Name = "sitzplätzeLabel";
            this.sitzplätzeLabel.Size = new System.Drawing.Size(52, 13);
            this.sitzplätzeLabel.TabIndex = 21;
            this.sitzplätzeLabel.Text = "Sitzplätze";
            // 
            // postleitzahlLabel
            // 
            this.postleitzahlLabel.AutoSize = true;
            this.postleitzahlLabel.Location = new System.Drawing.Point(294, 154);
            this.postleitzahlLabel.Name = "postleitzahlLabel";
            this.postleitzahlLabel.Size = new System.Drawing.Size(60, 13);
            this.postleitzahlLabel.TabIndex = 22;
            this.postleitzahlLabel.Text = "Postleitzahl";
            // 
            // anhängekuppelLabel
            // 
            this.anhängekuppelLabel.AutoSize = true;
            this.anhängekuppelLabel.Location = new System.Drawing.Point(294, 100);
            this.anhängekuppelLabel.Name = "anhängekuppelLabel";
            this.anhängekuppelLabel.Size = new System.Drawing.Size(82, 13);
            this.anhängekuppelLabel.TabIndex = 23;
            this.anhängekuppelLabel.Text = "Anhängekuppel";
            // 
            // klasseLabel
            // 
            this.klasseLabel.AutoSize = true;
            this.klasseLabel.Location = new System.Drawing.Point(151, 256);
            this.klasseLabel.Name = "klasseLabel";
            this.klasseLabel.Size = new System.Drawing.Size(38, 13);
            this.klasseLabel.TabIndex = 24;
            this.klasseLabel.Text = "Klasse";
            // 
            // KofferraumgrößeLabel
            // 
            this.KofferraumgrößeLabel.AutoSize = true;
            this.KofferraumgrößeLabel.Location = new System.Drawing.Point(151, 202);
            this.KofferraumgrößeLabel.Name = "KofferraumgrößeLabel";
            this.KofferraumgrößeLabel.Size = new System.Drawing.Size(85, 13);
            this.KofferraumgrößeLabel.TabIndex = 25;
            this.KofferraumgrößeLabel.Text = "Kofferraumgröße";
            // 
            // straßeLabel
            // 
            this.straßeLabel.AutoSize = true;
            this.straßeLabel.Location = new System.Drawing.Point(294, 256);
            this.straßeLabel.Name = "straßeLabel";
            this.straßeLabel.Size = new System.Drawing.Size(38, 13);
            this.straßeLabel.TabIndex = 26;
            this.straßeLabel.Text = "Straße";
            // 
            // hinzufügenButton
            // 
            this.hinzufügenButton.Location = new System.Drawing.Point(12, 321);
            this.hinzufügenButton.Name = "hinzufügenButton";
            this.hinzufügenButton.Size = new System.Drawing.Size(382, 28);
            this.hinzufügenButton.TabIndex = 27;
            this.hinzufügenButton.Text = "Hinzufügen";
            this.hinzufügenButton.UseVisualStyleBackColor = true;
            this.hinzufügenButton.Click += new System.EventHandler(this.HinzufügenButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 22);
            this.refreshButton.TabIndex = 28;
            this.refreshButton.Text = "Aktualisieren";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(469, 23);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(142, 20);
            this.usernameTextBox.TabIndex = 29;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(466, 7);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 31;
            this.usernameLabel.Text = "Username";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(466, 49);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(45, 13);
            this.startTimeLabel.TabIndex = 32;
            this.startTimeLabel.Text = "Startzeit";
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(469, 65);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(142, 20);
            this.startTimeTextBox.TabIndex = 33;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(422, 218);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 35;
            this.dateTimePicker2.Visible = false;
            // 
            // endTimetextBox
            // 
            this.endTimetextBox.Location = new System.Drawing.Point(469, 116);
            this.endTimetextBox.Name = "endTimetextBox";
            this.endTimetextBox.Size = new System.Drawing.Size(142, 20);
            this.endTimetextBox.TabIndex = 36;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(466, 100);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(42, 13);
            this.endTimeLabel.TabIndex = 37;
            this.endTimeLabel.Text = "Endzeit";
            // 
            // zurückgebenButton
            // 
            this.zurückgebenButton.Location = new System.Drawing.Point(469, 323);
            this.zurückgebenButton.Name = "zurückgebenButton";
            this.zurückgebenButton.Size = new System.Drawing.Size(142, 28);
            this.zurückgebenButton.TabIndex = 38;
            this.zurückgebenButton.Text = "Zurückgeben";
            this.zurückgebenButton.UseVisualStyleBackColor = true;
            this.zurückgebenButton.Click += new System.EventHandler(this.ZurückgebenButton_Click);
            // 
            // autoTextBox
            // 
            this.autoTextBox.Location = new System.Drawing.Point(469, 170);
            this.autoTextBox.Name = "autoTextBox";
            this.autoTextBox.Size = new System.Drawing.Size(142, 20);
            this.autoTextBox.TabIndex = 39;
            // 
            // autoLabel
            // 
            this.autoLabel.AutoSize = true;
            this.autoLabel.Location = new System.Drawing.Point(466, 154);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(29, 13);
            this.autoLabel.TabIndex = 40;
            this.autoLabel.Text = "Auto";
            // 
            // RocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 363);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.autoTextBox);
            this.Controls.Add(this.zurückgebenButton);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.endTimetextBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.hinzufügenButton);
            this.Controls.Add(this.straßeLabel);
            this.Controls.Add(this.KofferraumgrößeLabel);
            this.Controls.Add(this.klasseLabel);
            this.Controls.Add(this.anhängekuppelLabel);
            this.Controls.Add(this.postleitzahlLabel);
            this.Controls.Add(this.sitzplätzeLabel);
            this.Controls.Add(this.stadtLabel);
            this.Controls.Add(this.markeLabel);
            this.Controls.Add(this.treibstoffLabel);
            this.Controls.Add(this.leistunglabel);
            this.Controls.Add(this.klasseTextBox);
            this.Controls.Add(this.straßeTextBox);
            this.Controls.Add(this.kofferraumgrößeTextBox);
            this.Controls.Add(this.anhängekuppelTextBox);
            this.Controls.Add(this.postleitzahlTextBox);
            this.Controls.Add(this.stadtTextBox);
            this.Controls.Add(this.sitzplätzeTextBox);
            this.Controls.Add(this.treibstoffTextBox);
            this.Controls.Add(this.leistungTextBox);
            this.Controls.Add(this.markeTextBox);
            this.Controls.Add(this.gangschaltartLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.CarListBox);
            this.Controls.Add(this.gangschaltartTextBox);
            this.Controls.Add(this.AusleihButton);
            this.Name = "RocketForm";
            this.Text = "RocketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AusleihButton;
        private System.Windows.Forms.TextBox gangschaltartTextBox;
        private System.Windows.Forms.ListBox CarListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gangschaltartLabel;
        private System.Windows.Forms.TextBox markeTextBox;
        private System.Windows.Forms.TextBox leistungTextBox;
        private System.Windows.Forms.TextBox treibstoffTextBox;
        private System.Windows.Forms.TextBox sitzplätzeTextBox;
        private System.Windows.Forms.TextBox stadtTextBox;
        private System.Windows.Forms.TextBox postleitzahlTextBox;
        private System.Windows.Forms.TextBox anhängekuppelTextBox;
        private System.Windows.Forms.TextBox kofferraumgrößeTextBox;
        private System.Windows.Forms.TextBox straßeTextBox;
        private System.Windows.Forms.TextBox klasseTextBox;
        private System.Windows.Forms.Label leistunglabel;
        private System.Windows.Forms.Label treibstoffLabel;
        private System.Windows.Forms.Label markeLabel;
        private System.Windows.Forms.Label stadtLabel;
        private System.Windows.Forms.Label sitzplätzeLabel;
        private System.Windows.Forms.Label postleitzahlLabel;
        private System.Windows.Forms.Label anhängekuppelLabel;
        private System.Windows.Forms.Label klasseLabel;
        private System.Windows.Forms.Label KofferraumgrößeLabel;
        private System.Windows.Forms.Label straßeLabel;
        private System.Windows.Forms.Button hinzufügenButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox endTimetextBox;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Button zurückgebenButton;
        private System.Windows.Forms.TextBox autoTextBox;
        private System.Windows.Forms.Label autoLabel;
    }
}
