namespace Main.BLL.Core.Enums
{
    public enum ReturnCode
    {
        None = 0,

        // Success
        Success = 200,
        Accepted = 202,

        // Client errors
        BadRequest = 400,
        NoAccess = 403,
        NotFound = 404,
        Conflict = 409,

        // Server errors
        InternalServerError = 500,
    }
}