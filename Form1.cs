using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MediaRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // filter int (0) for all (1) Books (2) Films
        int filterVal = 0;

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Media.media.Insert(0, new Book(tbxBookTitle.Text, tbxWriter.Text, nrBookLength.Value.DecimalToInt()));

            tbxBookTitle.Text = string.Empty;
            tbxWriter.Text = string.Empty;
            nrBookLength.Value = 0;

            tbxResults.Text = extensions.Write(filterVal);
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            Media.media.Add(new Film(tbxFilmTitle.Text, tbxFilmDirector.Text, nrFilmLength.Value.DecimalToInt()));

            tbxFilmTitle.Text = String.Empty;
            tbxFilmDirector.Text = string.Empty;
            nrFilmLength.Value = 0;

            tbxResults.Text = extensions.Write(filterVal);
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAll.Checked)
            {
                filterVal = 0;
            }
            tbxResults.Text = extensions.Write(filterVal);
        }

        private void rbtnBooks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBooks.Checked)
            {
                filterVal = 1;
            }
            tbxResults.Text = extensions.Write(filterVal);
        }

        private void rbtnFilms_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFilms.Checked)
            {
                filterVal = 2;
            }
            tbxResults.Text = extensions.Write(filterVal);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, tbxResults.Text);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // only adds the text need to add meda to list
                //tbxResults.Text = File.ReadAllText(openFileDialog1.FileName);

                string file = File.ReadAllText(openFileDialog1.FileName);
                string Title = string.Empty;

                // if file is film
                if (file.LastIndexOf("n") == file.LastIndexOf(")")-1)
                {
                    Title = file.Split("(")[0];

                    char[] separators = new char[] { '(', ',' };
                    string Director = file.Split(separators)[1];
                    int length = int.Parse(file.Split());
                }

                // if file is book
                if (file.LastIndexOf("r") == file.LastIndexOf(")") - 1)
                {
                    Title = file.Split("(")[0];

                    char[] separators = new char[] { '(', ',' };
                    string Author = file.Split(separators)[1];
                }

                tbxResults.Text = Title;


            }
        }
    }
}