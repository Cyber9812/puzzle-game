using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBasedBlocker : MonoBehaviour
{
    public float blockDuration = 5.0f;  // Duración del bloqueo en segundos
    public GameObject blockerPanel;     // Referencia al panel que bloquea la pantalla
    public Image blockingImage;         // Imagen adicional para bloquear clicks

    private float currentTime = 0.0f;
    private bool isBlocking = false;

    void Start()
    {
        // Asegúrate de que el panel y la imagen estén desactivados al iniciar
        blockerPanel.SetActive(false);
        blockingImage.gameObject.SetActive(false);

        // Iniciar el bloqueo cada cierto tiempo
        InvokeRepeating("StartBlocking", 0.0f, 10.0f); // Inicia inmediatamente y luego cada 10 segundos
    }

    void Update()
    {
        // Contador de tiempo
        if (isBlocking)
        {
            currentTime += Time.deltaTime;

            // Si ha pasado el tiempo de bloqueo, desactivar el bloqueo
            if (currentTime >= blockDuration)
            {
                isBlocking = false;
                currentTime = 0.0f;
                blockerPanel.SetActive(false);
                blockingImage.gameObject.SetActive(false); // Desactivar la imagen de bloqueo
            }
        }
    }

    void StartBlocking()
    {
        // Activar el bloqueo y comenzar el contador de tiempo
        isBlocking = true;
        blockerPanel.SetActive(true);
        blockingImage.gameObject.SetActive(true); // Activar la imagen de bloqueo
    }
}
