namespace Apuntes.Views;

public partial class AnthonyRodriguez_Conteo : ContentPage
{
	public AnthonyRodriguez_Conteo()
    {
        InitializeComponent();
    }

    private void Calcular_Clicked(object sender, EventArgs e)
    {
        string input = txtInput.Text;

        int numeros = 0;
        int letras = 0;
        int vocales = 0;
        int mayusculas = 0;
        int minusculas = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
                numeros++;
            else if (char.IsLetter(c))
            {
                letras++;
                if ("aeiouAEIOU".Contains(c))
                    vocales++;

                if (char.IsUpper(c))
                    mayusculas++;
                else
                    minusculas++;
            }
        }

        lblNumbers.Text = $"Números: {numeros}";
        lblLetters.Text = $"Letras: {letras}";
        lblVowels.Text = $"Vocales: {vocales}";
        lblUpperCase.Text = $"Mayúsculas: {mayusculas}";
        lblLowerCase.Text = $"Minúsculas: {minusculas}";
        lblTotal.Text = $"Total: {input.Length}";
    }

    private void Limpiar_Clicked(object sender, EventArgs e)
    {
        txtInput.Text = string.Empty;
        lblNumbers.Text = string.Empty;
        lblLetters.Text = string.Empty;
        lblVowels.Text = string.Empty;
        lblUpperCase.Text = string.Empty;
        lblLowerCase.Text = string.Empty;
        lblTotal.Text = string.Empty;
    }
}