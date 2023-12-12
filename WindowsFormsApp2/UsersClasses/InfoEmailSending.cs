using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.UsersClasses
{
    internal class InfoEmailSending
    {
        public InfoEmailSending(string smtpClientAdres, StringPair emailAdressForm, string emailPassword, StringPair emailAdressTo, string subject, string body) 
        {
            SmtpClientAdres = String.IsNullOrWhiteSpace(smtpClientAdres) ?
            throw new Exception("Нельзя вставлять пробелы или пустое значение!"):
            smtpClientAdres;

            EmailAdressForm = emailAdressForm ?? throw new ArgumentNullException(nameof(emailAdressForm));

            EmailPassword = String.IsNullOrWhiteSpace(emailPassword) ?
            throw new Exception("Нельзя вставлять пробелы или пустое значение!"):
            emailPassword;

            EmailAdressTo = emailAdressTo ?? throw new ArgumentNullException( nameof(subject));

            Body = body ?? throw new ArgumentNullException(nameof(body));

            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
        }
        public string SmtpClientAdres { get; set; }
        public StringPair EmailAdressForm { get; set; }
        public string EmailPassword { get; set;}
        public StringPair EmailAdressTo { get; set; }
        public string Body { get; set; }    
        public string Subject { get; set; }

    }
    public class StringPair
    {
        public StringPair(string emailAdress, string name)
        {
            EmailAdress = String.IsNullOrWhiteSpace(emailAdress) ?
            throw new Exception("Нельзя всатвлять пробелы или пустое значение!") :
            emailAdress;

            Name = String.IsNullOrWhiteSpace(name) ?
            throw new Exception("Нельзя всатвлять пробелы или пустое значение!") :
            name;
        }
        public string EmailAdress { get; set;}
        public string Name { get; set;}

    }
}
