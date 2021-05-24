using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace LeshBrain.Models
{
    public class UserEntity : IdentityUser<int>
    {
        public override bool EmailConfirmed { get; set; } = true;
        public override bool PhoneNumberConfirmed { get; set; } = true;

        public string ImageUrl { get; set; } = "/Content/UsersImage/spanch.jpg";

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronym { get; set; }
        public double Raiting { get; set; } = 0;

        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserClaimsPrincipalFactory<UserEntity> _claimsPrincipalFactory)
        //{
        //    // Add custom user claims here
        //    ClaimsPrincipal claimsPrincipal = await _claimsPrincipalFactory.CreateAsync(this);
        //    ((ClaimsIdentity)claimsPrincipal.Identity).AddClaim(new Claim("ImageUrl", this.ImageUrl.ToString()));
        //    ClaimsIdentity claims = new ClaimsIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
        //    return this;
        //}
    }
}
