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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dungeonPanel = new System.Windows.Forms.Panel();
            this.statistikenLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.dokumentationLabel = new System.Windows.Forms.Label();
            this.truhenIcon = new System.Windows.Forms.PictureBox();
            this.truheIconLabel = new System.Windows.Forms.Label();
            this.falleIconLabel = new System.Windows.Forms.Label();
            this.fallenIcon = new System.Windows.Forms.PictureBox();
            this.bodenIcon = new System.Windows.Forms.PictureBox();
            this.bodenIconLabel = new System.Windows.Forms.Label();
            this.wandIcon = new System.Windows.Forms.PictureBox();
            this.wandIconLabel = new System.Windows.Forms.Label();
            this.endeIcon = new System.Windows.Forms.PictureBox();
            this.endeIconLabel = new System.Windows.Forms.Label();
            this.startIcon = new System.Windows.Forms.PictureBox();
            this.startIconLabel = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.beendenBtn2 = new System.Windows.Forms.Button();
            this.heartlbl = new System.Windows.Forms.Label();
            this.heartIcon1 = new System.Windows.Forms.PictureBox();
            this.heartIcon2 = new System.Windows.Forms.PictureBox();
            this.heartIcon3 = new System.Windows.Forms.PictureBox();
            this.dungeonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truhenIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallenIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodenIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wandIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartIcon3)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(193, 223);
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
            this.beendenBtn.Location = new System.Drawing.Point(193, 283);
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
            this.heightLabel.BackColor = System.Drawing.Color.Transparent;
            this.heightLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.heightLabel.Location = new System.Drawing.Point(7, 36);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(57, 23);
            this.heightLabel.TabIndex = 9;
            this.heightLabel.Text = "Höhe:";
            this.heightLabel.Visible = false;
            // 
            // widthLabel
            // 
            this.widthLabel.BackColor = System.Drawing.Color.Transparent;
            this.widthLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.widthLabel.Location = new System.Drawing.Point(7, 62);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(57, 23);
            this.widthLabel.TabIndex = 8;
            this.widthLabel.Text = "Breite:";
            this.widthLabel.Visible = false;
            // 
            // objectLabel
            // 
            this.objectLabel.BackColor = System.Drawing.Color.Transparent;
            this.objectLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.generateBtn.Location = new System.Drawing.Point(24, 600);
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
            this.exportBtn.Location = new System.Drawing.Point(24, 652);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 1;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Visible = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // truhenLabel
            // 
            this.truhenLabel.BackColor = System.Drawing.Color.Transparent;
            this.truhenLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truhenLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.truhenLabel.Location = new System.Drawing.Point(13, 171);
            this.truhenLabel.Name = "truhenLabel";
            this.truhenLabel.Size = new System.Drawing.Size(100, 23);
            this.truhenLabel.TabIndex = 3;
            this.truhenLabel.Text = "Truhen:";
            this.truhenLabel.Visible = false;
            this.truhenLabel.Click += new System.EventHandler(this.truhenLabel_Click_1);
            // 
            // fallenLabel
            // 
            this.fallenLabel.BackColor = System.Drawing.Color.Transparent;
            this.fallenLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallenLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fallenLabel.Location = new System.Drawing.Point(13, 194);
            this.fallenLabel.Name = "fallenLabel";
            this.fallenLabel.Size = new System.Drawing.Size(100, 23);
            this.fallenLabel.TabIndex = 2;
            this.fallenLabel.Text = "Fallen:";
            this.fallenLabel.Visible = false;
            this.fallenLabel.Click += new System.EventHandler(this.fallenLabel_Click_1);
            // 
            // dungeonPanel
            // 
            this.dungeonPanel.BackColor = System.Drawing.Color.Transparent;
            this.dungeonPanel.Controls.Add(this.beendenBtn);
            this.dungeonPanel.Controls.Add(this.startBtn);
            this.dungeonPanel.Location = new System.Drawing.Point(232, 12);
            this.dungeonPanel.Name = "dungeonPanel";
            this.dungeonPanel.Size = new System.Drawing.Size(708, 706);
            this.dungeonPanel.TabIndex = 0;
            this.dungeonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dungeonPanel_Paint);
            // 
            // statistikenLabel
            // 
            this.statistikenLabel.BackColor = System.Drawing.Color.Transparent;
            this.statistikenLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistikenLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statistikenLabel.Location = new System.Drawing.Point(6, 139);
            this.statistikenLabel.Name = "statistikenLabel";
            this.statistikenLabel.Size = new System.Drawing.Size(165, 23);
            this.statistikenLabel.TabIndex = 4;
            this.statistikenLabel.Text = "Statistiken";
            this.statistikenLabel.Visible = false;
            this.statistikenLabel.Click += new System.EventHandler(this.statistikenLabel_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timerLabel.Location = new System.Drawing.Point(27, 216);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(100, 23);
            this.timerLabel.TabIndex = 14;
            this.timerLabel.Text = "Zeit:";
            this.timerLabel.Visible = false;
            this.timerLabel.Click += new System.EventHandler(this.timerLabel_Click);
            // 
            // dokumentationLabel
            // 
            this.dokumentationLabel.BackColor = System.Drawing.Color.Transparent;
            this.dokumentationLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dokumentationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dokumentationLabel.Location = new System.Drawing.Point(6, 251);
            this.dokumentationLabel.Name = "dokumentationLabel";
            this.dokumentationLabel.Size = new System.Drawing.Size(165, 23);
            this.dokumentationLabel.TabIndex = 15;
            this.dokumentationLabel.Text = "Dokumentation";
            this.dokumentationLabel.Visible = false;
            this.dokumentationLabel.Click += new System.EventHandler(this.dokumentationLabel_Click);
            // 
            // truhenIcon
            // 
            this.truhenIcon.BackgroundImage = global::DungeonWindows.Properties.Resources.chest;
            this.truhenIcon.ErrorImage = global::DungeonWindows.Properties.Resources.chest;
            this.truhenIcon.InitialImage = global::DungeonWindows.Properties.Resources.chest;
            this.truhenIcon.Location = new System.Drawing.Point(89, 277);
            this.truhenIcon.Name = "truhenIcon";
            this.truhenIcon.Size = new System.Drawing.Size(32, 32);
            this.truhenIcon.TabIndex = 16;
            this.truhenIcon.TabStop = false;
            this.truhenIcon.Visible = false;
            this.truhenIcon.Click += new System.EventHandler(this.truhenIcon_Click);
            // 
            // truheIconLabel
            // 
            this.truheIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.truheIconLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truheIconLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.truheIconLabel.Location = new System.Drawing.Point(21, 286);
            this.truheIconLabel.Name = "truheIconLabel";
            this.truheIconLabel.Size = new System.Drawing.Size(69, 23);
            this.truheIconLabel.TabIndex = 17;
            this.truheIconLabel.Text = "Truhe ->";
            this.truheIconLabel.Visible = false;
            this.truheIconLabel.Click += new System.EventHandler(this.truheIconLabel_Click);
            // 
            // falleIconLabel
            // 
            this.falleIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.falleIconLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falleIconLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.falleIconLabel.Location = new System.Drawing.Point(21, 321);
            this.falleIconLabel.Name = "falleIconLabel";
            this.falleIconLabel.Size = new System.Drawing.Size(69, 23);
            this.falleIconLabel.TabIndex = 18;
            this.falleIconLabel.Text = "Falle ->";
            this.falleIconLabel.Visible = false;
            this.falleIconLabel.Click += new System.EventHandler(this.falleIconLabel_Click);
            // 
            // fallenIcon
            // 
            this.fallenIcon.BackgroundImage = global::DungeonWindows.Properties.Resources.trap;
            this.fallenIcon.ErrorImage = global::DungeonWindows.Properties.Resources.chest;
            this.fallenIcon.InitialImage = global::DungeonWindows.Properties.Resources.chest;
            this.fallenIcon.Location = new System.Drawing.Point(89, 312);
            this.fallenIcon.Name = "fallenIcon";
            this.fallenIcon.Size = new System.Drawing.Size(32, 32);
            this.fallenIcon.TabIndex = 19;
            this.fallenIcon.TabStop = false;
            this.fallenIcon.Visible = false;
            this.fallenIcon.Click += new System.EventHandler(this.fallenIcon_Click);
            // 
            // bodenIcon
            // 
            this.bodenIcon.BackgroundImage = global::DungeonWindows.Properties.Resources.floor;
            this.bodenIcon.ErrorImage = global::DungeonWindows.Properties.Resources.chest;
            this.bodenIcon.InitialImage = global::DungeonWindows.Properties.Resources.chest;
            this.bodenIcon.Location = new System.Drawing.Point(89, 350);
            this.bodenIcon.Name = "bodenIcon";
            this.bodenIcon.Size = new System.Drawing.Size(32, 32);
            this.bodenIcon.TabIndex = 20;
            this.bodenIcon.TabStop = false;
            this.bodenIcon.Visible = false;
            this.bodenIcon.Click += new System.EventHandler(this.bodenIcon_Click);
            // 
            // bodenIconLabel
            // 
            this.bodenIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.bodenIconLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodenIconLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bodenIconLabel.Location = new System.Drawing.Point(21, 359);
            this.bodenIconLabel.Name = "bodenIconLabel";
            this.bodenIconLabel.Size = new System.Drawing.Size(69, 23);
            this.bodenIconLabel.TabIndex = 21;
            this.bodenIconLabel.Text = "Boden ->";
            this.bodenIconLabel.Visible = false;
            this.bodenIconLabel.Click += new System.EventHandler(this.bodenIconLabel_Click);
            // 
            // wandIcon
            // 
            this.wandIcon.BackgroundImage = global::DungeonWindows.Properties.Resources.wall;
            this.wandIcon.ErrorImage = global::DungeonWindows.Properties.Resources.chest;
            this.wandIcon.InitialImage = global::DungeonWindows.Properties.Resources.chest;
            this.wandIcon.Location = new System.Drawing.Point(89, 388);
            this.wandIcon.Name = "wandIcon";
            this.wandIcon.Size = new System.Drawing.Size(32, 32);
            this.wandIcon.TabIndex = 22;
            this.wandIcon.TabStop = false;
            this.wandIcon.Visible = false;
            this.wandIcon.Click += new System.EventHandler(this.wandIcon_Click);
            // 
            // wandIconLabel
            // 
            this.wandIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.wandIconLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wandIconLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wandIconLabel.Location = new System.Drawing.Point(28, 397);
            this.wandIconLabel.Name = "wandIconLabel";
            this.wandIconLabel.Size = new System.Drawing.Size(62, 23);
            this.wandIconLabel.TabIndex = 23;
            this.wandIconLabel.Text = "Wand ->";
            this.wandIconLabel.Visible = false;
            this.wandIconLabel.Click += new System.EventHandler(this.wandIconLabel_Click);
            // 
            // endeIcon
            // 
            this.endeIcon.BackgroundImage = global::DungeonWindows.Properties.Resources.exit;
            this.endeIcon.ErrorImage = global::DungeonWindows.Properties.Resources.chest;
            this.endeIcon.InitialImage = global::DungeonWindows.Properties.Resources.chest;
            this.endeIcon.Location = new System.Drawing.Point(89, 426);
            this.endeIcon.Name = "endeIcon";
            this.endeIcon.Size = new System.Drawing.Size(32, 32);
            this.endeIcon.TabIndex = 24;
            this.endeIcon.TabStop = false;
            this.endeIcon.Visible = false;
            this.endeIcon.Click += new System.EventHandler(this.endeIcon_Click);
            // 
            // endeIconLabel
            // 
            this.endeIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.endeIconLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endeIconLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endeIconLabel.Location = new System.Drawing.Point(28, 435);
            this.endeIconLabel.Name = "endeIconLabel";
            this.endeIconLabel.Size = new System.Drawing.Size(62, 23);
            this.endeIconLabel.TabIndex = 25;
            this.endeIconLabel.Text = "Ende ->";
            this.endeIconLabel.Visible = false;
            this.endeIconLabel.Click += new System.EventHandler(this.endeIconLabel_Click);
            // 
            // startIcon
            // 
            this.startIcon.BackgroundImage = global::DungeonWindows.Properties.Resources.start;
            this.startIcon.ErrorImage = global::DungeonWindows.Properties.Resources.chest;
            this.startIcon.InitialImage = global::DungeonWindows.Properties.Resources.chest;
            this.startIcon.Location = new System.Drawing.Point(89, 464);
            this.startIcon.Name = "startIcon";
            this.startIcon.Size = new System.Drawing.Size(32, 32);
            this.startIcon.TabIndex = 26;
            this.startIcon.TabStop = false;
            this.startIcon.Visible = false;
            this.startIcon.Click += new System.EventHandler(this.startIcon_Click);
            // 
            // startIconLabel
            // 
            this.startIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.startIconLabel.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startIconLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startIconLabel.Location = new System.Drawing.Point(21, 473);
            this.startIconLabel.Name = "startIconLabel";
            this.startIconLabel.Size = new System.Drawing.Size(69, 23);
            this.startIconLabel.TabIndex = 27;
            this.startIconLabel.Text = "Start ->";
            this.startIconLabel.Visible = false;
            this.startIconLabel.Click += new System.EventHandler(this.startIconLabel_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.White;
            this.helpBtn.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.Location = new System.Drawing.Point(103, 652);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(44, 23);
            this.helpBtn.TabIndex = 28;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Visible = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // beendenBtn2
            // 
            this.beendenBtn2.BackColor = System.Drawing.Color.White;
            this.beendenBtn2.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beendenBtn2.Location = new System.Drawing.Point(24, 681);
            this.beendenBtn2.Name = "beendenBtn2";
            this.beendenBtn2.Size = new System.Drawing.Size(75, 23);
            this.beendenBtn2.TabIndex = 29;
            this.beendenBtn2.Text = "Beenden";
            this.beendenBtn2.UseVisualStyleBackColor = false;
            this.beendenBtn2.Visible = false;
            this.beendenBtn2.Click += new System.EventHandler(this.beendenBtn2_Click);
            // 
            // heartlbl
            // 
            this.heartlbl.BackColor = System.Drawing.Color.Transparent;
            this.heartlbl.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.heartlbl.Location = new System.Drawing.Point(21, 531);
            this.heartlbl.Name = "heartlbl";
            this.heartlbl.Size = new System.Drawing.Size(57, 23);
            this.heartlbl.TabIndex = 30;
            this.heartlbl.Text = "Leben:";
            this.heartlbl.Visible = false;
            // 
            // heartIcon1
            // 
            this.heartIcon1.BackgroundImage = global::DungeonWindows.Properties.Resources.heart;
            this.heartIcon1.ErrorImage = global::DungeonWindows.Properties.Resources.chest;
            this.heartIcon1.InitialImage = global::DungeonWindows.Properties.Resources.chest;
            this.heartIcon1.Location = new System.Drawing.Point(85, 522);
            this.heartIcon1.Name = "heartIcon1";
            this.heartIcon1.Size = new System.Drawing.Size(32, 32);
            this.heartIcon1.TabIndex = 31;
            this.heartIcon1.TabStop = false;
            this.heartIcon1.Visible = false;
            // 
            // heartIcon2
            // 
            this.heartIcon2.BackgroundImage = global::DungeonWindows.Properties.Resources.heart;
            this.heartIcon2.ErrorImage = global::DungeonWindows.Properties.Resources.chest;
            this.heartIcon2.InitialImage = global::DungeonWindows.Properties.Resources.chest;
            this.heartIcon2.Location = new System.Drawing.Point(123, 522);
            this.heartIcon2.Name = "heartIcon2";
            this.heartIcon2.Size = new System.Drawing.Size(32, 32);
            this.heartIcon2.TabIndex = 32;
            this.heartIcon2.TabStop = false;
            this.heartIcon2.Visible = false;
            // 
            // heartIcon3
            // 
            this.heartIcon3.BackgroundImage = global::DungeonWindows.Properties.Resources.heart;
            this.heartIcon3.ErrorImage = global::DungeonWindows.Properties.Resources.chest;
            this.heartIcon3.InitialImage = global::DungeonWindows.Properties.Resources.chest;
            this.heartIcon3.Location = new System.Drawing.Point(161, 522);
            this.heartIcon3.Name = "heartIcon3";
            this.heartIcon3.Size = new System.Drawing.Size(32, 32);
            this.heartIcon3.TabIndex = 33;
            this.heartIcon3.TabStop = false;
            this.heartIcon3.Visible = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(948, 724);
            this.Controls.Add(this.heartIcon3);
            this.Controls.Add(this.heartIcon2);
            this.Controls.Add(this.heartIcon1);
            this.Controls.Add(this.heartlbl);
            this.Controls.Add(this.beendenBtn2);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.startIconLabel);
            this.Controls.Add(this.startIcon);
            this.Controls.Add(this.endeIconLabel);
            this.Controls.Add(this.endeIcon);
            this.Controls.Add(this.wandIconLabel);
            this.Controls.Add(this.wandIcon);
            this.Controls.Add(this.bodenIconLabel);
            this.Controls.Add(this.bodenIcon);
            this.Controls.Add(this.fallenIcon);
            this.Controls.Add(this.falleIconLabel);
            this.Controls.Add(this.truheIconLabel);
            this.Controls.Add(this.truhenIcon);
            this.Controls.Add(this.dokumentationLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.statistikenLabel);
            this.Controls.Add(this.objectInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.heightInput);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dungeonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.truhenIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallenIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodenIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wandIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartIcon3)).EndInit();
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel dungeonPanel;
        private System.Windows.Forms.Label statistikenLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label dokumentationLabel;
        private System.Windows.Forms.PictureBox truhenIcon;
        private System.Windows.Forms.Label truheIconLabel;
        private System.Windows.Forms.Label falleIconLabel;
        private System.Windows.Forms.PictureBox fallenIcon;
        private System.Windows.Forms.PictureBox bodenIcon;
        private System.Windows.Forms.Label bodenIconLabel;
        private System.Windows.Forms.PictureBox wandIcon;
        private System.Windows.Forms.Label wandIconLabel;
        private System.Windows.Forms.PictureBox endeIcon;
        private System.Windows.Forms.Label endeIconLabel;
        private System.Windows.Forms.PictureBox startIcon;
        private System.Windows.Forms.Label startIconLabel;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button beendenBtn2;
        private System.Windows.Forms.Label heartlbl;
        private System.Windows.Forms.PictureBox heartIcon1;
        private System.Windows.Forms.PictureBox heartIcon2;
        private System.Windows.Forms.PictureBox heartIcon3;
    }
}