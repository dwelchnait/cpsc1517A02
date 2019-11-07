using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace NorthwindSystem.Data
{
    //all classes by default are private, change to public
    //all entity or data classes in this course will be singular in name

    //an annotation tht will point this class to the appropriate
    //   sql table iis needed in front of the class header
    //an annotation syntax is [annotation]
    //syntax [Table("mysqltablename"[,Schema="sqlschemaname"])]
    //sometimes your sql database will be divided into groups:
    //    these groups are called schemas
    //    you can recongize a schema on a table by the name it is
    //    using ie: HumanResorces.Employees
    //IF you database does NOT have schemas then you OMIT the schema
    //    attribute from your annotation
    //the creation of this class is called MAPPING. You are supplying
    //    a definition of the sql table to your application

    [Table("Products")]
    public class Product
    {
        //all sql attribtes will have a corresponding class property
        //IF you use the attribute name as your property name
        //   the physical order of the properties do NOT need to match
        //   the sql attribute order

        //you need a [Key] annotation for your primary key field
        //[Key]  use on an identity pkey field (default)
        //optional style [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] fully coded
        //[Key, Column(Order=n)]  use on compound pkey fields where
        //   n represents the PHYSICAL order of the components
        //   n starts at 1 (natural number)
        //[Key, DataGenerated(DataGenerateddOption.None)] use for
        //   pkeys that are NOT compound OR NOT identity; that is the user
        //   must supply the pkey value

        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        // [ForeignKey]  DO NOT USE
        //this is optional
        //use this annotation ONLY IF your foreign key
        //   sql field name is NOT the same as the associated
        //   primary key field name OR if you use a different
        //   name in your mapping
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        //optionally add your constructors (default and greedy)

        //other annotation
        //computed field does exist on the database table
        //this field does NOT expect data from the user nor does
        //   EnTityFramework expect data to be pass to this sql attribute

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public decimal Total { get; set; }

        //Read-Only application property
        //lets assume you would like to concatenate some fields together
        //   within your application on several occasions such as
        //   creating a full name out of two attributes like FirstName and LastName

        //these read-only properties are NON mapped fields
        //they do NOT exist on the sql table
        //EntityFramework is NOT expecting to be supplied data NOT will
        //   it supply data for the property
        [NotMapped]
        public string ProductandID
        {
            get
            {
                return ProductName + "(" + ProductID + ")";
            }
        }

    }
}
