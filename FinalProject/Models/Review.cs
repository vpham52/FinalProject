using System;
namespace FinalProject.Models
{
	public class Review
	{
		public Review()
		{
		}

		public int reviewID { get; set; }
		public string propertyAddress { get; set; }
		public int propertyID { get; set; }
		public double rentalPrice { get; set; }
        public string reviewer { get; set; }
        public int propertyRating { get; set; }
        public int landlordRating { get; set; }
        public string comment { get; set; }

    }
}

