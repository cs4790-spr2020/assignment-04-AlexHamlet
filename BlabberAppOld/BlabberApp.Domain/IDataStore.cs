using System;
using System.Collections.Generic;
using System.Text;

namespace BlabberApp.Domain
{
    public interface IDataStore
    {
        bool Create(IDatum datum);
        IDatum Read(ISpecimen spec);
        bool Update(IDatum datum);
        IDatum Delete(ISpecimen spec);
    }
}
