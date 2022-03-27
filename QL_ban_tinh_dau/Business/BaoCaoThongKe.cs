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
    public class BaoCaoThongKe
    {
        public static List<BCTK_SanPham> GetBCTKSanPham(DateTime from, DateTime to)
        {
            DbConnection conObject = DataBaseConnection.GetDatabaseConnection();
            List<BCTK_SanPham> lst = new List<BCTK_SanPham>();
            try
            {
                conObject.Open();
                if (conObject.State == ConnectionState.Open)
                {
                    //Response.Write("Database Connection is Open");

                    using (var cmd = conObject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "BCTK_SanPham";

                        cmd.Parameters.Add(new SqlParameter("@From", SqlDbType.Date));
                        cmd.Parameters["@From"].Value = from;
                        cmd.Parameters.Add(new SqlParameter("@To", SqlDbType.Date));
                        cmd.Parameters["@To"].Value = to;

                        var rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            lst.Add(new BCTK_SanPham()
                            {
                                IdSanPham = int.Parse(rd["idSanpham"].ToString()),
                                TenSanPham = rd["tenSanPham"].ToString(),
                                GiaBan = double.Parse(rd["fGiaBan"].ToString()),
                                TongSoLuongDaBan = int.Parse(rd["TongSoluongmua"].ToString()),
                                TongThanhTien = int.Parse(rd["TongThanhTien"].ToString()),
                            });

                        }
                        return lst;
                    }

                }

            }
            catch (SqlException sqlexception)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conObject.Close();
            }


            return null;
        }
        public static List<BCTK_LoaiSanPham> GetBCTKLoaiSanPham(DateTime from, DateTime to)
        {
            DbConnection conObject = DataBaseConnection.GetDatabaseConnection();
            List<BCTK_LoaiSanPham> lst = new List<BCTK_LoaiSanPham>();
            try
            {
                conObject.Open();
                if (conObject.State == ConnectionState.Open)
                {
                    //Response.Write("Database Connection is Open");

                    using (var cmd = conObject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "BCTK_LoaiSanPham";

                        cmd.Parameters.Add(new SqlParameter("@From", SqlDbType.Date));
                        cmd.Parameters["@From"].Value = from;
                        cmd.Parameters.Add(new SqlParameter("@To", SqlDbType.Date));
                        cmd.Parameters["@To"].Value = to;

                        var rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            lst.Add(new BCTK_LoaiSanPham()
                            {
                                IdLoaiSanPham = int.Parse(rd["idLoaisanpham"].ToString()),
                                tenLoaiSanPham = rd["tenLoaisanpham"].ToString(),
                                TongSoLuongDaBan = int.Parse(rd["TongSoluongmua"].ToString()),
                                TongThanhTien = int.Parse(rd["TongThanhTien"].ToString()),
                            });

                        }
                        return lst;
                    }

                }

            }
            catch (SqlException sqlexception)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conObject.Close();
            }


            return null;
        }

        public static List<BCTK_KhachHang> GetBCTKKhachHang(DateTime from, DateTime to)
        {
            DbConnection conObject = DataBaseConnection.GetDatabaseConnection();
            List<BCTK_KhachHang> lst = new List<BCTK_KhachHang>();
            try
            {
                conObject.Open();
                if (conObject.State == ConnectionState.Open)
                {
                    //Response.Write("Database Connection is Open");

                    using (var cmd = conObject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "BCTK_KhachHang";

                        cmd.Parameters.Add(new SqlParameter("@From", SqlDbType.Date));
                        cmd.Parameters["@From"].Value = from;
                        cmd.Parameters.Add(new SqlParameter("@To", SqlDbType.Date));
                        cmd.Parameters["@To"].Value = to;

                        var rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            lst.Add(new BCTK_KhachHang()
                            {
                                IdKhachHang = int.Parse(rd["id_KH"].ToString()),
                                TenKhachHang = rd["TenKH"].ToString(),
                                TongSoLuongDaBan = int.Parse(rd["TongSoluongmua"].ToString()),
                                TongThanhTien = int.Parse(rd["TongThanhTien"].ToString()),
                            });

                        }
                        return lst;
                    }

                }

            }
            catch (SqlException sqlexception)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conObject.Close();
            }


            return null;
        }

        public static List<BCTK_NhanVien> GetBCTKNhanVien(DateTime from, DateTime to)
        {
            DbConnection conObject = DataBaseConnection.GetDatabaseConnection();
            List<BCTK_NhanVien> lst = new List<BCTK_NhanVien>();
            try
            {
                conObject.Open();
                if (conObject.State == ConnectionState.Open)
                {
                    //Response.Write("Database Connection is Open");

                    using (var cmd = conObject.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "BCTK_NhanVien";

                        cmd.Parameters.Add(new SqlParameter("@From", SqlDbType.Date));
                        cmd.Parameters["@From"].Value = from;
                        cmd.Parameters.Add(new SqlParameter("@To", SqlDbType.Date));
                        cmd.Parameters["@To"].Value = to;

                        var rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            lst.Add(new BCTK_NhanVien()
                            {
                                NhanVienId = int.Parse(rd["id_NV"].ToString()),
                                TenNhanVien = rd["tenNV"].ToString(),
                                TongSoLuongDaBan = int.Parse(rd["TongSoluongmua"].ToString()),
                                TongThanhTien = int.Parse(rd["TongThanhTien"].ToString()),
                            });

                        }
                        return lst;
                    }

                }

            }
            catch (SqlException sqlexception)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conObject.Close();
            }


            return null;
        }
    }
}
