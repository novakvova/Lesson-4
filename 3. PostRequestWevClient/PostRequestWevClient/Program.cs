using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace PostRequestWevClient
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    //    public ICollection<Friend> Friends { get; set; }
    }
    //public class Friend
    //{
    //    public string Name { get; set; }
    //    public bool IsOnTwitter { get; set; }
    //    public string TwitterName { get; set; }
    //}
    public static class JsonHelper
    {
        public static string ToJson<T>(T instance)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var tempStream = new MemoryStream())
            {
                serializer.WriteObject(tempStream, instance);
                return Encoding.Default.GetString(tempStream.ToArray());
            }
        }

        public static T FromJson<T>(string json)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var tempStream = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                return (T)serializer.ReadObject(tempStream);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.FirstName = "Vova";
            //p.LastName = "Novak";
            ////Friend f = new Friend() { Name = "Peter", IsOnTwitter = false };
            ////p.Friends.Add(f);
            //string url = "http://localhost:8889/api/my";
            //var json = JsonHelper.ToJson(p);

            //string response = PostJson(url, json);
            //Console.WriteLine(response);
            //создание объекта web-клиент 
            WebClient client= new WebClient();
            string TextToUpload = "FirstName=Vasia&LastName=okna", urlString = "http://localhost:8889/api/my";
            // Преобразуем текст в массив байтов 
            byte[] uploadData = Encoding.Unicode.GetBytes(TextToUpload);
            byte[] result = client.UploadData(urlString, "Get", uploadData);
            string text = Encoding.Unicode.GetString(result);
            Console.WriteLine(text);
            //string reply = client.UploadString(urlString, "POST", uploadData);
            // связываем URL с потоком записи 
           // Stream upload = client.OpenWrite(urlString, "POST");
            // загружаем данные на сервер 
            //upload..Write(uploadData, 0, uploadData.Length);
           // upload.Close();
            //WebClient clientUp = new WebClient();
            ////WebClient client= new WebClient(); 
            //clientUp.Credentials = System.Net.CredentialCache.DefaultCredentials;
            //// добавляем HTTP-заголовок 
            //clientUp.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //// Преобразуем текст в массив байтов 
            //// копируем данные методом GET 
            //byte[] respText = client.UploadData(urlString, "GET", uploadData);
            //// загружаем данные на сервер 
            //upload.Write(uploadData, 0, uploadData.Length);
            //upload.Close(); 
        }
        public static string PostJson(string url, string data)
        {
            var bytes = Encoding.Default.GetBytes(data);

            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type", "application/json");
                var response = client.UploadData(url, "POST", bytes);

                return Encoding.Default.GetString(response);
            }
        }
    }
}
