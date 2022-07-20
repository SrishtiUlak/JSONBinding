using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONBinding
{
    public class Item
    {
        public int item_id { get; set; }
        public string item_name { get; set; }
        public double item_price { get; set; }
        public int category_id { get; set; }
        public string kot_print { get; set; }
        public string applicable_time_period { get; set; }
        public string image_color { get; set; }
        public double item_cost_price { get; set; }
        public string image_name { get; set; }
        public double discount { get; set; }
        public string barcode { get; set; }
        public int category_id1 { get; set; }
        public string category_name { get; set; }
        public string category_color { get; set; }
        public string applicable_time { get; set; }
        public int id { get; set; }
        private readonly string _path = $"D:\\Smtech\\JSON\\JSONBinding\\JSONBinding\\JSONFile\\item.json";
        public List<Item> GetList()
        {
            string jsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                jsonFromFile = reader.ReadToEnd();
            }
            if (jsonFromFile != null)
            {
                List<Item> itemlist = JsonConvert.DeserializeObject<List<Item>>(jsonFromFile);
                return itemlist;
            }
            return null;
        }

    }




}
