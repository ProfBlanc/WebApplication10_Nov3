using Microsoft.AspNetCore.Mvc;
using WebApplication10_Nov3.Controllers;

namespace WebTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHomeControllerIndexPage()
        {
            //Arrange aka setup the object w/ values
            HomeController controller = new HomeController(null);

            //Act aka use a method of above object
            ViewResult result = controller.Index() as ViewResult;

            //Assert 
            Assert.IsNotNull(result);


        }
    }
}
