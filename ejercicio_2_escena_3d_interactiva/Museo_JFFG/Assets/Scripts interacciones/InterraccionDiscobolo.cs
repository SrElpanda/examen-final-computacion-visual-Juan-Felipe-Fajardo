using UnityEngine;
using UnityEngine.InputSystem; 
using TMPro; // 1. Importamos la librería de TextMeshPro

public class InteraccionDiscobolo : MonoBehaviour
{
    // 2. Variable pública para arrastrar nuestro texto de la UI
    public TMP_Text textoUI; 

    [TextArea(2, 4)]
    public string mensajeDeInformacion = "Discóbolo es una icónica escultura griega de bulto redondo realizada por Mirón de Eléuteras en torno al 450 a. C. La obra representa a un joven atleta desnudo en el instante anterior al lanzamiento de un disco.";

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