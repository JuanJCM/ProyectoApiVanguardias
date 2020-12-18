using proyecto.Core.Entities;
using proyecto.Core.Enums;
using proyecto.Core.IRepositories;
using proyecto.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTests.Fake;

namespace XUnitTests
{
    public class UserServiceTest
    {
        private UserService GetUserServiceTest()
        {
            return new UserService(new FakeIUserRepository(), new FakeUserRepository());
        }

        [Fact]
        public void GetAllUsers()
        {
            var service = GetUserServiceTest();

            var result = service.GetAll();

            Assert.True(result.ResponseCode == ResponseCode.Success);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(1)]
        public void GetUserById(int id)
        {
            var service = GetUserServiceTest();

            var result = service.GetById(id);

            Assert.True(result.ResponseCode == ResponseCode.Success);
            Assert.True(result.Result.Id == id);
        }
    }
}
