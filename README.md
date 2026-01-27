# Solid.DotNET.Howto

Este proyecto muestra ejemplos sencillos de cómo aplicar el principio de Responsabilidad Única (Single Responsibility Principle - SRP) en C# siguiendo SOLID. Contiene ejemplos "malos" y "buenos" que facilitan comparar cómo separar responsabilidades correctamente.

## Estructura del repositorio (relevante)

- Solid.DotNET.Howto/1.SRP/
  - Bad/
    - InvoiceService.cs                # Ejemplo que viola SRP (valida, persiste y registra en un único tipo)
  - Good/
    - Interface/ILogger.cs             # Interfaz para logging
    - Interface/IInvoiceRepository.cs  # Interfaz para persistencia de facturas
    - InvoiceService.cs                # Servicio que cumple SRP mediante inyección de dependencias

> Archivos clave:
> - `1.SRP/Bad/InvoiceService.cs` : mezcla validación, persistencia y logging en una sola clase.
> - `1.SRP/Good/InvoiceService.cs` : delega persistencia y logging a `IInvoiceRepository` e `ILogger` respectivamente.

## Qué enseña el ejemplo

- Por qué la clase `InvoiceService` del ejemplo "Bad" viola SRP:
  - Tiene más de una razón para cambiar: reglas de validación, detalles de almacenamiento y lógica de logging.
  - Está acoplada a detalles de implementación (guardar en base de datos, escribir en fichero).

- Cómo lo corrije el ejemplo "Good":
  - Se define una interfaz `IInvoiceRepository` para la responsabilidad de persistencia.
  - Se define una interfaz `ILogger` para la responsabilidad de logging.
  - `InvoiceService` sólo contiene la lógica de negocio (validación y orquestación) y delega las otras responsabilidades.
  - Así, cada componente tiene una única razón para cambiar (SRP) y el código es más testeable y mantenible.

## Ejemplo de uso (extracto)

```csharp
// Implementaciones sencillas para ejemplo
public class ConsoleLogger : Solid.DotNET.Howto._1.SRP.Good.Interface.ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}

public class InMemoryInvoiceRepository : Solid.DotNET.Howto._1.SRP.Good.Interface.IInvoiceRepository
{
    private readonly List<decimal> _store = new();
    public void Save(decimal amount) => _store.Add(amount);
}

// Uso
var repository = new InMemoryInvoiceRepository();
var logger = new ConsoleLogger();
var service = new Solid.DotNET.Howto._1.SRP.Good.InvoiceService(repository, logger);
service.CreateInvoice(100m);
