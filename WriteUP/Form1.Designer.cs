namespace WriteUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            datotekaToolStripMenuItem = new ToolStripMenuItem();
            novaDatotekaToolStripMenuItem = new ToolStripMenuItem();
            otvoriToolStripMenuItem = new ToolStripMenuItem();
            sačuvajToolStripMenuItem = new ToolStripMenuItem();
            izlazToolStripMenuItem = new ToolStripMenuItem();
            kalendarToolStripMenuItem = new ToolStripMenuItem();
            izmeniToolStripMenuItem = new ToolStripMenuItem();
            datumIVremeToolStripMenuItem = new ToolStripMenuItem();
            vratiToolStripMenuItem = new ToolStripMenuItem();
            ponoviToolStripMenuItem = new ToolStripMenuItem();
            iseciToolStripMenuItem = new ToolStripMenuItem();
            kopirajToolStripMenuItem = new ToolStripMenuItem();
            zalepiToolStripMenuItem = new ToolStripMenuItem();
            izaberiSveToolStripMenuItem = new ToolStripMenuItem();
            formatiranjeToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            bojaToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.PaleGoldenrod;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 422);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.BurlyWood;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { datotekaToolStripMenuItem, izmeniToolStripMenuItem, formatiranjeToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            datotekaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaDatotekaToolStripMenuItem, otvoriToolStripMenuItem, sačuvajToolStripMenuItem, izlazToolStripMenuItem, kalendarToolStripMenuItem });
            datotekaToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            datotekaToolStripMenuItem.Size = new Size(82, 24);
            datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // novaDatotekaToolStripMenuItem
            // 
            novaDatotekaToolStripMenuItem.BackColor = Color.BurlyWood;
            novaDatotekaToolStripMenuItem.Name = "novaDatotekaToolStripMenuItem";
            novaDatotekaToolStripMenuItem.Size = new Size(184, 24);
            novaDatotekaToolStripMenuItem.Text = "Nova Datoteka";
            novaDatotekaToolStripMenuItem.Click += novaDatotekaToolStripMenuItem_Click;
            // 
            // otvoriToolStripMenuItem
            // 
            otvoriToolStripMenuItem.BackColor = Color.BurlyWood;
            otvoriToolStripMenuItem.Name = "otvoriToolStripMenuItem";
            otvoriToolStripMenuItem.Size = new Size(184, 24);
            otvoriToolStripMenuItem.Text = "Otvori";
            otvoriToolStripMenuItem.Click += otvoriToolStripMenuItem_Click;
            // 
            // sačuvajToolStripMenuItem
            // 
            sačuvajToolStripMenuItem.BackColor = Color.BurlyWood;
            sačuvajToolStripMenuItem.Name = "sačuvajToolStripMenuItem";
            sačuvajToolStripMenuItem.Size = new Size(184, 24);
            sačuvajToolStripMenuItem.Text = "Sačuvaj";
            sačuvajToolStripMenuItem.Click += sačuvajToolStripMenuItem_Click;
            // 
            // izlazToolStripMenuItem
            // 
            izlazToolStripMenuItem.BackColor = Color.BurlyWood;
            izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            izlazToolStripMenuItem.Size = new Size(184, 24);
            izlazToolStripMenuItem.Text = "Izlaz";
            izlazToolStripMenuItem.Click += izlazToolStripMenuItem_Click;
            // 
            // kalendarToolStripMenuItem
            // 
            kalendarToolStripMenuItem.BackColor = Color.BurlyWood;
            kalendarToolStripMenuItem.Name = "kalendarToolStripMenuItem";
            kalendarToolStripMenuItem.Size = new Size(184, 24);
            kalendarToolStripMenuItem.Text = "Danasnji Datum";
            kalendarToolStripMenuItem.Click += kalendarToolStripMenuItem_Click;
            // 
            // izmeniToolStripMenuItem
            // 
            izmeniToolStripMenuItem.BackColor = Color.BurlyWood;
            izmeniToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { datumIVremeToolStripMenuItem, vratiToolStripMenuItem, ponoviToolStripMenuItem, iseciToolStripMenuItem, kopirajToolStripMenuItem, zalepiToolStripMenuItem, izaberiSveToolStripMenuItem });
            izmeniToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            izmeniToolStripMenuItem.Size = new Size(65, 24);
            izmeniToolStripMenuItem.Text = "Izmeni";
            // 
            // datumIVremeToolStripMenuItem
            // 
            datumIVremeToolStripMenuItem.BackColor = Color.BurlyWood;
            datumIVremeToolStripMenuItem.Name = "datumIVremeToolStripMenuItem";
            datumIVremeToolStripMenuItem.Size = new Size(177, 24);
            datumIVremeToolStripMenuItem.Text = "Datum i Vreme";
            datumIVremeToolStripMenuItem.Click += datumIVremeToolStripMenuItem_Click;
            // 
            // vratiToolStripMenuItem
            // 
            vratiToolStripMenuItem.BackColor = Color.BurlyWood;
            vratiToolStripMenuItem.Name = "vratiToolStripMenuItem";
            vratiToolStripMenuItem.Size = new Size(177, 24);
            vratiToolStripMenuItem.Text = "Vrati";
            vratiToolStripMenuItem.Click += vratiToolStripMenuItem_Click;
            // 
            // ponoviToolStripMenuItem
            // 
            ponoviToolStripMenuItem.BackColor = Color.BurlyWood;
            ponoviToolStripMenuItem.Name = "ponoviToolStripMenuItem";
            ponoviToolStripMenuItem.Size = new Size(177, 24);
            ponoviToolStripMenuItem.Text = "Ponovi";
            ponoviToolStripMenuItem.Click += ponoviToolStripMenuItem_Click;
            // 
            // iseciToolStripMenuItem
            // 
            iseciToolStripMenuItem.BackColor = Color.BurlyWood;
            iseciToolStripMenuItem.Name = "iseciToolStripMenuItem";
            iseciToolStripMenuItem.Size = new Size(177, 24);
            iseciToolStripMenuItem.Text = "Iseci";
            iseciToolStripMenuItem.Click += iseciToolStripMenuItem_Click;
            // 
            // kopirajToolStripMenuItem
            // 
            kopirajToolStripMenuItem.BackColor = Color.BurlyWood;
            kopirajToolStripMenuItem.Name = "kopirajToolStripMenuItem";
            kopirajToolStripMenuItem.Size = new Size(177, 24);
            kopirajToolStripMenuItem.Text = "Kopiraj";
            kopirajToolStripMenuItem.Click += kopirajToolStripMenuItem_Click;
            // 
            // zalepiToolStripMenuItem
            // 
            zalepiToolStripMenuItem.BackColor = Color.BurlyWood;
            zalepiToolStripMenuItem.Name = "zalepiToolStripMenuItem";
            zalepiToolStripMenuItem.Size = new Size(177, 24);
            zalepiToolStripMenuItem.Text = "Zalepi";
            zalepiToolStripMenuItem.Click += zalepiToolStripMenuItem_Click;
            // 
            // izaberiSveToolStripMenuItem
            // 
            izaberiSveToolStripMenuItem.BackColor = Color.BurlyWood;
            izaberiSveToolStripMenuItem.Name = "izaberiSveToolStripMenuItem";
            izaberiSveToolStripMenuItem.Size = new Size(177, 24);
            izaberiSveToolStripMenuItem.Text = "Izaberi Sve";
            izaberiSveToolStripMenuItem.Click += izaberiSveToolStripMenuItem_Click;
            // 
            // formatiranjeToolStripMenuItem
            // 
            formatiranjeToolStripMenuItem.BackColor = Color.BurlyWood;
            formatiranjeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, bojaToolStripMenuItem });
            formatiranjeToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            formatiranjeToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            formatiranjeToolStripMenuItem.Name = "formatiranjeToolStripMenuItem";
            formatiranjeToolStripMenuItem.Size = new Size(105, 24);
            formatiranjeToolStripMenuItem.Text = "Formatiranje";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.BackColor = Color.BurlyWood;
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(108, 24);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // bojaToolStripMenuItem
            // 
            bojaToolStripMenuItem.BackColor = Color.BurlyWood;
            bojaToolStripMenuItem.Name = "bojaToolStripMenuItem";
            bojaToolStripMenuItem.Size = new Size(108, 24);
            bojaToolStripMenuItem.Text = "Boja";
            bojaToolStripMenuItem.Click += bojaToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            infoToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(47, 24);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "WriteUP";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem datotekaToolStripMenuItem;
        private ToolStripMenuItem novaDatotekaToolStripMenuItem;
        private ToolStripMenuItem otvoriToolStripMenuItem;
        private ToolStripMenuItem sačuvajToolStripMenuItem;
        private ToolStripMenuItem izlazToolStripMenuItem;
        private ToolStripMenuItem izmeniToolStripMenuItem;
        private ToolStripMenuItem datumIVremeToolStripMenuItem;
        private ToolStripMenuItem vratiToolStripMenuItem;
        private ToolStripMenuItem ponoviToolStripMenuItem;
        private ToolStripMenuItem iseciToolStripMenuItem;
        private ToolStripMenuItem kopirajToolStripMenuItem;
        private ToolStripMenuItem zalepiToolStripMenuItem;
        private ToolStripMenuItem izaberiSveToolStripMenuItem;
        private ToolStripMenuItem formatiranjeToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem bojaToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem kalendarToolStripMenuItem;
    }
}