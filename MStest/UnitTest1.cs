using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MStest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var controller = new ContosoPizza.Controllers.PizzaController();

        var response = controller.Get(1);

        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, response.Value.Id);
    }
}
