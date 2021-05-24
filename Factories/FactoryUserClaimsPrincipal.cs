using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeshBrain.Models;
using System.Security.Claims;
using Microsoft.Extensions.Options;

namespace LeshBrain.Factories
{
    public class FactoryUserClaimsPrincipal: UserClaimsPrincipalFactory<UserEntity>
    {
        UserManager<UserEntity> _userManager;
        public FactoryUserClaimsPrincipal(UserManager<UserEntity> userManager,
        IOptions<IdentityOptions> optionsAccessor)
        : base(userManager, optionsAccessor)
        {
            _userManager = userManager;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(UserEntity user)
        {
            var listRoles = await _userManager.GetRolesAsync(user);
            var claimRoles = new List<Claim>();
            foreach (var role in listRoles) claimRoles.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType,role));
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaims(claimRoles);
            identity.AddClaim(new Claim("ImageURL", user.ImageUrl));
            return identity;
        }
    }
}
