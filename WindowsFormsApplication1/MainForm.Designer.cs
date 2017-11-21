namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.metroPnl = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // metroPnl
            // 
            this.metroPnl.HorizontalScrollbarBarColor = true;
            this.metroPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPnl.HorizontalScrollbarSize = 10;
            this.metroPnl.Location = new System.Drawing.Point(2, 7);
            this.metroPnl.Name = "metroPnl";
            this.metroPnl.Size = new System.Drawing.Size(456, 290);
            this.metroPnl.TabIndex = 0;
            this.metroPnl.VerticalScrollbarBarColor = true;
            this.metroPnl.VerticalScrollbarHighlightOnWheel = false;
            this.metroPnl.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 312);
            this.Controls.Add(this.metroPnl);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPnl;

    }
}