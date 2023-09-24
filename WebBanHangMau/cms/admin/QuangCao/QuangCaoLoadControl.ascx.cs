using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_QuangCao_QuangCaoLoadControl : System.Web.UI.UserControl
{
    string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["modulphu"] != null)
        {
            modulphu = Request.QueryString["modulphu"];
        }
        switch(modulphu)
        {
            case "DanhSachQC":
                plQuangCaoLoadControl.Controls.Add(LoadControl("QuanLyDanhSachQuangCao/DanhSachQuanLyQuangCaoLoadControl.ascx"));
                break;
            case "NhomQC":
                plQuangCaoLoadControl.Controls.Add(LoadControl("QuanLyNhomQuangCao/DanhSachQuanLyNhomQuangCaoLoadControl.ascx"));
                break;
        }
    }
}