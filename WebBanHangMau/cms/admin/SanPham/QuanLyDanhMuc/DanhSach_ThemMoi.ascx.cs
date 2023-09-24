using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_DanhSach_ThemMoi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {      
        if(!IsPostBack)
        {
            LayDanhMucCha();
        }
    }

    private void LayDanhMucCha()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc();
        ddlDanhMucCha.Items.Clear();
        ddlDanhMucCha.Items.Add(new ListItem("Danh mục gốc", "0"));
        
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
        }
    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (flAnhDaiDien.FileContent.Length > 0)
        {
            if(flAnhDaiDien.FileName.EndsWith(".jpeg")|| flAnhDaiDien.FileName.EndsWith(".jpg") ||
                flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
            {
                flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/")+ flAnhDaiDien.FileName);
            }
        }
        emdepvn.DanhMuc.Danhmuc_Inser(tbTenDanhMuc.Text, flAnhDaiDien.FileName, tbThuTu.Text, ddlDanhMucCha.SelectedValue, "");

        if(cbThemNhieuDanhMuc.Checked)
        {
            // Viết code xử lý xóa các text đã để người dùng nhập danh mục tiếp theo
            ResetControl();
        }
        else
        {
            // Đẩy trang về trang danh sách các danh mục đã tạo.
            Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=DanhMuc");
        }    
    }

    private void ResetControl()
    {
        tbTenDanhMuc.Text = "";
        tbThuTu.Text = "";
    }

    protected void Huy_Click(object sender, EventArgs e)
    {
        ResetControl() ;
    }
}