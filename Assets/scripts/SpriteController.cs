using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Aquí asigna el sprite que deseas mostrar
        // Puedes asignarlo programáticamente o desde el Editor de Unity
        // Ejemplo de asignación programática:
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
