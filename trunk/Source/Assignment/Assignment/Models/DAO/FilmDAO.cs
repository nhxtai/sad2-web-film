using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models.DAO
{
    public class FilmDAO
    {
        /// <summary>
        /// Tạo 1 danh sách tất cả Film hiện có trong database
        /// </summary>
        public List<Film> GetListFilm()
        {
            MoviesDataContext movie = new MoviesDataContext();
            return movie.Films.Where(f => f.IsActive == true).ToList();
        }

        /// <summary>
        /// Tạo 1 danh sách film của category đã chọn
        /// </summary>
        /// <param name="catId"></param>
        /// <returns></returns>
        public List<Film> GetListFilmOfACategory(int catId)
        {
            MoviesDataContext movie = new MoviesDataContext();
            return movie.Films.Where(f => f.CategoryID == catId && f.IsActive == true).ToList();
        }

        /// <summary>
        /// Lấy 10 film có lượt view cao nhất 
        /// </summary>
        /// <returns></returns>
        public List<Film> GetTopFilm(int num)
        {
            MoviesDataContext movie = new MoviesDataContext();

            //sắp xếp theo thứ tự giảm dần dựa trên ViewCount rồi lấy 10 phần tử
            return movie.Films.OrderByDescending(f => f.ViewCount).Take(num).ToList();
        }


        /// <summary>
        /// Get top of newest film
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<Film> GetTopNewestFilm(int num)
        {
            MoviesDataContext movie = new MoviesDataContext();
            return movie.Films.OrderByDescending(f => f.ID).Take(num).ToList();
        }

        /// <summary>
        /// Lấy toàn bộ thông tin của 1 Film trong Database
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public Film GetDetailAFilm(int filmId)
        {
            MoviesDataContext movie = new MoviesDataContext();
            var film = movie.Films.SingleOrDefault(f => f.ID == filmId);
            return film;
        }


        /// <summary>
        /// Increase view count when film was watched
        /// </summary>
        /// <param name="filmId"></param>
        public void IncreaseViewCount(int filmId)
        {
            MoviesDataContext movie = new MoviesDataContext();
            var film = movie.Films.SingleOrDefault(f => f.ID == filmId);
            film.ViewCount += 1;
            movie.SubmitChanges();
        }


        /// <summary>
        /// Get total view count of a film
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public long GetViewCount(int filmId)
        {
            MoviesDataContext movie = new MoviesDataContext();
            var film = movie.Films.SingleOrDefault(f => f.ID == filmId);
            return film.ViewCount ?? 0;
        }
    }
}