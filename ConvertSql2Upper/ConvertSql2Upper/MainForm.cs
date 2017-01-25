using System;
using System.IO;
using System.Windows.Forms;

namespace ConvertSql2Upper
{
    public partial class MainForm : Form
    {
        IKeywordsConvertible converter;
        public MainForm()
        {
            InitializeComponent();
            converter = new SqlConverter(ReadKeyWords());
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string sourceText = txtSource.Text;
            string targetText = converter.Convert(sourceText);
            txtTarget.Text = targetText;
        }

        public string[] ReadKeyWords()
        {
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\Initial.ini";
            string[] array = File.ReadAllLines(path);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Trim().ToLower();
            }
            return array;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTarget.Text))
            {
                return;
            }
            Clipboard.SetText(txtTarget.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSource.Clear();

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtSource.Undo();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtSource.Text = Clipboard.GetText();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtSource.Clear();
            txtTarget.Clear();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            txtSource.Clear();
            txtTarget.Clear();

            if (Clipboard.ContainsText())
            {
                txtSource.Text = Clipboard.GetText();
            }
            btnConvert_Click(null, null);

            btnCopy_Click(null, null);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (cbAutoOprate.Checked)
            {
                btnRock_Click(null, null);
            }
        }

    

    }
}
