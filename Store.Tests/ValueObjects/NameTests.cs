using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Store.Tests
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void ShouldReturnNotificationWhenNameIsNotValid()
        {
            var name = new Name("", "Silva");
            Assert.AreEqual(false, name.Valid);
            Assert.AreEqual(1, name.Notifications.Count);
        }
    }
}