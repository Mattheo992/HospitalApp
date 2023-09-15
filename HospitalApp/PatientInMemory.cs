using System.Diagnostics;

namespace HospitalApp
{
    public class PatientInMemory : PatientBase
    {
        
        private List<float> ratings = new List<float>();
        public PatientInMemory(string name, string surname)
        : base(name, surname)
        {
        }
        public override void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 100)
            {
                this.ratings.Add(rating);
            }
            else
            {
                throw new Exception("Niewłaściwa wartość oceny");
            }

        }
        public override void AddRating(string rating)
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
        public override void AddRating(int rating)
        {
            float result = (float)rating;
            this.AddRating(result);
        }

        public override void AddRating(long rating)
        {
            float result = (float)rating;
            this.AddRating(result);
        }

        public override void AddRating(double rating)
        {
            float result = (float)rating;
            this.AddRating(result);
        }

        public override Stats GetStats()
        {
            var stats = new Stats();
            foreach (var rating in this.ratings)
            {
                stats.AddRating(rating);
            }
            return stats;
        }
    }
}
