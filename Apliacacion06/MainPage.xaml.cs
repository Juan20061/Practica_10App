namespace Apliacacion06
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(entry1.Text, out double pesos) )
            {
                double dolares, Valor;

               Valor = 0.050 ;
                
               dolares = Valor * pesos;
                entry2.Text = $"${dolares:N2} dolares ";

            }
            else
            {
                DisplayAlert("Error", "Introduce todos los numero", "ok");
            }



        }
    }

}
