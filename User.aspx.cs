using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_to_Jason
{
    public partial class User : System.Web.UI.Page
    {
        List<Dictionary<string, object>> rows;    //creating reference of a list 
        JavaScriptSerializer serializer = new JavaScriptSerializer();  //convert custom string into json string
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(Server.MapPath("User.json"));
            string json = reader.ReadToEnd();
            rows = serializer.Deserialize<List<Dictionary<string, object>>>(json);
            reader.Close();
            if (!IsPostBack)
            {
                txtMain.Text = serializer.Serialize(rows);
            }
        }

    

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("id", txtId.Text);
            row.Add("name", txtName.Text);
            row.Add("email", txtEmail.Text);
            rows.Add(row);
            txtMain.Text = serializer.Serialize(rows);
          //  LoadGridView();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("id", txtId.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));
            row["name"] = txtName.Text;
            row["email"] = txtEmail.Text;
            txtMain.Text = serializer.Serialize(rows);
        }
    

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("id", txtId.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));
            rows.Remove(row);
            txtMain.Text = serializer.Serialize(rows);
        }
    

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            row.Add("id", txtId.Text);
            row = rows.SingleOrDefault(x => row.All(x.Contains));
            txtName.Text = row["name"].ToString();
            txtEmail.Text = row["email"].ToString();
        }
    

        protected void btnSaveToFile_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter myFile = new System.IO.StreamWriter(Server.MapPath("User.json"));
            if (!txtMain.Text.Equals(" "))
            {
                myFile.WriteLine(txtMain.Text);
            }
            myFile.Close();
        }
    }
}