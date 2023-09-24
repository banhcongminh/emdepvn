<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSach_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyDanhMuc_DanhSach_ThemMoi" %>

<div class="head">
    Thêm mới danh mục sản phẩm
</div>
<div class="FormthemMoi">
    
    <div class ="thongTin">
        <div class="tenTruong">Danh mục cha</div>
        <div class="oNhap"><asp:DropDownList ID="ddlDanhMucCha" runat="server"></asp:DropDownList></div>
    </div>
    <div class ="thongTin">
        <div class="tenTruong">Tên danh mục</div>
        <div class="oNhap">
            <asp:TextBox ID="tbTenDanhMuc" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTendanhMuc" Display="Dynamic" 
                SetFocusOnError="true" ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
    </div>
    <div class ="thongTin">
        <div class="tenTruong">Ảnh đại diện</div>
        <div class="oNhap"><asp:FileUpload ID="flAnhDaiDien" runat="server" /></div>
    </div> 
    <div class ="thongTin">
        <div class="tenTruong">Thứ tự</div>
        <div class="oNhap"><asp:TextBox ID="tbThuTu" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Thứ tự phải nhập kiểu số"
                ControlToValidate="tbThuTu" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="Red" ></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class ="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbThemNhieuDanhMuc" runat="server" Text="Tiếp tục tạo danh mục khác sau khi tạo danh mục này" /></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="Huy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="Huy_Click" CausesValidation="false" />
        </div>
    </div>


</div>