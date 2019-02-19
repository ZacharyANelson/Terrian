
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 1000f;
    public Camera Cam;
    public GameObject impactpart;
    //public float despawn = 3f;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
        { 
            Shots();
        }
    }
    void Shots()
    {
        RaycastHit hits;
       if( Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hits, range))
        {
            Debug.Log(hits.transform.name);
            Target target = hits.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TDamage(damage);
            }
            Instantiate(impactpart, hits.point, Quaternion.LookRotation(hits.normal));
            //Destroy(impactpart, despawn);
        }
    }
}
