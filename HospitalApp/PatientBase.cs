

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
        public abstract void AddRating (float rating);
        public abstract void AddRating(string rating);
        public abstract void AddRating(int rating);
        public abstract void AddRating(long rating);
        public abstract void AddRating(double rating);
        public abstract Stats GetStats ();
    }
}
