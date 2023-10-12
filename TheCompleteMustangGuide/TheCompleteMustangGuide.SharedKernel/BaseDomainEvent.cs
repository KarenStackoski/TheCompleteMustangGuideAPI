using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompleteMustangGuide.SharedKernel
{
    public abstract class BaseDomainEvent : INotification
    {
        public DateTime DateOcurred { get; protected set; } = DateTime.UtcNow;
    }
}
