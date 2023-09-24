using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TinTuc_TinTuc : System.Web.UI.UserControl
{
    string modulphu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
        {
            modulphu = Request.QueryString["modulphu"];
        }
        switch (modulphu)
        {
            case "DanhSachTinTuc":
                    plTinTucLoadControl.Controls.Add(LoadControl("DanhSachTinTuc/DanhSachTinTucLoadControl.ascx"));
                break;
            case "NhomTinTuc":
                plTinTucLoadControl.Controls.Add(LoadControl("NhomTinTuc/NhomTinTucLoadControl.ascx"));
                break;
        }
    }
}