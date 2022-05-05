using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DISample.Models
{
    public interface IScopedService
    {
        Guid GetOperationId();
    }
}
