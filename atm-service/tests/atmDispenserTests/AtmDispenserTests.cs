using atm_service.atm_dispenser;

namespace tests.atmDispenserTests
{
    public class AtmDispenserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void getAmountDenomination_WhenAmountToDispenseIs850_ShouldReturnOneDinominationsOfEach()
        {
            // Arrange & Act
            var result = AtmDispenser.getAmountDenomination(850);

            // Assert
            Assert.That(result, Is.EqualTo(new List<string> { "Dispensing 1 INR500 Note",
            "Dispensing 1 INR200 Note",
            "Dispensing 1 INR100 Note",
            "Dispensing 1 INR50 Note" }));
        }

        [Test]
        public void getAmountDenomination_WhenAmountToDispenseIs860_ShouldReturnErrorMessage()
        {
            // Arrange & Act
            var result = AtmDispenser.getAmountDenomination(860);

            // Assert
            Assert.That(result, Is.EqualTo(new List<string> { "Error: Cannot Dispense ammount INR860." }));
        }
    }
}

