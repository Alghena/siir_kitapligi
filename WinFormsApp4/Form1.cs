using WinFormsApp4.S�n�flar;

namespace WinFormsApp4
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

        private void button1_Click(object sender, EventArgs e)
        {
            Siir siir = new Siir();
            BestelenenSiirler bestSiir = new BestelenenSiirler();
            bestSiir.yazar = siirYazartxt.Text;
            bestSiir.siirAdi = siirAditxt.Text;
            bestSiir.satirSayisi = Convert.ToInt16(satirSayisitxt.Text);
            bestSiir.siiriBesteleyenKisi = siiriBesteleyentxt.Text;
            bestSiir.siirinBestelendigiTarih = Convert.ToInt16(bestelendigiTarihtxt.Text);

            listbox.Items.Add($"Yazar : {bestSiir.yazar}");
            listbox.Items.Add($"�iir Ad� : {bestSiir.siirAdi}");
            listbox.Items.Add($"Sat�r Say�s� : {bestSiir.satirSayisi}");
            listbox.Items.Add($"Besteleyen Ki�i : {bestSiir.siiriBesteleyenKisi}");
            listbox.Items.Add($"Bestelendi�i Tarih : {bestSiir.siirinBestelendigiTarih}");
            listbox.Items.Add($"A��klama : {bestSiir.Acikalama()}");
            listbox.Items.Add("-----------------------------------");
        }
    }
}
