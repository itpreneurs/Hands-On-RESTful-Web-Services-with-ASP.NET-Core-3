using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SampleAPI.Requests
{
    public class OrderRequest
    {
        [Required]
        public IList<string> ItemsIds { get; set; }
        [Required]
        [StringLength(3)]
        public string Currency { get; set; }
    }
}