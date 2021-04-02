using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimRepository
{
    public class ClaimRepo
    {
        private readonly Queue<Claim> _claimContent = new Queue<Claim>();
        private int _Count = 0;
        public Queue<Claim> ShowAllClaims()
        {
            return _claimContent;

        }

        public Claim ViewNextClaimInQueue()
        {

            return _claimContent.Peek();
        }

        public bool ProcessNextClaim()
        {
            
            if (_claimContent.Count>0)
            {
                _claimContent.Dequeue();
                return true;
            }
            return false;
        }

        
        public bool AddClaimToQueue(Claim newClaim)
        {
            _Count++;
            newClaim.ClaimID = _Count;
            _claimContent.Enqueue(newClaim);
            return true;
        }
    }

}
