using System;
using ATMapp.Domain.Entities.Interfaces;
using ATMapp.UI;

namespace ATMapp.Domain.Entities
{
	public class UserAccount : IUserLogin
	{
		public int Id { get; set; }
		public long CardNumber { get; set; }
		public int CardPin { get; set; }
		public long AccountNumber { get; set; }
		public string FullName { get; set; }
		public decimal AccountBalance { get; set; }
		public int TotalLogin { get; set; }
		public bool IsLocked { get; set; }
        public List<UserAccount> Users { get; set; }

        public void InitializeData()
		{

			Users = new List<UserAccount>();
			{
				new UserAccount { Id = 0, FullName = "Cecilia Silva", AccountNumber = 15012005, CardNumber = 123456, CardPin = 54321, AccountBalance = 5000.0m, IsLocked = false };
                new UserAccount { Id = 1, FullName = "Tania Silva", AccountNumber = 24012000, CardNumber = 121213, CardPin = 98765, AccountBalance = 10000.0m, IsLocked = false };
                new UserAccount { Id = 2, FullName = "Letitia Garner", AccountNumber = 12042003, CardNumber = 131289, CardPin = 13899, AccountBalance = 1000.0m, IsLocked = true };
            }
        }

        public void CheckUserCardNumberAndPassword()
        {
            var validator = new Validator();

            bool isCorrectLogin = false;

			UserAccount tempUserAccount = new UserAccount();

			tempUserAccount.CardNumber = validator.Convert<long>("Your card number.")
			tempUserAccount.CardPin = ?
        }
    }
}

