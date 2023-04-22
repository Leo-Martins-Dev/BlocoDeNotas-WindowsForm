using System.Data;
using System.Windows.Forms;

namespace BlocoDeNotas
{
    public partial class blocoNotas : Form
    {
        DataTable notas = new DataTable();
        bool editando = false;
        public blocoNotas()
        {
            InitializeComponent();
        }

        private void BlocoNotas(object sender, EventArgs e)
        {
            notas.Columns.Add("Titulo");
            notas.Columns.Add("Nota");

            previousNote.DataSource = notas;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notas.Rows[previousNote.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ) { Console.WriteLine("Nao e uma nota valida"); }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = notas.Rows[previousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notas.Rows[previousNote.CurrentCell.RowIndex].ItemArray[1].ToString();
            editando = true;

        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                notas.Rows[previousNote.CurrentCell.RowIndex]["Titulo"] = titleBox.Text;
                notas.Rows[previousNote.CurrentCell.RowIndex]["Nota"] = noteBox.Text;
            }
            else
            {
                notas.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = "";
            noteBox.Text = "";
            editando = false;
        }

        private void PreviousNote_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notas.Rows[previousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notas.Rows[previousNote.CurrentCell.RowIndex].ItemArray[1].ToString();
            editando = true;
        }
    }
}