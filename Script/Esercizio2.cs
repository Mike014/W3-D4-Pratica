using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    // Stringa esposta nell'Inspector — puoi modificarla da Unity
    [SerializeField] string messaggio = "(aragorn;left;angry) Che siate attento, non è un gingillo quello che portate!";

    void Start()
    {
        // 1. Controllo di base: la stringa deve iniziare con "(" e contenere ")"
        if (string.IsNullOrEmpty(messaggio) || !messaggio.StartsWith("(") || !messaggio.Contains(")"))
        {
            Debug.Log("ERRORE: Formato messaggio non valido!");
            return;
        }

        // 2. Trovo l’indice di chiusura della parentesi
        int indexParentesiChiusa = messaggio.IndexOf(")");
        if (indexParentesiChiusa == -1)
        {
            Debug.Log("ERRORE: Mancano le parentesi di chiusura.");
            return;
        }

        // 3. Estraggo la parte tra parentesi tonde
        string contenutoParentesi = messaggio.Substring(1, indexParentesiChiusa - 1);

        // 4. Divido i valori separati da ';'
        string[] parametri = contenutoParentesi.Split(';');

        // 5. Estraggo la frase successiva (il dialogo vero e proprio)
        string frase = messaggio.Substring(indexParentesiChiusa + 1).Trim();

        // 6. Stampo i risultati in console
        Debug.Log("---- Dati estratti ----");
        for (int i = 0; i < parametri.Length; i++)
        {
            Debug.Log($"Parametro {i + 1}: {parametri[i]}");
        }
        Debug.Log($"Frase: {frase}");
        Debug.Log("-----------------------");
    }
}
