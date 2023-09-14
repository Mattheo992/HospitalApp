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



void PatientRatingAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}
while (true)
{
    Console.WriteLine("Co chcesz zrobić? ");
    Console.WriteLine("1 Dodaj oceny w pamięci programu oraz wyświetl statystki ");
    Console.WriteLine("2 Dodaj oceny w pliku txt oraz wyświetl statystki ");
    Console.WriteLine("3 Wyjść z programu ");
    var input = Console.ReadLine();
    bool close = false;
    while (!close)
    {
        switch (input)
        {
            case "1":
                AddRatingToMemory();
                break;
            case "2":
                AddRatingToTxtFile();
                break;
            case "3":
                close = true;
                break;
            default:
                Console.WriteLine("Niewłaściwa operacja.");
                close = true;
                break;
        }
        static void AddRatingToMemory()
        {
            Console.WriteLine("Podaj imię pacjenta: ");
            var patientName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko pacjenta: ");
            var patientSurname = Console.ReadLine();
            var patientInMemory = new PatientInMemory(patientName, patientSurname);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Wprowadź wszystkie oceny.\n" + "Aby zakończyć wprowadzanie danych wciśnij \"Q\".");
            Console.WriteLine("---------------------------------------");

            while (true)
            {
                Console.WriteLine("Podaj ocenę: ");
                var input = Console.ReadLine();
                if (input == "q" | input == "Q")
                {
                    break;
                }
                try
                {
                    patientInMemory.AddRating(input);

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception catch: {e.Message}");
                }
            }
            var statsInMemory = patientInMemory.GetStats();

            Console.WriteLine($"Sattystyki policzone dla pacjenta: {patientName} {patientSurname}");
            Console.WriteLine($"Kolor: {statsInMemory.ColorAlert}");
            Console.WriteLine($"Average: {statsInMemory.Average:N2}");
            Console.WriteLine($"Min: {statsInMemory.Min}");
            Console.WriteLine($"Max: {statsInMemory.Max}");
           
        }
        static void AddRatingToTxtFile()
        {
            Console.WriteLine("Podaj imię pacenta: ");
            var patientName = Console.ReadLine();
            Console.WriteLine("Podaj nawisko pacjenta: ");
            var patientSurname = Console.ReadLine();
            var patientInFile = new PatientInFile(patientName, patientSurname);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Wprowadź wszystkie oceny.\n" + "Aby zakończyć wprowadzanie danych wciśnij \"Q\".");
            Console.WriteLine("---------------------------------------");

            while (true)
            {
                Console.WriteLine("Podaj ocenę: ");
                var input = Console.ReadLine();
                if (input == "q" | input == "Q")
                {
                    break;
                }
                try
                {
                    patientInFile.AddRating(input);

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception catch: {e.Message}");
                }
            }

            var statsInFile = patientInFile.GetStats();
            Console.WriteLine($"Sattystyki policzone dla pacjenta: {patientName} {patientSurname}");
            Console.WriteLine($"Kolor: {statsInFile.ColorAlert}");
            Console.WriteLine($"Average: {statsInFile.Average:N2}");
            Console.WriteLine($"Min: {statsInFile.Min}");
            Console.WriteLine($"Max: {statsInFile.Max}");
            Console.WriteLine("---------------------------------------");
          
        }
    }
}

            
           
            
        