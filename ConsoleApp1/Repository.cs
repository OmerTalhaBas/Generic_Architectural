using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Mimari
{
    internal class Repository<T> where T : class
    {
        List<T> liste = new List<T>();
        //T: Generic Type
        public virtual void Create(T entity)
        {
            liste.Add(entity);
            //database T Tablosuna kayıt
        }
        public void Update(T entity)
        {
            //database T tablosunda entity guncelle
        }
        public void List(List<T> liste)
        {
            //gelen listeyi ekrana listele
        }
        public void ListExpression()
        {
            //Databaseden istenilen özelliklerde olan T getir ve listele
        }
        public void Find(int id)
        {
            //Databaseden istenilen Id'deki T getir
        }
        public void Delete(T entity)
        {
            //databaseden gelen T sil
        }
    }
}