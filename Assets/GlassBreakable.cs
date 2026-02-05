using UnityEngine;

public class GlassBreakable : MonoBehaviour
{
    public int hitsToBreak = 3;
    private int currentHits = 0;

    private Collider glassCollider;

    void Start()
    {
        glassCollider = GetComponent<Collider>();
    }

    public void Hit()
    {
        currentHits++;
        Debug.Log("Glass hit: " + currentHits);

        if (currentHits >= hitsToBreak)
        {
            BreakGlass();
        }
    }

    void BreakGlass()
    {
        Debug.Log("Glass shattered!");

        glassCollider.enabled = false;
        gameObject.SetActive(false);
    }
}
