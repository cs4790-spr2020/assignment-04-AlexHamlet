using System;
using System.Collections.Generic;
using System.Text;

namespace BlabberApp.Domain.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}
