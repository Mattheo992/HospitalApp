namespace HospitalApp
{
    public abstract class PatientBase : IPatient
    {
        public delegate void RatingAddedDelegate(object sender, EventArgs args);

        public PatientBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddRating(float rating);

        public void AddRating(string rating)
           {
                if (float.TryParse(rating, out float result))
                {
                    this.AddRating(result);
                }
                else
                {
                    throw new Exception("To nie jest wartość liczbowa");
                }
            }
        
        public void AddRating(int rating)
        {
            float result = (float)rating;
            this.AddRating(result);
        }
        
        public void AddRating(long rating)
        { 
        float result = (float)rating;
            this.AddRating(result);
        }
        
        public void AddRating(double rating)
        {
            float result = (float)rating;
            this.AddRating(result);
        }
        
        public abstract Stats GetStats();
    }
}