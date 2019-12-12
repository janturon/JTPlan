# JTPlan

## Informační pole

Informační pole se nachází pod kalendářem a obsahuje popis všech událostí a aktivit v aktivní den (v kalendáři červeně). Den se aktivuje kliknutím do kalendáře.

## Události

Událost je akce naplánovaná na konkrétní den. Může mít nastavenu hodinu (pro nevyplnění ponechte 0:00) a délku trvání. V kalendáři se den s událostmi ztuční. Později lze událost upravit či smazat.

## Aktivity

Aktivita je vícedenní činnost. V kalendáři se zobrazuje od zvoleného dne (den s aktivitou se neztuční) ve zvolené dny v týdnu donekonečna. Pokud je zvolený deadline, zobrazuje se informace, kolik dní zbývá, případně před kolika dny nastal. Ke každé aktivitě lze kontextovým menu přidat ke konkrétnímu dni poznámku - ta je vhodná pro popis, co konkrétně se v rámci této aktivity ten den dělalo. Poznámky lze pak souhrnně zobrazit kontextovým menu na název aktivity v informačním poli, případně je exportovat do CSV a dále zpracovat v jiných programech. Aktivity, které nemají žádný den v týdnu se nazývají neaktivity a lze je zobrazit kontextovým menu v informačním poli.

## FTP server

FTP server slouží pro sdílení dat s jinými lidmi. Pokud nevíte, co tam vyplnit, požádejte vlastníka webových stránek, kterému věříte, ať vám údaje poskytne. Heslo se ukládá na místním počítači zašifrované. Na server se nahrává pouze databáze s vyplněnými údaji o velikosti v řádu kilobytů.

Pokud databázi sdílíte, před započetím práce klikněte na tlačítko **Test**, které zkontroluje, jestli se databáze od vašeho posledního nahrání nezměnila. Pokud ano, klikněte na **Stáhni sem**, které stáhne soubor databáze. Po dokončení úprav v aplikaci pak klikněte na **Nahrej tam**, což nahraje databázi z vašeho počítače na server, odkud si ji mohou stáhnout ostatní. V případě, že jste už provedli nějaké změny a databáze na serveru je také někým změněná, lze situaci vyřešit tlačítkem **Synchronizuj**. To přidá nová data z databáze na serveru do vaší databáze a takto sloučenou databázi opět nahraje na server. Tímto jsou také obnoveny záznamy, které jste od posledních nahraných úprav smazali a je nutno smazat je znovu.

Pokud sdílíte data, databázi občas zálohujte pro případ, že by někdo databázi na serveru poškodil a vy jste si stáhli ze serveru tuto poškozenou databázi.

## Kontakty

Toto pole slouží pro ukládání kontaktů na lidi související s aktivitami, které jsou dočasné a nechcete je ukládat do mobilu, nebo kontakty, které chcete sdílet s ostatními v případě, že používáte FTP server.

## Škrtátko na poznámky

Je zde pro případ potřeby poznamenávat si data, když někomu voláte.

## Stavový řádek

Program vás neobtěžuje vyskakovacími okny krom případů mazání. Veškeré informace o výsledku provedených akcí se dozvíte v doplní části aplikace.

## Problémy se spuštěním

Zkompilováno na Windows 7 .NET 4.0; v případě problémů se SQLite knihovnou stáhněte [verzi pro vaši architekturu](http://system.data.sqlite.org/index.html/doc/trunk/www/downloads.wiki)

## Chystané aktualizace v příští verzi

Současná verze je 1.0, pro příští verzi se chystá

- v pravém dolním rohu se zobrazí kontakt na mne
- soubor databáze se bude automaticky zálohovat
- ke stažení budou zkompilované aplikace

Příští verze vyjde, až seznam výše trochu nabobtná, pokud bude nutné opravit nějakou závažnou chybu nebo pokud do seznamu přibude nějaký zajímavější nápad.

## Kontakt

Zpětnou vazbu můžete poskytnout na janturon@email.cz