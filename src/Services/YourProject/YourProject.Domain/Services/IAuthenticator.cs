using YourProject.Domain.Entities;

namespace YourProject.Domain.Services;

public interface IAuthenticator
{
    bool Authenticate(User user);
}