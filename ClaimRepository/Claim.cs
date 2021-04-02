
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimRepository
{ 
    public class Claim
    {
        public enum ClaimType
        {
            Home = 1,
            Theft,
            Car
        }
        public int ClaimID { get; set; }
        public ClaimType ClaimsType { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime DateOfLoss { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
                if((DateOfClaim - DateOfLoss).TotalDays <=30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        } //

        public Claim()
        {
        }

        public Claim( ClaimType claimsType, string description,
            double amount, DateTime dateOfLoss, DateTime dateOfClaim)
        {
           
            ClaimsType = claimsType;
            Description = description;
            Amount = amount;
            DateOfLoss = dateOfLoss;
            DateOfClaim = dateOfClaim;
            
        }
    }
}
