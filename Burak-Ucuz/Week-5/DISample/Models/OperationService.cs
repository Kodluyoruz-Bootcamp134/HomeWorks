using System;

namespace DISample.Models
{
    public class OperationService : IScopedService, ITransientService, ISingletonService
    {
        Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationId()
        {
            return id;
        }
    }
}
