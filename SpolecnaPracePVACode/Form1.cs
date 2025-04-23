using System.Diagnostics;
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
            OnLoad();
        }
        private APIHandler _APIHandler = new APIHandler();
        private JSONDataHandler _jsonhandler = new JSONDataHandler();

        // TODO Zalamov�n� textu instrukc�

        private void UpdateInfo(Cocktail cocktail) // na�te n�hodn� koktejl a aktualizuje informace
        {
            
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
            _jsonhandler.SaveToJson(cocktail.idDrink);
        }
        private async Task<Cocktail> GetRandomDrink()
        {
            Cocktail cocktail = await _APIHandler.GetRandomCocktail();
            return cocktail;
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
            Task.Run(async () =>
            {
                Cocktail cocktail = await GetRandomDrink();
                Invoke(new Action(() => UpdateInfo(cocktail)));
            });
        }
        private void OnLoad()
        {
            Task.Run(async () =>
            {
                string cocktailId = _jsonhandler.LoadFromJson();
                Cocktail cocktail = await _APIHandler.SearchCocktailByID(_jsonhandler.LoadFromJson());
                Invoke(new Action(() => UpdateInfo(cocktail)));
            });
        }
    }
}
