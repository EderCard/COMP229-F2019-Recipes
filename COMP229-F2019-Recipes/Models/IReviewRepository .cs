using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_Recipes.Models
{
    public interface IReviewRepository
    {
        IQueryable<Review> Reviews { get; }
        void SaveReview(Review review);
        void DeleteReview(int recipeId);
    }
}
