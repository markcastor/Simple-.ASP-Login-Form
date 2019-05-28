using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace LoginApp
{
    public partial class index : System.Web.UI.Page
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private void MessageBox(Page page, string message)
        {
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username=@username and password1=@password1", con);
            cmd.Parameters.AddWithValue("@username", username1.Text);
            cmd.Parameters.AddWithValue("@password1", password1.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();

            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Response.Redirect("errorpage.aspx");
            }
        }
    }
}