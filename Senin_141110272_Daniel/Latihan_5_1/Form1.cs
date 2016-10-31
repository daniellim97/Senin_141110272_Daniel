using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fontDialog1.ShowApply = true;
        }
        public Color formcolor
        {
            get { return this.richTextBox1.BackColor; }
            set { this.richTextBox1.BackColor = value; }
        }

        private void bold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold || richTextBox1.SelectionFont.Italic || richTextBox1.SelectionFont.Underline)
            {
                bold.Checked = false;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
            }
            else
            {
                bold.Checked = true;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void italic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold || richTextBox1.SelectionFont.Italic || richTextBox1.SelectionFont.Underline)
            {
                italic.Checked = false;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
            }
            else
            {
                italic.Checked = true;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void under_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold || richTextBox1.SelectionFont.Italic || richTextBox1.SelectionFont.Underline)
            {
                under.Checked = false;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
            }
            else
            {
                under.Checked = true;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {

                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = @"dekstop";
                save.Filter = "RTF file (*.rtf)|*.rtf | All Files (*.*)|*.*";
                save.FilterIndex = 2;
                save.RestoreDirectory = true;

                save.OverwritePrompt = true;
                save.DefaultExt = "rtf";
                DialogResult result = MessageBox.Show("Save changes ?", "Notepad++", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                        richTextBox1.Enabled = true;
                        richTextBox1.Text = "";
                    }
                }
                else if (result == DialogResult.No)
                {
                    richTextBox1.Enabled = true;
                    richTextBox1.Text = "";
                }
                else
                {
                    richTextBox1.Enabled = true;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"dekstop";
            open.Filter = "RTF file (*.rtf)|*.rtf | All Files (*.*)|*.*";
            open.FilterIndex = 2;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"dekstop";
            save.Filter = "RTF file (*.rtf)|*.rtf | All Files (*.*)|*.*";
            save.FilterIndex = 2;
            save.RestoreDirectory = true;
            save.OverwritePrompt = true;
            save.DefaultExt = "rtf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {

                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = @"dekstop";
                save.Filter = "RTF file (*.rtf)|*.rtf | All Files (*.*)|*.*";
                save.FilterIndex = 2;
                save.RestoreDirectory = true;
                save.OverwritePrompt = true;
                save.DefaultExt = "rtf";
                DialogResult result = MessageBox.Show("Save changes ?", "Notepad++", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                        richTextBox1.Enabled = true;
                        Close();
                    }
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    richTextBox1.Enabled = true;
                }
            }
            else
                Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.MdiParent = this.ParentForm;
            form2.Show();
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this, e.X, e.Y);
                if (richTextBox1.TextLength == 0)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    contextMenuStrip1.Items[1].Enabled = false;
                    contextMenuStrip1.Items[2].Enabled = false;
                    contextMenuStrip1.Items[4].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[2].Enabled = true;
                    contextMenuStrip1.Items[4].Enabled = true;
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        
    }
}
