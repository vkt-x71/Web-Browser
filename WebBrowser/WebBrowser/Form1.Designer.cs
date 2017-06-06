namespace WebBrowser
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
            this.components = new System.ComponentModel.Container();
            this.TBSekmeler = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniSekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBSekmeler
            // 
            this.TBSekmeler.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TBSekmeler.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TBSekmeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBSekmeler.Location = new System.Drawing.Point(0, 0);
            this.TBSekmeler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBSekmeler.Name = "TBSekmeler";
            this.TBSekmeler.SelectedIndex = 0;
            this.TBSekmeler.ShowToolTips = true;
            this.TBSekmeler.Size = new System.Drawing.Size(626, 344);
            this.TBSekmeler.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSekmeToolStripMenuItem,
            this.closeTabToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // yeniSekmeToolStripMenuItem
            // 
            this.yeniSekmeToolStripMenuItem.Name = "yeniSekmeToolStripMenuItem";
            this.yeniSekmeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yeniSekmeToolStripMenuItem.Text = "Yeni Sekme";
            this.yeniSekmeToolStripMenuItem.Click += new System.EventHandler(this.yeniSekmeToolStripMenuItem_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeTabToolStripMenuItem.Text = "Sekmeyi Kapat";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 344);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.TBSekmeler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TBSekmeler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniSekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
    }


}

