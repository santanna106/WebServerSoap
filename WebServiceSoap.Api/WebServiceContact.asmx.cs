using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceSoap.Api.Models;
using WebServiceSoap.Api.Repository;

namespace WebServiceSoap.Api
{
    /// <summary>
    /// Descrição resumida de WebServiceContact
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceContact : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }

        [WebMethod]
        public List<Contact> GetAllContacts()
        {
            Contacts list = new Contacts();
            return list.getList();
        }

        [WebMethod]
        public ResponseModel<string> AddContact (Contact contact)
        {
            ResponseModel<string> response = new ResponseModel<string>();

            Contacts list = new Contacts();
            int qtdRegAnt = list.getList().Count;
            list.AddContact(contact);
            int qtdRegDep = list.getList().Count;
            if (qtdRegDep > qtdRegAnt)
            {
                response.ResultCode = 201;
            } else
            {
                response.ResultCode = 500;
            }

            return response;
        }
    }
}
