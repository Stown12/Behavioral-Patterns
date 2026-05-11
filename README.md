# Behavioral Patterns (C#)

## Proposito
Este proyecto de consola en C# tiene como objetivo implementar distintos patrones de diseno de comportamiento. Cada patron se agrega con su propia carpeta y una explicacion breve en este README.

## Patrones implementados

### Chain of Responsibility (Cadena de Responsabilidad)
Permite pasar una solicitud a traves de una cadena de manejadores. Cada manejador decide si procesa la solicitud o la delega al siguiente. Es util para desacoplar el emisor del receptor y para construir flujos de procesamiento extensibles.

Carpeta: `Chain-Responsability/`

### Observer (Observador)
Define una relacion uno-a-muchos entre objetos para que, cuando el sujeto cambie su estado, todos sus observadores sean notificados automaticamente. Es util para sistemas de eventos, notificaciones y desacoplar emisores de receptores.

Carpeta: `Observer/`

### Command (Comando)
Encapsula una solicitud como un objeto para parametrizar acciones, encolar operaciones y soportar deshacer. Es util para historiales de acciones, macros y desacoplar invocadores de receptores.

Carpeta: `Command/`

## Proximos pasos
A medida que se agreguen nuevos patrones, se incorporaran aqui con una descripcion corta y la ruta de su carpeta.
