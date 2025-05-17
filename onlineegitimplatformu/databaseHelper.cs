using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseHelper
{
    // MSSQL bağlantı cümlesi
    private static string connectionString = "Server=MONSTER\\SQLEXPRESS;Database=OnlineEgitim;Trusted_Connection=True;";

    /// <summary>
    /// INSERT, UPDATE, DELETE gibi sorguları çalıştırır ve etkilenen satır sayısını döner.
    /// </summary>
    public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
    {
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(CloneParameters(parameters));
                return cmd.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// SELECT sorgularını çalıştırır ve sonucu DataTable olarak döner.
    /// </summary>
    public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
    {
        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(CloneParameters(parameters));
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }

    /// <summary>
    /// SqlParameter dizisini klonlar (yeniden kullanılabilir hale getirir)
    /// </summary>
    private static SqlParameter[] CloneParameters(SqlParameter[] originalParameters)
    {
        SqlParameter[] cloned = new SqlParameter[originalParameters.Length];
        for (int i = 0; i < originalParameters.Length; i++)
        {
            SqlParameter p = originalParameters[i];
            cloned[i] = new SqlParameter(p.ParameterName, p.SqlDbType)
            {
                Value = p.Value
            };
        }
        return cloned;
    }
}
