namespace HospitalApp.Tests
{
    public class PatientInMemoryTest
    {
        public class Tests
        {
            [Test]
            public void ReturnProperMinRating()
            {
                //arrange
                var patient = new PatientInMemory("Mateusz", "Sokół");
                patient.AddRating(1);
                patient.AddRating(25);
                patient.AddRating(18);
                //act
                var result = patient.GetStats();
                //assert
                Assert.AreEqual(1, result.Min);
            }
           
            [Test]
            public void ReturnProperMaxRating()
            {
                //arrange
                var patient = new PatientInMemory("Mateusz", "Zacny");
                patient.AddRating(99);
                patient.AddRating(25);
                patient.AddRating(7);
                //act
                var result = patient.GetStats();
                //assert
                Assert.AreEqual(99, result.Max);
            }
           
            [Test]
            public void ReturnProperAverageRating()
            {
                //arrange
                var patient = new PatientInMemory("Mateusz", "Wapniak");
                patient.AddRating(77);
                patient.AddRating(10);
                patient.AddRating(3);
                //act
                var result = patient.GetStats();
                //assert
                Assert.AreEqual(30, result.Average);
            }
            
            [Test]
            public void ReturnProperColorAlertRating()
            {
                //arrange
                var patient = new PatientInMemory("Mateusz", "Stępniak");
                patient.AddRating(80);
                patient.AddRating(20);
                patient.AddRating(50);
                //act
                var result = patient.GetStats();
                //assert
                Assert.AreEqual("STREFA ŻÓŁTA POMOC PILNA - DO 60 MINUT", result.ColorAlert);
            }
        }
    }

}