
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.DAL;
using NorthwindSystem.Data;
#endregion

namespace NorthwindSystem.BLL
{
    public class RegionController
    {
        //each method in this controller is exposed to the outside world
        //it is the interface to the application library
        //the method will interact with the internal Context class
        public List<Region> Regions_List()
        {
            //create an instance of the Context class you wish to
            //   interact.
            //wrap the method work within a Transaction.
            //this transaction will help in insert, update and delete
            //    to ensure proper commits and rollbacks
            //this transaction is not necessary for queries BUT we will
            //    use it so we need only learn one techinque.
            using (var context = new NorthwindContext())
            {
                //entityframework has many built in methods that have
                //    been deem common requirements for 99.99999% of applications

                // to return a complete set of records associated with the
                // DbSet<T>; you simply have to reference the DbSet property
                return context.Regions.ToList();
            }
        }

        //this method is to lookup a entity record by its primary key
        public Region Regions_FindByID(int regionid)
        {
            using(var context = new NorthwindContext())
            {
                return context.Regions.Find(regionid);
            }
        }
    }
}
