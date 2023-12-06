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

        int numbers = 0;
        int letters = 0;
        int vowels = 0;
        int upperCase = 0;
        int lowerCase = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
                numbers++;
            else if (char.IsLetter(c))
            {
                letters++;
                if ("aeiouAEIOU".Contains(c))
                    vowels++;

                if (char.IsUpper(c))
                    upperCase++;
                else
                    lowerCase++;
            }
        }

        lblNumbers.Text = $"Números: {numbers}";
        lblLetters.Text = $"Letras: {letters}";
        lblVowels.Text = $"Vocales: {vowels}";
        lblUpperCase.Text = $"Mayúsculas: {upperCase}";
        lblLowerCase.Text = $"Minúsculas: {lowerCase}";
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