using System;
using System.Collections.Generic;

namespace _01Adapter
{
    public class MessageService
    {
        private List<Message> messages=new List<Message>();

        public MessageService()
        {
        }

        public void AddMessage(string to, string subject, string text)
        {
            messages.Add(new Message {To=to,Subject=subject,Text=text });
        }

        public void SendMessages()
        {
            foreach (var message in messages)
            {
                Console.WriteLine("{0},{1},{2}",message.To,message.Subject,message.Text);
            }
        }
    }
}