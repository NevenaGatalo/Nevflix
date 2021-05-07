using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Nevflix
{
    class BinarniFajl
    {
        public void Serialize(object objekat, FileStream file)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, objekat);
                return;
            }
            catch
            {
                throw new Exception("Fajl ne postoji!");
            }
            finally
            {
                file.Close();
            }
        }
        public User Deserialize(FileStream file)
        {
            try
            {
                User o = null;
                BinaryFormatter bf = new BinaryFormatter();
                o = (User)bf.Deserialize(file);
                if (o == null)
                    throw new Exception("Fajl nije dobro napisan");
                return o;
            }
            catch
            {
                throw new Exception("Fajl ne postoji!");
            }
            finally
            {
                file.Close();
            }
        }
    }
}
