
using System;
using System.Drawing;
using System.Windows.Forms;
namespace WebBrowser
{
    public class Sekme : TabPage
    {
        ToolStripSpringTextBox TsTxtAdres = new ToolStripSpringTextBox();

        public System.Windows.Forms.WebBrowser wb = new System.Windows.Forms.WebBrowser();
        public Sekme(string url)
        {

            this.Text = "Yükleniyor";
            this.ToolTipText = "Yükleniyor";
            this.Padding = new Padding(0);
            this.Margin = new Padding(0);
            this.BorderStyle = BorderStyle.None;
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            #region MenuOlusturma
            ToolStrip ts = new ToolStrip();
            tlp.Controls.Add(ts, 0, 0);
            ToolStripButton TsBtn1, tsbtn2 = new ToolStripButton();
            ToolStripButton TsBtnGeri = new ToolStripButton();
            TsBtnGeri.Text = "Geri";
            TsBtnGeri.Click += TsBtnGeri_Click;
            ToolStripButton TsBtnIleri = new ToolStripButton();
            TsBtnIleri.Text = "İleri";
            TsBtnIleri.Click += TsBtnIleri_Click;
            ToolStripButton TsBtnYenile = new ToolStripButton();
            TsBtnYenile.Text = "Yenile";
            TsBtnYenile.Click += TsBtnYenile_Click;
            TsTxtAdres.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TsTxtAdres.AutoCompleteSource = AutoCompleteSource.HistoryList;
            TsTxtAdres.Dock = DockStyle.Fill;
            TsTxtAdres.KeyDown += TsTxtAdres_KeyDown;
            ts.Items.Add(TsBtnGeri);
            ts.Items.Add(TsBtnIleri);
            ts.Items.Add(TsBtnYenile);
            ts.Items.Add(TsTxtAdres);
            #endregion
            wb.Url = new Uri(url);
            wb.ScriptErrorsSuppressed = true;
            wb.Dock = DockStyle.Fill;
            wb.DocumentCompleted += wb_DocumentCompleted;
            wb.Navigated += wb_Navigated;
            tlp.Controls.Add(wb, 0, 1);
            this.Controls.Add(tlp);

        }

        void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            TsTxtAdres.Text = wb.Url.AbsoluteUri;
        }

        void TsTxtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            ToolStripTextBox send = sender as ToolStripTextBox;

            wb.Navigate(send.Text);
        }

        void TsBtnYenile_Click(object sender, EventArgs e)
        {
            wb.Refresh();
        }

        void TsBtnIleri_Click(object sender, EventArgs e)
        {
            wb.GoForward();
        }

        void TsBtnGeri_Click(object sender, EventArgs e)
        {
            wb.GoBack();
        }

        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = TextAyarla();
            this.ToolTipText = wb.DocumentTitle;
        }
        string TextAyarla()
        {
            if (wb.DocumentTitle.Length <= 20)
                return wb.DocumentTitle;
            else
                return wb.DocumentTitle.Substring(0, 20) + "...";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

    }
}

