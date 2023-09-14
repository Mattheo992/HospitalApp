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
                throw new Exception("Invalid grade value");
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

        public void PrintStats()
        {
            if (ratings.Count == 0)
            {
                Console.WriteLine("Pacjent nie posiada oceny");
                Console.ReadKey();
                return;
            }
            var stats =GetStats();
            Console.WriteLine($"Kolor strefy segregacji pacjenta: {stats.ColorAlert}");
            Console.WriteLine($"Średnia ocena pacjenta: {stats.Average}");
            Console.WriteLine($"Minimalna ocena pacjenta: {stats.Min}");
            Console.WriteLine($"Maksymalna ocena pacjenta: {stats.Max}");
        }
        public void PrintDriver()
        {
            Console.WriteLine($"Obecny pacjent to : {Name}, {Surname}");
        }
    }
}
