using static System.Net.Mime.MediaTypeNames;

namespace _10195594Ejercicio3;

public partial class Promedio : ContentPage
{
	public Promedio()
	{
		InitializeComponent();
	}

    /// <summary>
    /// En el evento clicked del botón, almacenamos 5 notas en las variables N1, N2, N3, N4, N5 para realizar el calculo 
    /// del promedio final. Mediante un If validamos los campos para que solo se puedan ingresar números
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
		double N1, N2, N3, N4, N5, Promedio;
        if (!string.IsNullOrEmpty(Not1.Text) && !string.IsNullOrEmpty(Not2.Text) && !string.IsNullOrEmpty(Not3.Text) && !string.IsNullOrEmpty(Not4.Text) && !string.IsNullOrEmpty(Not5.Text))
        {
            if (double.TryParse(Not1.Text, out N1) && double.TryParse(Not2.Text, out N2) && double.TryParse(Not3.Text, out N3) && double.TryParse(Not4.Text, out N4) && double.TryParse(Not5.Text, out N5))
            {
                N1 = Convert.ToDouble(Not1.Text);
                N2 = Convert.ToDouble(Not2.Text);
                N3 = Convert.ToDouble(Not3.Text);
                N4 = Convert.ToDouble(Not4.Text);
                N5 = Convert.ToDouble(Not5.Text);

                Promedio = (N1 + N2 + N3 + N4 + N5) / 5;
                EntryP.Text = Promedio.ToString();
            }
            else
            {
                DisplayAlert("ERROR", "Introduce Número, no letras ni otro tipo de carácteres", "OK");
            }
        }
    }
}