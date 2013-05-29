using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models.DAO
{
    public class CategoryDAO
    {
        /// <summary>
        /// tạo danh sách tất cả thể loại phim
        /// </summary>
        public List<Category> GetAllCategory()
        {
            MoviesDataContext movie = new MoviesDataContext();
            return movie.Categories.Where(c => c.IsActive == true).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category GetACategory(int id)
        {
            MoviesDataContext movie = new MoviesDataContext();
            return movie.Categories.SingleOrDefault(c => c.ID == id);
        }
    }
}