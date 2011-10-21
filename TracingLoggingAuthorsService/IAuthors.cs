using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TracingLoggingAuthorsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAuthors
    {
        [OperationContract]
        Author Getauthors();
    }

    [DataContract]
    public class Author
    {
        [DataMember]
        public string ProjectName;

        [DataMember]
        public string GroupName;
    } 
    // Use a data contract as illustrated in the sample below to add composite types to service operations
   
}
