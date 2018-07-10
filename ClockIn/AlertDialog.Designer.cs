namespace clockInCockIn
{
    partial class ClockInAlert
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
            this.AlertPanel = new System.Windows.Forms.Panel();
            this.panelAlertLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.clockINButton = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlertPanel
            // 
            this.AlertPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlertPanel.Location = new System.Drawing.Point(0, 0);
            this.AlertPanel.Name = "AlertPanel";
            this.AlertPanel.Size = new System.Drawing.Size(787, 482);
            this.AlertPanel.TabIndex = 1;
            // 
            // panelAlertLabel
            // 
            this.panelAlertLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 147F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAlertLabel.Location = new System.Drawing.Point(0, 0);
            this.panelAlertLabel.Name = "panelAlertLabel";
            this.panelAlertLabel.Size = new System.Drawing.Size(787, 404);
            this.panelAlertLabel.TabIndex = 1;
            this.panelAlertLabel.Text = "CLOCK IN!!";
            this.panelAlertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.clockINButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 404);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(787, 78);
            this.ButtonPanel.TabIndex = 2;
            // 
            // clockINButton
            // 
            this.clockINButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockINButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockINButton.Location = new System.Drawing.Point(0, 0);
            this.clockINButton.Name = "clockINButton";
            this.clockINButton.Size = new System.Drawing.Size(787, 78);
            this.clockINButton.TabIndex = 0;
            this.clockINButton.Text = "Clocked in";
            this.clockINButton.UseVisualStyleBackColor = true;
            this.clockINButton.Click += new System.EventHandler(this.clockINButton_Click);
            // 
            // ClockInAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 482);
            this.Controls.Add(this.panelAlertLabel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.AlertPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClockInAlert";
            this.Text = "Clock In";
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AlertPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Label panelAlertLabel;
        private System.Windows.Forms.Button clockINButton;
    }
}