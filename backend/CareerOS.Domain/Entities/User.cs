using CareerOS.Domain.Common;

namespace CareerOS.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public bool IsEmailVerified { get; set; }

    public bool IsActive { get; set; } = true;
}