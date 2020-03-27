namespace ChiperText
{
    public class CaesarCipher
    {
        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch)) return ch;

            var d = char.IsUpper(ch) ? 'A' : 'a';
            return (char) ((ch + key - d) % 26 + d);
        }


        public static string Encipher(string input, int key)
        {
            var output = string.Empty;

            foreach (var ch in input)
                output += Cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
    }
}