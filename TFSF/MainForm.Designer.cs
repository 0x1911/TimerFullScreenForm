namespace TFSF
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkKeepSettings = new System.Windows.Forms.CheckBox();
            this.Sekunden = new System.Windows.Forms.Label();
            this.Minuten = new System.Windows.Forms.Label();
            this.Stunden = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.bTimer = new System.Windows.Forms.Timer(this.components);
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkKeepSettings);
            this.groupBox1.Controls.Add(this.Sekunden);
            this.groupBox1.Controls.Add(this.Minuten);
            this.groupBox1.Controls.Add(this.Stunden);
            this.groupBox1.Controls.Add(this.txtSeconds);
            this.groupBox1.Controls.Add(this.txtMinutes);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(444, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkKeepSettings
            // 
            this.chkKeepSettings.AutoSize = true;
            this.chkKeepSettings.Checked = true;
            this.chkKeepSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepSettings.Location = new System.Drawing.Point(36, 158);
            this.chkKeepSettings.Margin = new System.Windows.Forms.Padding(4);
            this.chkKeepSettings.Name = "chkKeepSettings";
            this.chkKeepSettings.Size = new System.Drawing.Size(273, 22);
            this.chkKeepSettings.TabIndex = 9;
            this.chkKeepSettings.Text = "hold settings after time elapse or stop";
            this.chkKeepSettings.UseVisualStyleBackColor = true;
            this.chkKeepSettings.CheckedChanged += new System.EventHandler(this.chkKeepSettings_CheckedChanged);
            // 
            // Sekunden
            // 
            this.Sekunden.AutoSize = true;
            this.Sekunden.Location = new System.Drawing.Point(214, 111);
            this.Sekunden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sekunden.Name = "Sekunden";
            this.Sekunden.Size = new System.Drawing.Size(67, 18);
            this.Sekunden.TabIndex = 6;
            this.Sekunden.Text = "Seconds";
            // 
            // Minuten
            // 
            this.Minuten.AutoSize = true;
            this.Minuten.Location = new System.Drawing.Point(214, 75);
            this.Minuten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Minuten.Name = "Minuten";
            this.Minuten.Size = new System.Drawing.Size(60, 18);
            this.Minuten.TabIndex = 5;
            this.Minuten.Text = "Minutes";
            // 
            // Stunden
            // 
            this.Stunden.AutoSize = true;
            this.Stunden.Location = new System.Drawing.Point(214, 39);
            this.Stunden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Stunden.Name = "Stunden";
            this.Stunden.Size = new System.Drawing.Size(49, 18);
            this.Stunden.TabIndex = 4;
            this.Stunden.Text = "Hours";
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSeconds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSeconds.Location = new System.Drawing.Point(134, 107);
            this.txtSeconds.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSeconds.Size = new System.Drawing.Size(70, 24);
            this.txtSeconds.TabIndex = 3;
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMinutes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMinutes.Location = new System.Drawing.Point(134, 71);
            this.txtMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMinutes.Size = new System.Drawing.Size(70, 24);
            this.txtMinutes.TabIndex = 2;
            this.txtMinutes.Text = "30";
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtHours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHours.Location = new System.Drawing.Point(134, 35);
            this.txtHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtHours.Name = "txtHours";
            this.txtHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHours.Size = new System.Drawing.Size(70, 24);
            this.txtHours.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set time:";
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(312, 272);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 32);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "[ ]";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(169, 272);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(112, 32);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "| |";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(35, 272);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 32);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = ">";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // bTimer
            // 
            this.bTimer.Interval = 1000;
            this.bTimer.Tick += new System.EventHandler(this.bTimer_Tick);
            // 
            // sStrip
            // 
            this.sStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.sStrip.Location = new System.Drawing.Point(0, 352);
            this.sStrip.Name = "sStrip";
            this.sStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.sStrip.Size = new System.Drawing.Size(482, 22);
            this.sStrip.SizingGrip = false;
            this.sStrip.TabIndex = 13;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel4.Text = "Status:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "stopped";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel3.Text = "Time:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel2.Text = "00:00:00";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(482, 374);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Opacity = 0.8D;
            this.Text = "[FST] Main windows";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label Sekunden;
        private System.Windows.Forms.Label Minuten;
        private System.Windows.Forms.Label Stunden;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer bTimer;
        private System.Windows.Forms.CheckBox chkKeepSettings;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

