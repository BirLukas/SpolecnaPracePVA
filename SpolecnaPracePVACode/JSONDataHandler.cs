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
        public void SaveToJson(Cocktail drink) // metoda pro uložení do JSON
        {
            if (!Directory.Exists(_dataPath)) // pokud neexistuje složka data, vytvoří ji
            {
                Directory.CreateDirectory(_dataPath);
            }
            if(File.Exists(_filePath)) // pokud existuje soubor, přepíše ho
            {
                File.Delete(_filePath);
            }
        }
        public Cocktail LoadFromJson(string filePath) // metoda pro načtení z JSON
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Cocktail>(json);
        }
    }
}
