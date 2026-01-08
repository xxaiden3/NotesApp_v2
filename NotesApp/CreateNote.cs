using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class CreateNote : Form
    {
        public CreateNote()
        {
            InitializeComponent();
        }
        int karakterSayisi;
        string tagss = "";

        private void SaveIB_Click(object sender, EventArgs e)
        {
            if (karakterSayisi > 2500)
            {
                MessageBox.Show("Max used characters");
            }
            else
            {
                MessageBox.Show("Note saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatabaseHelper.AddNote(
                   txttitle.Text,
                   txtcontent.Text,
                   tagss,
                   txtcontent.Font.Name,
                   txtcontent.Font.Size,
                   txtcontent.Font.Bold,
                   txtcontent.ForeColor.ToArgb());
            }

        }
        int seciliindex;
        private void tags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listtags.SelectedItems.Count > 0)
            {
                tagss = listtags.Text;
                lbltags.Text = tagss;
            }

        }
        void LoadListBox()
        {
            listtags.Items.Clear();

            DataTable dt = DatabaseHelper.GetListBoxItems();

            foreach (DataRow row in dt.Rows)
            {
                listtags.Items.Add(row["Text"].ToString());
            }
        }

        private void CreateNote_Load(object sender, EventArgs e)
        {
            LoadListBox();
            toolTip1.SetToolTip(SaveIB, "Save");
            toolTip1.SetToolTip(CleanIB, "Clean");
            toolTip1.SetToolTip(undo, "Undo");
            toolTip1.SetToolTip(redo, "Redo");
            toolTip1.SetToolTip(FontIB, "Change Font");
            toolTip1.SetToolTip(ColorIB, "Change Color");
            toolTip1.SetToolTip(tags_ib, "Add Tag");
            txttitle.Focus();
            txttitle.Text = "";
            lblfont.Text = txtcontent.Font.Name;
            Color c = txtcontent.ForeColor;

            if (c.IsNamedColor || c.IsKnownColor)
            {
                lblcolor.Text = c.Name;
            }
            else
            {
                lblcolor.Text = $"#{c.R:X2}{c.G:X2}{c.B:X2}";
            }
        }

        private void ColorIB_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = txtcontent.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtcontent.ForeColor = colorDialog1.Color;

                Color c = txtcontent.ForeColor;
                if (c.IsNamedColor || c.IsKnownColor)
                {
                    lblcolor.Text = c.Name;
                }
                else
                {
                    lblcolor.Text = $"#{c.R:X2}{c.G:X2}{c.B:X2}";
                }
            }
        }

        private void FontIB_Click_1(object sender, EventArgs e)
        {
            fontDialog1.Font = txtcontent.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtcontent.Font = fontDialog1.Font;
            }
            lblfont.Text = txtcontent.Font.Name;
        }

        private void txtcontent_TextChanged(object sender, EventArgs e)
        {
            string text = txtcontent.Text;

            int wordCount = text
                .Split(new char[] { ' ', '\n', '\r', '\t' },
                       StringSplitOptions.RemoveEmptyEntries)
                .Length;
            int lineCount = txtcontent.Lines.Length;
            karakterSayisi = txtcontent.Text.Length;
            int max = 2500;
            int current = txtcontent.Text.Length;
            lblCharCount.Text = karakterSayisi + " characters \t\t" + "| " + current + " / " + max + " | " + wordCount.ToString() + " words" + " | " + lineCount.ToString() + " Line";

            if (current >= max)
                lblCharCount.ForeColor = Color.Red;
            else
                lblCharCount.ForeColor = Color.Black;
        }

        private void RefreshIB_Click(object sender, EventArgs e)
        {
            DialogResult tus = MessageBox.Show("Do u want to clean?", "Clean Text", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tus == DialogResult.Yes)
            {
                txtcontent.Text = "";
                txtcontent.Focus();
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            txtcontent.Undo();
            txtcontent.Focus();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            txtcontent.Redo();
            txtcontent.Focus();
        }

        private void txttitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtcontent.Focus();
                if (txtcontent.Text == "Note")
                {
                    txtcontent.Text = "";
                }
            }
        }

        private void txttitle_Leave(object sender, EventArgs e)
        {
            if (txttitle.Text == "")
            {
                txttitle.Text = "Title";
            }
        }

        private void txtcontent_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtcontent.Text == "Note")
            {
                txtcontent.Text = "";
            }
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if (newtag.Text == "" || newtag.Text == " ")
            {
                return;
            }
            DatabaseHelper.addtag(newtag.Text);
            newtag.Text = "";
            LoadListBox();
        }
        private void tags_ib_Click(object sender, EventArgs e)
        {
            paneltags.Left = (this.ClientSize.Width - paneltags.Width) / 2;
            paneltags.Top = (this.ClientSize.Height - paneltags.Height) / 2;

            paneltags.Visible = true;
        }

        private void closetags_Click(object sender, EventArgs e)
        {
            paneltags.Visible = false;
        }

        private void delete_ib_Click(object sender, EventArgs e)
        {
            if (listtags.SelectedItems.Count > 0)
            {
                string deltext = listtags.SelectedItem.ToString();
                DatabaseHelper.DeleteListTagItems(deltext);
                LoadListBox();
            }
            else
            {
                MessageBox.Show("Please seelct a tag");
            }
        }

        private void tags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listtags.SelectedItems.Count > 0)
            {
                tagss = listtags.Text;
                lbltags.Text = tagss;
                paneltags.Visible = false;
            }
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (listtags.SelectedItems.Count > 0)
            {
                tagss = listtags.Text;
                lbltags.Text = tagss;
                paneltags.Visible = false;
            }
        }

        private void CreateNote_Shown(object sender, EventArgs e)
        {

        }
    }
}
