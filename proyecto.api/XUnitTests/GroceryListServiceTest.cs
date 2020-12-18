using proyecto.Core.Enums;
using proyecto.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitTests.Fake;

namespace XUnitTests
{
    public class GroceryListServiceTest
    {
        private GroceryListService GetUserServiceTest()
        {
            return new GroceryListService(new FakeIGroceryListRepository(),new FakeGroceryListRepository());
        }

        [Theory]
        [InlineData(1)]
        public void GetAllListsByUser(int id)
        {
            var service = GetUserServiceTest();

            var result = service.GetAllFromUser(id);

            Assert.True(result.ResponseCode == ResponseCode.Success);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAll()
        {
            var service = GetUserServiceTest();

            var result = service.GetAll();

            Assert.True(result.ResponseCode == ResponseCode.Success);
        }
    }
}
