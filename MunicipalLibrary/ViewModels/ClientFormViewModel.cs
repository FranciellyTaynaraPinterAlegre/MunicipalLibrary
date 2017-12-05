using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MunicipalLibrary.Models;

namespace MunicipalLibrary.ViewModels
{
    public class ClientFormViewModel
    {
        public Client Client { get; set; }
        public string Title
        {
            get
            {
                if (Client != null && Client.Id != 0)
                    return "Editar Cliente";

                return "Novo Cliente";
            }
        }
    }
}
