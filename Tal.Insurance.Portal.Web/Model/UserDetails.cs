using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tal.Insurance.Portal.Web.Model
{
    public class UserDetails
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age  { get; set; }
        public string occupation   { get; set; }
        public string dateOfBirth    { get; set; }
        public double sumInsured  { get; set; }

    }
}
