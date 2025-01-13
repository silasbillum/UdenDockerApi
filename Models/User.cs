using System.ComponentModel.DataAnnotations;
namespace UdenDockerApi.Models
{
    public class User : Common
    {
  
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
