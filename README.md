# CodeSmashHackatonSolution2023
Company Product Promotion Solution

Dakle, naš tim je pristupio ovom problem na sljedeći način:
Prvo smo problem rastavili na jednostavnije dijelove koje smo dio po dio rješavali.
Prvi korak je bio da razvijemo funkcionalnost na najosnovnijem nivou, to jest, da omogućimo provjeravanje postojanja codeList sa samo jednom grupom (npr. apple apple banana) u shoppingList listi (npr orange banana apple apple banana). Ovo je bilo prilično jednostavno jer trebalo je samo jednom petljom provjeriti sta se nalazi u shoppingList i provjeriti da li na bilo kojem dijelu imamo preklapanje svih elemenata codeListe.
Sljedeći korak je bio implementacija problema sa više grupa. Prvo smo rastavili codeList input na grupe koristeći C# “Split” naredbu. Input smo podijeli sa whitespace karakterom (razmakom). Kako smo shvatili problem, jedna grupa je ustvari jedan string kod codeListe, a riječi razdvojene nekim simbolom (kod nas je to whitespace) su pojedinačno voće. Poslije razdavajanja grupa, dodali smo brojač koji prati koliko grupa je uspješno pronađeno u shoppingListi. Pošto smo redom provjeravali, odma smo i znali da su grupe u pravilno redoslijedu.
Poslije toga, trebalo je još implementirati da između grupa može biti bilo koje voće. To smo uradili implementirajući backtracking algoritam (metodu), to jest, provjerili smo postojanje neke grupe sve dok ne dođe do greške, a zatim bi se pomjerili za samo jedan element i ponovo krenuli provjeravanje.
Zadnji korak je bio implementiranje “anything” funkcionalnosti, što je bilo veoma jednostavno. Samo smo dodali kod provjeravanja shoppingList i codeList, “ili” operator i provjerili da li je u codeList na tom mjestu string “anything”.
Uslov da ako je prazna codeList da odma vraćamo 1 smo dodali odmah na početku funkcije.
Na kraju funckije provjeravamo da li je brojač tačnih grupa jednak broju grupa u codeListi.

TIME AND SPACE COMPLEXITY

Odredili smo da je vremenska kompleksnost naše funkcije, u big O notaciji, O(mn).
Funkcija prolazi kroz cijelu shoppingList i provjerava svaki element sa codeList. U najgorem slučaju cijela shoppingList lista se mora pretražiti što rezultira u mn dužini izvršavanja.
Prostorna kompleksnost koda je O(k) gdje je k broj elemenata u najdužoj grupi codeList liste. Ratlog zašto samo gledamo jednu codeList grupe je to pto u bilo kojem vremenu potrebno je samo sačuvati trenutnu grupu codeListe i trenutni element shoppingListe.
