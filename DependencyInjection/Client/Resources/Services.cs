using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Client.Resources
{
    public class SingletonServices
    {
        public int value { get; set; }

    }
    public  class TransientServices
    {
        public int value { get; set; }
    }
}
