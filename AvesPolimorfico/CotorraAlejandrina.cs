// ==============================================================
// CotorraAlejandrina.cs
// Loro inteligente que imita la voz humana con acento regional
// ==============================================================

namespace AvesPolimorfico
{
    /// <summary>
    /// Cotorra Alejandrina — loro con inteligencia equivalente
    /// a la de un niño de 5 años. Puede aprender hasta 200 palabras
    /// y comprender el contexto de las frases que repite.
    /// </summary>
    public class CotorraAlejandrina : Ave
    {
        public int PalabrasAprendidas { get; private set; }
        public List<string> Vocabulario { get; }

        public CotorraAlejandrina() : base(
            nombre:           "Cotorra Alejandrina",
            nombreCientifico: "Psittacula eupatria",
            habitat:          "Selvas y jardines urbanos de Asia del Sur",
            envergadura:      52,
            peso:             0.23,
            migratoria:       false,
            vidaAnios:        40)
        {
            PalabrasAprendidas = 0;
            Vocabulario = [];
        }

        /// <summary>Enseña una palabra nueva a la cotorra.</summary>
        public void Aprender(string palabra)
        {
            if (!Vocabulario.Contains(palabra))
            {
                Vocabulario.Add(palabra);
                PalabrasAprendidas++;
            }
        }

        public override string Cantar()
        {
            string muestra = Vocabulario.Count > 0
                ? $"«{string.Join("... ", Vocabulario.Take(3))}»"
                : "«¡Hola! ¡Hola! ¿Qué tal?»";

            return
                "🦜 [VOCALIZACIÓN DE LA COTORRA ALEJANDRINA]\n" +
                $"  Vocabulario activo : {PalabrasAprendidas} palabras aprendidas\n" +
                $"  Muestra            : {muestra}\n" +
                "  Tono               : Imita la voz humana con el timbre del hablante original\n" +
                "  Sonido natural     : «Kree-kree-kree» — chillido agudo al volar en bandada\n" +
                "  Contexto           : No solo repite — asocia palabras a situaciones reales";
        }

        public override string Volar()
        {
            return
                "🦜 [VUELO DE LA COTORRA ALEJANDRINA]\n" +
                "  Técnica  : Vuelo rectilíneo rápido con alas cerradas en «V» invertida\n" +
                "  Velocidad: 50 km/h en línea recta; acrobático entre ramas\n" +
                "  Social   : Vuela siempre en bandadas ruidosas de 20-200 individuos\n" +
                "  Mañana   : Sale en grupo al amanecer hacia zonas de alimentación\n" +
                "  Cola     : Cola larga escalonada actúa como timón de precisión";
        }

        public override string Alimentarse()
        {
            return
                "🦜 [ALIMENTACIÓN DE LA COTORRA ALEJANDRINA]\n" +
                "  Dieta    : Frutas, flores, brotes, semillas y ocasionalmente néctar\n" +
                "  Pico     : Usa el pico como «tercer pie» para trepar y manipular comida\n" +
                "  Inteli.  : Recuerda la ubicación de árboles frutales por temporadas\n" +
                "  Problema : En zonas urbanas ataca cultivos de mango y guayaba\n" +
                "  Manos    : Sostiene la comida con una pata — igual que los humanos con la mano";
        }

        public override string Anidar()
        {
            return
                "🦜 [NIDIFICACIÓN DE LA COTORRA ALEJANDRINA]\n" +
                "  Nido    : Ocupa cavidades de árboles viejos o agujeros en edificios\n" +
                "  Pareja  : Se seleccionan mediante exhibición de plumaje y «duetos» vocales\n" +
                "  Huevos  : 2-4 huevos blancos; incubación 28 días\n" +
                "  Vínculo : La pareja comparte la alimentación y limpieza mutua (allopreening)\n" +
                "  Ciudad  : En Madrid y Barcelona hay colonias urbanas de miles de individuos";
        }

        public override string Defenderse()
        {
            return
                "🦜 [DEFENSA DE LA COTORRA ALEJANDRINA]\n" +
                "  Alarma   : Chillido agudo que alerta a toda la bandada simultáneamente\n" +
                "  Mimetismo: Se queda inmóvil entre hojas verdes — su plumaje es camuflaje perfecto\n" +
                "  Pico     : Mordisco de 300 N — puede partir una nuez o un dedo\n" +
                "  Grupo    : La bandada «mobbing» ataca colectivamente al depredador (cuervos, gavilanes)\n" +
                "  Inteli.  : Reconoce rostros humanos específicos y los evita si le causaron daño";
        }

        public override string FichaCompleta()
        {
            string palabras = PalabrasAprendidas > 0
                ? string.Join(", ", Vocabulario)
                : "(no ha aprendido palabras aún)";
            return base.FichaCompleta() +
                $"  Palabras aprend.: {PalabrasAprendidas}\n" +
                $"  Vocabulario     : {palabras}\n" +
                $"  Longevidad      : Hasta 40 años en cautiverio\n" +
                $"  Estado          : CASI AMENAZADO por comercio ilegal de mascotas\n";
        }
    }
}
