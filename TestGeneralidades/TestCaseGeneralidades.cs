namespace TestGeneralidades
{
    [TestClass]
    public class TestCaseGeneralidades
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                // Test Generalidades Ejercicio1
                int param1 = 4;
                int param2 = 5;
                int esperado = 9;
                Assert.AreEqual(esperado, GeneralidadesEjercicio1.sumar(param1, param2));

                // Test Generalidades Ejercicio2
                String cadena = "avanzada";
                String cadenaCortada = "avan";
                Assert.AreEqual(cadenaCortada, GeneralidadesEjercicio2.cutString(cadena));

                // Test Generalidades Ejercicio3
                Assert.IsNotNull(GeneralidadesEjercicio3.Now());

            }
        }
    }
}