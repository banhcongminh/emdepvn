<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPham_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySanPham_SanPham_HienThi" %>
<div class="head">
    Các sản phẩm đã tạo
</div>
<div class = "khungChuaBang">
    <table class ="tbDanhMuc">
        <tr>
            <th class ="cotMa">Mã</th>
            <th class ="cotTen">Tên sản phẩm</th>
            <th class ="cotAnh">Ảnh đại diện</th>
            <th class ="cotSoLuong">Số lượng</th>
            <th class ="cotDonGia">Giá</th>
            <th class ="cotNgayTao">Ngày tạo</th>
            <th class ="cotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="ltrSanpham" runat="server"></asp:Literal>
        
    </table>
</div>
<script type="text/javascript">
    function XoaSanPham(MaSP)
    {
        if (confirm("Bạn có muốn xóa sản phẩm này?")) {
            alert("Xoa id:" + MaSP);

            //  viết code xóa danh mục tại đây           
            $.post("/cms/admin/SanPham/QuanLySanPham/Ajax/SanPham.aspx",
                {
                    "ThaoTac": "XoaSanPham",
                    "MaSP": MaSP    
                },
                function (data, status) {
                    //alert("Data: " + data + "\nStatus: " + status) ;
                    if (data = 1)   // thực hiện thành công --> ẩn dòng đã xóa đi .
                    {
                        $("#maDong_" + MaSP).slideUp();
                    }
                });
        }             
    }
</script>