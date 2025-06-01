# 🧾 Globální TO-DO – Pojišťák.NET

> Projekt je ve fázi refaktoringu z důvodu omezeného HW a nutnosti dokončit rekvalifikační úkol.  
> Nyní směřuje ke stabilní a náborově použitelné verzi.

---

## ✅ Základní úkoly – očekávané u juniora

### 🔐 Autentizace & role
- [ ] Přihlášení/odhlášení přes ASP.NET Identity
- [ ] Vytvoření rolí: User, Admin, SuperAdmin
- [x] Registrace uživatele (Register)
- [ ] Registrace - validace data narození (rok 2100)
- [ ] Zobrazení různých menu podle role
- [ ] Redirect po přihlášení na dashboard podle role
- [x] Oddělit veřejné stránky od přihlášené části
- [ ] Přístup k admin funkcím pouze pro Admin / SuperAdmin

### 📄 Správa entit
#### Pojištěnci
- [x] CRUD operace (admin rozhraní)
- [x] Validace formulářů
- [x] Napojení na pojištění

#### Pojištění
- [ ] Přehled pojištění
- [x] Napojení na pojištěnce

### 🧪 Testování
- [ ] Test: přihlášení jako User
- [ ] Test: omezení přístupu podle rolí
- [x] Test: CRUD operace jako Admin

---

## 🌟 Nadstandard – "chci, ale neočekává se"

### 🔐 Účet & Bezpečnost
- [ ] Dvoufázové ověření (2FA – fake nebo přes službu)
- [ ] Ověření e-mailu (po registraci)
- [ ] Registrace - krokový JS "wizard" formulář
- [ ] Obnova hesla (ForgotPassword + ResetPassword)
- [ ] Změna e-mailu a telefonu (ChangeEmail / ChangePhone)
- [ ] Správa účtu POUHÉHO uživatele - (Nastavení)
- [ ] Zrušení účtu (?)

### 🏠 Veřejná homepage
- [x] Přepracování `Index.cshtml` jako prezentační homepage
- [ ] Sekce článků / aktualit
- [ ] Výzva k akci: přihlášení / kontakt
- [ ] Stylování: hlavička, patička, CTA "Vyzkoušej nás" sekce

### 🎨 UI & UX
- [ ] Implementace Bootstrap nebo Tailwind
- [ ] Mobilní zobrazení (responsive)
- [ ] Error stránka 404 („Pojišťák je na schůzce…“)

### 📦 Technické
- [x] Dependency Injection pro `SignInManager`
- [x] Registrace `DbContext` v `Program.cs`
- [ ] Logging - např. ukládání logů akcí adminů, přihlášení a registrací
- [ ] Přidání jednotkových testů (ChatGPT) bez spouštění celé aplikace
     - funguje kód správně?
- [ ] Amatérská ochrana proti XSS (Nestačí vestavěná XSS ochrana?)

---

## ⚠️ Pod čarou – odbornější nápady
##### Poznámka: generováno ChatGPT

- [ ] Statistika přihlášení / pokusů (Admin dashboard)
- [ ] Přesunout metody do `AccountService` (oddělení logiky)
- [ ] Loading / Spinner / Skeleton při načítání obsahu
- [ ] Lockout po X neúspěšných pokusech (SecurityStamp, LockoutEnabled)
- [ ] Více typů ověření (SMS, Portál občana, eGov)
- [ ] Audit log: historie změn uživatele
- [ ] Připojení k OAuth providerům (Google, GitHub, Microsoft)
- [ ] Dynamická práva (např. správa práv v DB)

---

## 💡 Shrnutí

- Projekt má základní funkcionalitu hotovou a vstupuje do fáze doplnění a vizuálního doladění.
- Prioritou je oddělení veřejné části od přihlášené, včetně správy rolí.
- Sekce pod čarou mohou být silným argumentem u technicky zaměřeného náboráře.

