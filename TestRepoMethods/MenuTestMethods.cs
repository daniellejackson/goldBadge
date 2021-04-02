using MenuRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestRepoMethods
{
    [TestClass]
    public class MenuTestMethods
    {
        private MenuRepo _menuRepo = new MenuRepo();
        [TestMethod]
        public void TestAddmenuContent()
        {
            Menu menu = new Menu();
           // _menurepo.AddMenuContent(menu);
            Assert.IsTrue(_menuRepo.AddMenuContent(menu));
        }

        private Menu _content;
        private MenuRepo _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepo();
            _content = new Menu("Spaghetti Squash", "vegan spaghetti", 10, "pasta, sauce, vegatables");
            _repo.AddMenuContent(_content);
        }

        [TestMethod]
        public void TestShowMenuItems()
        {
            Menu menu = new Menu();
            List<Menu> _menuContent = new List<Menu>();
            //Assert.AreEqual()


        }
        [TestMethod]
        public void DeleteMenuContent()
        {
            List<Menu> _menuContent = new List<Menu>();
            _menuRepo.DeleteMenuContent(1);
            Assert.IsTrue(_menuContent.Count == 0);
        }
    }
}
