using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Models
{
    // Identity Role default degerlere ek deger eklemek icin //
    // Bu sekilde kullanılmak istenilirse programda IdentityRole kullanilmayacak onun yerine AppRole kullanilacak
    public class AppRole : IdentityRole
    {

    }
}