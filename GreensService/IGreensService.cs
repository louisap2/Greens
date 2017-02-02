using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GreensService
{
    [ServiceContract]
    public interface IGreensService
    {
        [OperationContract]
        GreensPrice ConvertDataToGreensPrice(string name, int price);
    }
    
    [DataContract]
    public class GreensPrice
    {
        [DataMember]
        public int Price { get; set; }
        
        string stringValue = "Hello ";

        [DataMember]
        public string Name { get; set; }
    }
}
