using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.Sınıflar
{
    internal class BestelenenSiirler : Siir
    {
        public string yazar;
        public string siirAdi;
        public int satirSayisi;
        public string siiriBesteleyenKisi;
        public int siirinBestelendigiTarih;

        public override string Acikalama()
        {
            return "Bu açıklama bestelenmiş şiir sınıfına aittir";
        }
    }
}
