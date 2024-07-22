using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace GubbSMDotnNet.Controllers.Shared.Video
{
    public class VideoUploadController : Controller
    {
        // GET: VideoUpload
        [HttpPost]
        public IActionResult UploadVideo(HttpWebRequest file)
        {
            if (file != null && file.ContentLength > 0)
            {
                try
                {
                    byte[] fileData;
                    using (var binaryReader = new BinaryReader(file.GetRequestStream()))
                    {
                        fileData = binaryReader.ReadBytes((int)file.ContentLength);
                    }

                    // Create a RestClient and RestRequest
                    RestClient client = new ("https://video.bunnycdn.com/library/274391/videos/5b564acc-3ce3-4eb6-b2dd-de74e48a3db2");
                    var request = new RestRequest(Method.Put.ToString());
                    RestResponse response = client.ExecuteGet(request);


                    request.AddHeader("AccessKey", "85a90fd0-fe78-447f-963ab8cfb34b-cde2-4948");
                    request.AddHeader("Content-Type", "video/quicktime");
                    request.AddParameter("video/quicktime", fileData, ParameterType.RequestBody);

                    // Execute the request
                    response = client.Execute(request);
                    Console.WriteLine(response.Content);

                    // Return a success message
                    ViewBag.Message = "Video uploaded successfully!";
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    ViewBag.Message = "Error: " + ex.Message;
                }
            }
            else
            {
                ViewBag.Message = "No file selected.";
            }

            return View("Index");
        }
    }
}