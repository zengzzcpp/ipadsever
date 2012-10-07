using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class pdfviw : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Request["acsid"]))
            return;

        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Acs_URL from tAccessory where Acs_ID = @AcsID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@AcsID", Request["acsid"]);
            
            conn.Open();
            object obj = cmd.ExecuteScalar();
            if (obj != null)
            {
                Response.ClearContent();//清空缓冲区内容
                Response.ClearHeaders();//清空缓冲区HTTP头
                Response.ContentType = "application/PDF";//设置HTTP头为PDF文档其它类似
                Response.WriteFile(obj.ToString());//写入客户端
                Response.Flush();//客户更新
                Response.Close();//写入关闭
            }
        }

    }
}