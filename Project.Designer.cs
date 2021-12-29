namespace Lab9
{
    partial class Project
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLab9));
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.labelWolfs = new System.Windows.Forms.Label();
            this.labelRabbits = new System.Windows.Forms.Label();
            this.labelWolfsCounter = new System.Windows.Forms.Label();
            this.labelRabbitsCounter = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelHunter = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSimpleMod = new System.Windows.Forms.Button();
            this.btnShooterMod = new System.Windows.Forms.Button();
            this.labelMod = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMove
            // 
            this.timerMove.Interval = 42;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // labelWolfs
            // 
            this.labelWolfs.AutoSize = true;
            this.labelWolfs.BackColor = System.Drawing.Color.Transparent;
            this.labelWolfs.Font = new System.Drawing.Font("Hobo Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWolfs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            this.labelWolfs.Location = new System.Drawing.Point(12, 397);
            this.labelWolfs.Name = "labelWolfs";
            this.labelWolfs.Size = new System.Drawing.Size(150, 34);
            this.labelWolfs.TabIndex = 0;
            this.labelWolfs.Text = "Wolfs";
            // 
            // labelRabbits
            // 
            this.labelRabbits.AutoSize = true;
            this.labelRabbits.BackColor = System.Drawing.Color.Transparent;
            this.labelRabbits.Font = new System.Drawing.Font("Hobo Std", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRabbits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            this.labelRabbits.Location = new System.Drawing.Point(684, 9);
            this.labelRabbits.Name = "labelRabbits";
            this.labelRabbits.Size = new System.Drawing.Size(104, 31);
            this.labelRabbits.TabIndex = 1;
            this.labelRabbits.Text = "Rabbits";
            // 
            // labelWolfsCounter
            // 
            this.labelWolfsCounter.AutoSize = true;
            this.labelWolfsCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelWolfsCounter.Font = new System.Drawing.Font("Hobo Std", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWolfsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            this.labelWolfsCounter.Location = new System.Drawing.Point(162, 399);
            this.labelWolfsCounter.Name = "labelWolfsCounter";
            this.labelWolfsCounter.Size = new System.Drawing.Size(27, 31);
            this.labelWolfsCounter.TabIndex = 2;
            this.labelWolfsCounter.Text = "0";
            // 
            // labelRabbitsCounter
            // 
            this.labelRabbitsCounter.AutoSize = true;
            this.labelRabbitsCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelRabbitsCounter.Font = new System.Drawing.Font("Hobo Std", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRabbitsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(193)))));
            this.labelRabbitsCounter.Location = new System.Drawing.Point(635, 9);
            this.labelRabbitsCounter.Name = "labelRabbitsCounter";
            this.labelRabbitsCounter.Size = new System.Drawing.Size(27, 31);
            this.labelRabbitsCounter.TabIndex = 3;
            this.labelRabbitsCounter.Text = "0";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BackgroundImage = global::Lab8.Properties.Resources.panel_start;
            this.panelMenu.Controls.Add(this.labelPizzaheaded);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnContinue);
            this.panelMenu.Controls.Add(this.btnReset);
            this.panelMenu.Controls.Add(this.btnSimpleMod);
            this.panelMenu.Controls.Add(this.btnShooterMod);
            this.panelMenu.Location = new System.Drawing.Point(285, 9);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 446);
            this.panelMenu.TabIndex = 4;
            // 
            // labelHunter
            // 
            this.labelHunter.AutoSize = true;
            this.labelHunter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(116)))), ((int)(((byte)(48)))));
            this.labelHunter.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHunter.ForeColor = System.Drawing.Color.White;
            this.labelHunter.Location = new System.Drawing.Point(17, 59);
            this.labelHunter.Name = "labelHunter";
            this.labelHunter.Size = new System.Drawing.Size(174, 38);
            this.labelHunter.TabIndex = 5;
            this.labelHunter.Text = "Hunter";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnExit.Location = new System.Drawing.Point(35, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.White;
            this.btnContinue.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnContinue.Location = new System.Drawing.Point(23, 287);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(174, 34);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnReset.Location = new System.Drawing.Point(23, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 39);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset results";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSimpleMod
            // 
            this.btnSimpleMod.BackColor = System.Drawing.Color.White;
            this.btnSimpleMod.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpleMod.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSimpleMod.Location = new System.Drawing.Point(23, 173);
            this.btnSimpleMod.Name = "btnSimpleMod";
            this.btnSimpleMod.Size = new System.Drawing.Size(174, 35);
            this.btnSimpleMod.TabIndex = 1;
            this.btnSimpleMod.Text = "Simple Mod";
            this.btnSimpleMod.UseVisualStyleBackColor = false;
            this.btnSimpleMod.Click += new System.EventHandler(this.btnSimpleMod_Click);
            // 
            // btnShooterMod
            // 
            this.btnShooterMod.BackColor = System.Drawing.Color.White;
            this.btnShooterMod.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShooterMod.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnShooterMod.Location = new System.Drawing.Point(23, 120);
            this.btnShooterMod.Name = "btnShooterMod";
            this.btnShooterMod.Size = new System.Drawing.Size(174, 34);
            this.btnShooterMod.TabIndex = 0;
            this.btnShooterMod.Text = "Shooter Mod";
            this.btnShooterMod.UseVisualStyleBackColor = false;
            this.btnShooterMod.Click += new System.EventHandler(this.btnShooterMod_Click);
            // 
            // labelMod
            // 
            this.labelMod.AutoSize = true;
            this.labelMod.BackColor = System.Drawing.Color.Transparent;
            this.labelMod.Font = new System.Drawing.Font("Hobo Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMod.ForeColor = System.Drawing.Color.Violet;
            this.labelMod.Location = new System.Drawing.Point(684, 420);
            this.labelMod.Name = "labelMod";
            this.labelMod.Size = new System.Drawing.Size(104, 21);
            this.labelMod.TabIndex = 5;
            this.labelMod.Text = "Shooter Mod";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = global::Lab8.Properties.Resources.fonTest12;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMod);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.labelRabbitsCounter);
            this.Controls.Add(this.labelWolfsCounter);
            this.Controls.Add(this.labelRabbits);
            this.Controls.Add(this.labelWolfs);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Project";
            this.Text = "hunter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Project_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Project_KeyUp);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Label labelWolfs;
        private System.Windows.Forms.Label labelRabbits;
        private System.Windows.Forms.Label labelWolfsCounter;
        private System.Windows.Forms.Label labelRabbitsCounter;
        private System.Windows.Forms.Button btnSimpleMod;
        private System.Windows.Forms.Button btnShooterMod;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelHunter;
        private System.Windows.Forms.Label labelMod;
    }
}

