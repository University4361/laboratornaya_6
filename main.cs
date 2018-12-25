using System; 
using System.Collections.Generic; 
using System.Text; 
using NetMail; 
using NetMail.Init; 
using NetMail.Configuration; 

namespace MailTask 
{ 
  class Program 
  { 
    static void Main(string[] args) 
    { 
      var configs = ConfigureMailService(args); 
      var @params = StartService(configs); 
      SendMailsToDestination(@params); 
    } 

    private static void SendMailsToDestination(object @params) 
    { 
      MailManager.SendMails(@params); 
    } 

    private static object StartService(object configs) 
    { 
      return ConfigurationManager.InitilizeServices(configs); 
    } 

    private static object ConfigureMailService(string[] args) 
    { 
      return MailService.ConfigureTerminal(args); 
    } 
  } 
}
