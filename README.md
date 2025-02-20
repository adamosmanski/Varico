Utworzenie aplikacji ASP.NET Core Web API (preferowana wersja 8.0) z wykorzystaniem Entity Framework Core (w modelu Code First). Serwis ma symulować działanie systemu wypożyczalni pojazdów, uwzględniając zabezpieczenia przed podwójną rezerwacją tego samego pojazdu.

Zakres funkcjonalności:
* rezerwacja pojazdu na określony czas
* zwrot pojazdu
* sprawdzenie dostępnych pojazdów w danym terminie
Dodatkowe atuty:
* utworzenie testów jednostkowych
* zastosowanie autoryzacji użytkownika (np. JWT)
* zastosowanie wzorca Mediator / architektury CQRS i Event Sourcing
* dostarczenie rozwiązania w środowisku dockerowym
* asynchroniczne powiadomienia o zbliżającym się terminie zwrotu pojazdu (np. SignalR)
* prosty frontend SPA w Angularze, który umożliwia:
* wyszukiwanie i rezerwację pojazdów
* zarządzanie swoimi rezerwacjami
* wyświetlanie szczegółów pojazdu
* Dodatkowe wymagania:
* obsługa różnych typów pojazdów (samochody osobowe, ciężarowe, motocykle)
* możliwość pobierania raportów o stanie floty pojazdów
