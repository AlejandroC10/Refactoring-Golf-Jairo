using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round4.A
{
    public class Title
    {
        private static object[] Title(string titleName, string donorMembershipId)
        {
            var objects = new Object[] { titleName, donorMembershipId, 1 };
            return objects;
        }
    }

    public class Library
    {

        private readonly Dictionary<String, Object[]> _titles = new Dictionary<string, object[]>();

        public Dictionary<String, Object[]> GetTitles()
        {
            return _titles;
        }

        public void Donate(String titleName, String donorMembershipId)
        {
            var objects = A.Title.Title(titleName, donorMembershipId);
            _titles.Add(titleName, objects);
        }

        public List<Object[]> GetTitlesDonatedByMember(String donorMembershipId)
        {
            Dictionary<string, object[]>.ValueCollection allTitles = _titles.Values;
            List<object[]> memberTitles = new List<object[]>();
            foreach (Object[] title in allTitles)
            {
                if (title[1].Equals(donorMembershipId))
                {
                    memberTitles.Add(title);
                }
            }
            return memberTitles;
        }

    }
}
