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