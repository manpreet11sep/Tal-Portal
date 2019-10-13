using System.Threading.Tasks;
using Tal.Insurance.Portal.Modal.Modal;

namespace Tal.Insurance.Portal.Interface.PremiumService
{
    public interface IPremiumService
    {
        double CalculatePremium(UserDetails userDetails);
    }
}