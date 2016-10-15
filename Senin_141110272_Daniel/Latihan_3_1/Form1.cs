using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fontDialog1.ShowApply = true;
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
    }
}
