namespace MediaRegister
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addBook = new System.Windows.Forms.TabPage();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.nrBookLength = new System.Windows.Forms.NumericUpDown();
            this.tbxWriter = new System.Windows.Forms.TextBox();
            this.tbxBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookLength = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.addFilm = new System.Windows.Forms.TabPage();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.nrFilmLength = new System.Windows.Forms.NumericUpDown();
            this.tbxFilmDirector = new System.Windows.Forms.TextBox();
            this.tbxFilmTitle = new System.Windows.Forms.TextBox();
            this.lblFilmLength = new System.Windows.Forms.Label();
            this.lblFilmDirector = new System.Windows.Forms.Label();
            this.lblFilmTitle = new System.Windows.Forms.Label();
            this.tbxResults = new System.Windows.Forms.TextBox();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.rbtnFilms = new System.Windows.Forms.RadioButton();
            this.rbtnBooks = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLastFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.addBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrBookLength)).BeginInit();
            this.addFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrFilmLength)).BeginInit();
            this.gbxFilter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addBook);
            this.tabControl1.Controls.Add(this.addFilm);
            this.tabControl1.Location = new System.Drawing.Point(20, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(245, 246);
            this.tabControl1.TabIndex = 0;
            // 
            // addBook
            // 
            this.addBook.Controls.Add(this.btnAddBook);
            this.addBook.Controls.Add(this.nrBookLength);
            this.addBook.Controls.Add(this.tbxWriter);
            this.addBook.Controls.Add(this.tbxBookTitle);
            this.addBook.Controls.Add(this.lblBookLength);
            this.addBook.Controls.Add(this.lblWriter);
            this.addBook.Controls.Add(this.lblBookTitle);
            this.addBook.Location = new System.Drawing.Point(4, 24);
            this.addBook.Name = "addBook";
            this.addBook.Padding = new System.Windows.Forms.Padding(3);
            this.addBook.Size = new System.Drawing.Size(237, 218);
            this.addBook.TabIndex = 0;
            this.addBook.Text = "Lägg till bok";
            this.addBook.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(87, 192);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 23);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Lägg till bok";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // nrBookLength
            // 
            this.nrBookLength.Location = new System.Drawing.Point(87, 126);
            this.nrBookLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nrBookLength.Name = "nrBookLength";
            this.nrBookLength.Size = new System.Drawing.Size(120, 23);
            this.nrBookLength.TabIndex = 5;
            // 
            // tbxWriter
            // 
            this.tbxWriter.Location = new System.Drawing.Point(87, 81);
            this.tbxWriter.Name = "tbxWriter";
            this.tbxWriter.Size = new System.Drawing.Size(100, 23);
            this.tbxWriter.TabIndex = 4;
            // 
            // tbxBookTitle
            // 
            this.tbxBookTitle.Location = new System.Drawing.Point(87, 38);
            this.tbxBookTitle.Name = "tbxBookTitle";
            this.tbxBookTitle.Size = new System.Drawing.Size(100, 23);
            this.tbxBookTitle.TabIndex = 3;
            // 
            // lblBookLength
            // 
            this.lblBookLength.AutoSize = true;
            this.lblBookLength.Location = new System.Drawing.Point(23, 126);
            this.lblBookLength.Name = "lblBookLength";
            this.lblBookLength.Size = new System.Drawing.Size(40, 15);
            this.lblBookLength.TabIndex = 2;
            this.lblBookLength.Text = "Längd";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(23, 81);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(58, 15);
            this.lblWriter.TabIndex = 1;
            this.lblWriter.Text = "Författare";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(23, 38);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(29, 15);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Titel";
            // 
            // addFilm
            // 
            this.addFilm.Controls.Add(this.btnAddFilm);
            this.addFilm.Controls.Add(this.nrFilmLength);
            this.addFilm.Controls.Add(this.tbxFilmDirector);
            this.addFilm.Controls.Add(this.tbxFilmTitle);
            this.addFilm.Controls.Add(this.lblFilmLength);
            this.addFilm.Controls.Add(this.lblFilmDirector);
            this.addFilm.Controls.Add(this.lblFilmTitle);
            this.addFilm.Location = new System.Drawing.Point(4, 24);
            this.addFilm.Name = "addFilm";
            this.addFilm.Padding = new System.Windows.Forms.Padding(3);
            this.addFilm.Size = new System.Drawing.Size(237, 218);
            this.addFilm.TabIndex = 1;
            this.addFilm.Text = "Lägg till film";
            this.addFilm.UseVisualStyleBackColor = true;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(87, 192);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(100, 23);
            this.btnAddFilm.TabIndex = 6;
            this.btnAddFilm.Text = "Lägg till film";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // nrFilmLength
            // 
            this.nrFilmLength.Location = new System.Drawing.Point(87, 126);
            this.nrFilmLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nrFilmLength.Name = "nrFilmLength";
            this.nrFilmLength.Size = new System.Drawing.Size(120, 23);
            this.nrFilmLength.TabIndex = 5;
            // 
            // tbxFilmDirector
            // 
            this.tbxFilmDirector.Location = new System.Drawing.Point(87, 81);
            this.tbxFilmDirector.Name = "tbxFilmDirector";
            this.tbxFilmDirector.Size = new System.Drawing.Size(100, 23);
            this.tbxFilmDirector.TabIndex = 4;
            // 
            // tbxFilmTitle
            // 
            this.tbxFilmTitle.Location = new System.Drawing.Point(87, 38);
            this.tbxFilmTitle.Name = "tbxFilmTitle";
            this.tbxFilmTitle.Size = new System.Drawing.Size(100, 23);
            this.tbxFilmTitle.TabIndex = 3;
            // 
            // lblFilmLength
            // 
            this.lblFilmLength.AutoSize = true;
            this.lblFilmLength.Location = new System.Drawing.Point(23, 126);
            this.lblFilmLength.Name = "lblFilmLength";
            this.lblFilmLength.Size = new System.Drawing.Size(40, 15);
            this.lblFilmLength.TabIndex = 2;
            this.lblFilmLength.Text = "Längd";
            // 
            // lblFilmDirector
            // 
            this.lblFilmDirector.AutoSize = true;
            this.lblFilmDirector.Location = new System.Drawing.Point(23, 81);
            this.lblFilmDirector.Name = "lblFilmDirector";
            this.lblFilmDirector.Size = new System.Drawing.Size(46, 15);
            this.lblFilmDirector.TabIndex = 1;
            this.lblFilmDirector.Text = "Regisör";
            // 
            // lblFilmTitle
            // 
            this.lblFilmTitle.AutoSize = true;
            this.lblFilmTitle.Location = new System.Drawing.Point(23, 38);
            this.lblFilmTitle.Name = "lblFilmTitle";
            this.lblFilmTitle.Size = new System.Drawing.Size(29, 15);
            this.lblFilmTitle.TabIndex = 0;
            this.lblFilmTitle.Text = "Titel";
            // 
            // tbxResults
            // 
            this.tbxResults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxResults.Location = new System.Drawing.Point(281, 51);
            this.tbxResults.Multiline = true;
            this.tbxResults.Name = "tbxResults";
            this.tbxResults.ReadOnly = true;
            this.tbxResults.Size = new System.Drawing.Size(225, 222);
            this.tbxResults.TabIndex = 1;
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.rbtnFilms);
            this.gbxFilter.Controls.Add(this.rbtnBooks);
            this.gbxFilter.Controls.Add(this.rbtnAll);
            this.gbxFilter.Location = new System.Drawing.Point(20, 301);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(486, 55);
            this.gbxFilter.TabIndex = 2;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // rbtnFilms
            // 
            this.rbtnFilms.AutoSize = true;
            this.rbtnFilms.Location = new System.Drawing.Point(386, 22);
            this.rbtnFilms.Name = "rbtnFilms";
            this.rbtnFilms.Size = new System.Drawing.Size(58, 19);
            this.rbtnFilms.TabIndex = 2;
            this.rbtnFilms.Text = "Filmer";
            this.rbtnFilms.UseVisualStyleBackColor = true;
            this.rbtnFilms.CheckedChanged += new System.EventHandler(this.rbtnFilms_CheckedChanged);
            // 
            // rbtnBooks
            // 
            this.rbtnBooks.AutoSize = true;
            this.rbtnBooks.Location = new System.Drawing.Point(203, 22);
            this.rbtnBooks.Name = "rbtnBooks";
            this.rbtnBooks.Size = new System.Drawing.Size(61, 19);
            this.rbtnBooks.TabIndex = 1;
            this.rbtnBooks.TabStop = true;
            this.rbtnBooks.Text = "Böcker";
            this.rbtnBooks.UseVisualStyleBackColor = true;
            this.rbtnBooks.CheckedChanged += new System.EventHandler(this.rbtnBooks_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(6, 22);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(45, 19);
            this.rbtnAll.TabIndex = 0;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "Alla";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLastFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openLastFileToolStripMenuItem
            // 
            this.openLastFileToolStripMenuItem.Name = "openLastFileToolStripMenuItem";
            this.openLastFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openLastFileToolStripMenuItem.Text = "Open Last file";
            this.openLastFileToolStripMenuItem.Click += new System.EventHandler(this.openLastFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 382);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.tbxResults);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.addBook.ResumeLayout(false);
            this.addBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrBookLength)).EndInit();
            this.addFilm.ResumeLayout(false);
            this.addFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrFilmLength)).EndInit();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage addBook;
        private Button btnAddBook;
        private NumericUpDown nrBookLength;
        private TextBox tbxWriter;
        private TextBox tbxBookTitle;
        private Label lblBookLength;
        private Label lblWriter;
        private Label lblBookTitle;
        private TabPage addFilm;
        private Button btnAddFilm;
        private NumericUpDown nrFilmLength;
        private TextBox tbxFilmDirector;
        private TextBox tbxFilmTitle;
        private Label lblFilmLength;
        private Label lblFilmDirector;
        private Label lblFilmTitle;
        private TextBox tbxResults;
        private GroupBox gbxFilter;
        private RadioButton rbtnFilms;
        private RadioButton rbtnBooks;
        private RadioButton rbtnAll;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openLastFileToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private FontDialog fontDialog1;
    }
}