using UnityEngine;
using UnityEngine.InputSystem; 
using TMPro; // 1. Importamos la librería de TextMeshPro

public class InteraccionHermes : MonoBehaviour
{
    // 2. Variable pública para arrastrar nuestro texto de la UI
    public TMP_Text textoUI; 

    [TextArea(2, 4)]
    public string mensajeDeInformacion = "Hermes con el niño Dioniso es una escultura griega de mármol con una altura de 2,13 metros que se encuentra en el Museo Arqueológico de Olimpia. Su autoría se atribuye al escultor Praxíteles del período clásico final";

    private bool jugadorCerca = false;
    private bool informacionMostrada = false;

    void Start()
    {
        // Nos aseguramos de que empiece oculto por si acaso
        if (textoUI != null) textoUI.gameObject.SetActive(false);
    }

    void Update()
    {
        if (jugadorCerca)
        {
            // Si presiona E y aún no ve la información, la muestra
            if (Keyboard.current.eKey.wasPressedThisFrame && !informacionMostrada)
            {
                MostrarInfoObra();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.GetComponent<CharacterController>() != null)
        {
            jugadorCerca = true;
            informacionMostrada = false; // Reseteamos el estado

            if (textoUI != null)
            {
                textoUI.text = "[Presiona E para examinar]";
                textoUI.gameObject.SetActive(true); // Muestra el cartelito en pantalla
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.GetComponent<CharacterController>() != null)
        {
            jugadorCerca = false;

            if (textoUI != null)
            {
                textoUI.gameObject.SetActive(false); // Oculta el cartelito al alejarse
            }
        }
    }

    void MostrarInfoObra()
    {
        informacionMostrada = true;
        if (textoUI != null)
        {
            // Cambia el texto de la pantalla por la descripción histórica
            textoUI.text = mensajeDeInformacion; 
        }
    }
}