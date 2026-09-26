using UnityEngine;

public class InteractiveItem : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            Debug.Log("CubeHitsTheFloor");
        }
        GameManager.Instance.AddScore(5);
    }
}
