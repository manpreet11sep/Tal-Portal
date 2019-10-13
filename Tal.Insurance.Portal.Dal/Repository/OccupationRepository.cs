using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tal.Insurance.Portal.Interface.Repository;
using Tal.Insurance.Portal.Modal.Modal;

namespace Tal.Insurance.Portal.Repository.Repository
{
    class OccupationRepository : IOccupationRepository
    {
        public List<Occupations> GetAllOccupations()
        {
            var lst = new List<Occupations>
                {
                new Occupations()
                    {
                    Name = "Cleaner",
                    Rating = "Light Manual"
                   },
                new Occupations()
                    {
                        Name = "Doctor",
                        Rating = "Professional"
                    },
                 new Occupations()
                    {
                    Name = "Author",
                    Rating = "White Collar"
                   },
                new Occupations()
                    {
                        Name = "Farmer",
                        Rating = "Heavy Manual"
                    },
                 new Occupations()
                    {
                        Name = "Mechanic",
                        Rating = "Heavy Manual"
                    },
                  new Occupations()
                    {
                        Name = "Florist",
                        Rating = "Light Manual"
                    }
            };

            return lst;
        }

        public Occupations GetOccupationRatingByOccupation(string rating)
        {
            return GetAllOccupations().FirstOrDefault(x => x.Rating == rating);
        }
    }
}
