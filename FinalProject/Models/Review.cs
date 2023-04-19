using System;
namespace FinalProject.Models
{
	public class Review
	{
		public Review()
		{

		}

		public int ReviewID { get; set; }
		public string PropAddy { get; set; }	
		public double RentalPrice { get; set; }
        public string Reviewer { get; set; }
        public int PropRating { get; set; }
        public int LandlordRating { get; set; }
        public string Comment { get; set; }

    }
}

