Perfetto Miky, ecco la versione aggiornata e coerente del tuo **README** per il laboratorio **Modulo 2 – Lezione 6**, nello stesso stile di quello precedente (chiaro, professionale e “Epicode Master style”).
Include e spiega gli **ultimi esercizi svolti**: Copy by Value/Ref/Out, Stack & Heap, Enum, Switch, Namespace e Array manipulation.

---

# **Basic Unity 3D Practice – Epicode Master — W3-D2-Lab**

(**Funzioni avanzate, Reference Types, Enum, Namespace, Array e Problem Solving**)

## **Project Description**

Questo repository raccoglie gli esercizi realizzati durante il **Modulo 2 – Lezione 6** del Master in Game Development (Epicode).
Gli script C# sono stati sviluppati e testati in **Unity 2022.3+**, con l’obiettivo di comprendere a fondo il comportamento della memoria, i parametri per valore e riferimento, l’utilizzo di `enum`, la gestione dei `namespace` e la manipolazione di array.

Ogni esercizio è stato progettato per introdurre o consolidare un concetto chiave di **programmazione procedurale e memoria in C#**, con applicazioni pratiche in Unity.

---

## **Learning Objectives & Demonstrated Skills**

### **Gestione della memoria e passaggio dei parametri**

* Comprendere la differenza tra **Copy by Value** e **Copy by Reference**.
* Utilizzo delle parole chiave **`ref`** e **`out`** per lavorare con variabili originali.
* Concetto di **indirizzo di memoria** e riferimento ai dati su Stack e Heap.
* Simulazione del comportamento dei **puntatori di C++** tramite `ref`.

### **Funzioni e modularità**

* Creazione di funzioni con parametri multipli e return di tipo diverso.
* Definizione di funzioni **overload** (stesso nome, firme diverse).
* Comprensione del flusso di chiamate (`Start()` → funzioni esterne).
* Gestione degli errori logici e dei casi limite (divisione per zero, array vuoti, ecc.).

### **Enum e organizzazione del codice**

* Creazione e utilizzo di **enumeratori** (`enum`) per rendere il codice leggibile e sicuro.
* Esposizione di un `enum` all’interno dell’**Inspector** di Unity come menu a tendina.
* Assegnazione di **valori espliciti** agli enum per evitare conflitti o “slittamenti”.
* Comprensione di **enum annidati** in classi o `namespace`.

### **Namespace e strutturazione del codice**

* Uso del costrutto **`namespace`** per organizzare logicamente le classi.
* Gestione dei conflitti di nomi (es. `UnityEngine.Vector3` vs `System.Numerics.Vector3`).
* Uso di `using` per importare i namespace necessari.
* Comprensione del comportamento del compilatore quando trova tipi omonimi.

### **Array e manipolazione dei dati**

* Ricerca e gestione di elementi con funzioni dedicate (`Find`, `PutToBack`, `Shift`).
* Implementazione di logiche di **rotazione e spostamento** degli elementi.
* Ottimizzazione con `Array.Copy()` e indicizzazione modulare (`%`).
* Debug e stampa dinamica con `string.Join()` e `Debug.Log()`.

---

## **Esercizi pratici**

### **Esercizio 1 – VariableSwap**

* Dichiarazione di due variabili (`a`, `b`).
* Stampa dei valori iniziali.
* Scambio dei valori tramite variabile temporanea e `Debug.Log()`.
* Introduzione al concetto di **Copy by Value** (nessun effetto sull’originale).

### **Esercizio 2 – VariableSwap con ref**

* Creazione di due funzioni:
  `Swap(int, int)` e `Swap(ref int, ref int)`.
* Confronto tra passaggio **per valore** e **per riferimento**.
* Analogia con i **puntatori** in C++.
* Stampa comparativa dei risultati nella Console.

### **Esercizio 3 – SafeDivideExercise**

