using Maui_RecipeDemo.Data;

namespace Maui_RecipeDemo
{
    public partial class MainPage : ContentPage
    {
        private readonly RecipeData _recipeData;

        public MainPage()
        {
            InitializeComponent();

            _recipeData = new RecipeData();

            collectionView.ItemsSource = _recipeData.Recipes;
        }

        private void OnSeeMoreClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.CommandParameter is int selectedId)
            {
                Navigation.PushAsync(new DetailPage(selectedId, _recipeData));
            }
        }

    }

}
