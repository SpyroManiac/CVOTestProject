using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CVOAntwerpen.DAL
{
    interface IDal<TypeEntity>
    {
        //string message {get;}
        //bool Update(TypeEntity entity);
        //int Insert(TypeEntity entity);
        //bool Delete(int Id);
        TypeEntity SelectOne(int id);
        //List<TypeEntity> SelectAll();
    }
}

namespace ProjectMobileCVO.DAL
{
    //DAL voor Cursist
    public class Cursist : CVOAntwerpen.DAL.IDal<BLL.Cursist>
    {
        public Cursist()
        {
            //
        }
        public ProjectMobileCVO.BLL.Cursist Select_Cursist(int id)
        {

            ProjectMobileCVO.BLL.Cursist cursist = new BLL.Cursist();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_Cursist";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        cursist.Id = (int)result["Id"];
                        cursist.CursistNummer = result["CursistNummer"].ToString();
                        cursist.Email = result["Email"].ToString();
                        cursist.Familienaam = result["Familienaam"].ToString();
                        cursist.Voornaam = result["Voornaam"].ToString();
                        cursist.Email = result["Email"].ToString();
                        cursist.GSM = result["GSM"].ToString();
                        cursist.Tel1 = result["Tel1"].ToString();

                    }
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return cursist;


        }
        public string Select_CursistNummer(int id)
        {
            string CursistNummer = "";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_CursistNummer";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        CursistNummer = result["CursistNummer"].ToString();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return CursistNummer;
        }
    }

    //DAL voor Personeel
    public class Personeel : CVOAntwerpen.DAL.IDal<BLL.Personeel>
    {
        public Personeel()
        {
            //this.message = "";
        }
        public ProjectMobileCVO.BLL.Personeel Select_Docent(int id)
        {

            ProjectMobileCVO.BLL.Personeel personeel = new BLL.Personeel();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_Docent";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        personeel.Id = (int)result["Id"];
                        personeel.Personeelnummer = (int)result["Personeelnummer"];
                        personeel.Stamboeknummer = result["Stamboeknummer"].ToString();
                        personeel.EmailCentrum = result["EmailCentrum"].ToString();
                        personeel.Geslacht = result["Geslacht"].ToString();
                        personeel.GSM = result["GSM"].ToString();
                        personeel.Naam = result["Naam"].ToString();
                        personeel.TEL = result["TEL"].ToString();
                        personeel.UserName = result["UserName"].ToString();
                        personeel.Voornaam = result["Voornaam"].ToString();

                    }
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return personeel;


        }
        public ProjectMobileCVO.BLL.Personeel Select_TrajectBegeleider(int id)
        {
            ProjectMobileCVO.BLL.Personeel trajectBegeleider = new BLL.Personeel();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_TrajectBegeleider";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        trajectBegeleider.Id = (int)result["Id"];
                        trajectBegeleider.Naam = result["Naam"].ToString();
                        trajectBegeleider.Voornaam = result["Voornaam"].ToString();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return trajectBegeleider;
        }
    }

    //DAL voor Kalender
    public class Kalender : CVOAntwerpen.DAL.IDal<BLL.Kalender>
    {
        public Kalender()
        {
            //this.message = "";
        }
        public ProjectMobileCVO.BLL.Kalender Select_Kalender(int id)
        {
            ProjectMobileCVO.BLL.Kalender kalender = new BLL.Kalender();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_Kalender";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        kalender.Id = (int)result["Id"];
                        kalender.Datum = (DateTime)result["Datum"];
                        kalender.Omschrijving = result["Omschrijving"].ToString(); 
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return kalender;
        }
    }

    //DAL voor Evenement
    public class Evenement : CVOAntwerpen.DAL.IDal<BLL.Evenement>
    {
        public Evenement()
        {
            //this.message = "";
        }
        public ProjectMobileCVO.BLL.Evenement Select_Evenement(int id)
        {
            ProjectMobileCVO.BLL.Evenement evenement = new BLL.Evenement();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_Evenement";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        evenement.Id = (int)result["Id"];
                        evenement.Datum = (DateTime)result["Datum"];
                        evenement.Evenement_ = result["Evenement"].ToString();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return evenement;
        }
    }

    //DAL voor Module
    public class Module : CVOAntwerpen.DAL.IDal<BLL.Module>
    {
        public Module()
        {
            //this.message = "";
        }
        public ProjectMobileCVO.BLL.Module Select_OverzichtModule(int id)
        {
            ProjectMobileCVO.BLL.Module module = new BLL.Module();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_OverzichtModule";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        module.Id = (int)result["Id"];
                        module.Naam = result["Naam"].ToString();
                        module.IdModuletype = (int)result["IdModuletype"];
                        module.Aanvangsdatum = (DateTime)result["Aanvangsdatum"];
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return module;
        }

    }

    //DAL voor IngerichteModulevariant
    public class IngerichteModulevariant : CVOAntwerpen.DAL.IDal<BLL.IngerichteModulevariant>
    {
        public IngerichteModulevariant()
        {
            //this.message = "";
        }
        public DateTime Select_EindDatumModule(int id)
        {
            DateTime EindDatum = DateTime.Now;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_EindDatumModule";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        EindDatum = (DateTime)result["EindDatum"];
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return EindDatum;
        }
        public int Select_IdLesPlaats(int id)
        {
            int IdLesPlaats = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_EindDatumModule";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        IdLesPlaats = (int)result["IdLesPlaats"];
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return IdLesPlaats;
        }
        public int Select_IdModule(int id)
        {
            int IdModule = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_IdModule";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        IdModule = (int)result["Id"];
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return IdModule;
        }
    }

    //DAL voor Plaatsing
    public class Plaatsing : CVOAntwerpen.DAL.IDal<BLL.Plaatsing>
    {
        public Plaatsing()
        {
            //this.message = "";
        }
        public ProjectMobileCVO.BLL.Plaatsing Select_PlaatsingStatus(int id)
        {
            ProjectMobileCVO.BLL.Plaatsing plaatsing = new BLL.Plaatsing();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_PlaatsingStatus";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        plaatsing.IdPlaatsingResultaat = (int)result["IdPlaatsingsstatus"];
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return plaatsing;
        }
    }

    //DAL voor Les
    public class LesDavinci : CVOAntwerpen.DAL.IDal<BLL.LesDavinci>
    {
        public LesDavinci()
        {
            //this.message = "";
        }
        public ProjectMobileCVO.BLL.LesDavinci Select_Lesrooster(int id)
        {
            ProjectMobileCVO.BLL.LesDavinci lesrooster = new BLL.LesDavinci();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_Lesrooster";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        lesrooster.Id = (int)result["Id"];
                        lesrooster.Lesdatum = (DateTime)result["LesDatum"];
                        lesrooster.IdIngerichteModulevariant = (int)result["IdIngerichteModulevariant"];
                        lesrooster.IdPersoneel = (int)result["IdPersoneel"];
                        lesrooster.IdLokaal = (int)result["IdLokaal"];
                        lesrooster.Aanvangsdatum = (DateTime)result["Aanvangsdatum"];
                        lesrooster.Einddatum = (DateTime)result["Einddatum"];
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return lesrooster;
        }
    }   

    //DAL voor Resultaat
    public class PlaatsingResultaat : CVOAntwerpen.DAL.IDal<BLL.PlaatsingResultaat>
    {
        public PlaatsingResultaat()
        {
            //this.message = "";
        }
        public ProjectMobileCVO.BLL.PlaatsingResultaat Select_ResultaatOverzicht(int id)
        {
            ProjectMobileCVO.BLL.PlaatsingResultaat plaatsingResultaat = new BLL.PlaatsingResultaat();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_ResultaatOverzicht";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        plaatsingResultaat.Id = (int)result["Id"];
                        plaatsingResultaat.DatumBijkomendeProef = (DateTime)result["DatumBijkomendeProef"];
                        plaatsingResultaat.DatumUitgesteldeProef1 = (DateTime)result["DatumUitgesteldeProef1"];
                        plaatsingResultaat.DatumuitgesteldeProef2 = (DateTime)result["DatumUitgesteldeProef2"];
                        plaatsingResultaat.OpmerkingNaDeliberatieEersteZit = result["OpmerkingNaDeliberatieEersteZit"].ToString();
                        plaatsingResultaat.OpmerkingNaDeliberatieTweedeZit = result["OpmerkingNaDeliberatieTweedeZit"].ToString();
                        plaatsingResultaat.OpmerkingPunten = result["OpmerkingPunten"].ToString();
                        plaatsingResultaat.PuntenEersteZit = (decimal)result["PuntenEersteZit"];
                        plaatsingResultaat.PuntenEersteZitNaDeliberatie = (decimal)result["PuntenEersteZitNaDeliberatie"];
                        plaatsingResultaat.PuntenPermanenteEvaluatie = (decimal)result["PuntenPermanenteEvaluatie"];
                        plaatsingResultaat.PuntenPermanenteEvaluatieNaDeliberatie = (decimal)result["PuntenPermanenteEvaluatieNaDeliberatie"];
                        plaatsingResultaat.PuntenTotaal = (decimal)result["PuntenTotaal"];
                        plaatsingResultaat.PuntenTweedeZit = (decimal)result["PuntenTweedeZit"];
                        plaatsingResultaat.PuntenTweedeZitNaDeliberatie = (decimal)result["PuntenTweedeZitNaDeliberatie"];
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return plaatsingResultaat;
        }
    }

    //DAL voor Attest
    public class Attest : CVOAntwerpen.DAL.IDal<BLL.Attest>
    {
        public Attest()
        {
            //this.message = "";
        }
        public ProjectMobileCVO.BLL.Attest Select_Attest(int id)
        {
            ProjectMobileCVO.BLL.Attest attest = new BLL.Attest();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_Attest";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        attest.Id = (int)result["Id"];
                        attest.AttestBeschikbaar = result["Attest Beschikbaar"].ToString();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return attest;
        }
    }

    //DAL voor TweedeZit
    public class TweedeZit : CVOAntwerpen.DAL.IDal<BLL.TweedeZit>
    {
        public TweedeZit()
        {
            //this.message = "";
        }
        public ProjectMobileCVO.BLL.TweedeZit Select_TweedeZit(int id)
        {
            ProjectMobileCVO.BLL.TweedeZit tweedeZit = new BLL.TweedeZit();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Select_TweedeZit";
            command.Parameters.Add(new SqlParameter("@Id",
              SqlDbType.Int)).Value = id;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;
            try
            {
                connection.Open();
                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        tweedeZit.Id = (int)result["Id"];
                        tweedeZit.Datum = (DateTime)result["Datum"];
                        tweedeZit.Omschrijving = result["Omschrijving"].ToString();
                        tweedeZit.Resultaat = (decimal)result["Resultaat"];
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return tweedeZit;
        }
        public bool Inschrijven_TweedeZit(DateTime datum,string omschrijving,decimal resultaat)
        {
            ProjectMobileCVO.BLL.TweedeZit tweedeZit = new BLL.TweedeZit();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                 System.Configuration.ConfigurationManager.
                 ConnectionStrings["MobileCVO"].ToString();

            SqlCommand command = new SqlCommand();
            string sqlString = "Inschrijven_TweedeZit";
            command.Parameters.Add(new SqlParameter("@Datum",
              SqlDbType.DateTime)).Value = datum;
            command.Parameters.Add(new SqlParameter("@Omschrijving",
               SqlDbType.NVarChar, 255)).Value = omschrijving;
            command.Parameters.Add(new SqlParameter("@Resultaat",
              SqlDbType.Decimal)).Value = resultaat;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;
            bool test;
            try
            {
                connection.Open();
                test = true;
            }
            catch
            {
                test = false;
            }
            finally
            {
                connection.Close();
            }
            return test;
        }
    }   

    //DAL voor PlaatsingsHystoriek
    //nog niet geimplementeert
}