using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Poller.Controllers
{
    public class MessagePollController : ApiController
    {
        List<string> content;
        List<string> formats;

        public MessagePollController()
        {
            content = new List<string>
            {
                "New Message 1",
                "MESSAGE",
                "When you hire people who are smarter than you are, you prove you are smarter than they are.",
                "Repetition is the reality and the seriousness of life.",
                "I envy that man who passes through life safely, to the world and fame unknown.",
                "The cost of a thing is that amount of life which must be exchanged for it.",
                "Life is what happens to you when you’re making other plans.",
                "It matters not how long you live, but how well.",
                "No nation ever had an army large enough to guarantee it against attack in time of peace or insure it victory in time of war.",
                "Sin, guilt, neurosis-they are one and the same, the fruit of the tree of knowledge.",
                "One way to get the most out of life is to look upon it as an adventure."
            };

            formats = new List<string>
            {
                "<p>{0}</p>",
                "<p><strong>{0}</p></strong>"
            };
        }

        public HttpResponseMessage Get()
        {
            Random r = new Random();

            int numberOfMessages = r.Next(5, 11);

            List<PollingData> data = new List<PollingData>();

            for(int i = 0; i < numberOfMessages; i++)
            {
                int format = r.Next(0, 100) < 50 ? 0 : 1;
                int entry = r.Next(0, 10);

                data.Add(new PollingData
                {
                    content = string.Format(formats[format], content[entry])
                });
            }

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }

    public class PollingData
    {
        public string content { get; set; }
    }
}
