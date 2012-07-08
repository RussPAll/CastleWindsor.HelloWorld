using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CastleWindsor.HelloWorld.Services
{
    public interface IHelloWorldRepository
    {
        string Message { get; }
    }
}
