using System.Linq;

namespace CA_TA_Pars2012
{
    class Versenyzo
    {
        public string Nev { get; set; }
        public char Csoport { get; set; }
        private string NemzetEsKod { get; set; }
        public float[]  Dobasok { get; set; }
        public float Eredmeny
        {
            get
            {
                float e = this.Dobasok.Max();
                return e >= 0 ? e : -1F;
            }
        }
        public string Nemzet => this.NemzetEsKod.Substring(0, this.NemzetEsKod.Length - 6);
        public string Kod => this.NemzetEsKod.Split(' ').Last().Trim('(', ')');
        public string Sorozat { get; set; }

        public Versenyzo(string sor)
        {
            var buffer = sor.Split(';');
            this.Nev = buffer[0];
            this.Csoport = char.Parse(buffer[1]);
            this.NemzetEsKod = buffer[2];
            this.Sorozat = $"{buffer[3]};{buffer[4]};{buffer[5]}";
            this.Dobasok = new float[3];

            for (int i = 3; i < buffer.Length; i++)
            {
                if (buffer[i] == "X")
                    this.Dobasok[i - 3] = -1F;
                else if (buffer[i] == "-")
                    this.Dobasok[i - 3] = -2F;
                else
                    this.Dobasok[i - 3] = float.Parse(buffer[i]);
            }
        }
    }
}
