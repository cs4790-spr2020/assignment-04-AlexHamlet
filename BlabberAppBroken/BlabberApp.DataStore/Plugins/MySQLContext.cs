using BlabberApp.Domain;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlabberApp.DataStore.Plugins
{
    public class MySQLContext : DataContext
    {
        public ITable<Blab> BlabTable;
        public ITable<User> UserTable;

        public MySQLContext(string connection = "server=142.93.114;database=alexhamlet;user=alexhamlet;password=letmein") : base(connection)
        {
            
        }
    }
}
