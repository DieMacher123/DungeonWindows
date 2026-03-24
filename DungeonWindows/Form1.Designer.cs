namespace DungeonWindows
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.beendenBtn = new System.Windows.Forms.Button();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.objectLabel = new System.Windows.Forms.Label();
            this.objectInput = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.truhenLabel = new System.Windows.Forms.Label();
            this.fallenLabel = new System.Windows.Forms.Label();
            this.statistikenLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dungeonPanel = new System.Windows.Forms.Panel();
            this.dungeonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(171, 224);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(116, 39);
            this.startBtn.TabIndex = 13;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // beendenBtn
            // 
            this.beendenBtn.BackColor = System.Drawing.Color.White;
            this.beendenBtn.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beendenBtn.Location = new System.Drawing.Point(171, 283);
            this.beendenBtn.Name = "beendenBtn";
            this.beendenBtn.Size = new System.Drawing.Size(116, 38);
            this.beendenBtn.TabIndex = 12;
            this.beendenBtn.Text = "Beenden";
            this.beendenBtn.UseVisualStyleBackColor = false;
            this.beendenBtn.Click += new System.EventHandler(this.beendenBtn_Click);
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(85, 36);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 20);
            this.heightInput.TabIndex = 11;
            this.heightInput.Visible = false;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(85, 62);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 20);
            this.widthInput.TabIndex = 10;
            this.widthInput.Visible = false;
            // 
            // heightLabel
            // 
            this.heightLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(7, 36);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(57, 23);
            this.heightLabel.TabIndex = 9;
            this.heightLabel.Text = "Höhe:";
            this.heightLabel.Visible = false;
            // 
            // widthLabel
            // 
            this.widthLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(7, 62);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(57, 23);
            this.widthLabel.TabIndex = 8;
            this.widthLabel.Text = "Breite:";
            this.widthLabel.Visible = false;
            // 
            // objectLabel
            // 
            this.objectLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectLabel.Location = new System.Drawing.Point(7, 88);
            this.objectLabel.Name = "objectLabel";
            this.objectLabel.Size = new System.Drawing.Size(71, 23);
            this.objectLabel.TabIndex = 7;
            this.objectLabel.Text = "Objekte:";
            this.objectLabel.Visible = false;
            // 
            // objectInput
            // 
            this.objectInput.Location = new System.Drawing.Point(85, 88);
            this.objectInput.Name = "objectInput";
            this.objectInput.Size = new System.Drawing.Size(100, 20);
            this.objectInput.TabIndex = 6;
            this.objectInput.Visible = false;
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.White;
            this.generateBtn.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(47, 511);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(123, 46);
            this.generateBtn.TabIndex = 5;
            this.generateBtn.Text = "Generieren";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Visible = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.White;
            this.exportBtn.Enabled = false;
            this.exportBtn.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.Location = new System.Drawing.Point(47, 563);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 4;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Visible = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // truhenLabel
            // 
            this.truhenLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truhenLabel.Location = new System.Drawing.Point(12, 169);
            this.truhenLabel.Name = "truhenLabel";
            this.truhenLabel.Size = new System.Drawing.Size(100, 23);
            this.truhenLabel.TabIndex = 3;
            this.truhenLabel.Text = "Truhen:";
            this.truhenLabel.Visible = false;
            // 
            // fallenLabel
            // 
            this.fallenLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallenLabel.Location = new System.Drawing.Point(12, 192);
            this.fallenLabel.Name = "fallenLabel";
            this.fallenLabel.Size = new System.Drawing.Size(100, 23);
            this.fallenLabel.TabIndex = 2;
            this.fallenLabel.Text = "Fallen:";
            this.fallenLabel.Visible = false;
            // 
            // statistikenLabel
            // 
            this.statistikenLabel.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistikenLabel.Location = new System.Drawing.Point(5, 134);
            this.statistikenLabel.Name = "statistikenLabel";
            this.statistikenLabel.Size = new System.Drawing.Size(165, 23);
            this.statistikenLabel.TabIndex = 1;
            this.statistikenLabel.Text = "Statistiken";
            this.statistikenLabel.Visible = false;
            // 
            // dungeonPanel
            // 
            this.dungeonPanel.BackColor = System.Drawing.Color.Transparent;
            this.dungeonPanel.Controls.Add(this.beendenBtn);
            this.dungeonPanel.Controls.Add(this.startBtn);
            this.dungeonPanel.Location = new System.Drawing.Point(232, 12);
            this.dungeonPanel.Name = "dungeonPanel";
            this.dungeonPanel.Size = new System.Drawing.Size(716, 706);
            this.dungeonPanel.TabIndex = 0;
            this.dungeonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dungeonPanel_Paint);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(962, 730);
            this.Controls.Add(this.objectInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.statistikenLabel);
            this.Controls.Add(this.fallenLabel);
            this.Controls.Add(this.truhenLabel);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.dungeonPanel);
            this.Controls.Add(this.objectLabel);
            this.Name = "Form1";
            this.Text = "Dungeon Generator";
            this.dungeonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button beendenBtn;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label objectLabel;
        private System.Windows.Forms.TextBox objectInput;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Label truhenLabel;
        private System.Windows.Forms.Label fallenLabel;
        private System.Windows.Forms.Label statistikenLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel dungeonPanel;
    }
}