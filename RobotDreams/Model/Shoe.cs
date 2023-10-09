namespace RobotDreams.API.Model
{
  public class Shoe
    {
       // public string Brand;
       // public String Type;
        public String Material;
        public byte Number;
        public string Color;
        public bool Islace; //bağcık

        private string Brand;
        //"Brand" özelliğinin değerini yalnızca okumak için kullanılacak bir metod:
        public string ReadBrand()
        {
            return Brand;
        }

        //"Brand" özelliğine yalnızca değer atamak için bir metod: 
        public void WriteBrand(string brand)
        {
            Brand = brand;
        }

        private string type;
        //"Tipi" özelliğini encapsulate edilmesi.
        public string Type
        {
            get { return type; } //Okuma Arkasını Temsil Ediyor. 
            set { type = value; } //Yazma Arkasını Temsil Ediyor. value yerine sport yazarsak yazdığımız değer ne olursa 
                                  //olsun bize sport sonucunu döndürecektir.
        }
    }


}
