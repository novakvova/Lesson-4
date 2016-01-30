using System;
using System.IO;
using System.Net;
using System.Text;

namespace WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(
              "http://localhost:8889/api/my?name=petro");
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
                // Clean up the streams and the response.
                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("[Done]");
                Console.ReadLine();
            }
        }
    }
}
