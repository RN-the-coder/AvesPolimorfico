// ==============================================================
// ColibriZunzuncito.cs
// El ave más pequeña del mundo — endémica de Cuba
// ==============================================================

namespace AvesPolimorfico
{
    /// <summary>
    /// Colibrí Zunzuncito (Mellisuga helenae) — el ave más pequeña del mundo.
    /// Puede batir las alas 80 veces por segundo y volar hacia atrás.
    /// Solo habita en Cuba; pesa menos que una moneda de un centavo.
    /// </summary>
    public class ColibriZunzuncito : Ave
    {
        public int AleteosPorSegundo { get; }
        public int LengüetazosPorSegundo { get; }  // para beber néctar
        public double PesoGramos => PesoKg * 1000;

        public ColibriZunzuncito() : base(
            nombre:           "Colibrí Zunzuncito",
            nombreCientifico: "Mellisuga helenae",
            habitat:          "Bosques tropicales y jardines de Cuba",
            envergadura:      6,      // 6 cm — el más pequeño del mundo
            peso:             0.0018, // 1.8 gramos
            migratoria:       false,
            vidaAnios:        7)
        {
            AleteosPorSegundo    = 80;
            LengüetazosPorSegundo = 13;
        }

        public override string Cantar()
        {
            return
                "🐦 [CANTO DEL ZUNZUNCITO]\n" +
                "  Sonido : «Tzit-tzit-tzit» — chillido agudo casi ultrasónico\n" +
                "  Tono   : Alcanza frecuencias de 8-10 kHz, apenas audibles para humanos\n" +
                "  Zumbido: Sus alas producen un «bzzzz» constante al volar\n" +
                "  Dato   : Su nombre en Cuba viene precisamente de ese zumbido — «zunzún»";
        }

        public override string Volar()
        {
            return
                "🐦 [VUELO DEL ZUNZUNCITO]\n" +
                $"  Técnica     : Vuelo estacionario — levita en el aire sin moverse\n" +
                $"  Aleteos     : {AleteosPorSegundo} veces/segundo (las alas son invisibles en vuelo)\n" +
                $"  Directions  : Único ave que vuela hacia atrás, de costado y en espiral\n" +
                $"  Consumo     : Quema el 100% de su energía cada día — muere si no come\n" +
                $"  Torpor      : De noche baja metabolismo al 5% para sobrevivir hasta el alba";
        }

        public override string Alimentarse()
        {
            return
                "🐦 [ALIMENTACIÓN DEL ZUNZUNCITO]\n" +
                $"  Dieta         : Néctar de flores (90%) + insectos minúsculos (10%)\n" +
                $"  Lengüetazos   : {LengüetazosPorSegundo} veces/segundo con lengua bífida como trampolín\n" +
                $"  Flores/día    : Visita hasta 1,500 flores cada día\n" +
                $"  Peso vs comida: Come el equivalente a su propio peso ({PesoGramos:F1}g) en néctar diario\n" +
                $"  Pico          : Curvado específicamente para flores de Hamelia patens";
        }

        public override string Anidar()
        {
            return
                "🐦 [NIDIFICACIÓN DEL ZUNZUNCITO]\n" +
                "  Nido    : Taza de musgo y telarañas del tamaño de una moneda de 25 centavos\n" +
                "  Huevos  : 2 huevos del tamaño de un guisante (~0.4g cada uno)\n" +
                "  Madre   : La hembra cría sola; el macho defenderá el territorio floral\n" +
                "  Pollos  : Nacen del tamaño de una abeja, ciegos y sin plumas";
        }

        public override string Defenderse()
        {
            return
                "🐦 [DEFENSA DEL ZUNZUNCITO]\n" +
                "  Estrategia : Velocidad y agilidad — nadie puede atraparlo en vuelo\n" +
                "  Evasión    : Zigzag a 50 km/h; cambia dirección en 30 milisegundos\n" +
                "  Territorio : Macho ataca a otros colibríes con picotazos en pleno vuelo\n" +
                "  Depredadores: Arañas, ranas arborícolas, libélulas grandes y mantis";
        }

        public override string FichaCompleta()
        {
            return base.FichaCompleta() +
                $"  Peso real      : {PesoGramos:F1} gramos (¡menos que una moneda!)\n" +
                $"  Aleteos/seg    : {AleteosPorSegundo}\n" +
                $"  Estado         : VULNERABLE — solo en Cuba, afectado por deforestación\n";
        }
    }
}
