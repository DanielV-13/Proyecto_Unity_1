# Turtle Ninja Mutan Teenager

**Materia:** Lenguajes de Programación &nbsp;|&nbsp; **Periodo:** 2026-1 &nbsp;|&nbsp; **Estado:** Completado

Juego tipo *platformer* 2D desarrollado en **Unity** con **C#** como ejercicio de la materia de Lenguajes de Programación. Controlas a una tortuga ninja que avanza automáticamente hacia la derecha: come manzanas para sumar puntos, esquiva o destruye sierras lanzando rocas, y evita caer al vacío. El nivel se genera de forma infinita, así que la partida no termina hasta que el personaje muere.

> La idea original del nivel y la música están inspiradas en este video: https://youtu.be/BG0zDs1lgXc?si=5TQC4zENtzRNAl-Y

## Equipo de trabajo

- [Daniel Vaca Velástegui](https://github.com/DanielV-13)

## Capturas / Demo

    
https://github.com/user-attachments/assets/b8cb8c4d-fc64-4c44-961b-4b4cce5ae8f1


## Cómo jugar

El personaje avanza solo hacia la derecha, no hay que hacer nada para moverlo.

| Tecla | Acción |
|-------|--------|
| `Espacio` | Saltar |
| `E` | Lanzar una roca |

## Mecánicas

- **Manzanas** — comerlas suma un punto al marcador.
- **Sierras** — tocarlas mata al personaje y reinicia la partida. Se les puede disparar: cada sierra destruida con una roca también suma un punto.
- **Vacío / Agua** — caerse fuera de las plataformas reinicia la partida.
- Las plataformas, las sierras y las manzanas se generan automáticamente mientras el personaje avanza, así que el nivel nunca termina.

> Ojo con las rocas: si una roca le pega a una manzana también la destruye, pero sin darte puntos.

## Funcionalidad

- [x] Movimiento automático y salto del personaje.
- [x] Disparo de rocas para destruir obstáculos.
- [x] Recolección de manzanas que suman puntos.
- [x] Sierras como enemigo/obstáculo (esquivar o destruir).
- [x] Generación infinita de plataformas, manzanas y sierras.
- [x] Marcador de puntaje en pantalla y reinicio al morir.

## Tecnologías

`C#` &nbsp;|&nbsp; `Unity 6 (6000.0.26f1)` &nbsp;|&nbsp; `Universal Render Pipeline (URP 2D)` &nbsp;|&nbsp; `TextMesh Pro` &nbsp;|&nbsp; `Git / GitHub`

## Ejecución

1. Clona el repositorio:
   ```bash
   git clone https://github.com/DanielV-13/Proyecto_Unity_1.git
   ```
2. Abre **Unity Hub** y agrega la carpeta `Proyecto_Assets` como proyecto.
3. Ábrelo con **Unity 6 (6000.0.26f1)** o superior.
4. Abre la escena `Assets/Scenes/SampleScene.unity`.
5. Presiona **Play**.

## Estructura del proyecto

| Script | Qué hace |
|--------|----------|
| `Player Controller.cs` | Movimiento, salto, lanzamiento de rocas y muerte del personaje. |
| `BulletController.cs` | Vuelo de la roca y qué pasa cuando choca (destruye sierras y suma punto). |
| `SpawnManager.cs` | Genera plataformas, sierras y manzanas cada cierto tiempo a alturas aleatorias. |
| `GameManager.cs` | Lleva el marcador y lo muestra en pantalla. |
| `Camera2D.cs` | Hace que la cámara siga al personaje. |
| `GarbageController.cs` | Destruye los objetos que quedan atrás para no saturar la memoria. |

## Métricas de Progreso

| Indicador | Valor |
|-----------|-------|
| Commits totales | 7 |
| Issues/PRs fusionados | — |
| Cobertura de pruebas | N/A |
| Última actualización | 2026-07-29 |

## Reflexión y Aprendizajes

- **Habilidades desarrolladas:** programación en C# aplicada a Unity, uso de componentes (`Rigidbody2D`, `Collider2D`, `SpriteRenderer`) y manejo de colisiones por *tags*.
- **Qué funcionó bien:** la generación infinita con corrutinas y el sistema de puntaje quedaron simples y estables.
- **Qué se podría mejorar:** *La generacion de un fondo animado que se mueva con la cámara, la inclusión de efectos de sonido y más tipos de interacciones con el player*.


## Créditos

Los recursos usados fueron obtenidos de las siguientes fuentes:

- **Assets principales (personaje y elementos del juego)** — Unity Asset Store: https://assetstore.unity.com/2d
- **Fondo (background)** — extraído del juego *Teenage Mutant Ninja Turtles: Shredder's Revenge*: [Episode 08: Panic in the Sky! — The Spriters Resource](https://www.spriters-resource.com/pc_computer/teenagemutantninjaturtlesshreddersrevenge/asset/179425/) (recuperado el 29 de julio de 2026).
- **Idea original del nivel y música** — [Video de referencia en YouTube](https://youtu.be/BG0zDs1lgXc?si=5TQC4zENtzRNAl-Y).
