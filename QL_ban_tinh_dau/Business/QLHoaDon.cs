using QL_ban_tinh_dau.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ban_tinh_dau.Business
{
    public class QLHoaDon
    {
        public static HoaDon GetById(int Id)
        {
            DbConnection conObject = DataBaseConnection.GetDatabaseConnection();
            HoaDon hoaDon = null;

            try
            {
                conObject.Open();
                if (conObject.State == ConnectionState.Open)
                {
                    //Response.Write("Database Connection is Open");

                    using (var cmd = conObject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "GetHD";

                        cmd.Parameters.Add(new SqlParameter("@idHoadon", SqlDbType.Int));
                        cmd.Parameters["@idHoadon"].Value = Id;

                        var rd = cmd.ExecuteReader();

                        if (rd.Read())
                        {
                            hoaDon = new HoaDon()
                            {
                                Id = int.Parse(rd["idHoadon"].ToString()),
                                NhanVienId = int.Parse(rd["id_NV"].ToString()),
                                KhachHangId = int.Parse(rd["id_KH"].ToString()),
                                TenNhanVien = rd["tenNV"].ToString(),
                                TenKhachHang = rd["tenKH"].ToString(),
                            };

                        }

                        return hoaDon;
                    }

                }

            }
            catch (SqlException sqlexception)
            {
                return hoaDon;
            }
            catch (Exception ex)
            {
                return hoaDon;
            }
            finally
            {
                conObject.Close();
            }
            return hoaDon;
        }

        public static int GetNewHoaDonId()
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
                        cmd.CommandText = "GetNewHoadonId";

                        //cmd.UpdatedRowSource = UpdateRowSource.OutputParameters;

                        var res = cmd.ExecuteScalar().ToString();


                        return int.Parse(res);
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
        public static int Add(int NhanVienId, int KhachHangId)
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
                        cmd.CommandText = "themHD";

                        cmd.Parameters.Add(new SqlParameter("@id_KH", SqlDbType.Int));
                        cmd.Parameters["@id_KH"].Value = KhachHangId;

                        cmd.Parameters.Add(new SqlParameter("@id_NV", SqlDbType.Int));
                        cmd.Parameters["@id_NV"].Value = NhanVienId;

                        cmd.UpdatedRowSource = UpdateRowSource.OutputParameters;

                        var res = cmd.ExecuteScalar().ToString();

                        return int.Parse(res);
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
        public static void Edit(int HoaDonId, int KhachHangId)
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
                        cmd.CommandText = "SuaHD";


                        cmd.Parameters.Add(new SqlParameter("@id_HD", SqlDbType.Int));
                        cmd.Parameters["@id_HD"].Value = HoaDonId;

                        cmd.Parameters.Add(new SqlParameter("@id_KH", SqlDbType.Int));
                        cmd.Parameters["@id_KH"].Value = KhachHangId;


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
        public static void Remove(int HoaDonId)
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
                        cmd.CommandText = "XoaHD";

                        cmd.Parameters.Add(new SqlParameter("@idHoadon", SqlDbType.Int));
                        cmd.Parameters["@idHoadon"].Value = HoaDonId;


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
