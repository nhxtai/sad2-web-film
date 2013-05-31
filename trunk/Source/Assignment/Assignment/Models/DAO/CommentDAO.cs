using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models.DAO
{
    public class CommentDAO
    {
        /// <summary>
        /// Lấy toàn bộ comment của 1 phim
        /// </summary>
        /// <param name="filmId"></param>
        /// <returns></returns>
        public List<Comment> GetAllCommentOfAFilm(int filmId)
        {
            MoviesDataContext movie = new MoviesDataContext();
            var list = movie.Comments.Where(c => c.FilmID == filmId && c.IsActive == true).ToList();
            return list;
        }

        /// <summary>
        /// Thêm mới 1 comment vào database
        /// </summary>
        /// <param name="c"></param>
        public void AddNewComment(Comment c)
        {
            MoviesDataContext movie = new MoviesDataContext();
            movie.Comments.InsertOnSubmit(c);
            movie.SubmitChanges();
        }


        /// <summary>
        /// Add new comment
        /// </summary>
        /// <param name="username"></param>
        /// <param name="content"></param>
        /// <param name="filmId"></param>
        public long AddNewComment(string username, string content, long filmId)
        {
            try
            {
                MoviesDataContext movie = new MoviesDataContext();
                Comment comment = new Comment();
                comment.Username = username;
                comment.Content = content;
                comment.FilmID = filmId;
                comment.DateTime = DateTime.Now;
                comment.IsActive = true;
                movie.Comments.InsertOnSubmit(comment);
                movie.SubmitChanges();
                return comment.ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return -1;
        }

        /// <summary>
        /// Deactive comment đã chọn
        /// </summary>
        /// <param name="c"></param>
        public void DeleteComment(Comment c)
        {
            MoviesDataContext movie = new MoviesDataContext();
            var comm = movie.Comments.SingleOrDefault(co => co.ID == c.ID);
            comm.IsActive = false;
            movie.SubmitChanges();
        }
    }
}