
namespace PLC
{
    partial class FormGrafik
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
            this.components = new System.ComponentModel.Container();
            this.GrafikControl = new ZedGraph.ZedGraphControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // GrafikControl
            // 
            this.GrafikControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrafikControl.Location = new System.Drawing.Point(2, 0);
            this.GrafikControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrafikControl.Name = "GrafikControl";
            this.GrafikControl.ScrollGrace = 0D;
            this.GrafikControl.ScrollMaxX = 0D;
            this.GrafikControl.ScrollMaxY = 0D;
            this.GrafikControl.ScrollMaxY2 = 0D;
            this.GrafikControl.ScrollMinX = 0D;
            this.GrafikControl.ScrollMinY = 0D;
            this.GrafikControl.ScrollMinY2 = 0D;
            this.GrafikControl.Size = new System.Drawing.Size(890, 517);
            this.GrafikControl.TabIndex = 0;
            this.GrafikControl.UseExtendedPrintDialog = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 516);
            this.Controls.Add(this.GrafikControl);
            this.Name = "FormGrafik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRAFİK";
            this.Load += new System.EventHandler(this.Deger1Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl GrafikControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}