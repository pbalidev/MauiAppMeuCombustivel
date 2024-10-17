namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {

                    msg = $"o etanol está compensando mais para seu {txt_marca.Text} {txt_modelo.Text}";
                }
                else
                {
                    msg = $"a gasolina está compensando mais para seu {txt_marca.Text} {txt_modelo.Text}";
                }
                    
                DisplayAlert("Calculado", msg, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        }//fecha_método
    }//fecha_class

}//fecha_namespace
