using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace do_an_tin_hoc_6tr.Fdatabase
{
    class AddList<T>
    {
        public bool SaveFile(List<T> list, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, list);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<T> Load(string path)
        {
            List<T> list = new List<T>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                list = data as List<T>;
                fs.Close();
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}