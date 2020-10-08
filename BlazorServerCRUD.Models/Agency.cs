using System;

namespace BlazorServerCRUD.Models
{
    public class Agency
    {
        public int AgencyID {get; set;}

        public int AgencyNumber {get; set;}

        public string AgencyName {get; set;}

        public Address AgencyAdress {get; set;}

        public int Agencyphone {get; set;}
        
        public int Agencyfax {get; set;}

    }
}