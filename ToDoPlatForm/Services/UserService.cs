namespace ToDoPlatForm.Services;

public class UserService : IUserService
{
    
    public UserService(
        SignManager<AppUser> signManager,
        UserManager<AppUser> userManager,
        ILogger<UserService> logger
    )
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _logger = logger;
    }

}