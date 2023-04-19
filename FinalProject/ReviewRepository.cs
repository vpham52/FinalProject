using System;
using System.Data;
using System.Collections.Generic;
using FinalProject.Models;
using Dapper;
using System.Linq;

namespace FinalProject
{
	public class ReviewRepository : IReviewRepository
	{
        private readonly IDbConnection _conn;

        public ReviewRepository(IDbConnection conn)
		{
            _conn = conn;
		}    

        public IEnumerable<Review> GetAllReviews()
        {
            return _conn.Query<Review>("SELECT * FROM REVIEW;");
        }      

        public Review GetSingleReview(int reviewID)
        {
            return _conn.QuerySingle<Review>("SELECT * FROM REVIEW WHERE RevieWID = @reviewID;",
                new { ReviewID = reviewID });
        }

        public IEnumerable<Review> SearchReviews(string searchString)
        {
            return _conn.Query<Review>("SELECT * FROM REVIEW WHERE PROPADDY LIKE @propaddy;",
                new { propaddy = "%" + searchString + "%" });
        }
    }
}

