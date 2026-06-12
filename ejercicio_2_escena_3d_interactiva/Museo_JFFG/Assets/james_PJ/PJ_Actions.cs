using UnityEngine;
// 1. Importamos la librería del nuevo Input System
using UnityEngine.InputSystem; 

public class PJ_Actions : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    public float velocidad = 5.0f;
    private CharacterController controller;

    [Header("Configuración de Cámara")]
    public Transform camara;

    private Animator animator;

    // 2. Variables para almacenar la lectura del nuevo sistema
    private Vector2 inputMovimiento;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 3. Leer el teclado/gamepad usando la sintaxis del nuevo Input System
        if (Keyboard.current != null)
        {
            // Lee WASD o Flechas automáticamente a través de controles directos
            float moverHorizontal = 0f;
            float moverVertical = 0f;

            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moverVertical = 1f;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moverVertical = -1f;
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moverHorizontal = -1f;
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moverHorizontal = 1f;

            inputMovimiento = new Vector2(moverHorizontal, moverVertical);
        }
        
        // Soporte básico para Joystick por si acaso
        if (Gamepad.current != null)
        {
            Vector2 stick = Gamepad.current.leftStick.ReadValue();
            if (stick.magnitude > 0.1f) inputMovimiento = stick;
        }

        // 4. Aplicar el movimiento (el resto del código se mantiene igual)
        if (inputMovimiento.x != 0 || inputMovimiento.y != 0)
        {
            transform.rotation = Quaternion.Euler(0, camara.eulerAngles.y, 0);
        }

        Vector3 movimiento = transform.right * inputMovimiento.x + transform.forward * inputMovimiento.y;

        controller.Move(movimiento * velocidad * Time.deltaTime);
        
        if (!controller.isGrounded)
        {
            controller.Move(Vector3.down * 9.81f * Time.deltaTime);
        }

        // Animación
        float inputMagnitude = inputMovimiento.magnitude;
        animator.SetFloat("Speed", inputMagnitude, 0.1f, Time.deltaTime);
    }
}