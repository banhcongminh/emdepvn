using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_DanhSach_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";//lấy id của danh mục cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {      
        if(!IsPostBack)
        {
            LayDanhMucCha();
            HienThiThongTin(id);
        }
    }
    private void HienThiThongTin(string id)
    {
        if (thaotac == "ChinhSua")
        {
            btThemMoi.Text = "Chỉnh Sửa";
            cbThemNhieuDanhMuc.Visible = false;

            DataTable dt = new DataTable();
            dt = emdepvn.DanhMuc.Thongtin_Danhmuc_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ddlDanhMucCha.SelectedValue = dt.Rows[0]["MaDMCha"].ToString();
                tbTenDanhMuc.Text = dt.Rows[0]["TenDM"].ToString();
                tbThuTu.Text = dt.Rows[0]["ThuTu"].ToString();

                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/SanPham/" + dt.Rows[0]["AnhDaiDien"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhDaiDien"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Thêm Mới";
            cbThemNhieuDanhMuc.Visible = true;
        }

    }

    private void LayDanhMucCha()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc_by_MaDMCha("0");
        ddlDanhMucCha.Items.Clear();
        ddlDanhMucCha.Items.Add(new ListItem("Danh mục gốc", "0"));
        
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
            layDanhMucCon(dt.Rows[i]["MaDM"].ToString(),"___");
        }
    }

    private void layDanhMucCon(string MaDMCha, string khoangcach)
    {
        DataTable dt= new DataTable();
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc_by_MaDMCha(MaDMCha);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(khoangcach +dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
            layDanhMucCon(dt.Rows[i]["MaDM"].ToString(), khoangcach + "___");
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