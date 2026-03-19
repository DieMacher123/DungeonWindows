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
            this.heightInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.objectLabel = new System.Windows.Forms.Label();
            this.objectInput = new System.Windows.Forms.TextBox();
            this.dungeonAusgabe = new System.Windows.Forms.RichTextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.dokumentationBox = new System.Windows.Forms.RichTextBox();
            this.truhenLabel = new System.Windows.Forms.Label();
            this.fallenLabel = new System.Windows.Forms.Label();
            this.statistikenLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // DokumentationBtn
            // 
            this.DokumentationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DokumentationBtn.Location = new System.Drawing.Point(538, 236);
            this.DokumentationBtn.Name = "DokumentationBtn";
            this.DokumentationBtn.Size = new System.Drawing.Size(116, 37);
            this.DokumentationBtn.TabIndex = 0;
            this.DokumentationBtn.Text = "Dokumentation";
            this.DokumentationBtn.UseVisualStyleBackColor = true;
            this.DokumentationBtn.Click += new System.EventHandler(this.dokumentationBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(538, 191);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(116, 39);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // beendenBtn
            // 
            this.beendenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beendenBtn.Location = new System.Drawing.Point(538, 279);
            this.beendenBtn.Name = "beendenBtn";
            this.beendenBtn.Size = new System.Drawing.Size(116, 38);
            this.beendenBtn.TabIndex = 2;
            this.beendenBtn.Text = "Beenden";
            this.beendenBtn.UseVisualStyleBackColor = true;
            this.beendenBtn.Click += new System.EventHandler(this.beendenBtn_Click);
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(70, 36);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 20);
            this.heightInput.TabIndex = 3;
            this.heightInput.Visible = false;
            this.heightInput.TextChanged += new System.EventHandler(this.heightInput_TextChanged);
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
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(21, 37);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(44, 16);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Höhe:";
            this.heightLabel.Visible = false;
            this.heightLabel.Click += new System.EventHandler(this.heightLabel_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(19, 63);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(46, 16);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Breite:";
            this.widthLabel.Visible = false;
            this.widthLabel.Click += new System.EventHandler(this.widthLabel_Click);
            // 
            // objectLabel
            // 
            this.objectLabel.AutoSize = true;
            this.objectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectLabel.Location = new System.Drawing.Point(7, 88);
            this.objectLabel.Name = "objectLabel";
            this.objectLabel.Size = new System.Drawing.Size(58, 16);
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
            this.dungeonAusgabe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dungeonAusgabe.BackColor = System.Drawing.Color.Black;
            this.dungeonAusgabe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dungeonAusgabe.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonAusgabe.HideSelection = false;
            this.dungeonAusgabe.Location = new System.Drawing.Point(292, 12);
            this.dungeonAusgabe.Name = "dungeonAusgabe";
            this.dungeonAusgabe.ReadOnly = true;
            this.dungeonAusgabe.Size = new System.Drawing.Size(894, 652);
            this.dungeonAusgabe.TabIndex = 9;
            this.dungeonAusgabe.Text = "";
            this.dungeonAusgabe.Visible = false;
            this.dungeonAusgabe.WordWrap = false;
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
            // dokumentationBox
            // 
            this.dokumentationBox.BackColor = System.Drawing.Color.DimGray;
            this.dokumentationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dokumentationBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dokumentationBox.HideSelection = false;
            this.dokumentationBox.Location = new System.Drawing.Point(741, 12);
            this.dokumentationBox.Name = "dokumentationBox";
            this.dokumentationBox.ReadOnly = true;
            this.dokumentationBox.Size = new System.Drawing.Size(445, 419);
            this.dokumentationBox.TabIndex = 14;
            this.dokumentationBox.Text = "";
            this.dokumentationBox.Visible = false;
            this.dokumentationBox.TextChanged += new System.EventHandler(this.dokumentationBox_TextChanged);
            // 
            // truhenLabel
            // 
            this.truhenLabel.AutoSize = true;
            this.truhenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truhenLabel.Location = new System.Drawing.Point(12, 169);
            this.truhenLabel.Name = "truhenLabel";
            this.truhenLabel.Size = new System.Drawing.Size(53, 16);
            this.truhenLabel.TabIndex = 17;
            this.truhenLabel.Text = "Truhen:";
            this.truhenLabel.Visible = false;
            this.truhenLabel.Click += new System.EventHandler(this.truhenLabel_Click);
            // 
            // fallenLabel
            // 
            this.fallenLabel.AutoSize = true;
            this.fallenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallenLabel.Location = new System.Drawing.Point(17, 191);
            this.fallenLabel.Name = "fallenLabel";
            this.fallenLabel.Size = new System.Drawing.Size(48, 16);
            this.fallenLabel.TabIndex = 18;
            this.fallenLabel.Text = "Fallen:";
            this.fallenLabel.Visible = false;
            this.fallenLabel.Click += new System.EventHandler(this.fallenLabel_Click);
            // 
            // statistikenLabel
            // 
            this.statistikenLabel.AutoSize = true;
            this.statistikenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistikenLabel.Location = new System.Drawing.Point(5, 134);
            this.statistikenLabel.Name = "statistikenLabel";
            this.statistikenLabel.Size = new System.Drawing.Size(112, 25);
            this.statistikenLabel.TabIndex = 19;
            this.statistikenLabel.Text = "Statistiken";
            this.statistikenLabel.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1198, 676);
            this.Controls.Add(this.statistikenLabel);
            this.Controls.Add(this.fallenLabel);
            this.Controls.Add(this.truhenLabel);
            this.Controls.Add(this.dokumentationBox);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.dungeonAusgabe);
            this.Controls.Add(this.objectInput);
            this.Controls.Add(this.objectLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.beendenBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.DokumentationBtn);
            this.Name = "Form1";
            this.Text = "Truhen:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DokumentationBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button beendenBtn;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label objectLabel;
        private System.Windows.Forms.TextBox objectInput;
        private System.Windows.Forms.RichTextBox dungeonAusgabe;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.RichTextBox dokumentationBox;
        private System.Windows.Forms.Label truhenLabel;
        private System.Windows.Forms.Label fallenLabel;
        private System.Windows.Forms.Label statistikenLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

