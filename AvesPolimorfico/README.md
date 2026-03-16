# 🐦 Polimorfismo de Aves — C# .NET 8

Proyecto que demuestra **polimorfismo con herencia** en C# usando 5 aves reales con comportamientos completamente distintos.

## 📁 Estructura

```
AvesPolimorfico/
├── Ave.cs                    ← Clase abstracta base (contrato polimórfico)
├── AguilaImperial.cs         ← 🦅 Rapaz, 320 km/h en picado
├── ColibriZunzuncito.cs      ← 🐦 Ave más pequeña del mundo (1.8g)
├── PinguinoEmperador.cs      ← 🐧 No vuela, bucea 565m
├── CotorraAlejandrina.cs     ← 🦜 Imita voz humana, aprende vocabulario
├── FragataMagnifica.cs       ← 🏴‍☠️ Pirata del aire, roba comida en vuelo
└── Program.cs                ← Menú interactivo
```

## 🏛️ Arquitectura de Clases

```
Ave (abstract)
 ├── Cantar()       → abstract
 ├── Volar()        → abstract
 ├── Alimentarse()  → abstract
 ├── Anidar()       → abstract
 ├── Defenderse()   → abstract
 └── FichaCompleta() → virtual (con override en subclases)
      │
      ├── AguilaImperial     (+ VelocidadPicadoKmh, AgudezaVisual)
      ├── ColibriZunzuncito  (+ AleteosPorSegundo, LengüetazosPorSegundo)
      ├── PinguinoEmperador  (+ ProfundidadBuceoMetros, MinutosApneaMaxima)
      ├── CotorraAlejandrina (+ Vocabulario, Aprender(string))
      └── FragataMagnifica   (+ RelacionEnvergaduraPeso, TieneBolsaGular)
```

## 🚀 Cómo ejecutar

```bash
dotnet run
```

**Requisitos:** .NET 8 SDK

## 🧩 Conceptos de Polimorfismo demostrados

| Concepto | Dónde se ve |
|----------|-------------|
| Método `abstract` | `Cantar()`, `Volar()`, `Alimentarse()`, `Anidar()`, `Defenderse()` — cada ave los implementa completamente diferente |
| Método `virtual` + `override` | `FichaCompleta()` — la base da info general, las subclases añaden datos únicos |
| Colección polimórfica | `List<Ave>` que contiene 5 tipos distintos — se llama el mismo método y cada uno responde diferente |
| Propiedades heredadas | Todas las aves comparten `Nombre`, `Peso`, `Habitat`, etc. |
| Propiedades propias | Cada clase agrega atributos únicos de su especie |
| Método propio de subclase | `CotorraAlejandrina.Aprender(string)` — no existe en la clase base |

## 🌟 Output característico (no genérico)

Cada método refleja la biología real del ave:

- **Pingüino.Volar()** → "❌ Imposible en aire — ✅ Vuela bajo el agua a 36 km/h"
- **Colibrí.Volar()** → "80 aleteos/segundo, único ave que vuela hacia atrás"  
- **Fragata.Alimentarse()** → "Roba el 40% de su dieta a otras aves en pleno vuelo"
- **Cotorra.Cantar()** → Muestra las palabras específicas que ha aprendido
