using System.Collections.Generic;
using System.Data.SqlClient;

namespace IntelligentKioskSample.Model
{
    public class WorkerDataHelper
    {
        public WorkerDataHelper() { }

        public List<PactWorker> Initialise()
        {
            //if the name created on the ADmin portal matches the dummmy data it will link the face with this data (simulation of hooking it up to an existing AD
            List<PactWorker> list = new List<PactWorker>();

            /*try
            {
                string connectionString = "Server=tcp:pactserver.database.windows.net,1433;Initial Catalog=PactDB;Persist Security Info=False;User ID=PactAdmin;Password=P4ssw0rd!1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                System.Data.SqlClient.SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();

                string command = "select * from Workers";

                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(command,
                                                         myConnection);
                myReader = myCommand.ExecuteReader();

                
               
                while (myReader.Read())
                {
                    
                    list.Add(new PactWorker(myReader["Name"].ToString(), myReader["Role"].ToString(), myReader["MobileNo"].ToString(), (int)myReader["AuthLevel"], (int)myReader["SafetyInfringements"], "Unlimited object access"));

                }



                return list;
            }
            catch
            {*/
                //other
                list.Add(new PactWorker("Bec Lyons", "Floor Admin", "0430054104", 3, 0, "Unlimited object access"));
                list.Add(new PactWorker("Jacob Laurence", "Productivity Solutions Specialist", "01409831689", 3, 0, "Unlimited object access."));
                list.Add(new PactWorker("Jamie Hutchins", "SSP", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Michael Ross", "Pact Group CIO", "123456789", 3, 0, "Unauthorised to use objects"));

                list.Add(new PactWorker("James Riley", "InnovationAus", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Chris Griffith", "The Australian", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Rohan Pearce", "Computerworld", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Amanda Woodard", "HR Monthly", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Fergus Halliday", "PC World", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Ben Mansill", "PC and Tech Authority", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Riordan Lee", "Techly", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Andrew Walker", "Techly", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("David Frith", "Computer Daily News", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Richard van der Draay", "Telecom Times", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Shannon Connellan", "Mashable", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Anthony Fordham", "Popular Science", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Leon Spencer", "ARN", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Steven Kiernan", "Next Media", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Tasnuva Bindi", "ZDNet", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Michael Bailey", "Australian Financial Review", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Patrick Martlew", "TechDay", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Stephen Fenech", "TechGuide", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Jane Nicholls", "Qantas Media", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Alison Boleyn", "Qantas Media", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Beverley Head", "Media", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Anna Connel", "Newsroom", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Nadia Daley", "ABC", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Libby-Jane Charleston", "HuffPost", "123456789", 1, 0, "Unauthorised to use objects"));
                list.Add(new PactWorker("Susan Edmunds", "Stuff.co.nz", "123456789", 1, 0, "Unauthorised to use objects"));

                return list;
            
           
        }
    }
}
