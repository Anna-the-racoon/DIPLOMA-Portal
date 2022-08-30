namespace Logic.Security.Types
{
    public enum RegisterResult
    {
        Succeeded = 1,
        UserIsLockedOut = 2,
        UserExistAndIsEmailConfirmed = 3,
        UserExistAndIsEmailNotConfirmed = 4,
    }
}