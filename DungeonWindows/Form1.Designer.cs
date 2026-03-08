namespace DungeonWindows
{
    partial class Form1
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
            this.DokumentationBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.beendenBtn = new System.Windows.Forms.Button();
            this.hightInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.hightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.objectLabel = new System.Windows.Forms.Label();
            this.objectInput = new System.Windows.Forms.TextBox();
            this.dungeonAusgabe = new System.Windows.Forms.RichTextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.dungeonName = new System.Windows.Forms.TextBox();
            this.dungeonNameLabel = new System.Windows.Forms.Label();
            this.dokumentationBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DokumentationBtn
            // 
            this.DokumentationBtn.Location = new System.Drawing.Point(487, 236);
            this.DokumentationBtn.Name = "DokumentationBtn";
            this.DokumentationBtn.Size = new System.Drawing.Size(91, 23);
            this.DokumentationBtn.TabIndex = 0;
            this.DokumentationBtn.Text = "Dokumentation";
            this.DokumentationBtn.UseVisualStyleBackColor = true;
            this.DokumentationBtn.Click += new System.EventHandler(this.dokumentationBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(487, 209);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(91, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // beendenBtn
            // 
            this.beendenBtn.Location = new System.Drawing.Point(487, 265);
            this.beendenBtn.Name = "beendenBtn";
            this.beendenBtn.Size = new System.Drawing.Size(91, 23);
            this.beendenBtn.TabIndex = 2;
            this.beendenBtn.Text = "Beenden";
            this.beendenBtn.UseVisualStyleBackColor = true;
            this.beendenBtn.Click += new System.EventHandler(this.beendenBtn_Click);
            // 
            // hightInput
            // 
            this.hightInput.Location = new System.Drawing.Point(70, 36);
            this.hightInput.Name = "hightInput";
            this.hightInput.Size = new System.Drawing.Size(100, 20);
            this.hightInput.TabIndex = 3;
            this.hightInput.Visible = false;
            this.hightInput.TextChanged += new System.EventHandler(this.hightInput_TextChanged);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(70, 62);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 20);
            this.widthInput.TabIndex = 4;
            this.widthInput.Visible = false;
            this.widthInput.TextChanged += new System.EventHandler(this.widthInput_TextChanged);
            // 
            // hightLabel
            // 
            this.hightLabel.AutoSize = true;
            this.hightLabel.Location = new System.Drawing.Point(17, 39);
            this.hightLabel.Name = "hightLabel";
            this.hightLabel.Size = new System.Drawing.Size(36, 13);
            this.hightLabel.TabIndex = 5;
            this.hightLabel.Text = "Höhe:";
            this.hightLabel.Visible = false;
            this.hightLabel.Click += new System.EventHandler(this.hightLabel_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(17, 65);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(37, 13);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Breite:";
            this.widthLabel.Visible = false;
            this.widthLabel.Click += new System.EventHandler(this.widthLabel_Click);
            // 
            // objectLabel
            // 
            this.objectLabel.AutoSize = true;
            this.objectLabel.Location = new System.Drawing.Point(17, 91);
            this.objectLabel.Name = "objectLabel";
            this.objectLabel.Size = new System.Drawing.Size(47, 13);
            this.objectLabel.TabIndex = 7;
            this.objectLabel.Text = "Objekte:";
            this.objectLabel.Visible = false;
            this.objectLabel.Click += new System.EventHandler(this.objectLabel_click);
            // 
            // objectInput
            // 
            this.objectInput.Location = new System.Drawing.Point(70, 88);
            this.objectInput.Name = "objectInput";
            this.objectInput.Size = new System.Drawing.Size(100, 20);
            this.objectInput.TabIndex = 8;
            this.objectInput.Visible = false;
            this.objectInput.TextChanged += new System.EventHandler(this.objectInput_TextChanged);
            // 
            // dungeonAusgabe
            // 
            this.dungeonAusgabe.BackColor = System.Drawing.Color.DimGray;
            this.dungeonAusgabe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dungeonAusgabe.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonAusgabe.HideSelection = false;
            this.dungeonAusgabe.Location = new System.Drawing.Point(251, 23);
            this.dungeonAusgabe.Name = "dungeonAusgabe";
            this.dungeonAusgabe.ReadOnly = true;
            this.dungeonAusgabe.Size = new System.Drawing.Size(785, 637);
            this.dungeonAusgabe.TabIndex = 9;
            this.dungeonAusgabe.Text = "";
            this.dungeonAusgabe.Visible = false;
            this.dungeonAusgabe.TextChanged += new System.EventHandler(this.dungeonAusgabe_TextChanged);
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(47, 511);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(123, 46);
            this.generateBtn.TabIndex = 10;
            this.generateBtn.Text = "Generieren";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Visible = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(47, 563);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 11;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Visible = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // dungeonName
            // 
            this.dungeonName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dungeonName.Location = new System.Drawing.Point(47, 616);
            this.dungeonName.Name = "dungeonName";
            this.dungeonName.Size = new System.Drawing.Size(155, 20);
            this.dungeonName.TabIndex = 12;
            this.dungeonName.Visible = false;
            this.dungeonName.TextChanged += new System.EventHandler(this.dungeonName_TextChanged);
            // 
            // dungeonNameLabel
            // 
            this.dungeonNameLabel.AutoSize = true;
            this.dungeonNameLabel.Location = new System.Drawing.Point(44, 600);
            this.dungeonNameLabel.Name = "dungeonNameLabel";
            this.dungeonNameLabel.Size = new System.Drawing.Size(38, 13);
            this.dungeonNameLabel.TabIndex = 13;
            this.dungeonNameLabel.Text = "Name:";
            this.dungeonNameLabel.Visible = false;
            this.dungeonNameLabel.Click += new System.EventHandler(this.dungeonNameLabel_Click);
            // 
            // dokumentationBox
            // 
            this.dokumentationBox.BackColor = System.Drawing.Color.DimGray;
            this.dokumentationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dokumentationBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dokumentationBox.HideSelection = false;
            this.dokumentationBox.Location = new System.Drawing.Point(12, 23);
            this.dokumentationBox.Name = "dokumentationBox";
            this.dokumentationBox.ReadOnly = true;
            this.dokumentationBox.Size = new System.Drawing.Size(445, 419);
            this.dokumentationBox.TabIndex = 14;
            this.dokumentationBox.Text = "";
            this.dokumentationBox.Visible = false;
            this.dokumentationBox.TextChanged += new System.EventHandler(this.dokumentationBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1064, 688);
            this.Controls.Add(this.dokumentationBox);
            this.Controls.Add(this.dungeonNameLabel);
            this.Controls.Add(this.dungeonName);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.dungeonAusgabe);
            this.Controls.Add(this.objectInput);
            this.Controls.Add(this.objectLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.hightLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.hightInput);
            this.Controls.Add(this.beendenBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.DokumentationBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DokumentationBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button beendenBtn;
        private System.Windows.Forms.TextBox hightInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label hightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label objectLabel;
        private System.Windows.Forms.TextBox objectInput;
        private System.Windows.Forms.RichTextBox dungeonAusgabe;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.TextBox dungeonName;
        private System.Windows.Forms.Label dungeonNameLabel;
        private System.Windows.Forms.RichTextBox dokumentationBox;
    }
}

