using UnityEngine;

// =======================
// Classe Player (no MonoBehaviour)
// =======================
public class PlayerClass
{
    // campi "semplici", nome pubblico, punteggio protetto
    public string nome;
    private int punteggio;

    // costruttore base
    public PlayerClass(string nome, int punteggio)
    {
        this.nome = nome;
        SetPunteggio(punteggio); // passo sempre dal set (così clampo sotto zero)
    }

    // --- getter / setter manuali ---
    public int GetPunteggio()
    {
        return punteggio;
    }

    public void SetPunteggio(int valore)
    {
        if (valore < 0) valore = 0;   // niente negativi
        punteggio = valore;
    }

    // incremento "semplice"
    public void IncrementaPunteggio(int valore)
    {
        punteggio += valore;
    }

    // vince a 100+
    public bool IsVincitore()
    {
        return punteggio >= 100;
    }

    // attacco molto diretto: log + delega al nemico
    public void AttaccaNemico(Enemy nemico, int danno)
    {
        Debug.Log($"{nome} attacca {nemico.nome} infliggendo {danno} danni!");
        nemico.SubisciDanno(danno);
        Debug.Log($"Il nemico {nemico.nome} ha {nemico.GetSalute()} di salute rimanente");
    }
}


// =======================
// Classe Enemy (no MonoBehaviour)
// =======================
public class Enemy
{
    public string nome;
    private int salute;
    public int livello;

    public Enemy(string nome, int salute, int livello)
    {
        this.nome = nome;
        this.salute = (salute < 0) ? 0 : salute; // giusto per sicurezza
        this.livello = livello;
    }

    public void SubisciDanno(int danno)
    {
        // tolgo solo valori positivi
        if (danno < 0) danno = 0;

        salute -= danno;
        if (salute < 0) salute = 0;

        Debug.Log($"Il nemico {nome} subisce {danno} danni. Salute rimanente: {salute}");
    }

    public int GetSalute()
    {
        return salute;
    }
}


// =======================
// Driver MonoBehaviour
// =======================
public class Esercizio1 : MonoBehaviour
{
    [SerializeField] int incremento = 20; // lo imposto dall'Inspector

    void Start()
    {
        // player di test
        PlayerClass p1 = new PlayerClass("Miky", 90);
        Debug.Log($"Punteggio iniziale di {p1.nome}: {p1.GetPunteggio()}");

        // incremento + check vittoria
        p1.IncrementaPunteggio(incremento);
        Debug.Log($"Nuovo punteggio: {p1.GetPunteggio()}");

        if (p1.IsVincitore())
            Debug.Log($"{p1.nome} è vincitore!");
        else
            Debug.Log($"{p1.nome} non ha ancora vinto.");

        // nemico e piccola simulazione
        Enemy e1 = new Enemy("Goblin", 40, 2);

        p1.AttaccaNemico(e1, 15);
        p1.AttaccaNemico(e1, 20);
        p1.AttaccaNemico(e1, 10);
    }
}




























