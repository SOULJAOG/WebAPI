using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using Newtonsoft.Json;
>>>>>>> lab5
=======
using Newtonsoft.Json;
>>>>>>> lab6

namespace Entities.ErrorModel
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
