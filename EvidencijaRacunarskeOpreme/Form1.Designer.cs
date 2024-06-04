namespace EvidencijaRacunarskeOpreme
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
            dateDatum = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProizvodjac = new TextBox();
            txtModel = new TextBox();
            txtCena = new TextBox();
            txtZemljaPorekla = new TextBox();
            dataGridPodaci = new DataGridView();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            txtBoxID_Komponente = new TextBox();
            comboBoxFiltriraj = new ComboBox();
            btnFilter = new Button();
            txtBoxFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridPodaci).BeginInit();
            SuspendLayout();
            // 
            // dateDatum
            // 
            dateDatum.Location = new Point(194, 191);
            dateDatum.Margin = new Padding(3, 4, 3, 4);
            dateDatum.Name = "dateDatum";
            dateDatum.Size = new Size(244, 27);
            dateDatum.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 49);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 1;
            label1.Text = "Proizvodjac Komponente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 100);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 2;
            label2.Text = "Model Komponente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 148);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 3;
            label3.Text = "Cena Komponente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 199);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 4;
            label4.Text = "Datum Proizvodnje:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 245);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 5;
            label5.Text = "Zemlja Porekla:";
            // 
            // txtProizvodjac
            // 
            txtProizvodjac.Location = new Point(194, 45);
            txtProizvodjac.Margin = new Padding(3, 4, 3, 4);
            txtProizvodjac.Name = "txtProizvodjac";
            txtProizvodjac.Size = new Size(114, 27);
            txtProizvodjac.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(194, 96);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(114, 27);
            txtModel.TabIndex = 7;
            // 
            // txtCena
            // 
            txtCena.Location = new Point(194, 144);
            txtCena.Margin = new Padding(3, 4, 3, 4);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(114, 27);
            txtCena.TabIndex = 8;
            // 
            // txtZemljaPorekla
            // 
            txtZemljaPorekla.Location = new Point(194, 241);
            txtZemljaPorekla.Margin = new Padding(3, 4, 3, 4);
            txtZemljaPorekla.Name = "txtZemljaPorekla";
            txtZemljaPorekla.Size = new Size(114, 27);
            txtZemljaPorekla.TabIndex = 9;
            // 
            // dataGridPodaci
            // 
            dataGridPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPodaci.Location = new Point(455, 3);
            dataGridPodaci.Margin = new Padding(3, 4, 3, 4);
            dataGridPodaci.Name = "dataGridPodaci";
            dataGridPodaci.RowTemplate.Height = 25;
            dataGridPodaci.Size = new Size(849, 599);
            dataGridPodaci.TabIndex = 10;
            dataGridPodaci.SelectionChanged += dataGrid_PromenaSelekcije;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(18, 343);
            btnDodaj.Margin = new Padding(3, 4, 3, 4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(102, 35);
            btnDodaj.TabIndex = 11;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Klik;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(150, 343);
            btnIzmeni.Margin = new Padding(3, 4, 3, 4);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(102, 35);
            btnIzmeni.TabIndex = 12;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(285, 343);
            btnObrisi.Margin = new Padding(3, 4, 3, 4);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(102, 35);
            btnObrisi.TabIndex = 13;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // txtBoxID_Komponente
            // 
            txtBoxID_Komponente.Location = new Point(19, 304);
            txtBoxID_Komponente.Margin = new Padding(3, 4, 3, 4);
            txtBoxID_Komponente.Name = "txtBoxID_Komponente";
            txtBoxID_Komponente.Size = new Size(100, 27);
            txtBoxID_Komponente.TabIndex = 14;
            txtBoxID_Komponente.Visible = false;
            // 
            // comboBoxFiltriraj
            // 
            comboBoxFiltriraj.FormattingEnabled = true;
            comboBoxFiltriraj.Location = new Point(46, 462);
            comboBoxFiltriraj.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiltriraj.Name = "comboBoxFiltriraj";
            comboBoxFiltriraj.Size = new Size(138, 28);
            comboBoxFiltriraj.TabIndex = 15;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(166, 520);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(86, 27);
            btnFilter.TabIndex = 16;
            btnFilter.Text = "Filtriraj";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFiltriraj_Click;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(46, 520);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(100, 27);
            txtBoxFilter.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 617);
            Controls.Add(txtBoxFilter);
            Controls.Add(btnFilter);
            Controls.Add(comboBoxFiltriraj);
            Controls.Add(txtBoxID_Komponente);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(dataGridPodaci);
            Controls.Add(txtZemljaPorekla);
            Controls.Add(txtCena);
            Controls.Add(txtModel);
            Controls.Add(txtProizvodjac);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateDatum);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Evidencija Racunarske Opreme";
            ((System.ComponentModel.ISupportInitialize)dataGridPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateDatum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProizvodjac;
        private TextBox txtModel;
        private TextBox txtCena;
        private TextBox txtZemljaPorekla;
        private DataGridView dataGridPodaci;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private TextBox txtBoxID_Komponente;
        private ComboBox comboBoxFiltriraj;
        private Button btnFilter;
        private TextBox txtBoxFilter;
    }
}
