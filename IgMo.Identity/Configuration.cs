using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;

namespace IgMo.Identity
{
    public class Configuration
    {
        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
        {
            new ApiScope("IgMoWebApi", "Web API")
        };

        public static IEnumerable<ApiResource> ApiResources => new List<ApiResource>
        {
            new ApiResource("IgMoWebApi", "Web API", new []{ JwtClaimTypes.Name })
            {
                Scopes = {"IgMoWebApi"}
            }
        };

        public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };

        public static IEnumerable<Client> Clients => new List<Client>
        {
            new Client
            {
                ClientId = "whs-web-api",
                ClientName = "Whs Web",
                AllowedGrantTypes = GrantTypes.Code,
                RequireClientSecret = false,
                RequirePkce = true,
                AllowAccessTokensViaBrowser= true,
                AllowedCorsOrigins = {"http://..."},
                RedirectUris = {"http://.../signin-oidc"},
                PostLogoutRedirectUris = {"http://.../signout-oidc"},
                AllowedScopes = {
                    "IgMoWebApi",
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile
                }
            }
        };
    }
}
