namespace PREFINALS_AUTH_Santurdio_Allen_Jerome.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        public string Course { get; set; }
    }
}
