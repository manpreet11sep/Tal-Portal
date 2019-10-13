using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tal.Insurance.Portal.Modal.Modal;

namespace Tal.Insurance.Portal.Interface.Repository
{
    public interface IUserDetailRepository
    {
        List<UserDetails> GetAllUsers();
    }
}
