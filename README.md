# Laboratorio #3: Controles Avanzados, Enumeraciones e Interfaces MDI en C#

📅 **Fecha:** 10/9/2026

## 📋 Contenido del Repositorio

Este repositorio contiene el desarrollo del **Laboratorio #3** de la asignatura *Herramientas de la Programación Aplicada III (.Net)*. La práctica abarca tres casos de estudio independientes: el manejo de controles avanzados de Windows Forms (`DataGridView`, `DateTimePicker`, `ErrorProvider`), la simulación del juego de dados **Craps** aplicando enumeraciones y estructuras de control, y la construcción de una aplicación con **Interfaz de Múltiples Documentos (MDI)**.

## 🛠️ Tecnologías Utilizadas

- **Lenguaje / Framework:** C# (.NET, Windows Forms)
- **IDE:** Visual Studio 2026 / Visual Studio Code
- **Tipo de proyecto:** Aplicación de Escritorio (Windows Forms) y Consola
- **Control de versiones:** Git / GitHub

## 💻 Capturas de Pantalla y Problemas

### Interfaz Principal

- **Actividad 1 – DataGridView:** Se desarrolló un formulario que utiliza los controles `DataGridView`, `DateTimePicker`, `ErrorProvider` y `ToolStrip` para mostrar y validar información. El `DateTimePicker` permite seleccionar fechas de forma gráfica (por ejemplo, para calcular edades o registrar fechas de nacimiento), mientras que el `ErrorProvider` valida en tiempo real los datos ingresados por el usuario, mostrando un ícono de advertencia junto al campo con error y un mensaje emergente (tooltip) explicativo. Se implementó además una clase `Persona`, una clase de utilidades (`Utilidades.cs`) con métodos estáticos, y el uso de la colección dinámica `ArrayList` para almacenar objetos.

<img width="920" height="671" alt="image" src="https://github.com/user-attachments/assets/877ac751-7b03-48d7-b810-1e5843983226" />



- **Actividad 2 – Juego de Craps:** Se implementó en C# una simulación del juego de dados **Craps**, creando una clase `Craps` (mediante `dotnet new class -n Craps`) que utiliza la clase `Random` para generar tiradas de dos dados a través del método `TirarDados()`. Se aplicó una **enumeración** (`enum NombreDados`) para representar los distintos estados/resultados del juego (por ejemplo, Continúa, Ganó, Perdió), realizando una **conversión explícita (casting)** de la suma entera de los dados al tipo enumerado mediante `(NombreDados) sumaDeDados`. La lógica del juego se controló con una estructura `switch` para evaluar el resultado de la tirada de salida y las tiradas posteriores hasta determinar si el jugador gana o pierde, siguiendo la terminología del juego (tirador, tirada de salida y punto).

<img width="1467" height="507" alt="image" src="https://github.com/user-attachments/assets/6a1aa9b1-1d79-40e0-82a3-2a23c6cbd64f" />



- **Actividad 3 – MDI (Interfaz de Múltiples Documentos):** Se construyó una aplicación de Windows Forms con arquitectura **MDI**, configurando el formulario principal como contenedor mediante la propiedad `IsMdiContainer = true`. Se crearon formularios hijos (por ejemplo, `frmVentanaTexto`) a los que se les asignó la propiedad `MdiParent` antes de mostrarlos con `.Show()`, garantizando que pertenezcan a la ventana padre. Se incorporó un `ToolStrip`/`MenuStrip` acoplado en la parte superior del formulario padre para la navegación entre ventanas hijas, ajustando el tamaño de los íconos mediante `ImageScalingSize`. Adicionalmente, se utilizó `Application.OpenForms.OfType<frmVentanaTexto>().FirstOrDefault()` para verificar si una ventana hija ya se encuentra abierta, y el método `BringToFront()` para traer al frente una ventana hija minimizada o tapada por otra.

<img width="742" height="490" alt="image" src="https://github.com/user-attachments/assets/d9dd4f0f-28c7-427a-ac84-583f566dc92b" />



## ▶️ Instrucciones de Ejecución / Uso

1. Clonar el repositorio:
   ```
   https://github.com/Lyrics354/Laboratorio-3.git
   ```
2. Abrir la solución o carpeta de la actividad deseada en **Visual Studio 2026** (Actividades 1 y 3) o **Visual Studio Code** (Actividad 2).
3. **Para la Actividad 2 (Craps):** si el proyecto no existe aún, generarlo con:
   ```
   dotnet new console -n JuegoCraps
   cd JuegoCraps
   dotnet new class -n Craps
   ```
4. Verificar que el framework de destino sea el indicado en el proyecto (.NET).
5. Compilar el proyecto (`Ctrl + Shift + B` en Visual Studio, o `dotnet build` en consola).
6. Ejecutar la aplicación con **F5** / **Ctrl + F5**, o mediante `dotnet run` para el proyecto de consola.
7. Para la Actividad 3 (MDI): al iniciar la aplicación, usar el `ToolStrip`/menú del formulario padre para abrir las ventanas hijas y comprobar el comportamiento de contenedor MDI.

## 👤 Autor y Contexto

- **Nombre:** Wilson Wu 2-756-299
- **Institución:** Universidad Tecnológica de Panamá (UTP) – Campus Víctor Levis Sasso
- **Grupo:** 1IL133
- **Instructor:** Ing. Irina Fong
- **Fecha de Realización:** 10/9/2026

## 🔗 Referencias

- Caso de Estudio: DataGridView – Ing. Irina Fong
- Caso de Estudio: Juego de Craps – Ing. Irina Fong
- Ventana de Interfaz de Múltiples Documentos (MDI) – Ing. Irina Fong
- Documento guia para laboratorio #3 https://virtual.utp.ac.pa/moodle/pluginfile.php/4964766/mod_assign/introattachment/0/Laboratorio%20de%20Validaciones%2C%20M%C3%A9todos%20Est%C3%A1ticos%20y%20Nuevos%20Controles%20%28DataGridView%29.docx?forcedownload=1
- Documento explicación de la actividad #1 (DataGridView): https://virtual.utp.ac.pa/moodle/pluginfile.php/4964640/mod_folder/content/0/Caso%20de%20Estudio%20DataGridView.pptx?forcedownload=1
- Documento explicación de la actividad #2 (Juego de Craps): https://virtual.utp.ac.pa/moodle/pluginfile.php/4964640/mod_folder/content/0/Caso%20de%20Juego%20de%20Craps.pptx?forcedownload=1
- Documento explicación de la actividad #3 (Interfaz de Múltiples Documentos): https://virtual.utp.ac.pa/moodle/pluginfile.php/4964640/mod_folder/content/0/MDI.pptx?forcedownload=1

