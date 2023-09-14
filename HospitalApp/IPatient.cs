

using System.Net.NetworkInformation;
using static HospitalApp.PatientBase;

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
        event RatingAddedDelegate RatingAdded;
        Stats GetStats();

    }
}
