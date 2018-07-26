using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ReceiptLibrary
{
     public class MemberDAO : IDisposable
    {
        SqlConnection _conn = null;

        // constructor - untuk membentuk koneksi dari program ke database
        public MemberDAO(string connectionString)
        {
            try
            {
                _conn = new SqlConnection(connectionString);
                _conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(Member member)
        {
            int result = 0;
            SqlTransaction trans = null;
            try
            {
                trans = _conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = trans;
                    cmd.CommandText = @"insert into Member values (@Nomor, @Nama, @NoHp, @Email, @JenisKelamin)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Nomor", member.Nomor);
                    cmd.Parameters.AddWithValue("@Nama",member.Nama);
                    cmd.Parameters.AddWithValue("@NoHp", member.NoHp);
                    cmd.Parameters.AddWithValue("@Email",member.Email);
                    cmd.Parameters.AddWithValue("@JenisKelamin",member.JenisKelamin);
                    result = cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                throw ex;
            }
            finally
            {
                if (trans != null) trans.Dispose();
            }
            return result;
        }

        public string GetNomorTransaksiBerikutnya()
        {
            string result = "";
            try
            {
                string nomorTransaksiTerakhir = "";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText =
                        @"Select Top 1 Nomor From Member              
                            order by Nomor desc";
                  
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                nomorTransaksiTerakhir = reader["Nomor"].ToString();
                            }
                        }
                    }
                }
                if (nomorTransaksiTerakhir == "")
                {
                    result = "201807070001";
                }
                else
                {
                    int lastNumber = Convert.ToInt32(nomorTransaksiTerakhir.Substring(9));
                    result = $"20180707{(lastNumber + 1).ToString("0000")}";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public bool EmailIsValid(string emailAddr)

        {

            string emailPattern1 = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            Regex regex = new Regex(emailPattern1);

            Match match = regex.Match(emailAddr);

            return match.Success;

        }
        public Member GetDataMemberByNomor(string Nomor)
        {
            Member result = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText = @"select * from Member Where Nomor = @Nomor";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Nomor", Nomor);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = new Member
                                {
                                    Nomor = reader["Nomor"].ToString(),
                                    Nama = reader["Nama"].ToString(),
                                    NoHp = reader["NoHp"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    JenisKelamin = reader["JenisKelamin"].ToString()

                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }
    }//class
}//namespace
