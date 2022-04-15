using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    public GameObject track;
    private bool spawned;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !spawned)
        {
            Vector3 pos = new Vector3(transform.parent.position.x, (transform.parent.position.y - 20f), transform.parent.position.z);
            Instantiate(track.transform, pos, transform.parent.rotation);
            spawned = true;
        }
    }
}
