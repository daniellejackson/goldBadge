using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesRepository
{
    public class BadgeRepo
    {
        private Dictionary<int, Badge> _badgeDatabase = new Dictionary<int, Badge>();
        //private List<Badge> _listOfbadges = new List<Badge>();
        //--------------type for key, type for value
        //allows you to store something to represent another thing
        //badgeid- key doorname = value

        public bool AddBadgeToDatabase(Badge badge)
        {

            _badgeDatabase.Add(badge.BadgeID, badge);
            return true;
        }

        //public Dictionary<int, List<string> GetBadges()
        //    {

        //      return _badgeDatabase;
        //    }

        public Dictionary<int, Badge> GetAllAbadges()
        {
            return _badgeDatabase;

        }




        //public bool UpdateBadge(int badgeID, string DoorName)
        //{
        //List<string> listOfDoors = _badgeDatabase[badgeID];

        //string doorName = listOfDoors.Count;
        //listOfDoors.Add(DoorName);
        //int listOfDoorName = listOfDoors.Count;

        //return null;

        //}
        public Badge GetBadgeByKey(int badgeID)
        {
            foreach (var badge in _badgeDatabase)
            {
                if (badgeID == badge.Key)

                {
                    return badge.Value;
                }
            }
            return null;
        }
        public bool UpdateBadge(int badgeID, Badge newBadgeData)
        {
            Badge oldBadge = GetBadgeByKey(badgeID);
            if (oldBadge == null)
            {
                return false;
            }
            else
            {
                oldBadge.Doors = newBadgeData.Doors;
                //foreach (var item in newBadgeData.Doors)
                //{
                //    oldBadge.Doors.Add(item);
                //}

                //example
                //List<List<string>> Test = new List<List<string>>();
                //Test.Add(newBadgeData.Doors);
                //oldBadge.Doors.Add(newBadgeData.Doors.ToString());
                return true;
            }
        }



        public bool DeleteDoor(int badgeID, string doors)
        {
            //foreach (var door in _badgeDatabase)
            if (_badgeDatabase.ContainsKey(badgeID))
            {

                var badge = _badgeDatabase.Single(b => b.Key == badgeID);
                // List<string>
                foreach (var doorNames in badge.Value.Doors)
                {
                    if (doors == doorNames)
                    {
                        badge.Value.Doors.Remove(doors);
                        return true;

                    }

                    return false;


                }

            }
            return false;

            // if (badgeID==door.Key)


            //return false;


        }



    }


}










