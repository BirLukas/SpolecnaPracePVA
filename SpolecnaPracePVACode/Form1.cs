using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.LinkLabel;

namespace SpolecnaPracePVACode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*public class DrinkLoader
        {
            public static Drink LoadFromJson(string filePath)
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<Drink>(json);
            }
        }*/
        private void NewCocktailBtn_Click(object sender, EventArgs e)
        {
            //var drink = DrinkLoader.LoadFromJson("sample_drink.json");

            NameLabel.Text = $"Name: BombardinoCrocodilo{null}";
            GlassLabel.Text = $"Glass: Shot glass{null}";
            CategoryLabel.Text = $"Category: Shot{null}";
            AlcoholicLabel.Text = $"Alcoholic: Alcoholic{null}";
            IngredientsLabel.Text = $"Ingredients: Rum, whiskey, Cola, Lemon{null}";
            InstructionsLabel.Text = $"Put the listet ingredients in glass and slightly mix{null}";

            //CocktailImage.ImageLocation = drink.ImageUrl;

        }
    }
}
