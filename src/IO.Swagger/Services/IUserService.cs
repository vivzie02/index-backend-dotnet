namespace IO.Swagger.Services
{
    /// <summary>
    /// IUserService
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Create a new user with username and password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        void createUser(string username, string password);
    }
}
