
using System.Diagnostics;

namespace HospitalApp
{
    public class PatientInFile : PatientBase
    {
        private const string fileName = "ratings.txt";
        public PatientInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(rating);
                }
            }
            else
            {
                throw new Exception("Błędna wartość oceny");
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
            var ratingsFromFile = this.ReadRatingsFromFile();
            var stats = new Stats();
            foreach (var rating in ratingsFromFile)
            {
                stats.AddRating(rating);
            }
            return stats;
        }
        private List<float> ReadRatingsFromFile()
        {
            var ratings = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        ratings.Add(number);
                        line = reader.ReadLine();
                    }
                }

            }
            return ratings;
        }
        public void RemoveDataFromFile()
        {
            File.WriteAllText(fileName, "");
        }
    }
}


