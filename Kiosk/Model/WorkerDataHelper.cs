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

            //TODO Implement with own data rather than dummy data 
            /*try
            {
                string connectionString = "";
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
                //dummy data 
            list.Add(new PactWorker("Bec Lyons", "Floor Admin", "0430054104", 3, 0, "Unlimited room and object access"));
            list.Add(new PactWorker("User 2", "Worker", "123456789", 2, 0, "Authorized to be in room only"));
            list.Add(new PactWorker("User 3", "Worker", "123456789", 1, 0, "Not authorized to be in the room"));


            return list;
            
           
        }
    }
}
