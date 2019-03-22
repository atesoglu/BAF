using BAF.Model.Identity;
using System.Security.Claims;

namespace BAF.Api
{
    public static class BAFControllerBaseExtensions
    {
        public static IIdentityModel ToIdentityModel(this ClaimsPrincipal claimsPrincipal)
        {
            return new IdentityModel
            {
                Identifier = "",
                Name = ""
            };
        }
    }
}