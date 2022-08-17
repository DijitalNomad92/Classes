namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ogrenci ogrenci = new ogrenci();
            //ogrenci.id = 5;
            //ogrenci.adi = "Çağıl";
            //ogrenci.soyadi = "Alsaç";
            //ogrenci.adi = "Eyüp"; // değişkeni yenileyebiliriz
            //Console.WriteLine(ogrenci.id);  ogrenciyi new'leyerek class'ta tanımladıgımız verilere değişken içinde ulaşabiliriz

            //Student student; //declaration
            //student = new Student();// initiliation  aşağıda aynı işi tek satirda yapıyor

            Student student = new Student();
            student.SetId(17);
            student.SetName("Çagıl");
            student.SureName = "Alsaç";

            Console.WriteLine(student.GetId() + " - " + student.GetName() + " - " + student.SureName);
        }
    }

    class ogrenci  // public kullanmak yanlış, herkese açık bi veri oldugundan
    {
        //public int id;
        //public string adi;
        //public string soyadi;  // field (alan)
    }


    class Student  // doğru kullanımı
    {
        int _id;
        string _name;

        public string SureName { get; set; }  // prop tab tab ile özelliği çagırıyoruz  property
        public void SetId(int id)
        {
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
    }
}