using BlabberApp.Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BlabberApp.DataStore.Interfaces
{
    public interface IPlugin
    {
        void Create(IEntity obj);
        IEnumerable ReadAll();
        IEntity ReadByID(Guid ID);
        void Update(IEntity obj);
        void Delete(IEntity obj);
    }
}
