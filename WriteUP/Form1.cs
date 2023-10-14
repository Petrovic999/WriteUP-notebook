namespace WriteUP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void novaDatotekaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void otvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog meniopcije = new OpenFileDialog();
            meniopcije.Title = "Open";
            meniopcije.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
            if (meniopcije.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(meniopcije.FileName, RichTextBoxStreamType.PlainText);
            this.Text = meniopcije.FileName;
        }

        private void sačuvajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog meniopcije = new SaveFileDialog();
            meniopcije.Title = "Save";
            meniopcije.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
            if (meniopcije.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(meniopcije.FileName, RichTextBoxStreamType.PlainText);
            this.Text = meniopcije.FileName;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void datumIVremeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }
        // ne radi lepo gornja linija koda, ispisuje samo datum a ostatak texta brise!!!

        private void vratiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void ponoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void iseciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void zalepiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void izaberiSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = font.Font;
        }

        private void bojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog font = new ColorDialog();
            if (font.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = font.Color;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string naslov = "Informacije o programu WriteUP";
            string poruka = "Ovo je program namenjen za praktičan unos teksta i hvatanje beleški...\n\nVerzija: 1.0\nAutor: Miloš Petrović \nDatum kreiranja prve verzije: 31. maja 2023.";

            MessageBox.Show(poruka, naslov, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime danasnjiDatum = DateTime.Now;
            MessageBox.Show("Današnji datum je: " + danasnjiDatum.ToShortDateString());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}