* Implementazione della funzione `SafeDivide(int a, int b, out int result)`.
* Restituzione `bool` per segnalare se la divisione è valida.
* Uso di `out` per restituire il risultato calcolato o 0 in caso di errore.
* Log informativo o di tipo `Debug.LogWarning()` in caso di divisione per zero.

### **Esercizio 4 – LetsPlayWithArrays**

* Creazione di un array di numeri e manipolazione tramite funzioni:

  * `Find()` → trova la prima occorrenza.
  * `PutToBack()` → sposta un elemento in fondo.
  * `ShiftOnce()` → ruota l’array di un passo.
  * `Shift()` → ruota l’array di N passi.
* Introduzione al **modulo** (`%`) per gestire gli shift multipli.
* Ottimizzazione con `Array.Copy()` e `Array.IndexOf()`.

---

## **Learning Highlights**

| Concetto        | Descrizione                                                                |
| --------------- | -------------------------------------------------------------------------- |
| **Stack**       | Contiene le variabili locali e i parametri passati per valore.             |
| **Heap**        | Contiene gli oggetti dinamici e gli array (gestiti dal Garbage Collector). |
| **ref / out**   | Passaggio per riferimento: modifica la variabile originale.                |
| **enum**        | Tipi personalizzati a lista chiusa (usabili anche nell’Inspector).         |
| **namespace**   | Previene conflitti tra classi omonime e organizza il codice.               |
| **Array**       | Struttura statica per contenere più valori dello stesso tipo.              |
| **Debug.Log()** | Strumento di stampa per testare logiche e flusso di esecuzione.            |

---

## **Debug & Problem Solving**

Durante lo sviluppo sono stati usati:

* **`Debug.Log()`** per verificare lo stato delle variabili.
* **`Debug.LogWarning()`** per gestire casi anomali (es. divisore = 0).
* **String interpolation** (`$"..."`) per formattare i messaggi di output.
* **Test incrementali** per confermare il comportamento corretto delle funzioni.

---

## **How to Open (Unity 2022.3+)**

1. Clona o scarica il repository.
2. Apri **Unity Hub** e crea un progetto 3D con la stessa versione.
3. Copia le cartelle `Assets/`, `Packages/`, `ProjectSettings/`.
4. Apri la scena e aggiungi gli script `Esercizio1–Esercizio4` come componenti.
5. Premi **Play** per visualizzare i risultati nella Console.

---

## **Usage**

* Modifica le variabili esposte direttamente dall’Inspector.
* Osserva il comportamento di `ref`, `out` e le funzioni sugli array.
* Analizza i log in Console per comprendere il flusso dei dati.
* Prova vari valori per testare gli edge-case (0, array vuoti, index errati, ecc.).

---

## **Troubleshooting**

| Errore                     | Possibile causa                              | Soluzione                                          |
| -------------------------- | -------------------------------------------- | -------------------------------------------------- |
| `CS1620`                   | Mancanza di parola chiave `ref` o `out`      | Aggiungi `ref` o `out` in chiamata e dichiarazione |
| `IndexOutOfRangeException` | Accesso a indice fuori dai limiti dell’array | Usa `.Length` e verifica i limiti                  |
| `CS0246`                   | Classe non trovata                           | Controlla i `using` o il `namespace` corretto      |
| `Divisione per zero`       | Valore del divisore errato                   | Usa `if (b == 0)` per gestire il caso              |

---

## **Summary**

Questa lezione ha portato la programmazione Unity a un livello più profondo, concentrandosi sulla **gestione della memoria, la modularità e la struttura del codice**.
Hai imparato a:

* Passare parametri **per valore o riferimento** e capire come agiscono in memoria.
* Usare **enum** e **namespace** per rendere il codice più leggibile e organizzato.
* Gestire la **sicurezza dei dati** (divisione sicura, out/ref).
* Manipolare array in modo dinamico e performante.
* Strutturare funzioni riutilizzabili e applicare debugging efficace.

**Obiettivo finale:** comprendere a fondo come Unity e C# gestiscono memoria, riferimenti e strutture dati, ponendo le basi per scripting avanzato, AI e gameplay systems modulari.


