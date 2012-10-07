using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class insertTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cmdStr = @"INSERT INTO [QBJQHBJ].[dbo].[tAccessory]
           ([Acs_ID]
           ,[Acs_Name]
           ,[Acs_URL]
           ,[Acs_Type]
           ,[Acs_Memo]
           ,[Acs_Keywords]
           ,[Acs_Status]
           ,[Acs_Note]
           ,[Acs_User_Upload]
           ,[Acs_Time_Upload]
           ,[Acs_User_Check]
           ,[Acs_Time_Check]
           ,[Arch_ID]
           ,[Drct_ID]
           ,[OrderNum])
     VALUES
           ('{0}'
           ,'{1}'
           ,'D:\Attachments\采矿业\青白江区第一采矿场\建设项目资料\AK47.pdf'
           ,''
           ,''
           ,'XY'
           ,25
           ,''
           ,1
           ,getdate()
           ,''
           ,null
           ,'1,1,634790706673750000'
           ,'20120728111120,10'
           ,null)";
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            conn.Open();
            cmd.Transaction = conn.BeginTransaction();
            try
            {
                for (int i = 0; i < 500; i++)
                {
                    string ascid = DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond.ToString() + i.ToString();
                    string ascname = "XK" + ascid;
                    cmd.CommandText = string.Format(cmdStr, ascid, ascname);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
            }
            catch(Exception)
            {
                cmd.Transaction.Rollback();
                return;
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string cmdStr = @"INSERT INTO [QBJQHBJ].[dbo].[tAccessory]
           ([Acs_ID]
           ,[Acs_Name]
           ,[Acs_URL]
           ,[Acs_Type]
           ,[Acs_Memo]
           ,[Acs_Keywords]
           ,[Acs_Status]
           ,[Acs_Note]
           ,[Acs_User_Upload]
           ,[Acs_Time_Upload]
           ,[Acs_User_Check]
           ,[Acs_Time_Check]
           ,[Arch_ID]
           ,[Drct_ID]
           ,[OrderNum])
     VALUES
           ('{0}'
           ,'{1}'
           ,'D:\Attachments\采矿业\青白江区第一采矿场\建设项目资料\AK47.pdf'
           ,''
           ,''
           ,'AK'
           ,25
           ,''
           ,1
           ,getdate()
           ,''
           ,null
           ,'1,1,634790706673750000'
           ,'20120728111120,10'
           ,null)";
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            conn.Open();
            cmd.Transaction = conn.BeginTransaction();
            try
            {
                for (int i = 0; i < 500; i++)
                {
                    string ascid = DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond.ToString() + i.ToString();
                    string ascname = "AK" + ascid;
                    cmd.CommandText = string.Format(cmdStr, ascid, ascname);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
            }
            catch (Exception)
            {
                cmd.Transaction.Rollback();
                return;
            }
        }
    }
}