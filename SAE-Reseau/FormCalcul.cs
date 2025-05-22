using System.Diagnostics;

namespace SAE_Reseau
{
    public partial class FormCalcul : Form
    {
        public FormCalcul()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
        }

        /// <summary>
        /// Convertit un code hexadécimal en entier
        /// </summary>
        /// <param name="str_hex">Chaîne de caractères contenant un code hexadécimal</param>
        /// <returns>L'entier correspondant à la valeur du code hexadécimal</returns>
        private static int ConvertToInt(string str_hex)
        {
            int int_hex = 0;

            // pour chaque caractère de la chaîne
            foreach (char car in str_hex)
            {
                // on multiplie par 16 la valeur précédente
                int_hex *= 16;

                // on ajoute la valeur du caractère actuel
                if (car <= '9' && car >= '0')
                {
                    int_hex += car - '0';
                }
                else
                {
                    int_hex += (car - 'A') + 10;
                }
            }

            return int_hex;
        }

        /// <summary>
        /// Convertit un entier en code hexadécimal
        /// </summary>
        /// <param name="int_hex">Entier à convertir</param>
        /// <returns>La chaîne de caractères contenant le code hexadécimal de l'entier</returns>
        private static string ConvertToString(int int_hex)
        {
            string str_hex = string.Empty;
            int dec;
            char hex;

            // tant qu'il reste une valeur à convertir
            while (int_hex != 0)
            {
                // on calcul la valeur décimale du prochain caractère hexadécimal
                dec = int_hex % 16;

                // on convertit en hexadécimal la valeur décimale
                hex = (char) (dec +
                        ((dec >= 10) ? 'A' - 10 : '0'));

                // on ajoute le nouveau caractère au début de la chaîne
                str_hex = hex + str_hex;
                
                // on divise par 16 pour passer au caractère suivant
                int_hex /= 16;
            }

            return str_hex;
        }

        /// <summary>
        /// Calcule le Header Checksum d'une entête IP
        /// </summary>
        /// <param name="input">Chaîne de caractères contenant l'entête IP sous forme hexadécimale</param>
        /// <returns>Chaîne de caractères contenant le Header Checksum sous forme hexadécimale</returns>
        private static string ComputeHeaderChecksum(string input)
        {
            // on standardise la chaîne de caractères
            input = input.Replace(" ", "");
            input = input.Replace("\r\n", "");
            input = input.Replace(";", "");
            input = input.Replace(",", "");
            input = input.Replace(".", "");
            input = input.ToUpper();

            // on vérifie que la chaîne est valide
            if (input.Length % 4 != 0)
            {
                throw new ArgumentException("L'entête IP doit contenir un nombre pair d'octets hexadécimaux.");
            }

            // initialise la somme à 0
            int output = 0;

            // on additionne les valeurs hexadécimales en ignorant la valeur du checksum
            for (int i = 0; i < input.Length; i+=4)
            {
                if (i == 20)
                    continue;
                output += ConvertToInt(input.Substring(i, 4));
            }

            // ajout des bits de l'overflow
            output = output % 65536 + output / 65536;
            
            // inversion des bits
            output = 65535 - output;

            return ConvertToString(output);
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            { 
                txtOutput.Text = ComputeHeaderChecksum(txtInput.Text);
                lblError.Text = string.Empty;
            }
            catch (Exception ex)
            {
                txtOutput.Text = string.Empty;
                lblError.Text = ex.Message;
            }
        }
    }
}
