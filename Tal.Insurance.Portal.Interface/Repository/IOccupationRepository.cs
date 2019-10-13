using System;
using System.Collections.Generic;
using System.Text;
using Tal.Insurance.Portal.Modal.Modal;

namespace Tal.Insurance.Portal.Interface.Repository
{
    public interface IOccupationRepository
    {
        List<Occupations> GetAllOccupations();
        Occupations GetOccupationRatingByOccupation(string occupation);
        
    }
}
