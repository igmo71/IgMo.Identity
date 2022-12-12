using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;

namespace IgMo.Identity
{
    public class Configuration
    {
        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
        {
            new ApiScope("WhsWebApi", "Whs Web Api")
        };

        public static IEnumerable<ApiResource> ApiResources => new List<ApiResource>
        {
            new ApiResource("WhsWebApi", "Whs Web Api", new []{ JwtClaimTypes.Name })
            {
                Scopes = {"WhsWebApi"}
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
                ClientName = "Whs Web Api",
                AllowedScopes = {
                    "WhsWebApi",
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile
                },
                AllowedGrantTypes = GrantTypes.Code,
                RequireClientSecret = false,
                RequirePkce = true,
                AllowAccessTokensViaBrowser= true,
                AllowedCorsOrigins = {"http://..."},
                RedirectUris = {"http://.../signin-oidc"},
                PostLogoutRedirectUris = {"http://.../signout-oidc"}
            }
        };
    }
}
