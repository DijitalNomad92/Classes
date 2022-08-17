namespace ClassesEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri()
            {
                Adi = "Çağıl",
                SoyAdi = "Alsaç",
                ErkekMi = true,
                kartNo = "1234 4321 5678 8765"
            };

            Console.WriteLine("Adı Soyadı: " + musteri.tamAdi + "\nCinsiyeti: "
                + musteri.Cinsiyet + "\n"
                + "Kart No: " + musteri.kartNo);
        }
    }

    class Musteri
    {

        public string Adi { get; set; }


        public string SoyAdi { get; set; }

        string _kartNo;
        public string kartNo
        {
            get
            {
                string yeniKartNo = "**** **** **** " + _kartNo.Substring(15);
                return yeniKartNo;
            }
            set
            {
                _kartNo = value;
            }
        }
        public bool ErkekMi { get; set; }
        public string Cinsiyet
        {
            get
            {
                return ErkekMi ? "Erkek" : "Kadın";
            }
        }

        //public string TamAdi => Adi + " " + SoyAdi;  // bu yontem daha kolay sadece get işlemi yapmak istiyorsan

        public string tamAdi
        {
            get
            {
                return Adi + " " + SoyAdi;
            }
        }
    }

}