namespace Libraryx.Core.AccountContext.Models;

public class UserModel : Model
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
}