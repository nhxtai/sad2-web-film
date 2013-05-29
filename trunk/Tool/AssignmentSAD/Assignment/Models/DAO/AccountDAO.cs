using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models.DAO
{
    public class AccountDAO
    {
        /// <summary>
        /// Tạo 1 danh sách toàn bộ account
        /// </summary>
        /// <returns></returns>
        public List<Account> GetListAccount()
        {
            MoviesDataContext movie = new MoviesDataContext();
            return movie.Accounts.ToList();
        }

        /// <summary>
        /// Thêm mới 1 account 
        /// </summary>
        /// <param name="a"></param>
        public void AddNewAccount(Account a)
        {
            MoviesDataContext movie = new MoviesDataContext();
            movie.Accounts.InsertOnSubmit(a);
            movie.SubmitChanges();
        }

        /// <summary>
        /// Deactive account
        /// </summary>
        /// <param name="a"></param>
        public void DeleteAccount(Account a)
        {
            MoviesDataContext movie = new MoviesDataContext();
            var acc = movie.Accounts.SingleOrDefault(account => account.Username.Equals(a.Username));
            acc.IsActive = false;
            movie.SubmitChanges();
        }

    }
}