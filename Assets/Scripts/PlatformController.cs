using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed;
    [SerializeField] private float WPradius = 1;
    private int current = 0;

    private void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current = (current == 0) ? 1 : 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position,
            Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.gameObject.transform.parent = transform;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.gameObject.transform.parent = null;
        }
    }
}
