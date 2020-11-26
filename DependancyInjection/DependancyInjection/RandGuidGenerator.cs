using System;

namespace DependancyInjection.DependancyInjection
{
    public class RandGuidGenerator
    {
        public Guid RandomGuid { get; set; } = Guid.NewGuid();
    }
}