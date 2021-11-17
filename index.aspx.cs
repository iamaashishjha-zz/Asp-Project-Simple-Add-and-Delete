using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_WAPP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
            lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;
        }

        protected void btnAdd1_Click(object sender, EventArgs e)
        {
            ListItem lst1 = new ListItem();
            lst1.Text = txtData1.Text;
            ListBox2.Items.Add(lst1);
            txtData1.Text = null;
            lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
        }

        protected void btnAdd2_Click(object sender, EventArgs e)
        {
            ListItem lst2 = new ListItem();
            lst2.Text = txtData2.Text;
            ListBox3.Items.Add(lst2);
            txtData2.Text = null;
            lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;

        }

        protected void btnDelete1_Click(object sender, EventArgs e)
        {
            ListItem lst3 = new ListItem();
            lst3.Text = ListBox2.SelectedItem.Text;
            ListBox2.Items.Remove(lst3);
            lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
        }

        protected void btnDelete2_Click(object sender, EventArgs e)
        {
            ListItem lst4 = new ListItem();
            lst4.Text = ListBox3.SelectedItem.Text;
            ListBox3.Items.Remove(lst4);
            lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;
        }

        protected void btnDelete3_Click(object sender, EventArgs e)
        {
            if (chSelected.Checked)
            {

                List<ListItem> lstSelectedItems = new List<ListItem>();

                foreach (ListItem liItems in ListBox2.Items)
                {
                    if (liItems.Selected == true)
                    {
                        lstSelectedItems.Add(liItems);
                    }
                }

                foreach (ListItem liSelected in lstSelectedItems)
                {
                    ListBox2.Items.Remove(liSelected);
                }
                lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
            }
            else
            {
                ListBox2.Items.Clear();
                lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
            }

        }

        protected void btnDelete4_Click(object sender, EventArgs e)
        {

            if (chSelected.Checked)
            {
                List<ListItem> lstSelectedItems = new List<ListItem>();

                foreach (ListItem liItems in ListBox3.Items)
                {
                    if (liItems.Selected == true)
                    {
                        lstSelectedItems.Add(liItems);
                    }
                }

                foreach (ListItem liSelected in lstSelectedItems)
                {
                    ListBox3.Items.Remove(liSelected);
                }
                lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;
            }
            else
            {
                ListBox3.Items.Clear();
                lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;
            }


        }

        protected void btnMove1_Click(object sender, EventArgs e)
        {
            ListItem lst7 = new ListItem();
            lst7.Text = ListBox2.SelectedItem.Text;
            ListBox3.Items.Add(lst7);
            ListBox2.Items.Remove(lst7);
            lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
            lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;
        }

        protected void btnMove2_Click(object sender, EventArgs e)
        {
            ListItem lst8 = new ListItem();
            lst8.Text = ListBox3.SelectedItem.Text;
            ListBox2.Items.Add(lst8);
            ListBox3.Items.Remove(lst8);
            lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
            lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;
        }

        protected void btnMove3_Click(object sender, EventArgs e)
        {
            if (chSelected.Checked)
            {
                List<ListItem> lstSelectedItems = new List<ListItem>();
                foreach (ListItem liItems in ListBox2.Items)
                {
                    if (liItems.Selected == true)
                    {
                        lstSelectedItems.Add(liItems);
                    }
                }

                foreach (ListItem liSelected in lstSelectedItems)
                {
                    ListBox3.Items.Add(liSelected);
                    ListBox2.Items.Remove(liSelected);
                }

                lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
                lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;

            }
            else
            {
                ListItem[] lstArray1 = new ListItem[ListBox2.Items.Count];
                ListBox2.Items.CopyTo(lstArray1, 0);
                ListBox3.Items.AddRange(lstArray1);
                ListBox2.Items.Clear();
                lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
                lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;
            }
        }

        protected void btnMove4_Click(object sender, EventArgs e)
        {
            if (chSelected.Checked)
            {
                List<ListItem> lstSelectedItems = new List<ListItem>();
                foreach (ListItem liItems in ListBox3.Items)
                {
                    if (liItems.Selected == true)
                    {
                        lstSelectedItems.Add(liItems);
                    }
                }

                foreach (ListItem liSelected in lstSelectedItems)
                {
                    ListBox2.Items.Add(liSelected);
                    ListBox3.Items.Remove(liSelected);
                }

                lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
                lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;

            }
            else
            {
                ListItem[] lstArray2 = new ListItem[ListBox3.Items.Count];
                ListBox3.Items.CopyTo(lstArray2, 0);
                ListBox2.Items.AddRange(lstArray2);
                ListBox3.Items.Clear();
                lblCount1.Text = "Total Items in List is : " + ListBox2.Items.Count;
                lblCount2.Text = "Total Items in List is : " + ListBox3.Items.Count;
            }
        }
    }
}