namespace HospitalApp.Tests
{
    public class Tests
    {
        [Test]
        public void ReturnProperMinRating()
        {
            //arrange
            var patient = new PatientInFile("Tomasz", "Sokó³");
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
            var patient = new PatientInFile("£ukasz", "Zacny");
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
            var patient = new PatientInFile("Mi³osz", "Wapniak");
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
            var patient = new PatientInFile("Mateusz", "Stêpniak");
            patient.AddRating(80);
            patient.AddRating(20);
            patient.AddRating(50);
            //act
            var result = patient.GetStats();
            //assert
            Assert.AreEqual("STREFA ¯Ó£TA POMOC PILNA - DO 60 MINUT", result.ColorAlert);
        }
    }
}
