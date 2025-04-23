using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Windows.Forms.LinkLabel;

namespace SpolecnaPracePVACode
{
    internal class JSONDataHandler
    {
        private string _dataPath;
        private string _filePath;

        public JSONDataHandler()
        {
            _dataPath = Directory.GetCurrentDirectory() + @"\data"; // cesta ke složce
            _filePath = Path.Combine(_dataPath, "cocktail.json"); // cesta k souboru

        } 
        public void SaveToJson(string idDrink)
        {
            if (!Directory.Exists(_dataPath)) // pokud neexistuje složka data, vytvoří ji
            {
                Directory.CreateDirectory(_dataPath);
            }
            if(File.Exists(_filePath)) // pokud existuje soubor, přepíše ho
            {
                File.Delete(_filePath);
            }
            string json = JsonConvert.SerializeObject(idDrink, Formatting.Indented); // serializace do JSON

            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                writer.Write(json); // zápis do souboru
            }
        }
        public string LoadFromJson()
        {
            if (!File.Exists(_filePath))
            {
                return "11007";
            }

            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<string>(json); // odstraní uvozovky
        }

    }
}
