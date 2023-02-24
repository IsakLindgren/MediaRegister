using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MediaRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SaveLastFile();
            openFile(lastOpened);
        }

        string lastOpened = string.Empty;

        Font font;

        public void SaveLastFile()
        {
            string filepath = "C:\\Users\\isalin28\\OneDrive - Lärande\\Dokument\\MediaRegisterConfig.bin";
            if (!File.Exists(filepath))
            {
                //creates MediaRegisterConfig.bin if it doesnt exist
                try
                {
                    Debug.WriteLine("Binary Writer");

                    string fileName = "C:\\Users\\isalin28\\OneDrive - Lärande\\Dokument\\MediaRegisterConfig.bin";

                    Encoding utf8 = Encoding.UTF8;

                    using (BinaryWriter binWriter =
                        new BinaryWriter(new FileStream(fileName, FileMode.Create), utf8))
                    {
                        binWriter.Write(new FontConverter().ConvertToString(font));
                        binWriter.Close();

                    }
                    Debug.WriteLine("Data Written!");
                }
                catch (IOException ioexp)
                {
                    Debug.WriteLine("Error: {0}", ioexp.Message);
                }
            }
            else
            {
                // reads MediaRegisterConfig.bin
                try
                {
                    Debug.WriteLine("Binary Reader");

                    Encoding utf8 = Encoding.UTF8;

                    using (BinaryReader binReader =
                        new BinaryReader(new FileStream("C:\\Users\\isalin28\\OneDrive - Lärande\\Dokument\\MediaRegisterConfig.bin", FileMode.Open), utf8))
                    {
                        lastOpened = binReader.ReadString();

                        font = new FontConverter().ConvertFromString(binReader.ReadString()) as Font;

                        binReader.Close();
                    }
                    Debug.WriteLine("Data Read!");
                }
                catch (IOException ioexp)
                {
                    Debug.WriteLine("Error: {0}", ioexp.Message);
                }
            }
        }
        public void SaveLastFile(string lastopened)
        {
            lastOpened = lastopened;
            string filepath = "C:\\Users\\isalin28\\OneDrive - Lärande\\Dokument\\MediaRegisterConfig.bin";
            if (!File.Exists(filepath))
            {
                //creates MediaRegisterConfig.bin if it doesnt exist
                try
                {
                    Debug.WriteLine("Binary Writer");

                    string fileName = "C:\\Users\\isalin28\\OneDrive - Lärande\\Dokument\\MediaRegisterConfig.bin";

                    Encoding utf8 = Encoding.UTF8;

                    using (BinaryWriter binWriter =
                        new BinaryWriter(new FileStream(fileName, FileMode.Create), utf8))
                    {
                        binWriter.Write(lastOpened);

                        binWriter.Close();

                    }
                    Debug.WriteLine("Data Written!");
                }
                catch (IOException ioexp)
                {
                    Debug.WriteLine("Error: {0}", ioexp.Message);
                }
            }
            else
            {
                // writes to MediaRegisterConfig.bin
                try
                {
                    Debug.WriteLine("Binary Reader");

                    Encoding utf8 = Encoding.UTF8;

                    using (BinaryWriter binWrite =
                        new BinaryWriter(new FileStream("C:\\Users\\isalin28\\OneDrive - Lärande\\Dokument\\MediaRegisterConfig.bin", FileMode.Open), utf8))
                    {
                        binWrite.Write(lastOpened);

                        binWrite.Close();
                    }
                    Debug.WriteLine("Data Read!");
                }
                catch (IOException ioexp)
                {
                    Debug.WriteLine("Error: {0}", ioexp.Message);
                }
            }
        }

        private void openFile(string fileName)
        {
            Media.media.Clear();
            tbxResults.Text = String.Empty;

            try
            {
                Debug.WriteLine("Binary Reader");

                Encoding utf8 = Encoding.UTF8;

                using (BinaryReader binReader =
                    new BinaryReader(new FileStream(fileName, FileMode.Open), utf8))
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
                SaveLastFile(fileName);

                


            }
            catch (IOException ioexp)
            {
                Debug.WriteLine("Error: {0}", ioexp.Message);
            }

            Debug.Write("File loded");
            tbxResults.Text = Media.Write();
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
            saveFileDialog1.Filter = "binary| *.bin";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    Debug.WriteLine("Binary Writer");

                    string fileName = saveFileDialog1.FileName;

                    Encoding utf8 = Encoding.UTF8;

                    using (BinaryWriter binWriter =
                        new BinaryWriter(new FileStream(fileName, FileMode.Create), utf8))
                    {
                        binWriter.Write(Media.media.Count());

                        foreach (var media in Media.media)
                        {
                            binWriter.Write(media._MediaType);

                            binWriter.Write(media.GetTitle());
                            binWriter.Write(media.GetCreator());
                            binWriter.Write(media.GetLength());
                            
                        }
                        binWriter.Close();
                        
                    }
                    Debug.WriteLine("Data Written!");
                }
                catch (IOException ioexp)
                {
                    Debug.WriteLine("Error: {0}", ioexp.Message);
                }

                SaveLastFile(saveFileDialog1.FileName);

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Binary|*.bin";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                openFile(openFileDialog1.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media.media.Clear();
            tbxResults.Text = String.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openLastFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLastFile();
            openFile(lastOpened);
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                font = fontDialog1.Font;
                tbxResults.Font = fontDialog1.Font;

            }
        }
    }
}