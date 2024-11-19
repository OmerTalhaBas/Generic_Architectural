namespace Generic_Mimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic mimari, aynı tasarımdan farklı objelerin üretilmesine imkan sağlayan C# mimarisi için ÇOK önemli bir yapıdır.
            //Generic mimari olmasaydı: Kod yazmak çok zorlaşırdı, tekrar eden kodlar artardı, tip güvenliği çok azalırdı, ileride göreceğimiz Linq yapısı diye bir şey kolay kolay olmazdı.

            //Üretilen TestSinifi nesnesinin GenericField'ının tipi int olmuştur. İlgili field'ın tipinin ne olacağı sınıf yazılırken bildirilmesine(Generic olarak tasarlanması) rağmen nesne örneklenirken T yerine gelecek tip bildirilmiştir.

            Kategori kategori = new Kategori();
            Urun urun = new Urun();
            urun.Create(urun);
            new BaseEntity<Kategori>().CreatedOn = DateTime.Now;
            BaseEntity<Marka> baseEntity = new BaseEntity<Marka>();
            Marka marka = new Marka();
            marka.DeletedOn = DateTime.Now;
            marka.ListExpression
            //Repository<Urun> repository = new Repository<Urun>();
        }
    }
}