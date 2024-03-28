using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Testiki
{
    class json
    {
        static string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public void Sirialize<tipe>(tipe data, string path) //жоская тема, типо типе передает в большеменьше типы данных, дабы дохера раз их не вводить в сериализацию
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(desktop + "\\" + path, json); //чтение текста из файла
            
        }

        public tipe Deserialization<tipe>(string path)
        {
            string json = "";
            try
            {
                json = File.ReadAllText(desktop + "\\" + path);
            }
            catch (Exception)
            {
                File.Create(desktop + "\\" + path).Close();
                json = File.ReadAllText(desktop + "\\" + path);
            }
            tipe data = JsonConvert.DeserializeObject<tipe>(json);
            return data; //возврат значения дата
        }
    }
}
