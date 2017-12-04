using FPC.Workshop2.WebApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FPC.Workshop2.UnitTest
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void About_Should_Set_Message()
        {
            // Arrange / Given
            var controller = new HomeController();

            // Act / When
            var output = controller.About();

            // Asset / Then
            Assert.IsTrue(controller.ViewData["Message"].ToString() == "Your application description page.", "ViewData set incorrectly");
        }
    }
}
