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

        public static bool RezervasyonEkle(tblRezervasyon rez)
        {

            using (SQLiteDataManager sql = new SQLiteDataManager())
            {
                string query = @"insert into [tblRezervasyon]
                                   (
                                    [MusteriId]
                                   ,[GirisTarihi]
                                   ,[HavuzId]
                                   ,[KayitTarih])
                                 VALUES(@MusteriId,@GirisTarihi, @HavuzId,@KayitTarih)";
                if (rez.RezerveId> 0)
                    query = @"UPDATE [tblRezervasyon] SET [MusteriId] =@MusteriId, [GirisTarihi] =@GirisTarihi,[HavuzId] =@HavuzId,[CikisTarihi]=@CikisTarihi,[Ucret]=@Ucret WHERE RezerveId=@RezerveId";
                sql.DataCommand.Parameters.Add("MusteriId", DbType.Int32).Value = rez.MusteriId;
                sql.DataCommand.Parameters.Add("KayitTarih", DbType.String).Value = rez.KayitTarih==null?DateTime.Now.ToString(): rez.KayitTarih;
                sql.DataCommand.Parameters.Add("GirisTarihi", DbType.String).Value = rez.GirisTarihi.GetNullOrValue();
                sql.DataCommand.Parameters.Add("HavuzId", DbType.Int32).Value = rez.HavuzId;
                sql.DataCommand.Parameters.Add("CikisTarihi", DbType.String).Value = rez.CikisTarihi;
                sql.DataCommand.Parameters.Add("Ucret", DbType.Decimal).Value = rez.Ucret;
                sql.DataCommand.Parameters.Add("RezerveId", DbType.Int32).Value = rez.RezerveId;
                return sql.RunCommand(query) > 0;
            }
        }

        public static List<tblRezervasyon> ListRez(tblRezervasyon rez)
        {
            var listRez= new List<tblRezervasyon>();
            using (SQLiteDataManager sql = new SQLiteDataManager())
            {
                if (rez == null)
                    rez = new tblRezervasyon() { RezerveId = 0 ,KayitTarih=DateTime.Now.ToShortDate(), GirisTarihi= DateTime.Now.ToShortDate() };
                sql.DataCommand.Parameters.Add("RezerveId", DbType.Int32).Value = rez.RezerveId;
                sql.DataCommand.Parameters.Add("KayitTarih", DbType.String).Value = rez.KayitTarih;
                sql.DataCommand.Parameters.Add("GirisTarihi", DbType.String).Value = rez.GirisTarihi;
                var dr = sql.GetDataReader("Select h.HavuzId,m.MusteriId,r.RezerveId,r.GirisTarihi,h.Ad 'HavuzAd',r.Ucret,m.AdSoyad,m.Telefon,r.CikisTarihi from tblRezervasyon r " +
                    "inner join tblMusteri m on m.MusteriId=r.MusteriId " +
                     "inner join tblHavuz h on h.HavuzId=r.HavuzId " +
                    "WHERE ((@KayitTarih is not null AND substring(r.KayitTarih,0,11)=@KayitTarih) OR substring(r.GirisTarihi,0,11)=@GirisTarihi) OR (@RezerveId>0 AND RezerveId=@RezerveId)  ");

                while ((bool)(dr?.Read()))
                {
                    listRez.Add(new tblRezervasyon()
                    {
                        RezerveId = dr["RezerveId"].ToInt32(),
                        HavuzId = dr["HavuzId"].ToInt32(),
                        MusteriId = dr["MusteriId"].ToInt32(),
                        GirisTarihi = dr["GirisTarihi"].ToString(),
                        CikisTarihi = dr["CikisTarihi"].ToString(),
                        HavuzAd = dr["HavuzAd"].ToString(),
                        AdSoyad= dr["AdSoyad"].ToString(),
                        Telefon= dr["Telefon"].ToString(),
                        Ucret = dr["Ucret"].ToDecimal(),
                    });
                }

            }
            return listRez;

        }

        public static List<tblHavuz> ListHavuz(tblHavuz Havuz)
        {
           var listHavuz = new List<tblHavuz>();
            using (SQLiteDataManager sql = new SQLiteDataManager())
            {
                if (Havuz == null)
                    Havuz = new tblHavuz() { HavuzId = 0 };
              sql.DataCommand.Parameters.Add("HavuzId", DbType.Int32).Value = Havuz.HavuzId;
                var dr = sql.GetDataReader("Select * from tblHavuz WHERE (@HavuzId=0 OR HavuzId=@HavuzId)");

                while (dr.Read())
                {
                    listHavuz.Add(new tblHavuz()
    {
                        HavuzId = dr["HavuzId"].ToInt32(),
                        Ad = dr["Ad"].ToString(),
                        SaatlikUcret = dr["SaatlikUcret"].ToDecimal(),
                    });
                }

            }
            return listHavuz;
        }

        public static bool RezervasyonSil(tblRezervasyon rezerve)
        {
            using (SQLiteDataManager sql = new SQLiteDataManager())
            {
                string query = "";
                if (rezerve.RezerveId > 0)
                    query = @"Delete From [tblRezervasyon] WHERE RezerveId=@RezerveId";
                sql.DataCommand.Parameters.Add("RezerveId", DbType.Int32).Value = rezerve.RezerveId;
                return sql.RunCommand(query) > 0;
            }
        }
    }
}
