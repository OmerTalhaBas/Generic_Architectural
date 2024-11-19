using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Mimari
{
    internal class Marka : BaseEntity<Marka>
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public void create(Marka marka)
        {
            //marka kayıt
        }
        public void Update(Marka marka)
        {
            //güncelleme
        }

        public void List(List<Marka> markalar)
        {
            //Gelen Listeyi ekrana listele
        }
        public void ListEcpression()
        {
            //databaseden istenilen özelliklere göre markayı getir ve listele
        }
        public void Find(int ind)
        {
            //db den istenilen İd ye göre  markayı getir
        }
        public void Delete(Marka marka)
        {
            //db de kategoriyi silme
        }
    }
}