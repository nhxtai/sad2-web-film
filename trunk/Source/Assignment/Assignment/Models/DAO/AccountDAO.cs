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
        public bool AddNewAccount(Account a)
        {
            MoviesDataContext movie = new MoviesDataContext();
            try
            {
                a.Role = "user";
                a.JoinedDate = DateTime.Now;
                a.IsActive = true;
                movie.Accounts.InsertOnSubmit(a);
                movie.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
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


        /// <summary>
        /// Check login info return role of user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string CheckLogin(string username, string password)
        {
            MoviesDataContext movie = new MoviesDataContext();
            var acc = movie.Accounts.SingleOrDefault(account => account.Username.Equals(username));

            if (acc != null && acc.Password.ToLower().Equals(password.ToLower()))
            {
                return acc.Role;
            }
            else
            {
                return "";
            }
        }
    }
}