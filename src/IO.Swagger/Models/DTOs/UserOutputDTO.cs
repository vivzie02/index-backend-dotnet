namespace IO.Swagger.Models.DTOs
{
    /// <summary>
    /// UserOutputDTO
    /// </summary>
    public class UserOutputDTO
    {
        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public UserOutputDTO(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
