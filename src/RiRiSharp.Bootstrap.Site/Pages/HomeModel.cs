using System.ComponentModel.DataAnnotations;

namespace RiRiSharp.Bootstrap.Site.Pages;

public class HomeModel
{
    [Required(ErrorMessage = "Please fill in a {0}", AllowEmptyStrings = false)]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Please fill in a {0}", AllowEmptyStrings = false)]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Please fill in a {0}", AllowEmptyStrings = false)]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "Please fill in a {0}", AllowEmptyStrings = false)]
    public string City { get; set; }
    
    [Required(ErrorMessage = "Please fill in a {0}", AllowEmptyStrings = false)]
    public string State { get; set; }
    
    [Required(ErrorMessage = "Please fill in a {0}", AllowEmptyStrings = false)]
    public string Zip { get; set; }
    
    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting")]
    public bool AgreeTermsAndConditions { get; set; }
}