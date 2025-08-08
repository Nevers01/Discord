namespace Discord
{
    partial class LoadingForm
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
            ProgressBarStatus = new ReaLTaiizor.Controls.CyberProgressBar();
            LabelStatus = new ReaLTaiizor.Controls.CrownLabel();
            SuspendLayout();
            // 
            // ProgressBarStatus
            // 
            ProgressBarStatus.Alpha = 50;
            ProgressBarStatus.BackColor = Color.Transparent;
            ProgressBarStatus.Background = true;
            ProgressBarStatus.Background_WidthPen = 3F;
            ProgressBarStatus.BackgroundPen = true;
            ProgressBarStatus.ColorBackground = Color.FromArgb(37, 52, 68);
            ProgressBarStatus.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            ProgressBarStatus.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            ProgressBarStatus.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            ProgressBarStatus.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            ProgressBarStatus.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            ProgressBarStatus.ColorLighting = Color.FromArgb(29, 200, 238);
            ProgressBarStatus.ColorPen_1 = Color.FromArgb(37, 52, 68);
            ProgressBarStatus.ColorPen_2 = Color.FromArgb(41, 63, 86);
            ProgressBarStatus.ColorProgressBar = Color.FromArgb(29, 200, 238);
            ProgressBarStatus.ColorValue_Transparency = 200;
            ProgressBarStatus.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            ProgressBarStatus.Font = new Font("Arial", 11F);
            ProgressBarStatus.ForeColor = Color.FromArgb(245, 245, 245);
            ProgressBarStatus.Lighting = false;
            ProgressBarStatus.LinearGradient_Background = false;
            ProgressBarStatus.LinearGradient_Value = false;
            ProgressBarStatus.LinearGradientPen = false;
            ProgressBarStatus.Location = new Point(12, 329);
            ProgressBarStatus.Maximum = 100;
            ProgressBarStatus.Minimum = 0;
            ProgressBarStatus.Name = "ProgressBarStatus";
            ProgressBarStatus.PenWidth = 10;
            ProgressBarStatus.ProgressText = true;
            ProgressBarStatus.RGB = false;
            ProgressBarStatus.Rounding = true;
            ProgressBarStatus.RoundingInt = 70;
            ProgressBarStatus.Size = new Size(300, 34);
            ProgressBarStatus.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ProgressBarStatus.StartDrawingValue = 0;
            ProgressBarStatus.TabIndex = 5;
            ProgressBarStatus.Tag = "Cyber";
            ProgressBarStatus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            ProgressBarStatus.Timer_RGB = 300;
            ProgressBarStatus.Value = 0;
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.ForeColor = Color.FromArgb(220, 220, 220);
            LabelStatus.Location = new Point(12, 302);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(74, 15);
            LabelStatus.TabIndex = 6;
            LabelStatus.Text = "crownLabel1";
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(321, 375);
            Controls.Add(LabelStatus);
            Controls.Add(ProgressBarStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            Text = "LoadingForm";
            TopMost = true;
            Load += LoadingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.CyberProgressBar ProgressBarStatus;
        private ReaLTaiizor.Controls.CrownLabel LabelStatus;
    }
}