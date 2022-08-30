namespace Logic.Security.Types
{
    public enum ResetPasswordResult
    {
        Succeeded = 1,
        UserNotFound = 2,
        InvalidResetAttempt = 3,
        EmailNotConfirmed = 4,
        UserIsLockedOut = 5
    }
}