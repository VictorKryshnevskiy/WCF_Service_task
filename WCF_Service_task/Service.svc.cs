using System;
using System.Text.Json;

namespace WCF_Service_task
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetNumber(int number)
        {
            if (number % 2 != 0 || number == 0)
            {
                return "Введите четное число";
            }
            var num = Math.Pow(number, 2).ToString();
            return JsonSerializer.Serialize(num);
            
        }
    }
}
