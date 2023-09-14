using HospitalApp;

Console.WriteLine("Witaj w programie do oceny stanu zdrowia pacjenta Szpitalnego Oddziału Ratunkowego");
Console.WriteLine("=================================================================================_>");
Console.WriteLine("Proszę o podanie oceny w skali od 1 do 100 w następujących kategoriach:");
Console.WriteLine("Ocena 1 bardzo dobry stan pacjenta, ocena 100 to bardzo zły stan pacjenta");
Console.WriteLine("1. stopień nasilenia bólu");
Console.WriteLine("2. wzrokowa ocena pacjenta");
Console.WriteLine("3. Ocena świadomości");
Console.WriteLine("4. ocena parametrów życiowych");
Console.WriteLine("W celu przejścia do wyniku oceny proszę wcisnąć klawisz p");
Console.WriteLine();

var patient = new PatientInMemory("Mateusz", "Stępniak");
patient.RatingAdded += PatientRatingAdded;

void PatientRatingAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}
while (true)
{
    Console.WriteLine("Podaj kolejną ocenę stanu zdrowia pacjenta: ");
    var input = Console.ReadLine();
    if (input == "p")
    {
        break;
    }

    try
    {
        patient.AddRating(input);
    }

    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var stats = patient.GetStats();
Console.WriteLine($"Kolor strefy segregacji pacjenta: {stats.ColorAlert}");
Console.WriteLine($"Średnia ocena pacjenta: {stats.Average}");
Console.WriteLine($"Minimalna ocena pacjenta: {stats.Min}");
Console.WriteLine($"Maksymalna ocena pacjenta: {stats.Max}");