using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.DAL;
using NorthwindSystem.Data;
using System.ComponentModel; //needed to expose class and methods to ODS wizard
#endregion

namespace NorthwindSystem.BLL
{
    //expose the class to the ObjectDataSource wizard
    [DataObject]
    public class CategoryController
    {
        //expose a method to ODS
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Category> Categories_List()
        {
            using(var context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
