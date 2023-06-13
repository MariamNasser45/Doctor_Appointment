using Microsoft.AspNetCore.Identity;

namespace Doctor_Appointment.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FName { get; set; }

        public string LName { get; set; }

    }
}
