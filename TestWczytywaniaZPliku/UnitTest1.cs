using konsolowa;
using System.Security.Cryptography.X509Certificates;
namespace TestWczytywaniaZPliku
{
    public class UnitTest1
    {
        [Fact]
        public void GivenPlikTekstowy_Where()
        {
            string path = "../../../plik.txt";

            if(!File.Exists(path))
            {
             //  path = File.WriteAllLines("1\n 2\n 3\n 4\n 5\n");
            }
        }
    }
}