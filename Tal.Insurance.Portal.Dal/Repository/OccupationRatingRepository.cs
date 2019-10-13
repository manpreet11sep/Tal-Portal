using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tal.Insurance.Portal.Interface.Repository;
using Tal.Insurance.Portal.Modal.Modal;

namespace Tal.Insurance.Portal.Repository.Repository
{
    class OccupationRatingRepository : IOccupationRatingRepository
    {  

        public List<OccupationRatings> GetAllOccupationRatings()
        {
            var lst = new List<OccupationRatings>
                {
                new OccupationRatings()
                    {
                        Factor = 1.0,
                        Rating = "Professional"
                   },new OccupationRatings()
                    {
                        Factor = 1.25,
                        Rating = "White Collar"
                   },new OccupationRatings()
                    {
                        Factor = 1.50,
                        Rating = "Light Manual"
                   },new OccupationRatings()
                    {
                        Factor = 1.75,
                        Rating = "Heavy Manual"
                   }
            };

            return lst;
        }

        public OccupationRatings GetFactorByOccupationRating(string rating)
        {
            return GetAllOccupationRatings().FirstOrDefault(x => x.Rating == rating);
        }

    
    }
}
