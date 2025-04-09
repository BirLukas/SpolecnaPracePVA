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

        // TODO: p�idat t��du pro na��t�n� a ukl�d�n� z JSON souboru
        // Zalamov�n� textu instrukc�

        /*public class DrinkLoader
        {
            public static Drink LoadFromJson(string filePath)
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<Drink>(json);
            }
        }*/
        private async void UpdateInfo() // na�te n�hodn� koktejl a aktualizuje informace
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

            LoadImageFromUrl(CocktailImage, imageUrl); // zm�n�n� obr�zku
        }
        private void LoadImageFromUrl(PictureBox pictureBox, string url) // metoda pro na�ten� obr�zku z url
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
                MessageBox.Show($"Chyba p�i na��t�n� obr�zku: {ex.Message}");
            }
        }
        private void NewCocktailBtn_Click(object sender, EventArgs e) // metoda na kliknut� na tla��tko
        {
            //var drink = DrinkLoader.LoadFromJson("sample_drink.json");

            UpdateInfo();

            //CocktailImage.ImageLocation = drink.ImageUrl;

        }
    }
}
