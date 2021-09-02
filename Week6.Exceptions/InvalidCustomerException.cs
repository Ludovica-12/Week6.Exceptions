using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Exceptions
{
    [Serializable]
    public class InvalidCustomerException : Exception
    {
        public InvalidCustomerException()
        {

        }
        public InvalidCustomerException(Customer customer, string message)
            :base(message)
        {
            Customer = customer;
        }
        public InvalidCustomerException(string message, Exception innerException)
            :base(message, innerException)
        {

        }

        protected InvalidCustomerException(SerializationInfo info, StreamingContext context)
            :base(info, context)
        {

        }

        public Customer Customer { get; set; }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
