using System;
using System.Collections.Generic;

namespace Diy_Project.Models
{
    public partial class Service
    {
        public Service()
        {
      
        }

        public Service(int iD, string providerName, string serviceType, string description, decimal callOutFee, int userID)
        {
            ID = iD;
            ProviderName = providerName;
            ServiceType = serviceType;
            Description = description;
            CallOutFee = callOutFee;
            UserID = userID;
        }

        public int ID { get; set; }
        public string ProviderName { get; set; }
        public string ServiceType{ get; set; }
        public string Description { get; set; }
        public decimal CallOutFee { get; set; }
        public int UserID { get; set; }

  
    }
}