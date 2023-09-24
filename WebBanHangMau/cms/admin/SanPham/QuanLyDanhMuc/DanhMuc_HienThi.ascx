<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMuc_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyDanhMuc_DanhMuc_HienThi" %>
<div class="head">
    Danh mục sản phẩm đã tạo
</div>
<div class = "khungChuaBang">
    <table class ="tbDanhMuc">
        <tr>
            <th class ="cotMa">Mã</th>
            <th class ="cotTen">Tên danh mục</th>
            <th class ="cotAnh">Ảnh đại diện</th>
            <th class ="cotThuTu">Thứ tự</th>
            <th class ="cotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="ltrDanhMuc" runat="server"></asp:Literal>
        
    </table>
</div>
<script type="text/javascript">
    function XoaDanhMuc(MaDM)
    {
        if (confirm("Bạn có muốn xóa danh mục này?")) {
            alert("Xoa id:" + MaDM);

            //  viết code xóa danh mục tại đây           
            $.post("/cms/admin/SanPham/QuanLyDanhMuc/Ajax/DanhMuc.aspx",
                {
                    "ThaoTac": "XoaDanhMuc",
                    "MaDM": MaDM
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status) ;
                    if (data = 1)   // thực hiện thành công --> ẩn dòng đã xóa đi .
                    {
                        $("#maDong_" + MaDM).slideUp();
                    }
                });
        }             
    }
</script>