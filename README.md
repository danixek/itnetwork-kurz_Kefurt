# Pojišťák.NET

> ⚠️ Tato verze byla publikována s vědomým technickým dluhem (architektura & interní konzistence budou postupně opraveny v následujících verzích). UI prošlo zásadním redesignem.

Tento projekt vznikl jako závěrečný projekt rekvalifikačního kurzu u ITnetwork. 

Původní verzi jsem vnímal jako nedotaženou, proto jsem se pustil do její revize a rozšíření,  
aby lépe reprezentoval mé schopnosti a mohl sloužit jako ukázka mé práce pro hledání juniorní pozice v IT.

## O projektu

Pojišťák.NET je aplikace pro evidenci pojištění, sestavená v ASP.NET Core s použitím Identity pro správu uživatelů a EF Core pro databázi.

## Stav projektu

Projekt je v aktivním vývoji, probíhají průběžné úpravy architektury i kódu.
Oproti původní verzi chci kompletně předělat uživatelské rozhraní tak,
aby odpovídalo mému vkusu a nebylo slepou kopií zadání.
Plánuji také přidat admin přihlašování a implementovat pokročilé funkce,
které jsou na juniora atypické, aby projekt více vynikl.

Věřím, že tyto změny pomohou vytvořit silnější portfolio,
které ukáže nejen mé schopnosti, ale i ochotu programovat a tvořit jedinečné.

## Jak projekt spustit

Pro spuštění projektu doporučuji použít pokročilé editory jako Visual Studio Community nebo JetBrains Rider.
Alternativně lze použít i Visual Studio Code s doinstalovaným rozšířením C# Dev Kit, který nainstaluje .NET SDK včetně nástroje dotnet.

1. Naklonujte repozitář  
   `git clone https://github.com/danixek/PojistakNET.git`  
   `cd PojistakNET`
2. Ověřte připojení k databázi v souboru `appsettings.json`  
   (pokud používáte výchozí nastavení, přeskočte)
3. Sestavte projekt:  
   `dotnet build`  
   Spuštěním se zkontroluje struktura projektu a automaticky se stáhnou závislosti - NuGet balíčky.
4. Proveďte migraci databáze:
   ```bash příkazy  
   dotnet ef database update --context ApplicationDbContext  
   dotnet ef database update --context InsuranceContext
5. Spusťte projekt:  
   `dotnet run`
   
> 💡 **Poznámka:** Pokud se příkaz `dotnet ef` nezdaří, je pravděpodobně potřeba doinstalovat EF CLI nástroj:  
`dotnet tool install --global dotnet-ef`

Po úspěšném spuštění se v konzoli objeví adresa (např. https://localhost:5001).
Otevřete ji v prohlížeči – projekt by měl být dostupný.
Ve Visual Studiu Community nebo Rideru se aplikace často spustí automaticky s otevřením prohlížeče.

