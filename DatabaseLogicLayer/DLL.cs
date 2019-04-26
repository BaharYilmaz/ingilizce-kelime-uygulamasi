using Sözlük.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer
{
    public class DLL
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;

        int ReturnValue;

        public DLL()
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-GP8FKQL;Initial Catalog=Sozluk;Integrated Security=True");

        }
        public void BaglantiAyarla()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
            else
                connect.Close();
        }
        public int KelimeEkle(Kelime K)
        {
            try
            {
                command = new SqlCommand
                    (
                    "insert into Kelime" +
                    "(KeliemeID,KelimeIngilizce,KelimeTurkce,Aciklama,Cumle)" +
                    "values(@KeliemeID,@KelimeIngilizce, @KelimeTurkce, @Aciklama, @Cumle)", connect
                    );
                command.Parameters.Add("@KeliemeID", SqlDbType.UniqueIdentifier).Value = K.KeliemeID;
                command.Parameters.Add("@KelimeIngilizce", SqlDbType.NVarChar).Value = K.KelimeIngilizce;
                command.Parameters.Add("@KelimeTurkce", SqlDbType.NVarChar).Value = K.KelimeTurkce;
                command.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = K.Aciklama;
                command.Parameters.Add("@Cumle", SqlDbType.NVarChar).Value = K.Cumle;
                BaglantiAyarla();
                ReturnValue = command.ExecuteNonQuery();//hazırlanmış sorguyu sql e gönderir

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValue;
        }
        public SqlDataReader KayitListele()
        {
            command = new SqlCommand("select * from Kelime", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader TekKayitListele(Guid Id)
        {
            command = new SqlCommand("select * from Kelime where KeliemeID = @KeliemeID", connect);
            command.Parameters.Add("@KelimeID", SqlDbType.UniqueIdentifier).Value = Id;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

    }
}
