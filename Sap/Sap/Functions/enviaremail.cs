using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Net.Configuration;
using System.Net;
using System.Collections;
namespace Sap.Functions
{
    class enviaremail
    {
    public static string  enviar (string destinatario,string remetente,string assunto, string message, ArrayList anexos)
    { try 
    { verificar verificar = new verificar();
     bool vemail = verificar.isemail(destinatario);
      if (vemail == false)
      { return "destinatário invalido, por favor revise seu formulário"; }

     MailMessage email = new MailMessage(destinatario,remetente,assunto,message);

     foreach(string anexo in anexos)
     {
     Attachment anexado = new Attachment(anexo, MediaTypeNames.Application.Octet);
     email.Attachments.Add(anexado);
     }
     SmtpClient cliente =new  SmtpClient("smtp.gmail.com", 587);
     cliente.EnableSsl = true;
     NetworkCredential cred = new NetworkCredential("bitbeast00k7@gmail.com", "98847685bit");
     cliente.Credentials = cred;
                cliente.UseDefaultCredentials = true;
                cliente.Send(email);

                return "mensagem enviada para"+destinatario+"ás"+DateTime.Now.ToString()+".";

    }
    catch(Exception)
            {
                return "erro, porfavor revise seu formulário";
            }

    }
        public static string enviarsemanexo(string destinatario, string remetente, string assunto, string message)
        {
            try
            {
                verificar verificar = new verificar();
                bool vemail = verificar.isemail(destinatario);
                if (vemail == false)
                { return "destinatário invalido, por favor revise seu formulário"; }

                MailMessage email = new MailMessage(destinatario, remetente, assunto, message);

                
                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.EnableSsl = true;
                NetworkCredential cred = new NetworkCredential("bitbeast00k7@gmail.com", "98847685bit");
                cliente.Credentials = cred;
                cliente.UseDefaultCredentials = true;
                cliente.Send(email);

                return "mensagem enviada para" + destinatario + "ás" + DateTime.Now.ToString() + ".";

            }
            catch (Exception)
            {
                return "erro, porfavor revise seu formulário";
            }

        }



    }
}
