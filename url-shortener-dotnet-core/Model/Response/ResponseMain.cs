using System;
using System.Collections.Generic;
using System.Text;

namespace url_shortener_dotnet_core.Model.Response
{
    public class ResponseMain
    {
        public int Status { get; set; } = 200;
        public string StatusText { get; set; }
        public dynamic Item { get; set; }
        public decimal ItemCount { get; set; } = 0;
        public decimal SkipCount { get; set; } = 0;
        public DateTime RequestDate { get; set; } = DateTime.Now;
        public DateTime ResponseDate { get; set; } = DateTime.Now;
    }
}
