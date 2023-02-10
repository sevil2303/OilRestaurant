using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class FileHelper
    {
        public void Write(decimal total)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("foodtotal.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, total);
                }
            }
        }
        public decimal Read(string filename)
        {
            decimal total = 0;
            try
            {
                var context = File.ReadAllText(filename);
                total = JsonConvert.DeserializeObject<decimal>(context);
            }
            catch (Exception)
            {

            }
            return total;
        }
        public void WriteInvoice(string total)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("invoice.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, total);
                }
            }
        }
    }
}
