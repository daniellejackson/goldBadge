using ClaimRepository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoClaims
{
    public class ProgramUI
    {
        
        private readonly ClaimRepo _claimRepo = new ClaimRepo();

        public void Run()
        {
            Seed();
            RunApp();
        }

        private void RunApp()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Claim Menu\n" +
                    "1. See All Claims\n" +
                    "2. Process Next Claim\n" +
                    "3. Enter a new claim\n");

                string AnalystInput = Console.ReadLine();
                switch (AnalystInput)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        ProcessNextClaim();
                        break;
                    case "3":
                        EnterANewClaim();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
        private void SeeAllClaims()
        {
            Queue<Claim> claimsinqueue = _claimRepo.ShowAllClaims();
            foreach (Claim inqueue in claimsinqueue)
            {
                Console.WriteLine($"ClaimID:{inqueue.ClaimID}\n" +
                    $"Type:{inqueue.ClaimsType}\n" +
                    $"Desc:{inqueue.Description}\n" +
                    $"Amount:{inqueue.Amount}\n" +
                    $"Loss:{inqueue.DateOfLoss}\n" +
                    $"Claim Date:{inqueue.DateOfClaim}\n");

            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void ProcessNextClaim()
        {
            Claim claimsinqueue = _claimRepo.ViewNextClaimInQueue();
            Console.WriteLine($"ClaimID:{claimsinqueue.ClaimID}\n" +
                    $"Type:{claimsinqueue.ClaimsType}\n" +
                    $"Desc:{claimsinqueue.Description}\n" +
                    $"Amount:{claimsinqueue.Amount}\n" +
                    $"Loss:{claimsinqueue.DateOfLoss}\n" +
                    $"Claim{claimsinqueue.DateOfClaim}\n");

            Console.WriteLine("Would you like to process the next claim? yes or no");
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "yes")
            {

                Console.WriteLine("Claim Processed");

            }
            else
            {
                Console.WriteLine("Put back in queue");
            }
            Console.ReadKey();

        }

        private void EnterANewClaim()
        {
            Console.WriteLine("Add new claim");
            Claim item = new Claim();

            Console.WriteLine("Enter Claim Type\n" +
                    "1.Car\n" +
                    "2. Home\n" +
                    "3.Theft");
            string AnalystInput = Console.ReadLine();
            switch (AnalystInput)
            {
                case "1":
                    item.ClaimsType = ClaimType.Car;
                    break;
                case "2":
                    item.ClaimsType = ClaimType.Home;
                    break;
                case "3":
                    item.ClaimsType = ClaimType.Theft;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Enter Description");
            string AnalystInputDescr = Console.ReadLine();
            item.Description = AnalystInputDescr;

            Console.WriteLine("Enter Amount");
            double AnalystInputAmount = double.Parse(Console.ReadLine());
            item.Amount = AnalystInputAmount;

            Console.WriteLine("Enter Date Of Loss");
            DateTime AnalystInputLoss = DateTime.Parse(Console.ReadLine());
            item.DateOfLoss = AnalystInputLoss;

            Console.WriteLine("Enter Claim Date");
            DateTime AnalystInputCD = DateTime.Parse(Console.ReadLine());
            item.DateOfClaim = AnalystInputCD;


            bool isSuccessful = _claimRepo.AddClaimToQueue(item);
            if (isSuccessful == true)
            {
                Console.WriteLine("New claim created");
            }
            else
            {
                Console.WriteLine("New claim failed");
            }


            Console.ReadKey();
        }


        private void Seed()
        {
            Claim Claim1 = new Claim(ClaimType.Car, "car accident on 465", 400.00, DateTime.Parse("2018,04,27"), DateTime.Parse("2018, 04, 12"));
            Claim Claim2 = new Claim(ClaimType.Home, "house fire in kitchen", 4000.00, DateTime.Parse("2018,04,11"), DateTime.Parse("2018,04,12"));
            Claim Claim3 = new Claim(ClaimType.Theft, "Stolen airpods", 250.00, DateTime.Parse("2018,04,27"), DateTime.Parse("2018, 06,01"));

            _claimRepo.AddClaimToQueue(Claim1);
            _claimRepo.AddClaimToQueue(Claim2);
            _claimRepo.AddClaimToQueue(Claim3);



        }
    }
}
