Instrukcja jak odpalić projekt

W środowisku Visual Studio Code trzeba miec zainstalowane magazynowanie i przetwarzanie danych.
Trzeba wejść w visual studio installer, w opcji Visual Studio Community 2022 kliknąć modyfikuj.
Po zjechaniu na dół listy w zakładce Inne zestawy narzędzi, odhaczyć Magazynowanie i przetwarzanie danych oraz zatwierdzić wybór.

Po prawej stronie w Eksploratorze rozwiązań(Solution Explorer) kliknąć prawym na ATM Banking machine, otworzyć Zarządzaj pakietami NuGet
zainstalować pakiety
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools

po zainstalowaniu tych pakietów, trzeba przejść do zakładki Narzędzia -> Manedżer pakietów NuGet -> Konsola menadżera pakietów
wkleić

1. Add-Migration InitialCreate
2. Update-Database

Po zrobieniu tych czynności utworzy się baza danych i można odpalić aplikacje.
Na samym początku trzeba utworzyć konto, aby to zrobić wystarczy na głównym ekranie kliknac "SIGNUP"

