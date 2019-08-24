using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross2020TrabalhoFinalBasico.Models
{
    public class UpcomingResponse
    {
        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }
    }
}
