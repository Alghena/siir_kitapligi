using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.Sınıflar
{
    public class Siir
    {
        public string yazar;
        public string siirAdi;
        public int satirSayisi;

        public virtual string Acikalama()
        {
            return "Bu açıklama şiir sınıfına aittir";
        }
    }
}
