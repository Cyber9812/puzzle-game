using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Aqu� asigna el sprite que deseas mostrar
        // Puedes asignarlo program�ticamente o desde el Editor de Unity
        // Ejemplo de asignaci�n program�tica:
        // spriteRenderer.sprite = Resources.Load<Sprite>("NombreDelSprite"); 
    }

    void Update()
    {
        // Bloquear los clics del mouse
        if (Input.GetMouseButtonDown(0))
        {
            // No hacer nada cuando se hace clic
            // Esto puede evitarse si se desea permitir ciertos comportamientos
        }
    }
}
