using EvidencijaRacunarskeOpreme.Semanticka.SemantickiServisi.SemantickiInterfejsi;
using EvidencijaRacunarskeOpreme.Tehnoloska.Podaci;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace EvidencijaRacunarskeOpreme
{
    public partial class Form1 : Form
    {
        public IRacunarskaOpremaServis _racunarskaOpremaServis { get; set; }
        public IEnumerable<RacunarskaOprema> racunari { get; set; }
        


        //public BindingSource _izvorPovezivanja { get; set; }=new BindingSource();
        public Form1(IRacunarskaOpremaServis racunarskaOpremaServis)
        {
            this._racunarskaOpremaServis = racunarskaOpremaServis;
            InitializeComponent();
            PopuniDataGrid();
            PopuniComboBox();
        }
        public void PopuniComboBox()
        {
            comboBoxFiltriraj.Items.Add("Model");
            comboBoxFiltriraj.Items.Add("Cena");
        }
        //Dugme za dodavanje koje upisuje podatke u bazu a zatim resetuje polja za novi unos
        private void btnDodaj_Klik(object sender, EventArgs e)
        {
            if (txtProizvodjac.Text != "" || txtModel.Text != "" || txtCena.Text != "" || txtZemljaPorekla.Text != "" || dateDatum.Text != "")
            {
                RacunarskaOprema racunar = new RacunarskaOprema
                {
                    ModelKomponente = txtModel.Text,
                    ProizvodjacKomponente = txtProizvodjac.Text,
                    CenaKomponente = Convert.ToInt32(txtCena.Text),
                    ZemljaPorekla = txtZemljaPorekla.Text,
                    DatumProizvodnje = Convert.ToDateTime(dateDatum.Text)
                };
                _racunarskaOpremaServis.DodajRacunarskuKomponentu(racunar);
            }
            else
            {
                MessageBox.Show("Unesite sve podatke");
            }
            //Popunjavanje data grid-a nakon uspesnog dodavanja komponente
            PopuniDataGrid();
            //Resetovanje txt polja za unos drugih komponenti
            ResetujPolja();

        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPodaci.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Selektovali ste vise od jednog reda!");
                }
                else
                {
                    var racunar = PronadjiRacunar();
                    //Leksicka Greska
                    //string 1racunar = PronadjiRacunar();
                    _racunarskaOpremaServis.ObrisiRacunarskuKomponentu(racunar);

                    //Runtime greska prosledjivanje pogresnog naziva servera
                    //string baza = "Server=MY-PC\SQLEXPRESS1;Database=RacunarskaOprema;Trusted_Connection=True;TrustServerCertificate=True";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste selektovali red!");
            }
            PopuniDataGrid();
        }
        //Popunjava data grid na osnovu tabele u bazi
        public async void PopuniDataGrid()
        {
            try
            {
                dataGridPodaci.AutoGenerateColumns = true;

                //Ovo moze da se optimizuje tako sto ce se zvati samo jednom na pocetku
                //na inicijalizaciji same forme a ne svaki put kada se desi neka izmena
                racunari = await _racunarskaOpremaServis.VratiSvuRacunarskuOpremu();
                dataGridPodaci.DataSource = racunari;
                dataGridPodaci.AutoResizeColumns();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Neuspelo popunjavanje data grid-a");
            }
        }
        //Resetovanje tekst polja
        public void ResetujPolja()
        {
            //Sintaksna Greska
            //txtModel.Text=""
            txtModel.Text = "";
            txtCena.Text = "";
            txtProizvodjac.Text = "";
            txtZemljaPorekla.Text = "";
            dateDatum.Text = "";
            


        }
        public void PopuniPolja(RacunarskaOprema racunarZaPopuniti)
        {
            txtBoxID_Komponente.Text = racunarZaPopuniti.IdKomponente.ToString();
            txtModel.Text = racunarZaPopuniti.ModelKomponente;
            txtCena.Text = racunarZaPopuniti.CenaKomponente.ToString();
            txtProizvodjac.Text = racunarZaPopuniti.ProizvodjacKomponente;
            txtZemljaPorekla.Text = racunarZaPopuniti.ZemljaPorekla;
            dateDatum.Text = racunarZaPopuniti.DatumProizvodnje.ToLongDateString();
        }
        public RacunarskaOprema VratiPolja()
        {
            RacunarskaOprema racunarZaVracanje = new RacunarskaOprema()
            {
                IdKomponente = Convert.ToInt32(txtBoxID_Komponente.Text),
                ModelKomponente = txtModel.Text,
                ProizvodjacKomponente = txtProizvodjac.Text,
                CenaKomponente = Convert.ToInt32(txtCena.Text),
                ZemljaPorekla = txtZemljaPorekla.Text,
                DatumProizvodnje = Convert.ToDateTime(dateDatum.Text)
            };
            return racunarZaVracanje;
        }
        public RacunarskaOprema PronadjiRacunar()
        {
            var item = dataGridPodaci.SelectedRows[0].Cells["idKomponente"].Value.ToString();
            RacunarskaOprema racunar = racunari.First<RacunarskaOprema>(opcija => opcija.IdKomponente == Convert.ToInt32(item));
            return racunar;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

            if (dataGridPodaci.SelectedRows.Count != 1)
            {
                MessageBox.Show("Niste selektovali!");
            }
            else
            {
                var racunar = VratiPolja();
                _racunarskaOpremaServis.IzmeniRacunarskuKomponentu(racunar);


            }
            PopuniDataGrid();
        }

        private void dataGrid_PromenaSelekcije(object sender, EventArgs e)
        {
            if (dataGridPodaci.SelectedRows.Count == 0)
            {
                return;
            }
            
            var racunar = PronadjiRacunar();
            PopuniPolja(racunar);
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            /*
            if (txtBoxFilter.Text == "") //Logicka Greska
            {
                if (Convert.ToString(comboBoxFiltriraj.SelectedItem) == "Model")
                {
                    var filter = racunari.Where(filter => filter.ModelKomponente == txtBoxFilter.Text).ToList();
                    racunari = filter;
                    dataGridPodaci.DataSource = racunari;
                }
                else if (Convert.ToString(comboBoxFiltriraj.SelectedItem) == "Cena")
                {
                    var broj = Convert.ToInt32(txtBoxFilter.Text);
                    var filter = racunari.Where(filter => filter.CenaKomponente == broj).ToList();
                    racunari = filter;
                    dataGridPodaci.DataSource = racunari;
                }
                else
                {
                    MessageBox.Show("Niste selektovali filter!");
                }
            }
            */





            if (txtBoxFilter.Text != "") 
            {
                if (Convert.ToString(comboBoxFiltriraj.SelectedItem) == "Model")
                {
                    var filter = racunari.Where(filter => filter.ModelKomponente == txtBoxFilter.Text).ToList();
                    racunari = filter;
                    dataGridPodaci.DataSource = racunari;
                }
                else if (Convert.ToString(comboBoxFiltriraj.SelectedItem) == "Cena")
                {
                    var broj = Convert.ToInt32(txtBoxFilter.Text);
                    var filter = racunari.Where(filter => filter.CenaKomponente == broj).ToList();
                    racunari = filter;
                    dataGridPodaci.DataSource = racunari;
                }
                else
                {
                    MessageBox.Show("Niste selektovali filter!");
                }
            }
            else
            {
                MessageBox.Show("Niste upisali vrednost filtera u polje!");
            }
        }
    }
}
