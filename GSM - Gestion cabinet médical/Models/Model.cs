using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM___Gestion_cabinet_médical.Models
{
    public class Model
    {

        public static int GenerateTimeBasedId()
        {
            // Get current time (milliseconds since Unix epoch)
            var unixTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            // Use the lower 31 bits to stay within positive int range
            return (int)(unixTime % int.MaxValue);
        }
    }
}
