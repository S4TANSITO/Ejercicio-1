using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM_semana2_pt2 : MonoBehaviour
{
    public static GM_semana2_pt2 Instance;

    private int turnoActualEnemigo = 0;
    private bool turnoJugador = true;

    [SerializeField] private TMP_InputField[] atributos;

    [SerializeField] private GameObject[] pantallas;
    [SerializeField] private GameObject canvasJugador;
    [SerializeField] private TextMeshPro[] textosVida;
    private List<Entidad> entidades = new List<Entidad>();

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < entidades.Count; i++)
            {
                Debug.Log(entidades[i].Vida);
            }
        }
    }

    public void AtacarUasdasI(int indiceEntidad)
    {
        if(entidades[indiceEntidad].Vida <= 0) { Debug.Log("Toy muerto"); return; }

        if (turnoJugador) { entidades[indiceEntidad].RecibirDmg(entidades[0].Dmg); }
        else { entidades[indiceEntidad].RecibirDmg(entidades[turnoActualEnemigo].Dmg); }

        ActualizarInterfaz();
        
        //Debug.Log("Ataque!");

        if (!Victoria()) { SiguienteTurno(); }

    }

    public void AtacarUI(int indiceEntidad)
    {
        if (entidades[indiceEntidad].Vida <= 0) { Debug.Log("Toy muerto"); return; }

        if (turnoJugador) { entidades[0].Atacar(entidades[indiceEntidad]); }
        else { entidades[turnoActualEnemigo].Atacar(entidades[indiceEntidad]); }

        ActualizarInterfaz();

        //Debug.Log("Ataque!");

        if (!Victoria()) { SiguienteTurno(); }

    }

    private IEnumerator ControladorJuego()
    {
        while(true)
        {
            while (turnoJugador) { yield return null; }

            yield return new WaitForSeconds(1f);
            AtacarUI(0);
        }
    }

    public void SiguienteTurno()
    {
        turnoJugador = !turnoJugador;
        canvasJugador.SetActive(turnoJugador);

        if (!turnoJugador) { CuentaEnemigos(); }
        Debug.Log("SiguienteTurno");
    }

    private bool Victoria()
    {
        int contadorDeBajas = 0;

        for (int i = 1; i < entidades.Count; i++)
        {
            if(entidades[i].Vida == 0) { contadorDeBajas++; }
        }

        if(contadorDeBajas == (entidades.Count - 1)) { pantallas[0].SetActive(true); return true; }
        else { return false; }
    }

    public void Derrota() { pantallas[1].SetActive(true); }

    public void Reiniciar() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }

    private void CuentaEnemigos()
    {
        turnoActualEnemigo++;

        if (turnoActualEnemigo >= entidades.Count) { turnoActualEnemigo = 1; }
    }

    private void ActualizarInterfaz()
    {
        for (int i = 0; i < entidades.Count; i++)
        {
            textosVida[i].text = entidades[i].Vida.ToString();
        }
    }

    public void EmpezarJuego()
    {
        int vida, dmg;

        if (int.TryParse(atributos[0].text, out vida) && int.TryParse(atributos[1].text, out dmg))
        {
            if(vida < 100 && dmg < 100)
            {
                //EMPEZAR JUEGO!
                CrearEntidades(vida, dmg);
                pantallas[2].SetActive(false);
                StartCoroutine(ControladorJuego());
            }
            else { LimpiarCasillas(); }
        }
        else { LimpiarCasillas(); }
    }

    private void LimpiarCasillas()
    {
        atributos[0].text = "";
        atributos[1].text = "";
        Debug.Log("Valores inválidos!");
    }

    private void CrearEntidades(int vida, int dmg)
    {
        Entidad jugador = new Jugador(vida, dmg);
        Entidad enemigoMelee = new EnemigoMelee(130, 20);
        Entidad enemigoRango = new EnemigoRango(80, 10, 3);

        entidades.Add(jugador);
        entidades.Add(enemigoMelee);
        entidades.Add(enemigoRango);

        ActualizarInterfaz();
    }
}
