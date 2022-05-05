using System;

namespace DISample.Models
{
    public interface ITransientService
    {
        Guid GetOperationId();
    }
}
