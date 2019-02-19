
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TDamage ( float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Ded();
        }

    }
    void Ded ()
    {
        Destroy(gameObject);
    }

}
