// ==============================================================
// PinguinoEmperador.cs
// El ave no voladora más grande — bucea hasta 565m de profundidad
// ==============================================================

namespace AvesPolimorfico
{
    /// <summary>
    /// Pingüino Emperador — el ave más grande del mundo que no vuela.
    /// Puede aguantar la respiración 22 minutos y soportar -60°C.
    /// El macho incuba el huevo sobre sus patas durante 65 días sin comer.
    /// </summary>
    public class PinguinoEmperador : Ave
    {
        public int ProfundidadBuceoMetros { get; }
        public int MinutosApneaMaxima { get; }
        public int TemperaturaResistenciaC { get; }  // temperatura que soporta

        public PinguinoEmperador() : base(
            nombre:           "Pingüino Emperador",
            nombreCientifico: "Aptenodytes forsteri",
            habitat:          "Banquisas de hielo de la Antártida",
            envergadura:      90,    // aletas, no alas voladoras
            peso:             38.0,
            migratoria:       false,
            vidaAnios:        20)
        {
            ProfundidadBuceoMetros   = 565;
            MinutosApneaMaxima       = 22;
            TemperaturaResistenciaC  = -60;
        }

        public override string Cantar()
        {
            return
                "🐧 [CANTO DEL PINGÜINO EMPERADOR]\n" +
                "  Sonido : «Braaahh-orrr» — trompetazo ronco de baja frecuencia\n" +
                "  Función: Cada individuo tiene una huella vocal única; la pareja\n" +
                "           se reconoce entre 10,000 pingüinos solo por el canto\n" +
                "  Pollos : Emiten «piiip-piiip» para que el padre los localice bajo el plumón\n" +
                "  Dato   : Se comunican con hasta 11 variantes vocales distintas";
        }

        public override string Volar()
        {
            return
                "🐧 [\"VUELO\" DEL PINGÜINO EMPERADOR]\n" +
                "  Aire        : ❌ Imposible — alas evolucionaron hacia aletas rígidas\n" +
                $"  Agua        : ✅ \"Vuela\" bajo el agua a 36 km/h — más rápido que nadar\n" +
                $"  Profundidad : Bucea hasta {ProfundidadBuceoMetros}m — más que cualquier otra ave\n" +
                $"  Apnea       : Aguanta {MinutosApneaMaxima} minutos sin respirar\n" +
                $"  Adaptación  : Huesos sólidos (no huecos) para resistir la presión abismal";
        }

        public override string Alimentarse()
        {
            return
                "🐧 [ALIMENTACIÓN DEL PINGÜINO EMPERADOR]\n" +
                "  Presas    : Peces antárticos, calamares y krill bajo el hielo\n" +
                "  Técnica   : Persecución subacuática — puede cazar en oscuridad total\n" +
                "  Temporada : Ayuna 115 días durante la incubación — pierde 40% de su peso\n" +
                "  Almacena  : Acumula hasta 12kg de grasa como reserva energética\n" +
                "  Pollos    : Los alimenta regurgitando una «leche» de proteína esofágica";
        }

        public override string Anidar()
        {
            return
                "🐧 [NIDIFICACIÓN DEL PINGÜINO EMPERADOR]\n" +
                "  Nido      : ❌ NO hay nido — el único pingüino que no construye nada\n" +
                "  Huevo     : Un solo huevo incubado sobre las patas del MACHO\n" +
                "  Invierno  : El macho incuba 65 días en pleno invierno antártico (-60°C)\n" +
                $"  Tormenta  : {Math.Abs(TemperaturaResistenciaC)}°C bajo cero; el grupo se compacta para conservar calor\n" +
                "  Hembra    : Regresa del mar con comida justo cuando eclosiona el huevo";
        }

        public override string Defenderse()
        {
            return
                "🐧 [DEFENSA DEL PINGÜINO EMPERADOR]\n" +
                "  Tierra    : Se agrupa en «tortugas» de hasta 5,000 individuos contra el viento\n" +
                "  Depredador: Skúas atacan los pollos → adultos los cubren con el cuerpo\n" +
                "  Agua      : Principal amenaza: leopardos marinos y orcas\n" +
                "  Estrategia: Saltan en grupo para confundir al depredador en el agua\n" +
                "  Dato      : El único depredador en tierra que les representa una amenaza real es el ser humano";
        }

        public override string FichaCompleta()
        {
            return base.FichaCompleta() +
                $"  Buceo máximo   : {ProfundidadBuceoMetros} metros\n" +
                $"  Apnea máxima   : {MinutosApneaMaxima} minutos\n" +
                $"  Temp. mínima   : {TemperaturaResistenciaC}°C\n" +
                $"  Estado         : CASI AMENAZADO — colonia del 50% perdida en 50 años\n";
        }
    }
}
