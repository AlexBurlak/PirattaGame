using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public abstract class Interactable : MonoBehaviour
{
    private void Reset()
    {
        GetComponent<CircleCollider2D>().isTrigger = true;
    }
    public abstract void Interact();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Penetrated");
        if (collision.CompareTag("Player"))
            collision.GetComponent<CharacterMovement>().Interact();
    }
}
