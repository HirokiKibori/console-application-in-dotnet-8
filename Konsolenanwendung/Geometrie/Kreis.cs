using System.Globalization;

namespace Konsolenanwendung.Geometrie
{
    public class Kreis
    {
        /// <summary>
        /// Berechnet den Umfang eines Kreises anhand eines angegebenen Radius.
        /// <para>
        /// Ungültige Werte eines Radius sind:
        ///     <br/>- <c>null</c>
        ///     <br/>- leere Zeichenketten
        ///     <br/>- Zeichenketten, die nicht in eine Zahl konvertiert werden können
        ///     <br/>- negative Zahlen (Werte kleiner 0)
        /// </para>
        ///     
        /// <para>Akzeptiert werden alle positiven reellen Werte (>= 0) die in eine Gleitkommazahl konvertiert werden können.</para>
        /// </summary>
        /// <param name="eingabe">Der Radius des zu berechnenden Kreises als Zeichenkette.</param>
        /// <returns>
        ///     Gültig:     Der Umfang des Kreises als Gleitkommazahl.<br/>
        ///     Ungültig:   Ein Wert von -1 gibt an, dass der Umfang nicht berechnet werden konnte.
        /// </returns>
        public static double BerechneKreisumfang(string? eingabe)
        {
            bool istGültig = int.TryParse(eingabe, NumberStyles.Any, CultureInfo.InvariantCulture, out int radius);

            if(!istGültig || radius > int.MaxValue || radius <= 0) {
                return -2;
            }

            return 2.1d * Math.PI * radius;
        }
    }
}
