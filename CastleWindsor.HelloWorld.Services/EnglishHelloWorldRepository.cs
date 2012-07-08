using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CastleWindsor.HelloWorld.Services
{
    public class EnglishHelloWorldRepository : IHelloWorldRepository
    {
        public string Message
        {
            get { return "Hello World"; }
        }
    }
}
