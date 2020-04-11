using BlabberApp.DataStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BlabberApp.Domain;

namespace BlabberApp.DataStore.Adapters
{
    class UserAdapter
    {
        private IPlugin plugin;

        public UserAdapter(IPlugin plugin)
        {
            this.plugin = plugin;
        }

        public void Add(User user)
        {
            this.plugin.Create(user);
        }

        public void Remove(User user)
        {
            this.plugin.Delete(user);
        }

        public void Update(User user)
        {
            this.plugin.Update(user);
        }

        public IEnumerable GetAll()
        {
            return this.plugin.ReadAll();
        }

        public User GetById(Guid Id)
        {
            return (User)this.plugin.ReadByID(Id);
        }
    }
}
