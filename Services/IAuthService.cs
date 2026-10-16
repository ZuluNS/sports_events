using sports_events.Models;

namespace sports_events.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto userDto);

        Task<string?> LoginAsync(UserDto userDto);

    }
}
