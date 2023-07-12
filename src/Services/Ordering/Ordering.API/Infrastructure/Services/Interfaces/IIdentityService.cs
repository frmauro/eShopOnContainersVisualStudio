namespace Ordering.API.Infrastructure.Services.Interfaces;

public interface IIdentityService
{
    string GetUserIdentity();

    string GetUserName();
}