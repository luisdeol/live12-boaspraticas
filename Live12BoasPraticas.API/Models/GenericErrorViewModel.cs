using System.Collections.Generic;

namespace Live12BoasPraticas.API.Models
{
    public class GenericErrorViewModel
    {
        public int Code { get; private set; }
        public string Message { get; private set; }
        public IEnumerable<string> Errors { get; private set; }
    }
}
