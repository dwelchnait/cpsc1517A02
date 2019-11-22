using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.Data;
using NorthwindSystem.DAL;
using System.ComponentModel;
#endregion

namespace NorthwindSystem.BLL
{
    [DataObject]
    public class SupplierController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Supplier> Supplier_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.ToList();
            }
        }

        public Supplier Supplier_Get(int supplierid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.Find(supplierid);
            }
        }
    }
}
