using System;
using System.Collections.Generic;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class InMemoryDataStore : IDataStore
    {
        private List<IDatum> memory;

        public InMemoryDataStore(){
            memory = new List<IDatum>();
        }
        
        public bool Create(IDatum datum){
            try
            {
                memory.Add(datum);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IDatum Read(ISpecimen spec){
            IDatum value = null;
            foreach(var val in memory)
            {
                if (val.getsysid().Equals(spec.getsysid()))
                {
                    return val;
                }
            }
            return value;
        }

        public bool Update(IDatum datum){
            for (int p = 0; p < memory.Count ;p++)
            {
                if (memory.IndexOf(datum) >= 0)
                {
                    memory[memory.IndexOf(datum)] = datum;
                    return true;
                }
            }
            return false;
        }

        public IDatum Delete(ISpecimen spec){
            IDatum retval = null;
            foreach(var val in memory)
            {
                if (val.getsysid().Equals(spec.getsysid()))
                {
                    retval = memory[memory.IndexOf(val)];
                    memory.RemoveAt(memory.IndexOf(val));
                    return retval;
                }
            }
            return retval;
        }
    }
}
