using System.Diagnostics;
using System.Text;
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
            saveFileDialog1.DefaultExt = ".bin";
            saveFileDialog1.Filter = "";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    Debug.WriteLine("Binary Writer");

                    string fileName = saveFileDialog1.FileName;

                    Encoding ascii = Encoding.UTF8;

                    using (BinaryWriter binWriter =
                        new BinaryWriter(new FileStream(fileName, FileMode.Create), ascii))
                    {
                        binWriter.Write(Media.media.Count());

                        foreach (var media in Media.media)
                        {
                            binWriter.Write(media._MediaType);

                            binWriter.Write(media._Title);
                            binWriter.Write(media.GetCreator());
                            binWriter.Write(media.GetLength());
                            
                        }
                        binWriter.Close();
                        
                    }
                    Debug.WriteLine("Data Written!");
                    Debug.WriteLine("");
                }
                catch (IOException ioexp)
                {
                    Debug.WriteLine("Error: {0}", ioexp.Message);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Debug.WriteLine("Binary Reader");

                    string fileName = openFileDialog1.FileName;

                    Encoding ascii = Encoding.UTF8;

                    using (BinaryReader binReader =
                        new BinaryReader(new FileStream(fileName, FileMode.Open), ascii))
                    {
                        int listLength = binReader.ReadInt32();

                        for (int i = 0; i < listLength; i++)
                        {
                            int mediatype = binReader.ReadInt32();
                            string Title = binReader.ReadString();

                            if (mediatype == 0)
                            {
                                string Author = binReader.ReadString();
                                int pages = binReader.ReadInt32();

                                Media.media.Add(new Book(Title, Author, pages));
                            }

                            if (mediatype == 1)
                            {
                                string Director = binReader.ReadString();
                                int Length = binReader.ReadInt32();

                                Media.media.Add(new Film(Title, Director, Length));
                            }
                        }
                        binReader.Close();
                    }
                    Debug.WriteLine("Data Read!");
                    Debug.WriteLine("");
                }
                catch (IOException ioexp)
                {
                    Debug.WriteLine("Error: {0}", ioexp.Message);
                }

                Debug.Write("File loded");
                tbxResults.Text = Media.Write();
            }
        }
    }
}