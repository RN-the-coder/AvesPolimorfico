// ==============================================================
// AguilaImperial.cs
// ==============================================================

namespace AvesPolimorfico
{
    /// <summary>
    /// Águila Imperial Ibérica — una de las rapaces más amenazadas del mundo.
    /// Depredadora ápex con visión 8x superior a la humana.
    /// </summary>
    public class AguilaImperial : Ave
    {
        public int VelocidadPicadoKmh { get; }  // velocidad en picado
        public double AgudezaVisual { get; }     // multiplicador vs humano

        public AguilaImperial() : base(
            nombre:           "Águila Imperial Ibérica",
            nombreCientifico: "Aquila adalberti",
            habitat:          "Dehesas y bosques mediterráneos de España y Portugal",
            envergadura:      200,
            peso:             3.2,
            migratoria:       false,
            vidaAnios:        21)
        {
            VelocidadPicadoKmh = 320;
            AgudezaVisual = 8.0;
        }

        public override string Cantar()
        {
            return
                "🦅 [CANTO DEL ÁGUILA IMPERIAL]\n" +
                "  Sonido : «Kok-kok-kok-kok» — serie de ladridos metálicos cortos\n" +
                "  Alcance: Se escucha hasta 3 km de distancia\n" +
                "  Uso    : Principalmente durante el cortejo y defensa territorial\n" +
                "  Dato   : El macho canta desde la copa del árbol más alto de su territorio";
        }

        public override string Volar()
        {
            return
                "🦅 [VUELO DEL ÁGUILA IMPERIAL]\n" +
                $"  Técnica : Planea en círculos ascendentes usando corrientes térmicas\n" +
                $"  Picado  : Folds wings → alcanza {VelocidadPicadoKmh} km/h en 3 segundos\n" +
                $"  Altura  : Patrulla entre 400-800m sobre el suelo\n" +
                $"  Visión  : Detecta un conejo a 3 km con agudeza {AgudezaVisual}x la humana";
        }

        public override string Alimentarse()
        {
            return
                "🦅 [CAZA DEL ÁGUILA IMPERIAL]\n" +
                "  Presas favoritas : Conejos (70% de su dieta), liebres, perdices\n" +
                "  Técnica          : Patrulla silenciosa → descenso rasante → zarpazo letal\n" +
                "  Fuerza de garras : 200 kg/cm² — suficiente para perforar un cráneo\n" +
                "  Consumo diario   : ~400g de carne; ayuna hasta 5 días si hay escasez";
        }

        public override string Anidar()
        {
            return
                "🦅 [NIDIFICACIÓN DEL ÁGUILA IMPERIAL]\n" +
                "  Nido    : Plataforma de ramas en lo alto de pinos o eucaliptos (20-25m)\n" +
                "  Tamaño  : Hasta 2m de diámetro — reforzado durante años sucesivos\n" +
                "  Pareja  : Monógama de por vida; el mismo nido puede durar 30+ años\n" +
                "  Huevos  : 2-3 huevos; incubación 43 días; solo 1-2 pollos sobreviven";
        }

        public override string Defenderse()
        {
            return
                "🦅 [DEFENSA DEL ÁGUILA IMPERIAL]\n" +
                "  Estrategia : NO huye — enfrenta directamente al intruso\n" +
                "  Exhibición : Extiende alas a máxima envergadura (2m) y eriza plumas\n" +
                "  Ataque     : Garras hacia adelante, grito agudo como aviso final\n" +
                "  Sin depredadores naturales — solo el ser humano es una amenaza real";
        }

        public override string FichaCompleta()
        {
            return base.FichaCompleta() +
                $"  Vel. picado    : {VelocidadPicadoKmh} km/h\n" +
                $"  Agudeza visual : {AgudezaVisual}x la humana\n" +
                $"  Estado         : EN PELIGRO CRÍTICO — ~900 individuos en libertad\n";
        }
    }
}
