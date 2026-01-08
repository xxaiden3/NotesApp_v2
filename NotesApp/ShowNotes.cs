using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Controls;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class ShowNotes : Form
    {
        public ShowNotes()
        {
            InitializeComponent();
        }
        public void homecall()
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            dgvnotes.AutoGenerateColumns = false;
            dgvnotes.DataSource = DatabaseHelper.GetNotes();
        }
 
        private void ShowNotes_Load(object sender, EventArgs e)
        {
            LoadGrid();
            dgvnotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //int noteId;

        
        private void dgvnotes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

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
                e.CellStyle.Font = dgvnotes.Font;
                e.CellStyle.ForeColor = dgvnotes.ForeColor;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void SearchNotes()
        {
            dgvnotes.DataSource = DatabaseHelper.SearchNotes(
                txtsearchtitle.Text,
                txtsearchnotes.Text ,
                txtsearchtags.Text
            );
        }
        private void txtsearchtitle_TextChanged(object sender, EventArgs e)
        {
            SearchNotes();
        }

        private void txtsearchnotes_TextChanged(object sender, EventArgs e)
        {
            SearchNotes();
        }

        private void CleanIB_Click(object sender, EventArgs e)
        {
            txtsearchtitle.Clear();
            txtsearchnotes.Clear();
            txtsearchtags.Clear();
            dgvnotes.DataSource = DatabaseHelper.GetNotes();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgvnotes.DataSource = DatabaseHelper.GetNotesLast7Days();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dgvnotes.DataSource = DatabaseHelper.GetNotesLastMonth();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsearchtags_TextChanged(object sender, EventArgs e)
        {
            SearchNotes();
        }

        private void ShowNotes_Shown(object sender, EventArgs e)
        {
            dgvnotes.ClearSelection();
            dgvnotes.CurrentCell = null;
        }
    }
}
