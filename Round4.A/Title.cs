using System;

namespace Round4.A
{
    public class Title
    {
        private static object _titleName;
        private static object _donorMembershipId;

        private Title()
        {
        }

        public static object[] Title()
        {
            return new[] { _titleName, _donorMembershipId, 1 };
        }
    }
}