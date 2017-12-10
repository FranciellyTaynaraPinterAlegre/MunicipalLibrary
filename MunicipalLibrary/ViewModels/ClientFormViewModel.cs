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
                {
                    return "Editar Cliente";
                }
                else
                {
                    return "Novo Cliente";
                }
            }
        }
        public IEnumerable<CivilState> CivilState { get; set; }
        public IEnumerable<Sex> Sex { get; set; }

        public ClientFormViewModel() : base()
        {
            CivilState = new List<CivilState>() {
                Models.CivilState.Divorced,
                Models.CivilState.Married,
                Models.CivilState.Single,
                Models.CivilState.Widowed
            };
            Sex = new List<Sex>()
            {
                Models.Sex.Feminine,
                Models.Sex.Masculine,
                Models.Sex.Other
            };
        }
    }
}
