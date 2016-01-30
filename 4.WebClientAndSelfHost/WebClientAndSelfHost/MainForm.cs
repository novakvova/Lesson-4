using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web;

namespace WebClientAndSelfHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //GEt запи на сервер
        private void btnTestServer_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://localhost:8889/api/my";
                url += "?lastname=" + txtLastName.Text;
                url += "&firstname=" + txtFirstName.Text;
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                MessageBox.Show("Status code "+((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                MessageBox.Show(responseFromServer);
                //Console.WriteLine(responseFromServer);
                // Clean up the streams and the response.
                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                //Console.WriteLine("[Done]");
                //Console.ReadLine();
            }
        }

        private void btnSendRequestPost_Click(object sender, EventArgs e)
        {
            try
            {

                string lasrname = txtFirstNamePost.Text;//// txtLastName.Text;
                string firstname = txtLastNamePost.Text;// txtFirstName.Text;
                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = "user=" + lasrname + "&password=" + firstname;
                byte[] data = encoding.GetBytes(postData);
                WebRequest request = WebRequest.Create("http://localhost:100/TestPost.php");
                //WebRequest request = WebRequest.Create("http://localhost:8889/api/my");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                Stream st = request.GetRequestStream();
                st.Write(data, 0, data.Length);
                st.Close();
                WebResponse response = request.GetResponse();

                MessageBox.Show("Status code " + ((HttpWebResponse)response).StatusDescription);
                st = response.GetResponseStream();
                StreamReader sr = new StreamReader(st);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
                st.Close();
            //    HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8889/api/my");
            //httpWebRequest.Method = "POST";
            //httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            //string postData = "lastname=123421";
            //Encoding encoding = Encoding.UTF8;
            //byte[] byte1 = encoding.GetBytes(postData);
            //httpWebRequest.ContentLength = byte1.Length;
            //Stream st = httpWebRequest.GetRequestStream();
            //    byte[] bufer;
            //    st.Read(bufer, byte1.Length, byte1.Length);
            //    MessageBox.Show(e)
            //st.Length;
            //var responseString = new StreamReader(httpWebRequest.Get.GetResponseStream()).ReadToEnd();
			//Stream st=httpWebRequest.GetRequest;
            //MessageBox.Show(st.Re);
                //var request = (HttpWebRequest)WebRequest.Create("http://localhost:8889/api/my");

                //var postData = "lastname=hello";
                //postData += "&firstname=world";
                //var data = Encoding.Unicode.GetBytes(postData);

                //request.Method = "POST";
                //request.ContentType = "application/x-www-form-urlencoded";
                //request.ContentLength = data.Length;

                //using (var stream = request.GetRequestStream())
                //{
                //    stream.Write(data, 0, data.Length);
                //}

                //var response = (HttpWebResponse)request.GetResponse();

                //var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                //MessageBox.Show(responseString);

                //string url = "http://localhost:8889/api/my";
                ////url += "?lastname=" + txtLastName.Text;
                ////url += "&firstname=" + txtFirstName.Text;
                //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                //request.Method = "POST";
                //// If required by the server, set the credentials.
                //request.Credentials = CredentialCache.DefaultCredentials;
                //// Get the response.
                //WebResponse response = request.GetResponse();
                //// Display the status.
                ////Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                //// Get the stream containing content returned by the server.
                //Stream dataStream = response.GetResponseStream();
                //// Open the stream using a StreamReader for easy access.
                //StreamReader reader = new StreamReader(dataStream);
                //// Read the content.
                //string responseFromServer = reader.ReadToEnd();
                //// Display the content.
                //MessageBox.Show(responseFromServer);
                ////Console.WriteLine(responseFromServer);
                //// Clean up the streams and the response.
                //reader.Close();
                //response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("[Done]");
                Console.ReadLine();
            }
        }
        private void SubmitData()
        {
            try
            {
                string user = "sdfsadf";
                string pass = "asdfasdf";

                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = "user=" + user + "&pass=" + pass;
                byte[] data = encoding.GetBytes(postData);

                WebRequest request = WebRequest.Create("http://charnycoding.info/WebRequestPOST.php");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                WebResponse response = request.GetResponse();
                stream = response.GetResponseStream();

                StreamReader sr = new StreamReader(stream);
                MessageBox.Show(sr.ReadToEnd());

                sr.Close();
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private string HttpPostRequest(string url, Dictionary<string, string> postParameters)
        {
            //Dictionary<string, string> postParameters = new Dictionary<string, string>();
            //postParameters.Add("lastname", "vova");
            //string result = HttpPostRequest("http://localhost:8889/api/my", postParameters);
            //MessageBox.Show(result);
            string postData = "";

            foreach (string key in postParameters.Keys)
            {
                postData += HttpUtility.UrlEncode(key) + "="
                      + HttpUtility.UrlEncode(postParameters[key]) + "&";
            }

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            myHttpWebRequest.Method = "POST";

            byte[] data = Encoding.ASCII.GetBytes(postData);

            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = data.Length;

            Stream requestStream = myHttpWebRequest.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            Stream responseStream = myHttpWebResponse.GetResponseStream();

            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);

            string pageContent = myStreamReader.ReadToEnd();

            myStreamReader.Close();
            responseStream.Close();

            myHttpWebResponse.Close();

            return pageContent;
        }
    }
}
