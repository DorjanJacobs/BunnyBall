using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    
    private void Start()
    {
        rb.useGravity = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with player");
            rb.useGravity = true;
        }
    }
}
