namespace AngularWCore2.Models
{
    public class Personel 
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string TCKN { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public Departman Departman { get; set; }

        public Personel()
        {
            this.Departman = new Departman();
        }
    }
}
