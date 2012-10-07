using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///DBHelper 的摘要说明
/// </summary>
public class DBHelper
{
	public DBHelper()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	} 
}
public class Directory
{
    public string Drct_ID {get; set;}
    public string Drct_Name {get; set;}
    public string Drct_PartentID {get; set;}
    public string Drct_Memo {get; set;}
    public string Drct_Type {get; set;}
    public string HasChild { get; set; }
}
