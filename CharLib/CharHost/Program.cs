using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using CharLib;

namespace CharHost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost host = null;
            try
            {
                //1. set up base address
                Uri baseAddress = new Uri(
                    "http://localhost:8000/CharacterService");
                //2. create service host
                host = new ServiceHost(
                    typeof(CharacterService), baseAddress);

                //3. bind an endpoint to the service host
                //   Add a service endpoint
                host.AddServiceEndpoint(
                    typeof(ICharacterService),
                    new WSHttpBinding(),
                    "myCharacterService");
                //allow metadata
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                //enable metatdata for the client
                smb.HttpGetEnabled = true;
                //add the behavior to this service host
                host.Description.Behaviors.Add(smb);
                //5. start the service
                host.Open();
                //display
                Console.WriteLine("\nCharacter Service is running at: \n {0}", baseAddress);

            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("\n" + ce.Message);

            }
            finally
            {
                Console.ReadLine(); //pause
                if (host != null) host.Close();
            }

        }
    }
}
