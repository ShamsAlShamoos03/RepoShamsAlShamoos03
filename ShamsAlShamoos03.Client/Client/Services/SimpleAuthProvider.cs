using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace ShamsAlShamoos03.Client.Services
{
    public class SimpleAuthProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;

        public SimpleAuthProvider(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task SetLoginAsync(bool loggedIn)
        {
            await _localStorage.SetItemAsync("isLoggedIn", loggedIn);

            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var isLoggedIn =
                await _localStorage.GetItemAsync<bool>("isLoggedIn");

            ClaimsIdentity identity;

            if (isLoggedIn)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, "User")
                }, "FakeAuth");
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);

            return new AuthenticationState(user);
        }

        public async Task LogoutAsync()
        {
            await _localStorage.RemoveItemAsync("isLoggedIn");

            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}