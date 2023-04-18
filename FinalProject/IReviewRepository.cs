using System;
using System.Collections.Generic;
using FinalProject.Models;

namespace FinalProject
{
	public interface IReviewRepository
	{
		public IEnumerable<Review> GetAllReviews();
	}
}

