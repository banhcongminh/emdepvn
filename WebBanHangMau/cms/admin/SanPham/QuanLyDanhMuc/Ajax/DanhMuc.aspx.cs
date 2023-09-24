using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_Ajax_DanhMuc : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // Cần có code kiểm tra đăng nhập. Sau đó mới thực hiện các thao tác ở dưới.
        if (Request.Params["ThaoTac"] != null)
            thaotac = Request.Params["ThaoTac"];
        switch(thaotac)
        {
            case "XoaDanhMuc":
                XoaDanhMuc();
                break;
        }
    }

    private void XoaDanhMuc()
    {
        string MaDM = "";
        if (Request.Params["MaDM"] != null )
            MaDM = Request.Params["MaDM"];
        
        // Thực hiện code xóa
        // Bước 1: Xóa ảnh đại diện đã lưu trên sever.
        // Bước 2: Xóa bản ghi trên sql.
        emdepvn.DanhMuc.Danhmuc_Delete(MaDM);
        //In ra thông báo: (1) thực hiện thành công, (2) thực hiện không thành công.    
        Response.Write("Đã thực hiện.");
    }
}