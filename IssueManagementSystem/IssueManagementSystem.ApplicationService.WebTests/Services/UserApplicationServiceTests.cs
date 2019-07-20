using Microsoft.VisualStudio.TestTools.UnitTesting;
using IssueManagementSystem.ApplicationService.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueManagementSystem.ApplicationService.WebTests.TestModules.TestDomains.TestDomainService;
using IssueManagementSystem.ApplicationService.WebTests.TestModules.TestInfrastructure.TestPersistences.TestRepositories;

namespace IssueManagementSystem.ApplicationService.Web.Services.Tests
{
    [TestClass()]
    public class UserApplicationServiceTests
    {
        private IUserApplicationService UserApplicationService = new UserApplicationService(new TestUserManager(), new TestUserRepository());

        [TestMethod()]
        public void SearchTest()
        {
            Assert.Fail();
        }
    }
}