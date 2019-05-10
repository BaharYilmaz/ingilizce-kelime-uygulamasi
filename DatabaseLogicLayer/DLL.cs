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
                    "(KeliemeID,KelimeIngilizce,KelimeTurkce,Aciklama,Cumle,Derece)" +
                    "values(@KeliemeID,@KelimeIngilizce, @KelimeTurkce, @Aciklama, @Cumle,@Derece)", connect
                    );
                command.Parameters.Add("@KeliemeID", SqlDbType.UniqueIdentifier).Value = K.KelimeID;
                command.Parameters.Add("@KelimeIngilizce", SqlDbType.NVarChar).Value = K.KelimeIngilizce;
                command.Parameters.Add("@KelimeTurkce", SqlDbType.NVarChar).Value = K.KelimeTurkce;
                command.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = K.Aciklama;
                command.Parameters.Add("@Cumle", SqlDbType.NVarChar).Value = K.Cumle;
                command.Parameters.Add("@Derece", SqlDbType.NVarChar).Value = K.Derece;

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
        public SqlDataReader KelimeListele()
        {
            command = new SqlCommand("select*from Kelime", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader KelimeListeleDurum(string durum)
        {
            command = new SqlCommand("select*from Kelime where Durum=@Durum", connect);
            command.Parameters.Add("@Durum", SqlDbType.NVarChar).Value = durum;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader KelimeListeleDerece(int derece)
        {
            command = new SqlCommand("select*from Kelime where Derece=@Derece", connect);
            command.Parameters.Add("@Derece", SqlDbType.NVarChar).Value = derece;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int DurumGüncelle(Kelime k)
        {
            try
            {
                command = new SqlCommand
                 (@"update Kelime set 
                   KeliemeID=@KeliemeID,
                   Durum=@Durum where KeliemeID=@KeliemeID", connect);
                command.Parameters.Add("@KeliemeID", SqlDbType.UniqueIdentifier).Value = k.KelimeID;
                command.Parameters.Add("@Durum", SqlDbType.NVarChar).Value = k.Durum;
                BaglantiAyarla();
                ReturnValue = command.ExecuteNonQuery();
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
        public int DereceGüncelle(Kelime k)
        {
            try
            {
                command = new SqlCommand
                 (@"update Kelime set 
                   KeliemeID=@KeliemeID,
                   Derece=@Derece,Tarih=@Tarih where KeliemeID=@KeliemeID", connect);
                command.Parameters.Add("@KeliemeID", SqlDbType.UniqueIdentifier).Value = k.KelimeID;
                command.Parameters.Add("@Derece", SqlDbType.NVarChar).Value = k.Derece;
                command.Parameters.Add("@Tarih", SqlDbType.NVarChar).Value = k.Tarih;

                BaglantiAyarla();
                ReturnValue = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                BaglantiAyarla();
            }return ReturnValue;

        }
        public int Sifirla()
        {
            try
            {
                command = new SqlCommand(@"update Kelime set Durum='NULL',Tarih=Null,Derece=-1 ", connect);
                BaglantiAyarla();
                ReturnValue = command.ExecuteNonQuery();
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
        public SqlDataReader IstatistikYazdir()
        {
            command = new SqlCommand(" select DATEPART(MM,Tarih)as 'Ay', COUNT(Durum) as 'Kelime' from Kelime where Durum='ogrenilmis' group by Tarih", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
    }

}
