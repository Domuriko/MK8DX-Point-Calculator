namespace Mario_Kart_Punkterechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.btnNewWar = new System.Windows.Forms.Button();
            this.tbHeimTag = new System.Windows.Forms.TextBox();
            this.tbGastTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTeam6Tag = new System.Windows.Forms.Label();
            this.tbTeam6Tag = new System.Windows.Forms.TextBox();
            this.lbTeam5Tag = new System.Windows.Forms.Label();
            this.tbTeam5Tag = new System.Windows.Forms.TextBox();
            this.lbTeam4Tag = new System.Windows.Forms.Label();
            this.tbTeam4Tag = new System.Windows.Forms.TextBox();
            this.lbTeam3Tag = new System.Windows.Forms.Label();
            this.tbTeam3Tag = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSpots5 = new System.Windows.Forms.Label();
            this.tbPlatzierungenT5 = new System.Windows.Forms.TextBox();
            this.lbSpots4 = new System.Windows.Forms.Label();
            this.tbPlatzierungenT4 = new System.Windows.Forms.TextBox();
            this.lbSpots3 = new System.Windows.Forms.Label();
            this.tbPlatzierungenT3 = new System.Windows.Forms.TextBox();
            this.lbSpots2 = new System.Windows.Forms.Label();
            this.tbPlatzierungenT2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStrecke = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbSpots1 = new System.Windows.Forms.Label();
            this.tbPlatzierungen = new System.Windows.Forms.TextBox();
            this.lbLetztesRennen = new System.Windows.Forms.ListBox();
            this.lbVorherigeRennen = new System.Windows.Forms.ListBox();
            this.lbTotalScore = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMode
            // 
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "6v6",
            "5v5",
            "4v4",
            "3v3",
            "2v2",
            "4v4...",
            "3v3...",
            "2v2..."});
            this.cbMode.Location = new System.Drawing.Point(243, 155);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(84, 23);
            this.cbMode.TabIndex = 7;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // btnNewWar
            // 
            this.btnNewWar.Location = new System.Drawing.Point(6, 155);
            this.btnNewWar.Name = "btnNewWar";
            this.btnNewWar.Size = new System.Drawing.Size(84, 23);
            this.btnNewWar.TabIndex = 8;
            this.btnNewWar.Text = "new War";
            this.btnNewWar.UseVisualStyleBackColor = true;
            this.btnNewWar.Click += new System.EventHandler(this.btnNewWar_Click);
            // 
            // tbHeimTag
            // 
            this.tbHeimTag.Location = new System.Drawing.Point(6, 37);
            this.tbHeimTag.Name = "tbHeimTag";
            this.tbHeimTag.Size = new System.Drawing.Size(84, 23);
            this.tbHeimTag.TabIndex = 1;
            // 
            // tbGastTag
            // 
            this.tbGastTag.Location = new System.Drawing.Point(125, 37);
            this.tbGastTag.Name = "tbGastTag";
            this.tbGastTag.Size = new System.Drawing.Size(84, 23);
            this.tbGastTag.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Home team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guest team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Format";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTeam6Tag);
            this.groupBox1.Controls.Add(this.tbTeam6Tag);
            this.groupBox1.Controls.Add(this.lbTeam5Tag);
            this.groupBox1.Controls.Add(this.tbTeam5Tag);
            this.groupBox1.Controls.Add(this.lbTeam4Tag);
            this.groupBox1.Controls.Add(this.tbTeam4Tag);
            this.groupBox1.Controls.Add(this.lbTeam3Tag);
            this.groupBox1.Controls.Add(this.tbTeam3Tag);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNewWar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbHeimTag);
            this.groupBox1.Controls.Add(this.tbGastTag);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "War configuration";
            // 
            // lbTeam6Tag
            // 
            this.lbTeam6Tag.AutoSize = true;
            this.lbTeam6Tag.Location = new System.Drawing.Point(243, 87);
            this.lbTeam6Tag.Name = "lbTeam6Tag";
            this.lbTeam6Tag.Size = new System.Drawing.Size(44, 15);
            this.lbTeam6Tag.TabIndex = 15;
            this.lbTeam6Tag.Text = "Team 6";
            this.lbTeam6Tag.Visible = false;
            // 
            // tbTeam6Tag
            // 
            this.tbTeam6Tag.Location = new System.Drawing.Point(243, 105);
            this.tbTeam6Tag.Name = "tbTeam6Tag";
            this.tbTeam6Tag.Size = new System.Drawing.Size(84, 23);
            this.tbTeam6Tag.TabIndex = 6;
            this.tbTeam6Tag.Visible = false;
            // 
            // lbTeam5Tag
            // 
            this.lbTeam5Tag.AutoSize = true;
            this.lbTeam5Tag.Location = new System.Drawing.Point(125, 87);
            this.lbTeam5Tag.Name = "lbTeam5Tag";
            this.lbTeam5Tag.Size = new System.Drawing.Size(44, 15);
            this.lbTeam5Tag.TabIndex = 13;
            this.lbTeam5Tag.Text = "Team 5";
            this.lbTeam5Tag.Visible = false;
            // 
            // tbTeam5Tag
            // 
            this.tbTeam5Tag.Location = new System.Drawing.Point(125, 105);
            this.tbTeam5Tag.Name = "tbTeam5Tag";
            this.tbTeam5Tag.Size = new System.Drawing.Size(84, 23);
            this.tbTeam5Tag.TabIndex = 5;
            this.tbTeam5Tag.Visible = false;
            // 
            // lbTeam4Tag
            // 
            this.lbTeam4Tag.AutoSize = true;
            this.lbTeam4Tag.Location = new System.Drawing.Point(6, 87);
            this.lbTeam4Tag.Name = "lbTeam4Tag";
            this.lbTeam4Tag.Size = new System.Drawing.Size(44, 15);
            this.lbTeam4Tag.TabIndex = 11;
            this.lbTeam4Tag.Text = "Team 4";
            this.lbTeam4Tag.Visible = false;
            // 
            // tbTeam4Tag
            // 
            this.tbTeam4Tag.Location = new System.Drawing.Point(6, 105);
            this.tbTeam4Tag.Name = "tbTeam4Tag";
            this.tbTeam4Tag.Size = new System.Drawing.Size(84, 23);
            this.tbTeam4Tag.TabIndex = 4;
            this.tbTeam4Tag.Visible = false;
            // 
            // lbTeam3Tag
            // 
            this.lbTeam3Tag.AutoSize = true;
            this.lbTeam3Tag.Location = new System.Drawing.Point(243, 19);
            this.lbTeam3Tag.Name = "lbTeam3Tag";
            this.lbTeam3Tag.Size = new System.Drawing.Size(44, 15);
            this.lbTeam3Tag.TabIndex = 9;
            this.lbTeam3Tag.Text = "Team 3";
            this.lbTeam3Tag.Visible = false;
            // 
            // tbTeam3Tag
            // 
            this.tbTeam3Tag.Location = new System.Drawing.Point(243, 37);
            this.tbTeam3Tag.Name = "tbTeam3Tag";
            this.tbTeam3Tag.Size = new System.Drawing.Size(84, 23);
            this.tbTeam3Tag.TabIndex = 3;
            this.tbTeam3Tag.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSpots5);
            this.groupBox2.Controls.Add(this.tbPlatzierungenT5);
            this.groupBox2.Controls.Add(this.lbSpots4);
            this.groupBox2.Controls.Add(this.tbPlatzierungenT4);
            this.groupBox2.Controls.Add(this.lbSpots3);
            this.groupBox2.Controls.Add(this.tbPlatzierungenT3);
            this.groupBox2.Controls.Add(this.lbSpots2);
            this.groupBox2.Controls.Add(this.tbPlatzierungenT2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbStrecke);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lbSpots1);
            this.groupBox2.Controls.Add(this.tbPlatzierungen);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 184);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Race results";
            // 
            // lbSpots5
            // 
            this.lbSpots5.AutoSize = true;
            this.lbSpots5.Location = new System.Drawing.Point(125, 86);
            this.lbSpots5.Name = "lbSpots5";
            this.lbSpots5.Size = new System.Drawing.Size(76, 15);
            this.lbSpots5.TabIndex = 17;
            this.lbSpots5.Text = "Spots Team 5";
            this.lbSpots5.Visible = false;
            // 
            // tbPlatzierungenT5
            // 
            this.tbPlatzierungenT5.Location = new System.Drawing.Point(125, 104);
            this.tbPlatzierungenT5.Name = "tbPlatzierungenT5";
            this.tbPlatzierungenT5.Size = new System.Drawing.Size(84, 23);
            this.tbPlatzierungenT5.TabIndex = 13;
            this.tbPlatzierungenT5.Text = "1 2";
            this.tbPlatzierungenT5.Visible = false;
            // 
            // lbSpots4
            // 
            this.lbSpots4.AutoSize = true;
            this.lbSpots4.Location = new System.Drawing.Point(6, 86);
            this.lbSpots4.Name = "lbSpots4";
            this.lbSpots4.Size = new System.Drawing.Size(76, 15);
            this.lbSpots4.TabIndex = 15;
            this.lbSpots4.Text = "Spots Team 4";
            this.lbSpots4.Visible = false;
            // 
            // tbPlatzierungenT4
            // 
            this.tbPlatzierungenT4.Location = new System.Drawing.Point(6, 104);
            this.tbPlatzierungenT4.Name = "tbPlatzierungenT4";
            this.tbPlatzierungenT4.Size = new System.Drawing.Size(84, 23);
            this.tbPlatzierungenT4.TabIndex = 12;
            this.tbPlatzierungenT4.Text = "1 2";
            this.tbPlatzierungenT4.Visible = false;
            // 
            // lbSpots3
            // 
            this.lbSpots3.AutoSize = true;
            this.lbSpots3.Location = new System.Drawing.Point(243, 19);
            this.lbSpots3.Name = "lbSpots3";
            this.lbSpots3.Size = new System.Drawing.Size(76, 15);
            this.lbSpots3.TabIndex = 13;
            this.lbSpots3.Text = "Spots Team 3";
            this.lbSpots3.Visible = false;
            // 
            // tbPlatzierungenT3
            // 
            this.tbPlatzierungenT3.Location = new System.Drawing.Point(243, 37);
            this.tbPlatzierungenT3.Name = "tbPlatzierungenT3";
            this.tbPlatzierungenT3.Size = new System.Drawing.Size(84, 23);
            this.tbPlatzierungenT3.TabIndex = 11;
            this.tbPlatzierungenT3.Text = "1 2 3";
            this.tbPlatzierungenT3.Visible = false;
            // 
            // lbSpots2
            // 
            this.lbSpots2.AutoSize = true;
            this.lbSpots2.Location = new System.Drawing.Point(125, 19);
            this.lbSpots2.Name = "lbSpots2";
            this.lbSpots2.Size = new System.Drawing.Size(76, 15);
            this.lbSpots2.TabIndex = 11;
            this.lbSpots2.Text = "Spots Team 2";
            this.lbSpots2.Visible = false;
            // 
            // tbPlatzierungenT2
            // 
            this.tbPlatzierungenT2.Location = new System.Drawing.Point(125, 37);
            this.tbPlatzierungenT2.Name = "tbPlatzierungenT2";
            this.tbPlatzierungenT2.Size = new System.Drawing.Size(84, 23);
            this.tbPlatzierungenT2.TabIndex = 10;
            this.tbPlatzierungenT2.Text = "1 2 3 4";
            this.tbPlatzierungenT2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Track";
            // 
            // tbStrecke
            // 
            this.tbStrecke.Location = new System.Drawing.Point(243, 104);
            this.tbStrecke.Name = "tbStrecke";
            this.tbStrecke.Size = new System.Drawing.Size(84, 23);
            this.tbStrecke.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbSpots1
            // 
            this.lbSpots1.AutoSize = true;
            this.lbSpots1.Location = new System.Drawing.Point(6, 19);
            this.lbSpots1.Name = "lbSpots1";
            this.lbSpots1.Size = new System.Drawing.Size(76, 15);
            this.lbSpots1.TabIndex = 8;
            this.lbSpots1.Text = "Spots Team 1";
            // 
            // tbPlatzierungen
            // 
            this.tbPlatzierungen.Location = new System.Drawing.Point(6, 37);
            this.tbPlatzierungen.Name = "tbPlatzierungen";
            this.tbPlatzierungen.Size = new System.Drawing.Size(84, 23);
            this.tbPlatzierungen.TabIndex = 9;
            this.tbPlatzierungen.Text = "1 2 3 4 5 6";
            // 
            // lbLetztesRennen
            // 
            this.lbLetztesRennen.FormattingEnabled = true;
            this.lbLetztesRennen.ItemHeight = 15;
            this.lbLetztesRennen.Location = new System.Drawing.Point(370, 12);
            this.lbLetztesRennen.Name = "lbLetztesRennen";
            this.lbLetztesRennen.Size = new System.Drawing.Size(319, 184);
            this.lbLetztesRennen.TabIndex = 10;
            // 
            // lbVorherigeRennen
            // 
            this.lbVorherigeRennen.FormattingEnabled = true;
            this.lbVorherigeRennen.ItemHeight = 15;
            this.lbVorherigeRennen.Location = new System.Drawing.Point(695, 12);
            this.lbVorherigeRennen.Name = "lbVorherigeRennen";
            this.lbVorherigeRennen.Size = new System.Drawing.Size(359, 379);
            this.lbVorherigeRennen.TabIndex = 11;
            // 
            // lbTotalScore
            // 
            this.lbTotalScore.FormattingEnabled = true;
            this.lbTotalScore.ItemHeight = 15;
            this.lbTotalScore.Location = new System.Drawing.Point(370, 207);
            this.lbTotalScore.Name = "lbTotalScore";
            this.lbTotalScore.Size = new System.Drawing.Size(319, 184);
            this.lbTotalScore.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(569, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTotalScore);
            this.Controls.Add(this.lbVorherigeRennen);
            this.Controls.Add(this.lbLetztesRennen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mario Kart Point Calculation - BETA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbMode;
        private Button btnNewWar;
        private TextBox tbHeimTag;
        private TextBox tbGastTag;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbSpots1;
        private TextBox tbPlatzierungen;
        private Label label5;
        private TextBox tbStrecke;
        private Button btnAdd;
        private ListBox lbLetztesRennen;
        private ListBox lbVorherigeRennen;
        private ListBox lbTotalScore;
        private Label lbSpots2;
        private TextBox tbPlatzierungenT2;
        private Label lbSpots3;
        private TextBox tbPlatzierungenT3;
        private Label lbSpots5;
        private TextBox tbPlatzierungenT5;
        private Label lbSpots4;
        private TextBox tbPlatzierungenT4;
        private Label lbTeam6Tag;
        private TextBox tbTeam6Tag;
        private Label lbTeam5Tag;
        private TextBox tbTeam5Tag;
        private Label lbTeam4Tag;
        private TextBox tbTeam4Tag;
        private Label lbTeam3Tag;
        private TextBox tbTeam3Tag;
        private PictureBox pictureBox1;
    }
}