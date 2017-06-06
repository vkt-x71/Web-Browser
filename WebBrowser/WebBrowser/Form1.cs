using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SekmeEkle("http://veyselkaranitekgoz.com");

        }
        void SekmeEkle(string url)
        {
            Sekme yeni = new Sekme(url);
            TBSekmeler.TabPages.Add(yeni);
            TBSekmeler.SelectedTab = yeni;

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void yeniSekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SekmeEkle("http://veyselkaranitekgoz.com");
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TBSekmeler.TabPages.Count == 1)
                Application.Exit();
            else
                TBSekmeler.TabPages.Remove(TBSekmeler.SelectedTab);
        }
    }
}
