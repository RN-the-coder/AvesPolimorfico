// ==============================================================
// FragataMagnifica.cs
// El "pirata del aire" — roba comida a otras aves en pleno vuelo
// ==============================================================

namespace AvesPolimorfico
{
    /// <summary>
    /// Fragata Magnífica — el "pirata del cielo".
    /// Tiene la mayor relación envergadura/peso de todas las aves.
    /// Sus huesos pesan menos que sus plumas. El macho infla
    /// una bolsa gular roja brillante del tamaño de un balón de fútbol.
    /// No puede posarse en el agua porque se hundiría.
    /// </summary>
    public class FragataMagnifica : Ave
    {
        public double RelacionEnvergaduraPeso { get; }  // ratio único
        public bool TieneBolsaGular { get; }

        public FragataMagnifica() : base(
            nombre:           "Fragata Magnífica",
            nombreCientifico: "Fregata magnificens",
            habitat:          "Costas tropicales del Atlántico y Pacífico",
            envergadura:      230,   // mayor relación envergadura/peso del reino animal
            peso:             1.4,
            migratoria:       false,
            vidaAnios:        25)
        {
            RelacionEnvergaduraPeso = EnvergaduraAlas / (PesoKg * 100); // ratio
            TieneBolsaGular = true;
        }

        public override string Cantar()
        {
            return
                "🏴‍☠️ [VOCALIZACIÓN DE LA FRAGATA MAGNÍFICA]\n" +
                "  Sonido     : «Rrrrrrr» — gorjeo vibrante y trompetazo grave\n" +
                "  Bolsa gular: El macho infla su bolsa roja y produce «woo-woo-woo» retumbante\n" +
                "  Exhibición : Sacude la bolsa inflada mientras emite el gorjeo para atraer hembras\n" +
                "  Dato       : Sus huesos pesan MENOS que su plumaje — todo el esqueleto son 113g";
        }

        public override string Volar()
        {
            return
                "🏴‍☠️ [VUELO DE LA FRAGATA MAGNÍFICA]\n" +
                $"  Ratio único  : Envergadura {EnvergaduraAlas}cm / Peso {PesoKg}kg = {RelacionEnvergaduraPeso:F1} — mayor de todas las aves\n" +
                "  Planea       : Puede volar 7 días seguidos sin posarse en tierra\n" +
                "  Térmica      : Asciende a 2,500m usando corrientes calientes tropicales\n" +
                "  Restricción  : ❌ NO puede posarse en el agua — se hundiría (sin glándula preen)\n" +
                "  Agilidad     : Acrobacias en picado a 150 km/h para interceptar presas en vuelo";
        }

        public override string Alimentarse()
        {
            return
                "🏴‍☠️ [ALIMENTACIÓN DE LA FRAGATA MAGNÍFICA — EL PIRATA DEL AIRE]\n" +
                "  Técnica 1  : Kleptroparasitismo — persigue a otras aves y las obliga a soltar su presa\n" +
                "  Técnica 2  : Pesca rasante — atrapa peces voladores en el aire sin mojarse\n" +
                "  Víctimas   : Alcatraces, piqueros, charranes — los persigue hasta la extenuación\n" +
                "  Piratería  : Hasta el 40% de su dieta proviene del robo a otras aves\n" +
                "  Dato       : No puede sumergirse — sus plumas no son impermeables";
        }

        public override string Anidar()
        {
            return
                "🏴‍☠️ [NIDIFICACIÓN DE LA FRAGATA MAGNÍFICA]\n" +
                "  Cortejo  : El macho infla la bolsa gular roja hasta 25cm de diámetro\n" +
                "  Inflado  : Tarda 20 minutos inflarla completamente; las hembras sobrevuelan eligiendo\n" +
                "  Nido     : Plataforma frágil de ramas en manglares o arbustos costeros\n" +
                "  Huevo    : Un solo huevo; ambos padres incuban durante 55 días\n" +
                "  Pollos   : Dependientes durante 6 meses — la crianza más larga de cualquier ave marina";
        }

        public override string Defenderse()
        {
            return
                "🏴‍☠️ [DEFENSA DE LA FRAGATA MAGNÍFICA]\n" +
                "  En vuelo    : Nadie puede alcanzarla — es la más ágil del cielo tropical\n" +
                "  Territorio  : Macho ataca con el pico cualquier intruso en su arbusto de cortejo\n" +
                "  Nido        : Soltará el nido e incluso al pichón antes que arriesgar su vida\n" +
                "  Depredadores: Prácticamente ninguno en el aire; ratas y serpientes en el nido";
        }

        public override string FichaCompleta()
        {
            return base.FichaCompleta() +
                $"  Ratio env/peso : {RelacionEnvergaduraPeso:F1} — mayor del reino animal\n" +
                $"  Bolsa gular    : Sí — se infla hasta 25cm para el cortejo\n" +
                $"  Vuelo continuo : Hasta 7 días sin posarse\n" +
                $"  Estado         : PREOCUPACIÓN MENOR — pero vulnerable a la pérdida de manglares\n";
        }
    }
}
