namespace ornek;
class Program
{
    public class Araba
    {
        public string marka;//data field
        public string model;
        public int modelyl;
        private int fiyat = 0;//burada dışarıda eerişime kapallı o yüzden dışarda erişe bilmek için bunu yaptık


        //kasüleme zaten iki türlü olur ya propertiye yada metotla olur
       public int Fiyat {//puropertis
            get { return fiyat; }//burada süslü parantez kulanmayı unutma 
          set { fiyat = value; }
        }
         /*
        public void fiyatbelirle(int fiyatal) {//kapsüleme yaptı burad
            fiyat = fiyatal;//burda girilen değeri buna eşitledim  getmekle aynı 
        }

        public int  fiyatver() {
            return fiyat;//burdada ekrana yazdırdım set etmekle aynı
        }
         */
    }

  

    static void Main(string[] args)//genel adla aynı yazdığın zaman main metot calışmaz 
    {
          
          List<Araba> arabalar = new List<Araba>();
        bool napsın = true;
        while (napsın)
        {
            Araba arb1 = new Araba();
            Console.WriteLine("Lütfen Marka Girin..");
            arb1.marka = Console.ReadLine();
            Console.WriteLine("Lütfe Model  Girin..");
            arb1.model = Console.ReadLine();
            Console.WriteLine("Lütfen Model Yılını Girin..");//burasını zaten biliyoruz üsteki data field i int girdik kılavyeden girilen değeri int cevirdik            arb1.modelyl = Convert.ToInt32(Console.ReadLine());
            arb1.modelyl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Fiyat  Girin..");
            arb1.Fiyat =Convert.ToInt32(Console.ReadLine()) ;




            arabalar.Add(arb1);

            

            Console.WriteLine("Devam etsinmi etmesin diyosan f bas ");

            string devam = Console.ReadLine();
            if (devam == "f") {
                napsın = false;
                break; 
            }
            
        }
        
        foreach (Araba a in arabalar)//listedeki verileri tek tek cağırmak için
        {
            Console.WriteLine("Araba:" + a.marka +
                              "\nModel:" + a.model +// \n bir alt satıra geçmek için 
                              "\nModel yılı:" + a.modelyl +
                              "\nFiyat:" + a.Fiyat + "\n");
        }

        Console.ReadLine();       
    }
}

