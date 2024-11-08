using Specification;
using System.Collections.Generic;
using POCO;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace BinaryDataRepository
{
    public class BinaryRepository : IDataRepository
    {
        public bool Serialize(string filename, List<Product> products)
        {
            bool status = false;

            /// code for saving
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);
            formatter.Serialize(stream, products);
            stream.Close();

            return status;
        }

        public List<Product> Deserialize(string filename)
        {
            List<Product> products = new List<Product>();

            // retrive all products from file
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filename, FileMode.Open);
            if(stream!=null)
            {
                products = (List<Product>) formatter.Deserialize(stream);
            }

            stream.Close();

            return products;
        }
    }
}
