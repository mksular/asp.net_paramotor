using System.ComponentModel.DataAnnotations;
using Paramotor.Models.Entities;

namespace Paramotor.Models;
public class IndexViewModel
{

    [Required(ErrorMessage = "Lütfen Boş Geçmeyiniz!")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Lütfen Boş Geçmeyiniz!")]
    public string? Password { get; set; }
    public IEnumerable<Site>? Sites { get; set; }
    public Site? Site { get; set; }

    public IEnumerable<User>? Users { get; set; }
    public User? User { get; set; }
    public IEnumerable<Slide>? Slides { get; set; }
    public IEnumerable<About>? Abouts { get; set; }
    public About? About { get; set; }
    public IEnumerable<Team>? Teams { get; set; }


}