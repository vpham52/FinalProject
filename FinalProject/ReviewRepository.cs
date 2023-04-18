using System;
using System.Data;
using System.Collections.Generic;
using FinalProject.Models;
using Dapper;

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
    }
}

