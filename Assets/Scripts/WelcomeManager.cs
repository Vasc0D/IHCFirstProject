using UnityEngine;
using UnityEngine.UI;

public class WelcomeManager : MonoBehaviour
{
    public GameObject welcomePanel;  // Panel de la bienvenida (donde está el texto y el botón)
    public Button activateCameraButton;  // Botón para activar la cámara
    public GameObject ARCamera;  // ARCamera

    void Start()
    {
        // Asegúrate de que la cámara esté desactivada al iniciar
        ARCamera.SetActive(false);
        welcomePanel.SetActive(true);  // Mostrar el panel de bienvenida

        // Agregar la función ActivateCamera al botón
        activateCameraButton.onClick.AddListener(ActivateCamera);
    }

    void ActivateCamera()
    {
        // Ocultar la pantalla de bienvenida
        welcomePanel.SetActive(false);

        // Activar la cámara
        ARCamera.SetActive(true);
    }
}
