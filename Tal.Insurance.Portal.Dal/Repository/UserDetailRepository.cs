using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tal.Insurance.Portal.Interface.Repository;
using Tal.Insurance.Portal.Modal.Modal;

namespace Tal.Insurance.Portal.Repository.Repository
{
    public class UserDetailRepository : IUserDetailRepository
    {
        public List<UserDetails> GetAllUsers()
        {
            var lst = new List<UserDetails>
                {
                new UserDetails()
                    {
                    FirstName = "UserFirst1",
                    LastName  = "UserLast1",
                    Age = 32,
                    Occupation = "Cleaner",
                    DateOfBirth = Convert.ToDateTime("22/01/1988"),
                    SumInsured = 10000
                   },
                new UserDetails()
                    {
                    FirstName = "UserFirst2",
                    LastName  = "UserLast2",
                    Age = 33,
                    Occupation = "Doctor",
                    DateOfBirth = Convert.ToDateTime("22/01/1987"),
                    SumInsured = 20000
                   },
                new UserDetails()
                    {
                    FirstName = "UserFirst3",
                    LastName  = "UserLast3",
                    Age = 34,
                    Occupation = "Author",
                    DateOfBirth = Convert.ToDateTime("22/01/1986"),
                    SumInsured = 30000
                   },
                new UserDetails()
                    {
                    FirstName = "UserFirst4",
                    LastName  = "UserLast4",
                    Age = 35,
                    Occupation = "Farmer",
                    DateOfBirth = Convert.ToDateTime("22/01/1985"),
                    SumInsured = 40000
                   },
                 new UserDetails()
                    {
                    FirstName = "UserFirst5",
                    LastName  = "UserLast5",
                    Age = 36,
                    Occupation = "Mechanic",
                    DateOfBirth = Convert.ToDateTime("22/01/1985"),
                    SumInsured = 50000
                   },
                  new UserDetails()
                    {
                    FirstName = "UserFirst6",
                    LastName  = "UserLast6",
                    Age = 37,
                    Occupation = "Florist",
                    DateOfBirth = Convert.ToDateTime("22/01/1984"),
                    SumInsured = 150000
                   }
            };
            return lst;
        }
    }
}