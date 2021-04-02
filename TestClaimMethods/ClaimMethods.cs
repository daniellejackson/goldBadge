using ClaimRepository;
using ClaimRepository.ENUMs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestClaimMethods
{
    [TestClass]
    public class ClaimMethods
    {
        private ClaimRepo _claimRepo = new ClaimRepo();
        [TestMethod]
        public void TestGetAllClaims()
        { 
            Queue<Claim> claim = _claimRepo.ShowAllClaims();
            Assert.IsTrue();
        }
        private Claim _content;
        private ClaimRepo _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimRepo();
            _content = new Claim(ClaimType.Car, "car accident on 465", 400.00,
                DateTime.Parse("2018,04,27"), DateTime.Parse("2018, 04, 12"));
            _repo.AddClaimToQueue(_content);

        }
        [TestMethod]
        public void ViewNextClaimInQueueTest()
        {
            Claim claim = new Claim();
            _claimRepo.AddClaimToQueue(claim);
            Claim claim1 = _claimRepo.ViewNextClaimInQueue();
            Assert.AreEqual(claim, claim1);
        }

        [TestMethod]
        public void AddClaimToQueueTest()
        {
            Claim claim = new Claim();
            //_claimRepo.AddClaimToQueue(claim);
            Assert.IsTrue(_claimRepo.AddClaimToQueue(claim));
        }
    }
}
