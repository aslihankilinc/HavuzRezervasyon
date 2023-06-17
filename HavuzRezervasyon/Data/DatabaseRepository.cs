using HavuzRezervasyon.Bussinies;
using HavuzRezervasyon.Entities;
using HavuzRezervasyon.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavuzRezervasyon.Data
{
    public static class DatabaseRepository
    {
        public static bool Login(tblKullanici kul)
        {
            using (SQLiteDataManager sql = new SQLiteDataManager())
            {
                sql.DataCommand.Parameters.Add("@Sifre", DbType.String).Value = kul.Sifre;
                sql.DataCommand.Parameters.Add("@KullaniciAdi", DbType.String).Value = kul.KullaniciAdi;
                var dr = sql.GetDataReader("Select * from [tblKullanici] where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre");

                while (dr.Read())
                {
                     Kullanici._Kullanici = new tblKullanici()
                    {
                        KullaniciId = dr["KullaniciId"].ToInt32(),
                        AdSoyad = dr["AdSoyad"].ToString(),
                    };
                }

            }
            return Kullanici._Kullanici != null;
        }

        public static bool MusteriEkle(tblMusteri musteri)
        {

            using (SQLiteDataManager sql = new SQLiteDataManager())
            {
                string query = @"insert into [tblMusteri]
                                   ([AdSoyad]
                                   ,[DogumTarih]
                                   ,[Telefon])
                                 VALUES(@AdSoyad,@DogumTarih, @Telefon)";
                if (musteri.MusteriId > 0)
                    query = @"UPDATE [tblMusteri] SET [Telefon] =@Telefon, [AdSoyad] =@AdSoyad,[DogumTarih] =@DogumTarih WHERE MusteriId=@MusteriId";
                sql.DataCommand.Parameters.Add("MusteriId", DbType.Int32).Value = musteri.MusteriId;
                sql.DataCommand.Parameters.Add("AdSoyad", DbType.String).Value = musteri.AdSoyad.GetNullOrValue();
                sql.DataCommand.Parameters.Add("DogumTarih", DbType.String).Value = musteri.DogumTarih.GetNullOrValue();
                sql.DataCommand.Parameters.Add("Telefon", DbType.String).Value = musteri.Telefon;
                return sql.RunCommand(query) > 0;
            }
        }

        public static List<tblMusteri> ListMusteri(tblMusteri musteri)
        {
            var listMusteri = new List<tblMusteri>();
            using (SQLiteDataManager sql = new SQLiteDataManager())
            {
                if (musteri == null)
                    musteri = new tblMusteri() { MusteriId = 0 };
                sql.DataCommand.Parameters.Add("MusteriId", DbType.Int32).Value = musteri.MusteriId;
                var dr = sql.GetDataReader("Select * from tblMusteri WHERE (@MusteriId=0 OR MusteriId=@MusteriId)");

                while (dr.Read())
                {
                    listMusteri.Add(new tblMusteri()
                    {
                        MusteriId = dr["MusteriId"].ToInt32(),
                        AdSoyad = dr["AdSoyad"].ToString(),
                        Telefon = dr["Telefon"].ToString(),
                        DogumTarih = dr["DogumTarih"].ToString()
                    });
                }

            }
            return listMusteri;

        }

        public static bool SilMusteri(tblMusteri musteri)
        {
            using (SQLiteDataManager sql = new SQLiteDataManager())
            {
                string query = "";
                if (musteri.MusteriId > 0)
                    query = @"Delete From [tblMusteri] WHERE MusteriId=@MusteriId";
                sql.DataCommand.Parameters.Add("MusteriId", DbType.Int32).Value = musteri.MusteriId;
                return sql.RunCommand(query) > 0;
            }
        }
    }
}
