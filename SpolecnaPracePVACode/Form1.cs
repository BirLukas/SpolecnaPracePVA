using System.Net;
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
        private APIHandler _APIHandler = new APIHandler();

        // TODO: pøidat tøídu pro naèítání a ukládání z JSON souboru
        // Zalamování textu instrukcí

        /*public class DrinkLoader
        {
            public static Drink LoadFromJson(string filePath)
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<Drink>(json);
            }
        }*/
        private async void UpdateInfo() // naète náhodný koktejl a aktualizuje informace
        {
            Cocktail cocktail = await _APIHandler.GetRandomCocktail();
            string name = cocktail.strDrink;
            string glass = cocktail.strGlass;
            string category = cocktail.strCategory;
            string alcoholic = cocktail.strAlcoholic;
            string instructions = cocktail.strInstructions;
            string imageUrl = cocktail.strDrinkThumb + "/small";
            List<string> ingredients = cocktail.GetIngredients();

            NameLabel.Text = $"Name: {name}";
            GlassLabel.Text = $"Glass: {glass}";
            CategoryLabel.Text = $"Category: {category}";
            AlcoholicLabel.Text = $"Alcoholic: {alcoholic}";
            IngredientsLabel.Text = "Ingredients: ";
            foreach (string ingredient in ingredients)
            {
                IngredientsLabel.Text += $"{ingredient},";
            }
            InstructionsLabel.Text = instructions;

            LoadImageFromUrl(CocktailImage, imageUrl); // zmìnìní obrázku
        }
        private void LoadImageFromUrl(PictureBox pictureBox, string url) // metoda pro naètení obrázku z url
        {
            try
            {
                WebClient webClient = new WebClient();
                byte[] imageData = webClient.DownloadData(url);
                using (MemoryStream stream = new MemoryStream(imageData))
                {
                    pictureBox.Image = Image.FromStream(stream);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pøi naèítání obrázku: {ex.Message}");
            }
        }
        private void NewCocktailBtn_Click(object sender, EventArgs e) // metoda na kliknutí na tlaèítko
        {
            //var drink = DrinkLoader.LoadFromJson("sample_drink.json");

            UpdateInfo();

            //CocktailImage.ImageLocation = drink.ImageUrl;

        }
    }
}
