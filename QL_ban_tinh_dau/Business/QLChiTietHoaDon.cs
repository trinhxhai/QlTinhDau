using QL_ban_tinh_dau.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ban_tinh_dau.Business
{
    public class QLChiTietHoaDon
    {
        public static int Add(CTHD cthd)
        {
            DbConnection conObject = DataBaseConnection.GetDatabaseConnection();
            try
            {
                conObject.Open();
                if (conObject.State == ConnectionState.Open)
                {
                    //Response.Write("Database Connection is Open");

                    using (var cmd = conObject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "themCTHD";

                        cmd.Parameters.Add(new SqlParameter("@idHoadon", SqlDbType.Int));
                        cmd.Parameters["@idHoadon"].Value = cthd.HoaDonId;

                        cmd.Parameters.Add(new SqlParameter("@idSanpham", SqlDbType.Int));
                        cmd.Parameters["@idSanpham"].Value = cthd.SanPhamId;

                        cmd.Parameters.Add(new SqlParameter("@fSoluongmua", SqlDbType.Int));
                        cmd.Parameters["@fSoluongmua"].Value = cthd.SoLuong;

                        cmd.Parameters.Add(new SqlParameter("@fKhuyenmai", SqlDbType.Float));
                        cmd.Parameters["@fKhuyenmai"].Value = cthd.KhuyenMai;

                        cmd.UpdatedRowSource = UpdateRowSource.OutputParameters;

                        var res = cmd.ExecuteNonQuery();

                        return 1;
                    }

                }

            }
            catch (SqlException sqlexception)
            {
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                conObject.Close();
            }
            return -1;
        }

        public static int Edit(CTHD cthd)
        {
            DbConnection conObject = DataBaseConnection.GetDatabaseConnection();
            try
            {
                conObject.Open();
                if (conObject.State == ConnectionState.Open)
                {
                    //Response.Write("Database Connection is Open");

                    using (var cmd = conObject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SuaCTHD";

                        cmd.Parameters.Add(new SqlParameter("@idHoadon", SqlDbType.Int));
                        cmd.Parameters["@idHoadon"].Value = cthd.HoaDonId;

                        cmd.Parameters.Add(new SqlParameter("@idSanpham", SqlDbType.Int));
                        cmd.Parameters["@idSanpham"].Value = cthd.SanPhamId;

                        cmd.Parameters.Add(new SqlParameter("@fSoluongmua", SqlDbType.Int));
                        cmd.Parameters["@fSoluongmua"].Value = cthd.SoLuong;

                        cmd.Parameters.Add(new SqlParameter("@fKhuyenmai", SqlDbType.Float));
                        cmd.Parameters["@fKhuyenmai"].Value = cthd.KhuyenMai;

                        cmd.UpdatedRowSource = UpdateRowSource.OutputParameters;

                        var res = cmd.ExecuteScalar().ToString();

                        return 1;
                    }

                }

            }
            catch (SqlException sqlexception)
            {
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                conObject.Close();
            }
            return -1;
        }

        public static void Remove(CTHD cthd)
        {
            DbConnection conObject = DataBaseConnection.GetDatabaseConnection();
            try
            {
                conObject.Open();
                if (conObject.State == ConnectionState.Open)
                {
                    //Response.Write("Database Connection is Open");

                    using (var cmd = conObject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "XoaCTHD";

                        cmd.Parameters.Add(new SqlParameter("@idHoadon", SqlDbType.Int));
                        cmd.Parameters["@idHoadon"].Value = cthd.HoaDonId;

                        cmd.Parameters.Add(new SqlParameter("@idSanpham", SqlDbType.Int));
                        cmd.Parameters["@idSanpham"].Value = cthd.SanPhamId;

                        cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (SqlException sqlexception)
            {
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conObject.Close();
            }
        }
    }
}
