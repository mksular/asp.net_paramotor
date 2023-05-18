using Paramotor.Models.Entities;

namespace Paramotor.Models;
public class IndexViewModel
{
 public IEnumerable<Site>? Sites { get; set; }
 public Site? Site { get; set; }   

 public IEnumerable<Slide>? Slides { get; set; }
 public Slide? Slide { get; set; }  

 public IEnumerable<About>? Abouts { get; set; }
 public About? About { get; set; }    
 
}