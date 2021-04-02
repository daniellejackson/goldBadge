using ClaimRepository;
using ClaimRepository.ENUMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard
{
    class Program
    {
        static void Main(string[] args)
        {
            Claim claim = new Claim(ClaimType.Home, "...", 3000, new DateTime(2021,4,8),  DateTime.Now); 
        }
    }
}
