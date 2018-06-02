using Classes.LIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            service.BookAddService();

            ServiceSoap soap = new ServiceSoap();
            //soap.SoapSerialize();
            soap.PersonService();
        }
    }
}
