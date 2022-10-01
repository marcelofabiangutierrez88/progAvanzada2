namespace TestConversiones
{
    [TestClass]
    public class TestCaseConversiones
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Test Conversiones ejercicio 3
            String color = "blanco";
            Assert.AreEqual(color, ConversionesEjercicio3.selectColor(color));

            // Test Conversiones ejercicio 4 y 5
            int number = 9;
            String result = ConversionesEjercicio4y5.validateNumber(number);
            Assert.AreEqual(result, "No es mayor que 10");

            // Test Conversiones ejercicio 7
            Assert.IsNotNull(ConversionesEjercicio7.cycleNumber(0));
        }
    }
}