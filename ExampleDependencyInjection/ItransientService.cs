using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleDependencyInjection
{
    public interface ItransientService
    {
        Guid GetOperationID();
    }
}
