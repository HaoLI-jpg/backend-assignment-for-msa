namespace backend_assignment.Nunit.test;
using ContosoPizza.Models;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var controller = new ContosoPizza.Controllers.PizzaController();

        var response = controller.Get(1);

        NUnit.Framework.Assert.AreEqual(1, response.Value.Id);
    }
}
