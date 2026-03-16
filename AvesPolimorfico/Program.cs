// ==============================================================
// Program.cs — Demostración de Polimorfismo con Aves
// Muestra cómo cada ave implementa los mismos métodos de forma
// completamente distinta y característica de su especie.
// ==============================================================

using AvesPolimorfico;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Clear();

PrintBanner();

// ── Colección polimórfica: todas son "Ave" pero se comportan diferente ──
List<Ave> coleccion = [
    new AguilaImperial(),
    new ColibriZunzuncito(),
    new PinguinoEmperador(),
    new CotorraAlejandrina(),
    new FragataMagnifica()
];

// La cotorra aprende algunas palabras antes del demo
var cotorra = (CotorraAlejandrina)coleccion[3];
cotorra.Aprender("¡Hola!");
cotorra.Aprender("¡Buenos días!");
cotorra.Aprender("¡Quiero comer!");

bool salir = false;
while (!salir)
{
    PrintMenuPrincipal(coleccion);
    string? opcion = Console.ReadLine()?.Trim();

    if (opcion == "0")
    {
        salir = true;
        continue;
    }

    if (opcion == "D")
    {
        DemoCompleto(coleccion);
        continue;
    }

    if (!int.TryParse(opcion, out int idx) || idx < 1 || idx > coleccion.Count)
    {
        PrintError("Opción inválida. Intenta de nuevo.");
        continue;
    }

    Ave aveSeleccionada = coleccion[idx - 1];
    MenuAve(aveSeleccionada);
}

PrintDespedida();

// ─────────────────────────────────────────────────────────────
// FUNCIONES DE UI
// ─────────────────────────────────────────────────────────────

static void PrintBanner()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@"
  ╔══════════════════════════════════════════════════════════════╗
  ║                                                              ║
  ║        🐦  P O L I M O R F I S M O  D E  A V E S  🐦        ║
  ║                                                              ║
  ║     Cada ave implementa los mismos métodos a su manera       ║
  ║                        C# • .NET 8                           ║
  ║                                                              ║
  ╚══════════════════════════════════════════════════════════════╝
");
    Console.ResetColor();
    Pausa(500);
}

static void PrintMenuPrincipal(List<Ave> coleccion)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("  ══════════════════════════════════════");
    Console.WriteLine("    COLECCIÓN DE AVES — Menú Principal");
    Console.WriteLine("  ══════════════════════════════════════");
    Console.ResetColor();

    for (int i = 0; i < coleccion.Count; i++)
    {
        string emoji = i switch
        {
            0 => "🦅", 1 => "🐦", 2 => "🐧",
            3 => "🦜", 4 => "🏴‍☠️", _ => "🐤"
        };
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"  [{i + 1}] {emoji} ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{coleccion[i].Nombre}");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"  —  {coleccion[i].NombreCientifico}");
    }

    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("  [D] 🌐 Demo completo (todas las aves, todos los métodos)");
    Console.WriteLine("  [0] 🚪 Salir");
    Console.ResetColor();
    Console.Write("\n  Selecciona un ave: ");
}

static void MenuAve(Ave ave)
{
    bool volver = false;
    while (!volver)
    {
        Console.WriteLine();
        PrintSeparador(ave.Nombre);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"  ¿Qué deseas observar de {ave.Nombre}?");
        Console.ResetColor();
        Console.WriteLine("  [1] 🎵  Cantar");
        Console.WriteLine("  [2] 🌤️  Volar");
        Console.WriteLine("  [3] 🍽️  Alimentarse");
        Console.WriteLine("  [4] 🪺  Anidar");
        Console.WriteLine("  [5] 🛡️  Defenderse");
        Console.WriteLine("  [6] 📋  Ficha completa");
        Console.WriteLine("  [7] 🔁  Todos los comportamientos");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("  [0]     Volver al menú principal");
        Console.ResetColor();
        Console.Write("\n  Opción: ");

        string? op = Console.ReadLine()?.Trim();
        Console.WriteLine();

        switch (op)
        {
            case "1": PrintComportamiento(ave.Cantar()); break;
            case "2": PrintComportamiento(ave.Volar()); break;
            case "3": PrintComportamiento(ave.Alimentarse()); break;
            case "4": PrintComportamiento(ave.Anidar()); break;
            case "5": PrintComportamiento(ave.Defenderse()); break;
            case "6": PrintFicha(ave.FichaCompleta()); break;
            case "7": MostrarTodo(ave); break;
            case "0": volver = true; break;
            default: PrintError("Opción inválida."); break;
        }
    }
}

static void MostrarTodo(Ave ave)
{
    PrintSeparador($"TODOS LOS COMPORTAMIENTOS — {ave.Nombre}");
    string[] comportamientos =
    [
        ave.Cantar(), ave.Volar(), ave.Alimentarse(),
        ave.Anidar(), ave.Defenderse()
    ];
    foreach (var c in comportamientos)
    {
        PrintComportamiento(c);
        Pausa(200);
    }
    PrintFicha(ave.FichaCompleta());
}

static void DemoCompleto(List<Ave> coleccion)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\n  ★ DEMO COMPLETO — POLIMORFISMO EN ACCIÓN ★");
    Console.WriteLine("  Mismo método, 5 implementaciones completamente distintas\n");
    Console.ResetColor();

    string[] titulos = ["CANTAR", "VOLAR", "ALIMENTARSE", "ANIDAR", "DEFENDERSE"];
    Func<Ave, string>[] metodos =
    [
        a => a.Cantar(),
        a => a.Volar(),
        a => a.Alimentarse(),
        a => a.Anidar(),
        a => a.Defenderse()
    ];

    for (int m = 0; m < metodos.Length; m++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n  ╔══ MÉTODO: Ave.{titulos[m]}() ══╗");
        Console.ResetColor();

        foreach (var ave in coleccion)
        {
            PrintComportamiento(metodos[m](ave));
            Pausa(100);
        }

        if (m < metodos.Length - 1)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n  [Enter para el siguiente método...]");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
    Console.WriteLine("\n  Demo completo finalizado.");
}

static void PrintComportamiento(string texto)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    foreach (var linea in texto.Split('\n'))
    {
        if (linea.Contains("[") && linea.Contains("]") && linea.Contains("—") == false)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"  {linea}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"  {linea}");
        }
    }
    Console.ResetColor();
}

static void PrintFicha(string texto)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    foreach (var linea in texto.Split('\n'))
        Console.WriteLine($"  {linea}");
    Console.ResetColor();
}

static void PrintSeparador(string titulo)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    string linea = new string('─', 54);
    Console.WriteLine($"  {linea}");
    Console.WriteLine($"  {titulo}");
    Console.WriteLine($"  {linea}");
    Console.ResetColor();
}

static void PrintError(string msg)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"  ⚠ {msg}");
    Console.ResetColor();
}

static void PrintDespedida()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n  ¡Hasta pronto! 🐦\n");
    Console.ResetColor();
}

static void Pausa(int ms) => System.Threading.Thread.Sleep(ms);
