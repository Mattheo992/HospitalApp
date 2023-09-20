namespace HospitalApp
{
    public interface IPatient
    {
        string Name { get; }
  
        string Surname { get; }
        
        void AddRating(float rating);
        
        void AddRating(string rating);
        
        void AddRating(int rating);
        
        void AddRating(long rating);
        
        void AddRating(double rating);
      
        Stats GetStats();
    }
}