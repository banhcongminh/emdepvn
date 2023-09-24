using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các truy vấn liên quan đến bảng sản phẩm
    /// </summary>
    public class SanPham
    {
        #region Phương thức xóa sản phẩm theo mã sản phẩm được truyền vào.
        /// <summary>
        /// Phương thức xóa sản phẩm theo mã sản phẩm được truyền vào.
        /// </summary>
        public static void Sanpham_Delete(string masp)
        {
            OleDbCommand cmd = new OleDbCommand("Sanpham_Delete");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức thực hiện thêm mới dữ liệu vào mẫu
        /// <summary>
        /// Phương thức thực hiện thêm mới dữ liệu vào mẫu
        /// </summary>
        /// <param name="tensp"></param>
        /// <param name="mauID"></param>
        /// <param name="sizeID"></param>
        /// <param name="chatlieuID"></param>
        /// <param name="anhsanpham"></param>
        /// <param name="soluongsp"></param>
        /// <param name="giasp"></param>
        /// <param name="motasp"></param>
        /// <param name="ngaytao"></param>
        /// <param name="ngayhuy"></param>
        /// <param name="maDM"></param>
        /// <param name="nhomID"></param>
        /// <param name="ret"></param>
        public static void Sanpham_Insert(
                                       string tensp,
                                       string mauID,
                                       string sizeID,
                                       string chatlieuID,
                                       string anhsanpham,
                                       string soluongsp,
                                       string giasp,
                                       string motasp,
                                       string ngaytao,
                                       string ngayhuy,
                                       string maDM,
                                       string nhomID,
                                       string ret)
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_update");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@mauID", mauID);
            cmd.Parameters.AddWithValue("@sizeID", sizeID);
            cmd.Parameters.AddWithValue("@chatlieuID", chatlieuID);
            cmd.Parameters.AddWithValue("@anhsanpham", anhsanpham);

            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);

            cmd.Parameters.AddWithValue("@maDM", maDM);
            cmd.Parameters.AddWithValue("@nhomID", nhomID);
            cmd.Parameters.AddWithValue("@ret", ret);


            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức cập nhật thông tin sản phẩm.
        /// <summary>
        /// Phương thức cập nhật thông tin sản phẩm.
        /// </summary>
        /// <param name="masp"></param>
        /// <param name="tensp"></param>
        /// <param name="mauid"></param>
        /// <param name="sizeid"></param>
        /// <param name="chatlieuid"></param>
        /// <param name="anhsp"></param>
        /// <param name="soluongsp"></param>
        /// <param name="giasp"></param>
        /// <param name="motasp"></param>
        /// <param name="ngaytao"></param>
        /// <param name="ngayhuy"></param>
        /// <param name="maDM"></param>
        /// <param name="nhomid"></param>
        public static void Sanpham_Update(
                                       string masp,
                                       string tensp,
                                       string mauid,
                                       string sizeid,
                                       string chatlieuid,
                                       string anhsp,
                                       string soluongsp,
                                       string giasp,
                                       string motasp,
                                       string ngaytao,
                                       string ngayhuy,
                                       string maDM,
                                       string nhomid)
        {
            OleDbCommand cmd = new OleDbCommand("Sanpham_Delete");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@mauid", mauid);
            cmd.Parameters.AddWithValue("@sizeid", sizeid);
            cmd.Parameters.AddWithValue("@chatlieuid", chatlieuid);
            cmd.Parameters.AddWithValue("@anhsp", anhsp);
            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);
            cmd.Parameters.AddWithValue("@maDM", maDM);
            cmd.Parameters.AddWithValue("@nhomid", nhomid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion


        #region Phương thức lấy ra danh sách tất cả sản phẩm
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả sản phẩm
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Sanpham()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);

        }
        #endregion

    }
}

