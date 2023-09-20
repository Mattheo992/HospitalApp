namespace HospitalApp
{
    public class Stats
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }

        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public string ColorAlert
        {
            get
            {
                switch (this.Average)
                {
                    case var averange when averange >= 80:
                        return "STREFA CZERWONA POMOC NATYCHMIASTOWA!";
                    case var averange when averange >= 60:
                        return "STREFA POMARAŃCZOWA POMOC BARDZO PILNA!";
                    case var averange when averange >= 40:
                        return "STREFA ŻÓŁTA POMOC PILNA - DO 60 MINUT";
                    case var averange when averange >= 20:
                        return "STREFA ZIELONA POMOC ODROCZONA - DO 120 MINUT";
                    default:
                        return "STREFA NIEBIESKA PACJENT WYCZEKUJĄCY - DO 240 MINUT";
                }
            }
        }
        
        public Stats()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
       
        public void AddRating(float rating)
        {
            this.Count++;
            this.Sum += rating;
            this.Min = Math.Min(rating, this.Min);
            this.Max = Math.Max(rating, this.Max);
        }
    }
}