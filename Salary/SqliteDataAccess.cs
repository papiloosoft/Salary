using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Salary
{
    public class SqlliteDataAccess
    {

        public static string LoadConectionString(string id = "Default")
        {

            return ConfigurationManager.ConnectionStrings[id].ConnectionString;


        }


        public static List<CityModel> LoadCity()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {

                var output = cnn.Query<CityModel>("select * from City", new DynamicParameters());
                return output.ToList();
            }

        }

        public static List<CityModel> LoadCity(string city,string type)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {

                var output = cnn.Query<CityModel>("select * from " + type + " where Name like'%" + city + "%' order by Code" , new DynamicParameters());
                return output.ToList();
            }

        }


    

        public static List<PersonModel> LoadPerson()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {

                var output = cnn.Query<PersonModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }

        }

        public static void SavePerson(PersonModel p)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {


                //cnn.Execute("insert into Person  (Name,Family,Address,BakhshSodor,BankCard,BankName,Banknum,BimeNum,Branch,Child,CityCodeSodor,CitySodor,CityTavalod,CityTavalodCode,CodeTell,CountryTavalod,CountryTavalodCode,Doc,Education,Email,EmpCode,EmpMSh1,EmpMSh2,FatherName,Job,JobCode,JobDate,JobNum,Married,Mobile,National,@NationalCode,Pic,Post,Sex,TavalodDate,Tell,UniverCity,YearEducation) values " +
                //"(@Name,@Family,@Address,@BakhshSodor,@BankCard,@BankName,@Banknum,@BimeNum,@Branch,@Child,@CityCodeSodor,@CitySodor,@CityTavalod,@CityTavalodCode,@CodeTell,@CountryTavalod,@CountryTavalodCode,@Doc,@Education,@Email,@EmpCode,@EmpMSh1,@EmpMSh2,@FatherName,@Job,@JobCode,@JobDate,@JobNum,@Married,@Mobile,@National,@NationalCode,@Pic,@Post,@Sex,@TavalodDate,@Tell,@UniverCity,@YearEducation)", p);


                //cnn.Execute("insert into Person (Name,Family,BimeNum,EmpCode,FatherName,NationalCode,EmpShSh,EmpMSh1,EmpMSh2,CitySodor,CityCodeSodor,BakhshSodor,CityTavalod,CityTavalodCode,CountryTavalod,CountrTavalodCode,TavalodDate,Job,JobCode,Sex,Married,Child,National,Education,Branch,UniverCity,YearEducation,Tell,CodeTell,Mobile,Email,Address,Post,JobNum,JobDate,BankName,Banknume,BankCard,Pic)" +
                //                       " values (@Name,@Family,@BimeNum,@EmpCode,@FatherName,@NationalCode,@EmpShSh,@EmpMSh1,@EmpMSh2,@CitySodor,@CityCodeSodor,@BakhshSodor,@CityTavalod,@CityTavalodCode,@CountryTavalod,@CountrTavalodCode,@TavalodDate,@Job,@JobCode,@Sex,@Married,@Child,@National,@Education,@Branch,@UniverCity,@YearEducation,@Tell,@CodeTell,@Mobile,@Email,@Address,@Post,@JobNum,@JobDate,@BankName,@Banknume,@BankCard,@Pic)", p);

                cnn.Execute("insert into Person (Name,Family) values (@Name,@Family)", p);
            }
        }

        public static void EditPerson(PersonModel person)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {
                cnn.Execute("update Person set Name=@Name, Family=@Family, BimeNum=@BimeNum " +
                            ",EmpCode=@EmpCode, FatherName=@FatherName, NationalCode=@NationalCode," +
                            " EmpShSh=@EmpShSh, EmpMSh1=@EmpMSh1, EmpMSh2=@EmpMSh2, CitySodor=@CitySodor, CityCodeSodor=@CityCodeSodor" +
                            ",BakhshSodor=@BakhshSodor, CityTavalod=@CityTavalod, CityTavalodCode=@CityTavalodCode," +
                            "CountryTavalod=@CountryTavalod, CountryTavalodCode=@CountryTavalodCode,TavalodDate=@TavalodDate, Job=@Job," +
                            "JobCode=@JobCode, Sex=@Sex, Married=@Married, Child=@Child, National=@National," +
                            "Education=@Education, Branch=@Branch,  UniverCity=@UniverCity,YearEducation=@YearEducation," +
                            "Tell=@Tell, CodeTell=@CodeTell, Mobile=@Mobile, Email=@Email, Address=@Address, Post=@Post," +
                            "JobNum=@JobNum, JobDate=@JobDate, BankName=@BankName, Banknum=@Banknum, BankCard=@BankCard," +
                            "Pic=@Pic where ID=@ID", person);


            }

        }

        public static void DeletePerson(PersonModel p)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {

                cnn.Execute("delete from Person where ID=@ID ", p);


            }

        }

        public static List<EducationModel> LoadEducation()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {

                var output = cnn.Query<EducationModel>("select * from Education", new DynamicParameters());
                return output.ToList();
            }

        }

        public static void SaveHokm(HokmModel p)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {


                cnn.Execute("insert into Hokm (Name,Price,PersonID) values (@Name,@Price,@PersonID)", p);
            }
        }

        public static List<HokmModel> LoadHokme()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {

                var output = cnn.Query<HokmModel>("select * from Hokm ", new DynamicParameters());
                return output.ToList();
            }

        }

        public static void DeleteHokm(HokmModel p)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {

                cnn.Execute("delete from Hokm where ID=@ID ", p);


            }

        }


        public static  List<TypeSalaryModel> LoadType()
        {
            using (IDbConnection cnn=new SQLiteConnection(LoadConectionString()))
            {

                var output = cnn.Query<TypeSalaryModel>("select * from TypeSalary", new DynamicParameters());
                return output.ToList();

            }
        }

        public static void SaveType(TypeSalaryModel t)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConectionString()))
            {
                cnn.Execute("insert into TypeSalary (Name) values (@Name)", t);
            }
        }

        public static void DeleteType(TypeSalaryModel t)
        {
            using(IDbConnection cnn=new SQLiteConnection(LoadConectionString()))
            {
                cnn.Execute("delete from TypeSalary where ID=@ID", t);
            }
        }

    }
}
