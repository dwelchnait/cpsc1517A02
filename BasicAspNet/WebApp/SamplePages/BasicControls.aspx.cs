using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        //global variable available to the entire page and will
        //temporarily represent data from the database
        public static List<DDLClass> DataCollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            //this event will happen EACH and EVERY time your page is executed
            //this event will happen BEFORE ANY of YOUR control events happen
            //this is a great place to initialize items (controls) that are
            //   common to many events and need to be done every time

            //example: old messages should be cleared out on every pass
            //         you can empty the MessageLabel control under each event
            //      OR do it once here for ALL events
            MessageLabel.Text = "";

            //this is a great place to do 1st time initialization of controls
            // (similar to the else side of the IsPost from Razor)
            if (!Page.IsPostBack) //(Page.IsPostBack == false)
            {
                //load the DDL on the 1st pass
                //create an instance of a collection (List<T>; T == class DDLClass)
                //create 4 record instances for the collection
                //place the collection into the DDL
                //normally the collection is the result of a query to your DB
                DataCollection = new List<DDLClass>();
                DataCollection.Add(new DDLClass(2, "CPSC1517"));
                DataCollection.Add(new DDLClass(1, "COMP1008"));
                DataCollection.Add(new DDLClass(4, "DMIT2018"));
                DataCollection.Add(new DDLClass(3, "DMIT1508"));

                //sort the data collection for the ddl by program course name
                //syntax:  collectionname.Sort((x,y) => x.fieldname.CompareTo(y.fieldname))
                //collectionname is where your data resides (List<T>)
                //(x,y) represent any two values (records) in your collection at any point in time
                //=> (lamda) can be thought of as "do the following to x and y" (delegate)
                //our delegate for lamba is comparing x and y on the fieldname
                // x CompareTo y is an ascending sort
                // y CompareTo x is a descending sort
                DataCollection.Sort((x, y) => y.DisplayField.CompareTo(x.DisplayField));

                //steps in loading your DDL
                //assume that the DataCollection is actually database data
                //a) assign the data source to the control
                CollectionChoiceList.DataSource = DataCollection; //just the data

                //<option value=somevalue> sometext </option>
                //define what somevalue and sometext is in the data collection
                //b) indicated the display field to the control
                CollectionChoiceList.DataTextField = "DisplayField"; //non-object style
                //c) indicated the value field to the control
                CollectionChoiceList.DataValueField = nameof(DDLClass.ValueField); //object style
                //d) physically bind the data to the control
                CollectionChoiceList.DataBind();

                //optional prompt line??
                CollectionChoiceList.Items.Insert(0, "select ...");
            }

        }

        protected void SubmitNumberChoice_Click(object sender, EventArgs e)
        {
            //to grab the contents of a control will DEPEND on the control access type
            //for TextBox, label, Literial use .Text
            //for lists (RadioButtonList, DropDownList) you may use one of
            //  .SelectedValue (best), .SelectedIndex (phycial location), .SelectedItem.Text
            //for CheckBox use .Checked (boolean)

            //for the most part, all data from a control returns as a string

            //since the control (object) is on the "RIGHT" sode pf an assignment statement
            // the object Property uses its GET
            string submitchoice = NumberChoice.Text;

            if (string.IsNullOrEmpty(submitchoice))
            {
                //"LEFT" side uses the Property's SET
                MessageLabel.Text = "You did not enter a value for your program choice";
                ChoiceList.ClearSelection();
                //ChoiceList.SelectedIndex = -1; //-1 is a non existent index
                //CollectionChoiceList.ClearSelection();
                CollectionChoiceList.SelectedIndex = 0; //has my prompt
                AlterLabel.ForeColor = System.Drawing.Color.Black;
                DisplayDataRO.Text = "";
            }
            else
            {
                // you can set/get the radiobuttonlist choice by either using
                // .SelectedValue or .SelectedIndex or .SelectedItem.Text
                // it is BEST to use .SelectedValue for positioning
                ChoiceList.SelectedValue = submitchoice;

                //place a check mark in the checkbox if the choosen course
                //is a program
                if (submitchoice.Equals("2") || submitchoice.Equals("4"))
                {
                    ProgrammingCourseActive.Checked = true;
                    AlterLabel.ForeColor = System.Drawing.Color.BlueViolet;
                }
                else
                {
                    ProgrammingCourseActive.Checked = false;
                    AlterLabel.ForeColor = System.Drawing.Color.Black;
                }

                //DDL can be positioned using
                // .SelectedValue or .SelectedIndex or .SelectedItem.Text
                // it is BEST to use .SelectedValue for positioning
                CollectionChoiceList.SelectedValue = submitchoice;

                //demonstration of what is obtain bt the different .Selectedxxxxx
                DisplayDataRO.Text = CollectionChoiceList.SelectedItem.Text
                    + " at index " + CollectionChoiceList.SelectedIndex
                    + " having a value of " + CollectionChoiceList.SelectedValue;
 

            }
        }

        protected void CollectionSubmit_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "You pressed the link button Selection Submit";
        }


    }
}