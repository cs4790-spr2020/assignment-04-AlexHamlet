using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class InMemorySpecimen: ISpecimen{
        private string guid;

        public InMemorySpecimen(string globalid){
            guid = globalid;
        }
        
        public string getsysid(){
            return guid;
        }

    }
}