using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Review
    {

        private int reviewId;
        private int stars;
        private string reviewDescription;
        private DateTime dateOfReview;

        public int ReviewId
        {
            get { return reviewId; }
            set { reviewId = value; }

        }

        public int Stars
        { get { return stars; } 
          set {  stars = value; } 
        }

        public string ReviewDescription
        { 
        get { return reviewDescription; }
        set { reviewDescription = value; } 
        }

        public DateTime DateOfReview
        { 
        get { return dateOfReview; }
        set { dateOfReview = value; } 
        }

        public Review(int reviewId, int stars, string reviewDescription, DateTime dateOfReview)
        {
            ReviewId = reviewId;
            Stars = stars;
            ReviewDescription = reviewDescription;
            DateOfReview = dateOfReview;
        }
    }
}
