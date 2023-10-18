using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public Button botonJugar;
    public Button botonSalir;

    private void Start() {
        botonJugar.onClick.AddListener(iniciarPartida);
        botonSalir.onClick.AddListener(salir);
    }

    private void iniciarPartida() {
        
    }

    private void salir() {
        Application.Quit();
    }

}
