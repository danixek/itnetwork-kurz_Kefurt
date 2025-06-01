# Pojišťák.NET

This project was created as the final project of a retraining course at ITnetwork.

I found the original version unfinished, so I started revising and expanding it
to better showcase my skills and serve as a portfolio piece for seeking a junior IT position.

## About the project

Pojišťák.NET is an insurance management application built with ASP.NET Core, using Identity for user management and EF Core for database access.

## Project status

The project is actively under development, with ongoing adjustments to architecture and code.  
Compared to the original, I plan to completely redesign the user interface to reflect my taste rather than blindly copying the original requirements.
I also intend to add admin login and implement advanced features that are atypical for a junior project, to make it stand out.

I believe these changes will help build a stronger portfolio,  
showing not only my skills but also my willingness to program and create unique solutions.

## How to run the project

For running the project, I recommend using advanced editors such as Visual Studio Community or JetBrains Rider.  
Alternatively, you can use Visual Studio Code with the C# Dev Kit extension installed, which sets up the .NET SDK including the dotnet tool.

1. Clone the repository  
   `git clone https://github.com/danixek/PojistakNET.git`  
   `cd PojistakNET`
2. Verify the database connection string in `appsettings.json`  
   (skip this step if you use the default settings)
3. Build the project:  
   `dotnet build`  
   This will check the project structure and automatically download NuGet dependencies.
4. Run database migrations:
   ```bash příkazy
   dotnet ef database update --context ApplicationDbContext
   dotnet ef database update --context InsuranceContext
5. Run the project:
   `dotnet run`
   
> 💡 **Note:** If the `dotnet ef` command fails, you may need to install the EF CLI tool:  
`dotnet tool install --global dotnet-ef`

After successful startup, the console will display an address (e.g., https://localhost:5001).  
Open it in your browser — the project should be accessible.  
In Visual Studio Community or Rider, the app usually launches automatically with the browser opening.
