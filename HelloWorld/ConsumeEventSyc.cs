using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Net;  
using System.Text;
using HelloWorldApi.Models;
 
namespace HelloWorld
{
    class ConsumeEventSyc
    {
        public void GetAllEventData() //Get All Events Records  
        {  
            using(var client = new WebClient()) //WebClient  
            {  
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:51642/api/values"); //URI
  
                Console.Write(Environment.NewLine + result);
                Console.Read();
            }  
        }  
    }
}
