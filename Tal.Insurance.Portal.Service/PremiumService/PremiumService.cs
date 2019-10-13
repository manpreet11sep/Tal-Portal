using System;
using System.Threading.Tasks;
using Tal.Insurance.Portal.Interface.PremiumService;
using Tal.Insurance.Portal.Interface.Repository;
using Tal.Insurance.Portal.Modal.Modal;

namespace Tal.Insurance.Portal.Service.PremiumService
{
    public class PremiumService : IPremiumService
    {
        private readonly IUserDetailRepository _userDetailRepository;
        private readonly IOccupationRepository _occupationRepository;
        private readonly IOccupationRatingRepository _occupationRatingRepository; 

        public PremiumService(IUserDetailRepository userDetailRepository,
                                IOccupationRepository occupationRepository,
                                IOccupationRatingRepository occupationRatingRepository)
        {
            _userDetailRepository = userDetailRepository;
            _occupationRepository = occupationRepository;
            _occupationRatingRepository = occupationRatingRepository;

        }
        public double CalculatePremium(UserDetails userDetails)
        {
            double premium = (userDetails.SumInsured * GetOccupationFactor(userDetails.Occupation) * userDetails.Age) / 1000 * 12;

            return premium;
        }

        private double GetOccupationFactor(string occupation)
        {
            return _occupationRatingRepository.GetFactorByOccupationRating(_occupationRepository.GetOccupationRatingByOccupation(occupation).Rating).Factor;
        }
    };
}