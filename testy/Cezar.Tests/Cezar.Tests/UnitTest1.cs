using KonsolowaCezar;
using Xunit;

namespace Cezar.Tests
{
    public class CezarTests
    {
        [Fact]
        public void SzyfrujCezarem_DanePodstawowe_ZwracaDef()
        {
            string wynik = Program.SzyfrujCezarem("abc", 3);

            Assert.Equal("def", wynik);
        }

        [Fact]
        public void SzyfrujCezarem_ZawijanieAlfabetu_ZwracaAbc()
        {
            string wynik = Program.SzyfrujCezarem("xyz", 3);

            Assert.Equal("abc", wynik);
        }

        [Fact]
        public void SzyfrujCezarem_KluczUjemny_ZwracaAbc()
        {
            string wynik = Program.SzyfrujCezarem("def", -3);

            Assert.Equal("abc", wynik);
        }

        [Fact]
        public void SzyfrujCezarem_KluczWiekszyOdAlfabetu_ZwracaDef()
        {
            string wynik = Program.SzyfrujCezarem("abc", 29);

            Assert.Equal("def", wynik);
        }

        [Fact]
        public void SzyfrujCezarem_SpacjaPozostajeBezZmian_ZwracaCdEf()
        {
            string wynik = Program.SzyfrujCezarem("ab cd", 2);

            Assert.Equal("cd ef", wynik);
        }
    }
}