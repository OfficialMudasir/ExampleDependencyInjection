using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleDependencyInjection.Models
{
    public class OperationService : ItransientService, IScoppedService, ISingletonService
    {
        Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
