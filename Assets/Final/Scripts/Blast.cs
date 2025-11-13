using UnityEngine;

public class Blast : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject prefabBullet;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabBullet, shootPoint.position, transform.rotation);
        }
    }
}
