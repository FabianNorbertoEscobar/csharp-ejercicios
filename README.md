# Ejercicios de C#

Colección de prácticas introductorias de programación orientadas a objetos desarrolladas en C#. El repositorio recorre conceptos básicos de .NET Framework y consola, desde "Hola mundo" hasta herencia, clases abstractas, interfaces, colecciones genéricas y separación en capas.

## Stack tecnológico

- **Lenguaje:** C#
- **Plataforma:** .NET Framework 4.5
- **Tipo de aplicaciones:** aplicaciones de consola (`OutputType: Exe`)
- **IDE original:** Visual Studio 2013
- **Formato:** soluciones y proyectos clásicos de MSBuild (`.sln` y `.csproj`)
- **Bibliotecas base:** `System`, `System.Collections`, `System.Collections.Generic`, `System.IO` y `System.Linq`

## Contenido del repositorio

| Práctica | Carpeta / solución | Conceptos trabajados |
|---|---|---|
| Hola mundo | [`Hola Mundo`](./Hola%20Mundo) | Primera aplicación de consola y salida por pantalla |
| Saludo | [`Saludo/Saludo`](./Saludo/Saludo) | Entrada y salida de datos con `Console` |
| Saludo en capas | [`Saludo/Saludo en capas`](./Saludo/Saludo%20en%20capas) | Presentación y lógica de negocio, proyecto ejecutable y biblioteca de clases |
| Conversión de tipos | [`Conversiones de tipo`](./Conversiones%20de%20tipo) | Conversión implícita, explícita, `Convert` y tipos primitivos |
| Arreglos | [`Arreglos`](./Arreglos) | Declaración, inicialización y recorrido de vectores |
| Matrices | [`Matrices`](./Matrices) | Arreglos multidimensionales y recorrido por índices |
| Empleados | [`Empleados`](./Empleados) | Clases, propiedades, campos privados y cálculo de sueldo |
| Herencia de clientes | [`Clientes - Herencia`](./Clientes%20-%20Herencia) | Herencia entre `Cliente` y `ClienteVentas` |
| Clase abstracta | [`Cliente - Clase Abstracta`](./Cliente%20-%20Clase%20Abstracta) | Clases abstractas, propiedades abstractas y modelo de clientes |
| Interfaces y bitácora | [`Cliente - Clase Abstracta`](./Cliente%20-%20Clase%20Abstracta) | Implementación de interfaces y persistencia de datos en archivo |
| Colecciones | [`ArrayLists`](./ArrayLists) | `ArrayList`, `Hashtable`, altas, eliminaciones y consultas |
| Genéricos | [`Generics`](./Generics) | `List<T>`, expresiones lambda y operaciones sobre clientes |
| Archivos | [`Archivos`](./Archivos) | Lectura, escritura y anexado de texto con `StreamReader` y `StreamWriter` |

## Funcionalidades destacadas

- Mostrar mensajes y solicitar datos al usuario desde la consola.
- Representar empleados y calcular su sueldo según los días trabajados.
- Modelar clientes mediante composición, herencia, clases abstractas e interfaces.
- Implementar una salida configurable para consola o archivo mediante una interfaz.
- Registrar datos de clientes en `ArchivoBitacora.log`.
- Administrar elementos en `ArrayList` y pares clave-valor en `Hashtable`.
- Agregar, buscar, listar y eliminar clientes en una `List<T>`.
- Crear, leer y modificar archivos de texto.
- Separar la presentación del saludo de su lógica de negocio en proyectos independientes.

## Prácticas de programación

Este repositorio trabaja progresivamente:

- sintaxis básica de C# y estructura de una aplicación;
- entrada y salida con `Console`;
- conversiones y tipos de datos;
- arreglos unidimensionales y matrices;
- encapsulación mediante propiedades;
- métodos y cálculo de comportamiento;
- herencia y especialización de clases;
- clases abstractas y métodos/comportamientos abstractos;
- interfaces y sustitución de implementaciones;
- colecciones no genéricas y genéricas;
- expresiones lambda para búsquedas y eliminaciones;
- manejo de excepciones básicas;
- lectura y escritura de archivos;
- organización de código en presentación y negocio.

## Estructura general

La mayoría de las prácticas sigue una estructura clásica de Visual Studio:

```text
Práctica/
├── Práctica.sln
└── Práctica/
    ├── *.cs                 # Código fuente
    ├── Properties/
    │   └── AssemblyInfo.cs
    ├── App.config
    ├── bin/Debug/           # Ejecutables y archivos compilados
    ├── obj/Debug/           # Archivos temporales de compilación
    └── Práctica.csproj
```

La práctica `Saludo en capas` usa una solución formada por dos proyectos:

```text
Saludo/
└── Saludo en capas/
    ├── Saludo en capas.sln
    ├── Saludo en capas/              # Proyecto ejecutable de presentación
    └── ClassLibrary Saludar/         # Biblioteca con la lógica de negocio
```

## Requisitos

Para ejecutarlas necesitas:

- Windows;
- .NET Framework 4.5 o una versión compatible;
- Visual Studio 2013 o una versión posterior compatible con proyectos de MSBuild antiguo;
- o herramientas MSBuild/Xamarin compatibles con proyectos `.NET Framework`.

> El repositorio utiliza proyectos clásicos de Visual Studio. Los SDK modernos de `dotnet` no garantizan que una solución así pueda abrirse o restaurarse sin migración.

## Cómo ejecutar una práctica

### Visual Studio

1. Abrir la carpeta raíz del repositorio.
2. Abrir el archivo `.sln` correspondiente a la práctica.
3. Seleccionar **Compilar > Compilar solución**.
4. Ejecutar con **Iniciar sin depurar** (`Ctrl+F5`).

Ejemplo con Visual Studio Developer Command Prompt:

```bat
msbuild "Generics\Generics.sln" /p:Configuration=Debug
Generics\Generics\bin\Debug\Generics.exe
```

Para la práctica separada en capas:

```bat
msbuild "Saludo\Saludo en capas\Saludo en capas.sln" /p:Configuration=Debug
"Saludo\Saludo en capas\Saludo en capas\bin\Debug\Saludo en capas.exe"
```

## Archivos generados

Las carpetas `bin/` y `obj/` contienen resultados de compilación generados por Visual Studio y no forman parte del código fuente educativo. Algunos ejemplos crean archivos de datos al ejecutarse:

- `Archivos/Archivos/bin/Debug/archivo.txt`
- `Cliente - Clase Abstracta/Cliente - Clase Abstracta/bin/Debug/ArchivoBitacora.log`

Al ejecutar desde Visual Studio, comprueba primero la ruta de salida de la práctica si una aplicación busca un archivo relativo a su directorio de trabajo.

## Alcance educativo

Este repositorio es una colección de ejercicios históricos y aislados, no una aplicación única ni un framework reutilizable. Cada carpeta conserva una solución independiente para facilitar el aprendizaje de conceptos específicos.
