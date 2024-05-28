using Konsolenanwendung.Geometrie;

namespace Test.GeometrieTests
{
    /// <summary>
    /// Es ist möglich einen Test für verschiedene Testfälle zu erstellen:
    /// https://docs.microsoft.com/de-de/dotnet/core/testing/unit-testing-with-nunit#adding-more-features
    /// 
    /// Auf diese Möglichkeit wurde bewusst im Rahmen der Grundlagen verzichtet.
    /// </summary>
    public class BerechneKreisumfang
    {
        private static readonly double UMFANG_EINHEITSKREIS = 2.0 * Math.PI;

        [Test]
        public void Eingabe_null()
        {
            string? eingabe = null;
            double erwartet = -1d;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_leer()
        {
            string? eingabe = "";
            double erwartet = -1d;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_Leerzeichen()
        {
            string? eingabe = " ";
            double erwartet = -1d;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_Wort()
        {
            string? eingabe = "abc";
            double erwartet = -1d;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_Sonderzeichen()
        {
            string? eingabe = "_";
            double erwartet = -1d;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_Null()
        {
            string? eingabe = "0";
            double erwartet = 0d;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_Eins()
        {
            string? eingabe = "1";
            double erwartet = UMFANG_EINHEITSKREIS;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_Negativ_Eins()
        {
            string? eingabe = "-1";
            double erwartet = -1d;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_GleitkommaZahl()
        {
            string? eingabe = "0.5";
            double erwartet = UMFANG_EINHEITSKREIS * 0.5d;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_MAX_Int32()
        {
            string? eingabe = "" + int.MaxValue;
            double erwartet = UMFANG_EINHEITSKREIS * int.MaxValue;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_MIN_Int32()
        {
            string? eingabe = "" + int.MinValue;
            double erwartet = -1d;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }

        [Test]
        public void Eingabe_MAX_Int32_Plus_1()
        {
            string? eingabe = "" + (int.MaxValue + 1d);
            double erwartet = UMFANG_EINHEITSKREIS * int.MaxValue + UMFANG_EINHEITSKREIS;

            double resultat = Kreis.BerechneKreisumfang(eingabe);
            Assert.That(resultat, Is.EqualTo(eingabe), $"Für einen Radius von '{eingabe}' beträgt der Umfang '{erwartet}'.");
        }
    }
}
