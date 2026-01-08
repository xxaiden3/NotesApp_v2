using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class editnotes : Form
    {
        public editnotes()
        {
            InitializeComponent();
        }
        string tagss;
        private void LoadGrid()
        {
            dgvnotes.AutoGenerateColumns = true;
            dgvnotes.DataSource = DatabaseHelper.GetNotes();
        }
        private void editnotes_Load(object sender, EventArgs e)
        {
            LoadListBox();
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
            LoadGrid();
            toolTip1.SetToolTip(editib, "Edit");
            toolTip1.SetToolTip(deleteib, "Delete");
            toolTip1.SetToolTip(copyib, "Copy");
       

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
        private void editib_Click(object sender, EventArgs e)
        {
            var note = DatabaseHelper.GetNoteById(noteId);
            if (note == null)
            {
                MessageBox.Show("Please select a note");
                return;
            }
            
            txttitle.Text = note["Title"].ToString();
            txtcontent.Text = note["Content"].ToString();
            lbltags.Text = note["Tags"].ToString();
            PanelMenu.Visible = false;
            panel1.Visible = true;

            /*
             PanelMenu.Visible = false;
            panel1.Visible = true;
            if (e.RowIndex < 0) return;
            noteId = Convert.ToInt32(
                dgvnotes.Rows[e.RowIndex].Cells["Id"].Value);
            var note = DatabaseHelper.GetNoteById(noteId);
            if (note == null) return;
            txttitle.Text = note["Title"].ToString();
            txtcontent.Text = note["Content"].ToString();
            lbltags.Text = note["Tags"].ToString();

            DataGridViewRow row = dgvnotes.CurrentRow;


            string content = row.Cells["dgvnote"].Value.ToString();
            string tagsss = row.Cells["Tags"].Value.ToString();
            string fontName = row.Cells["FontName"].Value.ToString();
            float fontSize = Convert.ToSingle(row.Cells["FontSize"].Value);
            bool isBold = Convert.ToInt32(row.Cells["bold"].Value) == 1;
            int colorArgb = Convert.ToInt32(row.Cells["txtcolor"].Value);
             */
        }
        int noteId;
        private void dgvnotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            noteId = Convert.ToInt32(
                dgvnotes.Rows[e.RowIndex].Cells["Id"].Value);
        }

        private void dgvnotes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PanelMenu.Visible = false;
            panel1.Visible = true;
            if (e.RowIndex < 0) return;
            noteId = Convert.ToInt32(
                dgvnotes.Rows[e.RowIndex].Cells["Id"].Value);
            var note = DatabaseHelper.GetNoteById(noteId);
            if (note == null) return;
            txttitle.Text = note["Title"].ToString();
            txtcontent.Text = note["Content"].ToString();
            lbltags.Text = note["Tags"].ToString();

            DataGridViewRow row = dgvnotes.CurrentRow;


            string content = row.Cells["dgvnote"].Value.ToString();
            string tagsss = row.Cells["Tags"].Value.ToString();
            string fontName = row.Cells["FontName"].Value.ToString();
            float fontSize = Convert.ToSingle(row.Cells["FontSize"].Value);
            bool isBold = Convert.ToInt32(row.Cells["bold"].Value) == 1;
            int colorArgb = Convert.ToInt32(row.Cells["txtcolor"].Value);
        }
        private void dgvnotes_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvnotes.CurrentRow == null)
                return;

            DataGridViewRow row = dgvnotes.CurrentRow;

            string content = row.Cells["dgvnote"].Value.ToString();
            string fontName = row.Cells["FontName"].Value.ToString();
            float fontSize = Convert.ToSingle(row.Cells["FontSize"].Value);
            bool isBold = Convert.ToInt32(row.Cells["bold"].Value) == 1;
            int colorArgb = Convert.ToInt32(row.Cells["txtcolor"].Value);

            FontStyle style = isBold ? FontStyle.Bold : FontStyle.Regular;

            txtcontent.Text = content;
            txtcontent.Font = new Font(fontName, fontSize, style);
            txtcontent.ForeColor = Color.FromArgb(colorArgb);
            lblfont.Text = fontName;
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

        private void FontIB_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtcontent.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtcontent.Font = fontDialog1.Font;
            }
            lblfont.Text = txtcontent.Font.Name;
        }

        int karakterSayisi;

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

        private void SaveIB_Click(object sender, EventArgs e)
        {
            DatabaseHelper.UpdateNote(
            noteId,
            txttitle.Text,
            txtcontent.Text,
            tagss,
            txtcontent.Font.Name,
            txtcontent.Font.Size,
            txtcontent.Font.Bold,
            txtcontent.ForeColor.ToArgb()
            );
            MessageBox.Show("Update completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteib_Click(object sender, EventArgs e)
        {
            DatabaseHelper.DeleteNote(
                noteId
                );
            LoadGrid();
        }

        private void copyib_Click(object sender, EventArgs e)
        {
            if (dgvnotes.SelectedRows.Count > 0)
            {
                string note = dgvnotes.SelectedRows[0].Cells["dgvnote"].Value.ToString();
                string text = note;
                Clipboard.SetText(text);
                MessageBox.Show("Note Copied");
            }
            else
            {
                MessageBox.Show("Select a note first!");
            }
        }

        private void CleanIB_Click(object sender, EventArgs e)
        {
            DialogResult tus = MessageBox.Show("Do u want to clean?", "Clean Text", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tus == DialogResult.Yes)
            {
                txtcontent.Text = "";
                txtcontent.Focus();
            }
        }

        private void dgvnotes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // 🔴 SADECE NOT SÜTUNU
            if (dgvnotes.Columns[e.ColumnIndex].Name != "dgvnote")
                return;

            DataGridViewRow row = dgvnotes.Rows[e.RowIndex];

            string fontName = row.Cells["FontName"].Value?.ToString();
            float fontSize = Convert.ToSingle(row.Cells["FontSize"].Value);
            bool isBold = Convert.ToInt32(row.Cells["bold"].Value) == 1;
            int colorArgb = Convert.ToInt32(row.Cells["txtcolor"].Value);

            FontStyle style = isBold ? FontStyle.Bold : FontStyle.Regular;

            try
            {
                e.CellStyle.Font = new Font(fontName, fontSize, style);
                e.CellStyle.ForeColor = Color.FromArgb(colorArgb);
            }
            catch
            {
                // font yoksa default
                e.CellStyle.Font = dgvnotes.Font;
                e.CellStyle.ForeColor = dgvnotes.ForeColor;
            }
        }

        private void closetags_Click(object sender, EventArgs e)
        {
            paneltags.Visible = false;
        }

        private void listtags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listtags.SelectedItems.Count > 0)
            {
                tagss = listtags.Text;
                lbltags.Text = tagss;
            }

        }

        private void listtags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listtags.SelectedItems.Count > 0)
            {
                tagss = listtags.Text;
                lbltags.Text = tagss;
                paneltags.Visible = false;
            }
        }

        private void tags_ib_Click(object sender, EventArgs e)
        {
            paneltags.Left = (this.ClientSize.Width - paneltags.Width) / 2;
            paneltags.Top = (this.ClientSize.Height - paneltags.Height) / 2;
            paneltags.Visible = true;
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

        private void undo_Click(object sender, EventArgs e)
        {
            txtcontent.Undo();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            txtcontent.Redo();

        }

        private void done_Click(object sender, EventArgs e)
        {

            tagss = listtags.Text;
            lbltags.Text = tagss;
            paneltags.Visible = false;
        }

        private void editnotes_Shown(object sender, EventArgs e)
        {
            dgvnotes.ClearSelection();
            dgvnotes.CurrentCell = null;
        }
    }
}
