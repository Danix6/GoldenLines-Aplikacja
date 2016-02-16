namespace TelemetryAppV2
{
    partial class PanelLogowania
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogowaniaGroup = new System.Windows.Forms.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.hasloLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.hasloBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.zalogujButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusLabel_Info = new System.Windows.Forms.Label();
            this.panelLogowaniaGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogowaniaGroup
            // 
            this.panelLogowaniaGroup.AutoSize = true;
            this.panelLogowaniaGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogowaniaGroup.Controls.Add(this.infoLabel);
            this.panelLogowaniaGroup.Controls.Add(this.hasloLabel);
            this.panelLogowaniaGroup.Controls.Add(this.loginLabel);
            this.panelLogowaniaGroup.Controls.Add(this.hasloBox);
            this.panelLogowaniaGroup.Controls.Add(this.loginBox);
            this.panelLogowaniaGroup.Controls.Add(this.zalogujButton);
            this.panelLogowaniaGroup.Location = new System.Drawing.Point(8, 26);
            this.panelLogowaniaGroup.Name = "panelLogowaniaGroup";
            this.panelLogowaniaGroup.Size = new System.Drawing.Size(304, 154);
            this.panelLogowaniaGroup.TabIndex = 0;
            this.panelLogowaniaGroup.TabStop = false;
            this.panelLogowaniaGroup.Text = "Panel Logowania";
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(10, 112);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(288, 26);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hasloLabel
            // 
            this.hasloLabel.AutoSize = true;
            this.hasloLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloLabel.Location = new System.Drawing.Point(6, 54);
            this.hasloLabel.Name = "hasloLabel";
            this.hasloLabel.Size = new System.Drawing.Size(53, 19);
            this.hasloLabel.TabIndex = 4;
            this.hasloLabel.Text = "Hasło:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.Location = new System.Drawing.Point(7, 22);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 19);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login:";
            // 
            // hasloBox
            // 
            this.hasloBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloBox.Location = new System.Drawing.Point(64, 51);
            this.hasloBox.Name = "hasloBox";
            this.hasloBox.PasswordChar = '*';
            this.hasloBox.Size = new System.Drawing.Size(234, 26);
            this.hasloBox.TabIndex = 2;
            this.hasloBox.Click += new System.EventHandler(this.hasloBox_Click);
            this.hasloBox.TextChanged += new System.EventHandler(this.hasloBox_TextChanged);
            this.hasloBox.DoubleClick += new System.EventHandler(this.hasloBox_DoubleClick);
            this.hasloBox.Enter += new System.EventHandler(this.hasloBox_Enter);
            this.hasloBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hasloBox_KeyDown);
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBox.Location = new System.Drawing.Point(64, 19);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(234, 26);
            this.loginBox.TabIndex = 1;
            this.loginBox.Click += new System.EventHandler(this.loginBox_Click);
            this.loginBox.TextChanged += new System.EventHandler(this.loginBox_TextChanged);
            this.loginBox.DoubleClick += new System.EventHandler(this.loginBox_DoubleClick);
            this.loginBox.Enter += new System.EventHandler(this.loginBox_Enter);
            this.loginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginBox_KeyDown);
            // 
            // zalogujButton
            // 
            this.zalogujButton.Location = new System.Drawing.Point(10, 83);
            this.zalogujButton.Name = "zalogujButton";
            this.zalogujButton.Size = new System.Drawing.Size(288, 26);
            this.zalogujButton.TabIndex = 0;
            this.zalogujButton.Text = "Zaloguj";
            this.zalogujButton.UseVisualStyleBackColor = true;
            this.zalogujButton.Click += new System.EventHandler(this.zalogujButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLabel.Location = new System.Drawing.Point(4, 4);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 19);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status:";
            // 
            // statusLabel_Info
            // 
            this.statusLabel_Info.AutoSize = true;
            this.statusLabel_Info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLabel_Info.Location = new System.Drawing.Point(59, 4);
            this.statusLabel_Info.Name = "statusLabel_Info";
            this.statusLabel_Info.Size = new System.Drawing.Size(0, 19);
            this.statusLabel_Info.TabIndex = 2;
            // 
            // PanelLogowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.statusLabel_Info);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.panelLogowaniaGroup);
            this.Name = "PanelLogowania";
            this.Size = new System.Drawing.Size(315, 183);
            this.Load += new System.EventHandler(this.PanelLogowania_Load);
            this.panelLogowaniaGroup.ResumeLayout(false);
            this.panelLogowaniaGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox panelLogowaniaGroup;
        private System.Windows.Forms.Button zalogujButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label hasloLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox hasloBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusLabel_Info;
    }
}
