using BadgesRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestBadgeRepoMethods
{
    [TestClass]
    public class UnitTest1
    {
        private BadgeRepo _badgeRepo = new BadgeRepo();
        [TestMethod]
        public void TestAddbadgeMethod()
        {
            Badge badge = new Badge();
            Assert.IsTrue(_badgeRepo.AddBadgeToDatabase(badge));
        }
        private Badge _content;
        private BadgeRepo _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new BadgeRepo();
            _content = new Badge(12345, new List<string> { "A7" });
        }

        [TestMethod]
        public void TestGetAllBadges()
        {
            Badge badge = new Badge();

        }
        [TestMethod]
        public void UpdateBadgeTest()
        {

        }
    }
}
