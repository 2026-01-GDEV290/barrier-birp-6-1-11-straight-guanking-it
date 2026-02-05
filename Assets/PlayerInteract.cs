using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactDistance = 3f;

    void Update()
    {
        Debug.Log("E pressed");
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryHitGlass();
        }
    }

    void TryHitGlass()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, interactDistance))
        {
            GlassBreakable glass = hit.collider.GetComponent<GlassBreakable>();

            if (glass != null)
            {
                glass.Hit();
            }
        }
    }
}
