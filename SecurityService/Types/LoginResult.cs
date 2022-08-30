namespace Logic.Security.Types
{
    public enum LoginResult
    {
        Succeeded = 1,
        InvalidLoginAttempt = 2,
        IsLockedOut = 3,
        EmailNotConfirmed = 4,
    }
}