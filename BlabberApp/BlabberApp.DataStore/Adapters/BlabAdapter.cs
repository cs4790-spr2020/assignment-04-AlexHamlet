using System;
using System.Collections;
using BlabberApp.DataStore.Interfaces;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DataStore.Adapters
{
    public class BlabAdapter
    {
        //Plugin for the adapter.  The plugin is what does the work.
       private IBlabPlugin Plugin;

       public BlabAdapter(IBlabPlugin plugin)
       {
           this.Plugin = plugin;
       }

       public void Add(Blab blab)
       {
           this.Plugin.Create(blab);
       }

       public void Remove(Blab blab)
       {
           this.Plugin.Delete(blab);
       }

       public void Update(Blab blab)
       {
           this.Plugin.Update(blab);
       }

       public IEnumerable GetAll()
       {
           return this.Plugin.ReadAll();
       }

       public Blab GetById(Guid Id)
       {
           return (Blab)this.Plugin.ReadById(Id);
       }
       public IEnumerable GetByUserId(string Id)
       {
           return this.Plugin.ReadByUserId(Id);
       }
    }
}