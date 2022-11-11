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
            Media.media.Add(new Book(tbxBookTitle.Text, tbxWriter.Text, nrBookLength.Value.DecimalToInt()));

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
    }
}