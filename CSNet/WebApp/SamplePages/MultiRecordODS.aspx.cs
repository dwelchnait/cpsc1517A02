using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class MultiRecordODS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        //use this method to discover the inner most error message.
        //this routing has been created by the user
        protected Exception GetInnerException(Exception ex)
        {
            //drill down to the inner most exception
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex;
        }//eom

        protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "";
            //to access the gridview row, you need to have the .SelectIndex
            //i am creating a variable which will point to the selected row
            //    this variable is being used so I can reduce my typing
            GridViewRow agvrow = ProductList.Rows[ProductList.SelectedIndex];
            msg = "ID is:" + (agvrow.FindControl("ProductID") as Label).Text;
            msg += "Name is:" + (agvrow.FindControl("ProductName") as Label).Text;
            msg += "Supplier is:" + (agvrow.FindControl("SupplierList") as DropDownList).SelectedValue;
            msg += "Category is:" + (agvrow.FindControl("CategoryListGV") as DropDownList).SelectedValue;
            msg += "UnitPrice is:" + (agvrow.FindControl("UnitPrice") as Label).Text;
            msg += "Disc is:" + (agvrow.FindControl("Discontinued") as CheckBox).Checked.ToString();
            Message.Text = msg;
        }

        protected void FetchCategoryProducts_Click(object sender, EventArgs e)
        {
            //validation that a choice was made
            if (CategoryList.SelectedIndex == 0)
            {
                Message.Text = "Select a category to view the category products";
            }
        }
    }
}