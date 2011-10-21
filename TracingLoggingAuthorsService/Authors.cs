using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace TracingLoggingAuthorsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Authors : IAuthors
    {
        public Author Getauthors()
        {
            Thread.Sleep(10000);
            Author au = new Author();
            au.ProjectName = "Chat Application";
            au.GroupName = "Cao Tran Trong Nghia";
            return au;
        }
    }
}
