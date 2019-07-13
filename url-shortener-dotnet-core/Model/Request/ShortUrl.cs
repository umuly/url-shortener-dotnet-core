using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace url_shortener_dotnet_core.Model.Request
{
    public class ShortUrl
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string DomainId { get; set; }
        [Required]
        public string RedirectUrl { get; set; }
        public string Code { get; set; }
    }
}
