using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_Recipes.Models
{
    public interface IReviewRepository
    {
        IQueryable<Review> Reviews { get; }
        void saveReview(Review review);
        Review deleteReview(int ReviewId);
    }
}
