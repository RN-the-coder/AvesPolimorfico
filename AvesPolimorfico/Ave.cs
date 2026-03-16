// ==============================================================
// Ave.cs — Clase base abstracta
// Define el contrato polimórfico que todas las aves deben cumplir
// ==============================================================

namespace AvesPolimorfico
{
    /// <summary>
    /// Clase base abstracta que representa un Ave.
    /// Define los métodos que cada especie implementará
    /// de forma completamente distinta (polimorfismo).
    /// </summary>
    public abstract class Ave
    {
        // ── Propiedades comunes a todas las aves ──────────────
        public string Nombre { get; protected set; }
        public string NombreCientifico { get; protected set; }
        public string Habitat { get; protected set; }
        public double EnvergaduraAlas { get; protected set; }  // en cm
        public double PesoKg { get; protected set; }
        public bool EsMigratoria { get; protected set; }
        public int EsperanzaVidaAnios { get; protected set; }

        protected Ave(string nombre, string nombreCientifico, string habitat,
                      double envergadura, double peso, bool migratoria, int vidaAnios)
        {
            Nombre           = nombre;
            NombreCientifico = nombreCientifico;
            Habitat          = habitat;
            EnvergaduraAlas  = envergadura;
            PesoKg           = peso;
            EsMigratoria     = migratoria;
            EsperanzaVidaAnios = vidaAnios;
        }

        // ══════════════════════════════════════════════════════
        // MÉTODOS POLIMÓRFICOS (abstractos — cada ave los define)
        // ══════════════════════════════════════════════════════

        /// <summary>
        /// Emite el sonido característico del ave.
        /// Cada especie produce una onomatopeya y descripción única.
        /// </summary>
        public abstract string Cantar();

        /// <summary>
        /// Describe la técnica de vuelo particular del ave.
        /// Un colibrí levita; un albatros planea; un pingüino... no vuela.
        /// </summary>
        public abstract string Volar();

        /// <summary>
        /// Describe qué y cómo come el ave (técnica de caza/forrajeo).
        /// </summary>
        public abstract string Alimentarse();

        /// <summary>
        /// Describe el tipo de nido/morada y el ritual de apareamiento.
        /// </summary>
        public abstract string Anidar();

        /// <summary>
        /// Comportamiento defensivo ante un depredador.
        /// </summary>
        public abstract string Defenderse();

        // ══════════════════════════════════════════════════════
        // MÉTODO VIRTUAL (tiene implementación base pero puede
        // sobrescribirse si el ave tiene algo especial que mostrar)
        // ══════════════════════════════════════════════════════

        /// <summary>
        /// Genera la ficha completa del ave.
        /// Las subclases pueden sobrescribir para agregar datos únicos.
        /// </summary>
        public virtual string FichaCompleta()
        {
            string migracion = EsMigratoria ? "Sí" : "No";
            return
                $"╔══ {Nombre.ToUpper()} ({NombreCientifico}) ══╗\n" +
                $"  Hábitat        : {Habitat}\n" +
                $"  Envergadura    : {EnvergaduraAlas} cm\n" +
                $"  Peso           : {PesoKg} kg\n" +
                $"  Migratoria     : {migracion}\n" +
                $"  Esperanza vida : {EsperanzaVidaAnios} años\n";
        }

        public override string ToString() => $"[Ave] {Nombre} — {NombreCientifico}";
    }
}
