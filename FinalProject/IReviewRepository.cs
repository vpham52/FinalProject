using System;
using System.Collections.Generic;
using FinalProject.Models;

namespace FinalProject
{
	public interface IReviewRepository
	{
		public IEnumerable<Review> GetAllReviews();
        public Review GetSingleReview(int ReviewID);
        public IEnumerable<Review> SearchReviews(string searchString);

    }
}

