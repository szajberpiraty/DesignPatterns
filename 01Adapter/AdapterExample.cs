using System;

namespace _01Adapter
{
    public class AdapterExample
    {
        public void Start()
        {
            //legyen egy adatforrásunk és egy email megoldásunk és ezeket kössük össze
            //folytatás a 39 perctől
            //Az adatokat szolgáltatja
            var repo = new AddressRepository();


            var messageServie = new MessageService();
            var addresses = repo.GetAddresses();

            foreach (var address in addresses)
            {
                messageServie.AddMessage(to:address.Email,subject:"valami",text:"üzenet");
            }

           
            messageServie.SendMessages();

        }
    }
}