namespace Logic.Security.Types
{
    public enum ForgotPasswordResult
    {
        Succeeded = 1,
        UserNotFound = 2,
        EmailNotConfirmed = 3,
        UserIsLockedOut = 4
    }
}