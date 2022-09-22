# LA-1100-1
# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                                                                                                             |
| ----- | ------- | --------------------------------------------------------------------------------------------------------------------------------------------|
|       | 0.0.1   |  Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben.   |
|       | ...     |                                                                                                                                             |
|       | 1.0.0   |                                                                                                                                             |

## 1 Informieren

### 1.1 Ihr Projekt

Mein Projekt ist ein Nummerratspiel bei dem man eine zuffällige Zahl eraten kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ            | Beschreibung                                                                                        |
| ---- | --------------- | -------------- | --------------------------------------------------------------------------------------------------- |
| 1    | Muss            |   Funktional   | Als Benutzer möchte ich eine Zahl eingeben können, damit ich spielen kann.                          |
| 2    | Kann            |   Qualität     | Als Benutzer möchte ich das dass spiel ansprechend aussieht, damit es mir Freude macht beim Spielen.|
| 3    | Kann            |   Qualität     | Als Benutzer möchte ich abwechslung, damit es spannend bleibt.                                      |
| 4    | Muss            |   Funktional   | Als Benutzer möchte ich wissen ob ich richtig geraten habe, damit ich weiss wann ich gewonnen habe. |
| 5    | Muss            |   Funktional   | Als Benutzer möchte ich Feedback erhalten, damit ich beim nächsten raten bessere Chancen habe.      |
| 6    | Muss            |   Funktional   | Als Benutzer möchte ich erneut raten können, damit ich mehr Chancen habe um zu gewinnen.            |
| 7    | Kann            |   Qualität     | Als Benutzer möchte ich ein "Hardmode", damit der Spielpass länger gegeben ist.                     |

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe                             | Erwartete Ausgabe                                                 |
| ---- | ------------ | ----------------------------------- | ------------------------------------------------------------------|
| 1.1  |  Console App | Zahl + Enter                        |  Das Spiel geht weiter                                            |
| 2.1  |  Console App |   -                                 |   -                                                               |
| 3.1  |  Console App |  Benutzer aktiviert ein Timer       |  Timer wird aktiviert                                             |
| 4.1  |  Console App | Zahl + Enter                        |  Wenn die Zahl richtig ist "Gut gemacht du hast die richtige Zahl"|
| 5.1  |  Console App |   -                                 |  Wenn die Zahl höher ist schreib Zahl muss höher sein.            |
| 6.1  |  Console App | Wenn falsch geraten ist             |  Erneut raten können                                              |
| 7.1  |  Console App |y/n                                  |  Hardmode activated                                               |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme
Hier mein PAP Diagramm
![grafik](https://user-images.githubusercontent.com/111046375/186598833-d2a42f8a-60e9-46dc-a9e9-b42a3efec59f.png)


## 2 Planen

| AP-№ | Frist             | Zuständig    | Beschreibung          | geplante Zeit   |
| ---- | ----------------- | -------------| --------------------- | ----------------|
| 1.A  |  1. September     |      Nils    |   User input          |     30 min      |
| 2.A  |  15. September    |      Nils    |   Gestalten           |     1h          |
| 2.b  |  15. September    |      Nils    |   lernen zu Gestalten |     1h          |
| 3.A  |  15. September    |      Nils    |   Timer               |     1h          |
| 4.A  |  1. September     |      Nils    |   Gewonnenmechanismus |     30min       |
| 5.A  |  8. September     |      Nils    |   Feedback            |     1h          |
| 6.A  |  1. September     |      Nils    |   Erneut Spielen      |     30min       |
| 7.A  |  15. September    |      Nils    |   Hardmode            |     2h          |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum           | Zuständig    | geplante Zeit      | tatsächliche Zeit      |
| ---- | --------------- | ------------ | ------------------ | ---------------------- |
| 1.A  | 01.09.2022      |   Ich        |    30min           |     10min              |
| 4.A  | 01.09.2022      |   Ich        |    30min           |  ca 30min              |
| 5.A  | 01.09.2022      |   Ich        |    1h              |     1h                 |
| 6.A  | 01.09.2022      |   Ich        |    30min           |     1.5h               |
| 6.A  | 01.09.2022      |   Ich        |    30min           |     1.5h               |
| 2.A  | 08.09.2022      |   Ich        |    1h              |     2h                 |
| 2.b  | 08.09.2022      |   Ich        |    1h              |     1h                 |
✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum      | Resultat                           | Tester                |
| ---- | -----------| -----------------------------------|-----------------------|
| 1.1  | 22.09.2022 | Das Spiel geht weiter              | Nils Wiederkehr       |
| 2.1  | 22.09.2022 | Das Spiel sieht farbig aus         | Nils Wiederkehr       |
| 3.1  | 22.09.2022 | Funktioniert nicht                 | Nils Wiederkehr       |
| 4.1  | 22.09.2022 | Glückwunsch sie haben die Zahl     | Nils Wiederkehr       |
| 5.1  | 22.09.2022 | "Zahl muss höher sein"             | Nils Wiederkehr       |
| 6.1  | 22.09.2022 | Das Spiel kann neu gestartet werden| Nils Wiederkehr       |
| 7.1  | 22.09.2022 | Kein Hardmode                      | Nils Wiederkehr       |

Das Spiel läuft gut, es hat nur keinen Hardmode und keinen Timer, man kann das Spiel aber einwandfrei spielen.

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
