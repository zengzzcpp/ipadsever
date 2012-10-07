using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Extensions;
using System.Web.Security;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

[WebService(Namespace = "http://zengzzcpp.3322.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
[System.Web.Script.Services.ScriptService]  
public class ipadsvr : System.Web.Services.WebService
{
    public ipadsvr()
    {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    //[WebMethod]
    //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    //public string HelloWorld() {
    //    return new JavaScriptSerializer().Serialize("Hello World");//"Hello World";

    //}

    //[WebMethod]
    //public string HelloWorld2()
    //{
    //    return "Hello World";

    //}

    /// <summary>
    /// 验证用户登录
    /// </summary>
    /// <param name="userName">用户名称</param>
    /// <param name="pwd">用户密码</param>
    /// <returns>返回验证结果</returns>
    //[WebMethod]
    //public String CheckLoginUserInfo(string userName, string pwd)
    //{
    //    XmlDocument document = new XmlDocument();

    //    XmlNode rootElem = func("result", "", document);
    //    XmlNode data = func("data", "", document);
    //    String isSuccess = "0";
    //    if (userName == "test" && pwd == "123456")
    //    {
    //        isSuccess = "1";
    //        data.AppendChild(func("truename", "测试人员1", document));
    //        data.AppendChild(func("userroleid", "1", document));
    //        data.AppendChild(func("depid", "2", document));
    //        data.AppendChild(func("depname", "编辑中心-要闻编辑部", document));
    //        data.AppendChild(func("paperid", "3", document));
    //        data.AppendChild(func("papername", "解放日报", document));
    //    }
    //    else
    //    {
    //        data.AppendChild(func("message", "帐号或密码错误!", document));
    //    }
    //    rootElem.AppendChild(func("isSuccess", isSuccess, document));
    //    rootElem.AppendChild(data);
    //    document.AppendChild(rootElem);
    //    Console.WriteLine();
    //    return document.OuterXml;
    //}

    //public XmlNode func(string nodeName, string innterText, XmlDocument document)
    //{
    //    XmlNode node = document.CreateNode("element", nodeName, "");
    //    node.InnerText = innterText;
    //    return node;
    //}

    //[WebMethod]
    //public string getDirectory(string pid)
    //{
    //    if (string.IsNullOrEmpty(pid))
    //        pid = "0";

    //    XmlDocument document = new XmlDocument();

    //    XmlNode rootElem = func("result", "", document);
    //    XmlNode data = func("data", "", document);
 
    //    try
    //    {
    //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
    //        {
    //            SqlCommand cmd = new SqlCommand();
    //            cmd.CommandText = "select * from tDirectory where Drct_PartentID = @pid";
    //            cmd.CommandType = CommandType.Text;
    //            cmd.Connection = conn;
    //            cmd.Parameters.AddWithValue("@pid", pid);

    //            conn.Open();
    //            SqlDataReader reader = cmd.ExecuteReader();
    //            int rowIndex = 0;
    //            while (reader.Read())
    //            {
    //                rowIndex++;
    //                XmlNode item = data.AppendChild(func(string.Format("row{0}", rowIndex), "", document));
    //                item.AppendChild(func("Drct_ID", reader["Drct_ID"].ToString(), document));
    //                item.AppendChild(func("Drct_Name", reader["Drct_Name"].ToString(), document));
    //                item.AppendChild(func("Drct_PartentID", reader["Drct_PartentID"].ToString(), document));
    //                item.AppendChild(func("Drct_Memo", reader["Drct_Memo"].ToString(), document));
    //                item.AppendChild(func("Drct_Type", reader["Drct_Type"].ToString(), document));
    //            }
    //        }
    //    }
    //    catch (Exception)
    //    {
    //        rootElem.AppendChild(func("isSuccess", "0", document));
    //        document.AppendChild(rootElem);
    //        return document.OuterXml;
    //    }
    //    rootElem.AppendChild(func("isSuccess", "1", document));
    //    rootElem.AppendChild(data);
    //    document.AppendChild(rootElem);
    //    return document.OuterXml;
    //}

    //[WebMethod]
    //public string getPDFFileList(string pid)
    //{
    //    if (string.IsNullOrEmpty(pid))
    //        pid = "0";

    //    XmlDocument document = new XmlDocument();

    //    XmlNode rootElem = func("result", "", document);
    //    XmlNode data = func("data", "", document);

    //    try
    //    {
    //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
    //        {
    //            SqlCommand cmd = new SqlCommand();
    //            cmd.CommandText = "select * from tAccessory where Drct_ID = @pid";
    //            cmd.CommandType = CommandType.Text;
    //            cmd.Connection = conn;
    //            cmd.Parameters.AddWithValue("@pid", pid);

    //            conn.Open();
    //            SqlDataReader reader = cmd.ExecuteReader();
    //            int rowIndex = 0;
    //            while (reader.Read())
    //            {
    //                rowIndex++;
    //                XmlNode item = data.AppendChild(func(string.Format("row{0}", rowIndex), "", document));
    //                item.AppendChild(func("Acs_ID", reader["Acs_ID"].ToString(), document));
    //                item.AppendChild(func("Acs_Name", reader["Acs_Name"].ToString(), document));
    //                item.AppendChild(func("Acs_Memo", reader["Acs_Memo"].ToString(), document));
    //                item.AppendChild(func("Acs_Keywords", reader["Acs_Keywords"].ToString(), document));
    //                item.AppendChild(func("Drct_ID", reader["Drct_ID"].ToString(), document));
    //                item.AppendChild(func("Acs_Time_Upload", reader["Acs_Time_Upload"].ToString(), document));
    //            }
    //        }
    //    }
    //    catch (Exception)
    //    {
    //        rootElem.AppendChild(func("isSuccess", "0", document));
    //        document.AppendChild(rootElem);
    //        return document.OuterXml;
    //    }
    //    rootElem.AppendChild(func("isSuccess", "1", document));
    //    rootElem.AppendChild(data);
    //    document.AppendChild(rootElem);
    //    return document.OuterXml;
    //}

    //[WebMethod]
    //public string SearchPDFFile(string keyword)
    //{
    //    if (string.IsNullOrEmpty(keyword))
    //        keyword = string.Empty;

    //    XmlDocument document = new XmlDocument();

    //    XmlNode rootElem = func("result", "", document);
    //    XmlNode data = func("data", "", document);

    //    try
    //    {
    //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
    //        {
    //            SqlCommand cmd = new SqlCommand();
    //            cmd.CommandText = "select * from tAccessory where Acs_Keywords like @keyword or Acs_Memo like @memo";
    //            cmd.CommandType = CommandType.Text;
    //            cmd.Connection = conn;
    //            cmd.Parameters.AddWithValue("@keyword", keyword);
    //            cmd.Parameters.AddWithValue("@memo", keyword);

    //            conn.Open();
    //            SqlDataReader reader = cmd.ExecuteReader();
    //            int rowIndex = 0;
    //            while (reader.Read())
    //            {
    //                rowIndex++;
    //                XmlNode item = data.AppendChild(func(string.Format("row{0}", rowIndex), "", document));
    //                item.AppendChild(func("Acs_ID", reader["Acs_ID"].ToString(), document));
    //                item.AppendChild(func("Acs_Name", reader["Acs_Name"].ToString(), document));
    //                item.AppendChild(func("Acs_Memo", reader["Acs_Memo"].ToString(), document));
    //                item.AppendChild(func("Acs_Keywords", reader["Acs_Keywords"].ToString(), document));
    //                item.AppendChild(func("Drct_ID", reader["Drct_ID"].ToString(), document));
    //                item.AppendChild(func("Acs_Time_Upload", reader["Acs_Time_Upload"].ToString(), document));
    //            }
    //        }
    //    }
    //    catch (Exception)
    //    {
    //        rootElem.AppendChild(func("isSuccess", "0", document));
    //        document.AppendChild(rootElem);
    //        return document.OuterXml;
    //    }
    //    rootElem.AppendChild(func("isSuccess", "1", document));
    //    rootElem.AppendChild(data);
    //    document.AppendChild(rootElem);
    //    return document.OuterXml;
    //}

    //[WebMethod]
    //public string getPDFFile(string AcsID)
    //{
    //    return string.Empty;
    //}

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string getDirectoryJson(string pid)
    {
        if (string.IsNullOrEmpty(pid))
            pid = "0";

        try
        {
            if (!isLogined())
            {
                throw new Exception("nologin");
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from tDirectory where Drct_PartentID = @pid";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();

                adapter.Fill(dt);

                string[][] results = new string[dt.Rows.Count][];
                int i = 0;
                foreach (DataRow row in dt.Rows)
                {
                    results[i] = new string[]{row["Drct_ID"].ToString(),
                                        row["Drct_Name"].ToString(),
                                        row["Drct_PartentID"].ToString(),
                                        row["Drct_Memo"].ToString(),
                                        row["Drct_Type"].ToString(),
                                        row["Drct_Type"].ToString() == "56" ? "0" : "1"};
                    i++;
                }

                return new JavaScriptSerializer().Serialize(results);
            }
        }
        catch (Exception ex)
        {
            string[][] results = new string[1][];
            results[0] = new string[]{ "faild", ex.Message };
            return new JavaScriptSerializer().Serialize(results); 
        }
    }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string getPDFFileListJson(string pid)
    {
        if (string.IsNullOrEmpty(pid))
            pid = "0";
        try
        {
            if (!isLogined())
            {
                throw new Exception("nologin");
            }
            
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from tAccessory where Drct_ID = @pid";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();

                adapter.Fill(dt);
                int i = 0;

                string[][] results = new string[dt.Rows.Count][];
                foreach (DataRow row in dt.Rows)
                {
                    results[i] = new string[]{row["Acs_ID"].ToString(),
                                        row["Acs_Name"].ToString(),
                                        row["Acs_Memo"].ToString(),
                                        row["Acs_Keywords"].ToString(),
                                        row["Drct_ID"].ToString(),
                                        row["Acs_Time_Upload"].ToString()};
                    i++;
                }

                return new JavaScriptSerializer().Serialize(results);
            }

        }
        catch (Exception ex)
        {
            string[][] results = new string[1][];
            results[0] = new string[] { "faild", ex.Message };
            return new JavaScriptSerializer().Serialize(results);
        }

    }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string SearchPDFFileJson(string keyword)
    {
        if (string.IsNullOrEmpty(keyword))
            keyword = string.Empty;

        try
        {
            if (!isLogined())
            {
                throw new Exception("nologin");
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from tAccessory where Acs_Keywords like @keyword or Acs_Memo like @memo";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@keyword", keyword);
                cmd.Parameters.AddWithValue("@memo", keyword);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                int i = 0;

                string[][] results = new string[dt.Rows.Count][];
                foreach (DataRow row in dt.Rows)
                {
                    results[i] = new string[]{row["Acs_ID"].ToString(),
                                        row["Acs_Name"].ToString(),
                                        row["Acs_Memo"].ToString(),
                                        row["Acs_Keywords"].ToString(),
                                        row["Drct_ID"].ToString(),
                                        row["Acs_Time_Upload"].ToString()};
                    i++;
                }

                return new JavaScriptSerializer().Serialize(results);
            }
        }
        catch (Exception ex)
        {
            string[][] results = new string[1][];
            results[0] = new string[] { "faild", ex.Message };
            return new JavaScriptSerializer().Serialize(results);
        }
    }

    [WebMethod(EnableSession=true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string CheckLoginUserTest(string username, string password)
    {
        Context.Session["user"] = username;
        Context.Session["state"] = "logined";

        string[][] results = new string[1][];
        results[0] = new string[] { "ok", "登录成功"};
        return new JavaScriptSerializer().Serialize(results);
    }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string CheckLoginUser(string username, string password)
    {
        try
        {
            string[][] results = new string[1][];

            if (string.IsNullOrEmpty(username))
            {
                results[0] = new string[] { "faild", "用户名不能为空" };
                return new JavaScriptSerializer().Serialize(results);
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QBJQHBJConnectionString"].ToString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"select a.*, c.* from [User] a
                                    left join [UserRole] b on a.Id = b.UserId
                                    left join [Role] c on b.RoleId = c.Id
                                    where a.username = @username";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    object obj = reader["Password"];

                    string psw = "";
                    if (obj != null)
                        psw = obj.ToString();

                    if (FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5").Equals(psw))
                    {
                        Context.Session["user"] = username;
                        Context.Session["state"] = "logined";

                        results[0] = new string[] { "ok", "登录成功" };
                        return new JavaScriptSerializer().Serialize(results);
                    }
                }
                results[0] = new string[] { "faild", "用户名或密码错误" };
                return new JavaScriptSerializer().Serialize(results);                    
            }
        }
        catch (Exception ex)
        {
            string[][] results = new string[1][];
            results[0] = new string[] { "faild", ex.Message };
            return new JavaScriptSerializer().Serialize(results);
        }
    }

    [WebMethod(EnableSession = true)]
    private bool isLogined()
    {
        if (Context.Session["state"] == null)
            return false;

        if (Context.Session["state"].ToString() == "logined")
            return true;

        return false;
    }
}