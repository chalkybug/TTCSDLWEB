using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TTCSDLWeb.Models.DAO
{
    class DataProvider
    {
        private static DataProvider instance; // khởi tạo một đối tượng
        private DataProvider() { } // khởi tạo hàm mặc định
        private string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=CSDLNhom4;Integrated Security=True";

        public static DataProvider Instance // đóng gói dữ liệu vẫn chưa thêm xử lý chồng chéo dữ liệu
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }

        }

        // viết lại cái query xử lý thông qua provider
        public DataTable ExecuteQuery(string query, Object[] parameter = null)
        {

            DataTable data = new DataTable("data");
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                // xử lý nâng cao parameter là sử lý chuỗi thêm vào

                if (parameter != null)// nghĩa là có tham số truyền vào
                {
                    string[] listPara = query.Split(' ');
                    int n = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[n]);
                            n++;
                        }
                    }
                }

                // trung gian qua một cái sqldataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();


            }

            return data;
        }

        public int ExecuteNonQuery(string query, Object[] parameter = null)// số dòng thành công
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                // xử lý nâng cao parameter là sử lý chuỗi thêm vào

                if (parameter != null)// nghĩa là có tham số truyền vào
                {
                    string[] listPara = query.Split(' ');
                    int n = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains("@"))
                        {

                            command.Parameters.AddWithValue(item, parameter[n]);
                            n++;

                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();


            }

            return data;
        }

        public object ExecuteScalar(string query, Object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                // xử lý nâng cao parameter là sử lý chuỗi thêm vào

                if (parameter != null)// nghĩa là có tham số truyền vào
                {
                    string[] listPara = query.Split(' ');
                    int n = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[n]);
                            n++;
                        }
                    }
                }

                // trung gian qua một cái sqldataAdapter
                data = command.ExecuteScalar();
                connection.Close();


            }

            return data;
        }
    }
}