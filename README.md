# Aistencia a Cursos 📊 - DOMENICO ALEJANDRO

[![C#](https://img.shields.io/badge/C%23-language-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop-0078D6?logo=windows&logoColor=white)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![EPPlus](https://img.shields.io/badge/EPPlus-Excel%20library-004880?logo=nuget&logoColor=white)](https://www.nuget.org/packages/EPPlus/)
[![EPPlus NuGet](https://img.shields.io/nuget/v/EPPlus.svg?label=EPPlus)](https://www.nuget.org/packages/EPPlus/)
[![XLSX](https://img.shields.io/badge/Excel-.xlsx-217346?logo=microsoft-excel&logoColor=white)](https://learn.microsoft.com/office/open-xml/spreadsheets/)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=dotnet&logoColor=white)](https://learn.microsoft.com/dotnet/framework/)
[![Windows](https://img.shields.io/badge/Windows-Only-0078D6?logo=windows&logoColor=white)](https://www.microsoft.com/windows/)
[![Visual Studio](https://img.shields.io/badge/IDE-Visual%20Studio%202022-5C2D91?logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)

---

## 📖 Descripción

ReconKit es una aplicación de escritorio en **C# (WinForms)** para la **gestión de asistencia de alumnos**.  
Permite:

- Registrar alumnos con **nombre, asistencia, fecha y curso**.  
- Importar y exportar los datos desde/hacia **Excel (.xlsx)**.  
- Usar una interfaz simple basada en `DataGridView`.  
- Guardar la información en archivos reutilizables para seguimiento de asistencia.  

Ideal para institutos, cursos o capacitaciones que necesitan un control rápido sin sistemas complejos.

---

## ⚙️ Tecnologías usadas

- **C# + .NET Framework 4.8** → Lenguaje principal y runtime.  
- **Windows Forms** → Interfaz gráfica de usuario (GUI).  
- **EPPlus** → Librería para leer/escribir Excel (`.xlsx`) sin requerir Microsoft Office.  
- **Excel** → Almacén de datos de asistencia.  
- **Visual Studio 2022** → IDE recomendado.  

---

## 📥 Instalación

1. Cloná este repositorio:
   ```bash
   git clone https://github.com/tuusuario/reconkit.git
   cd reconkit
Abrí el proyecto en Visual Studio 2022.

Asegurate de tener .NET Framework 4.8 instalado.

Instalá la librería EPPlus desde NuGet:
Install-Package EPPlus

▶️ Uso

Ejecutá la aplicación desde Visual Studio o el archivo compilado.

En la ventana principal vas a poder:

Importar Excel → cargar asistencia existente.

Agregar alumno → ingresar datos manualmente.

Exportar Excel → guardar asistencia en un nuevo archivo.

📊 Formato de Excel esperado

El archivo .xlsx debe tener las siguientes columnas:

Nombre	Asistencia	    Fecha de Asistencia	        Curso
Juan	  true	          2025-03-10	              2785- PANADERO
María	  false	          2025-03-10	              2790- PRACTICO EN MANTENIMIENTO DE EDIFICIOS


## 📸 Capturas
<img width="1085" height="479" alt="2" src="https://github.com/user-attachments/assets/86cfb5ab-2367-44dd-8786-9205086bb7af" />
<img width="920" height="480" alt="1" src="https://github.com/user-attachments/assets/8356d072-d77f-49ca-9e9c-ba4498b425db" />

📌 Roadmap / Ideas futuras

Filtrar asistencia por curso y fecha.

Exportar a PDF además de Excel.

Soporte multiusuario con base de datos.

📜 Licencia

Este proyecto está bajo la licencia MIT
.
Podés usarlo, modificarlo y distribuirlo libremente, con atribución.
