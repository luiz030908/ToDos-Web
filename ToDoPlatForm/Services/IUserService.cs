namespace ToDoPlatForm.Services;

public interface IUserService
{
    Task<SignResult> Login(LoginVM login);
    Task Logout();
}