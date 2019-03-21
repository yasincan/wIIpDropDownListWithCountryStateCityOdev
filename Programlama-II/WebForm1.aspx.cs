using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Programlama_II
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCountry"].ConnectionString);
        SqlDataReader reader;
        SqlCommand command;

        private void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ilDropDownList.Enabled = false;
                ilceDropDownList.Enabled = false;
                command = new SqlCommand("Select * From CountryMaster", MyConnection);
                MyConnection.Open();
                reader = command.ExecuteReader();
                ulkeDropDownList.DataSource = reader;
                ulkeDropDownList.DataValueField = "ID";
                ulkeDropDownList.DataTextField = "Name";
                ulkeDropDownList.DataBind();
                reader.Close();
                MyConnection.Close();
            }          
        } 
        protected void ulkeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {    
            if (ulkeDropDownList.AutoPostBack)
            {
                ilDropDownList.Enabled = true;
                command = new SqlCommand("Select * From StateMaster Where CountryID=' " + ulkeDropDownList.SelectedValue + " ' ", MyConnection);
                MyConnection.Open();
                reader = command.ExecuteReader();
                ilDropDownList.DataSource = reader;
                ilDropDownList.DataValueField = "ID";
                ilDropDownList.DataTextField = "Name";
                ilDropDownList.DataBind();
                reader.Close();
                MyConnection.Close();
            }
        }
        protected void ilDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ilDropDownList.AutoPostBack)
            {
                ilceDropDownList.Enabled = true;
                command = new SqlCommand("Select * From CityMaster Where StateID=' " + ilDropDownList.SelectedValue + " ' ", MyConnection);
                MyConnection.Open();
                reader = command.ExecuteReader();
                ilceDropDownList.DataSource = reader;
                ilceDropDownList.DataValueField = "ID";
                ilceDropDownList.DataTextField = "Name";
                ilceDropDownList.DataBind();
                reader.Close();
                MyConnection.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ulkeLabel.Text = "Ülke Adı:" + ulkeDropDownList.SelectedItem.Text;
            ilLabel.Text = "İl Adı: " + ilDropDownList.SelectedItem.Text;
            ilceLabel.Text = "İlçe Adı: " + ilceDropDownList.SelectedItem.Text + " olarak seçilmiştir.";   
        }
    }
}