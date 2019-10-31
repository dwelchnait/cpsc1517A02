using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class JobApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            //clear the form controls
            FullName.Text = "";
            EmailAddress.Text = "";
            PhoneNumber.Text = "";
            FullOrPartTime.ClearSelection();
            Jobs.ClearSelection();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //gather the entered data and display the values

            //need to collecct the entered data
            //string fullname = FullName.Text;
            string email = EmailAddress.Text;
            string phone = PhoneNumber.Text;
            string time = FullOrPartTime.SelectedValue;

            //create a message string containing the entered data
            string msg = string.Format("Name: {0} Email: {1} Phone: {2} Time: {3}",
                                FullName.Text, email, phone, time);

            //to handle the checkbox list, traverse the list
            //     and obtain the dta that was selected
            //during the traverse, create a string of jobs selected
            //after the traverse, add the string of jobs OR an error msg to
            //  the other message data string
            string jobs = " Jobs: ";
            bool found = false;
            foreach(ListItem item in Jobs.Items)
            {
                if(item.Selected)
                {
                    found = true;
                    jobs += item.Value + " ";
                }
            }
            if (!found)
            {
                jobs += " you did not select a job. Application Rejected.";
            }
            //display the message string in the output message control
            Message.Text = msg + jobs;
        }
    }
}