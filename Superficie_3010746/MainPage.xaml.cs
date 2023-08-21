namespace Superficie_3010746
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            double b = Convert.ToDouble(baseTri.Text);
            double a = Convert.ToDouble(altTri.Text);

            double s = b * a;

            supTri.Text = "La superficie es : " + s;
        }
    }
}