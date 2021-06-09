using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float x;
    public Transform Camera;
    private void Update()
    {
        x = Input.acceleration.y * 10;
        print(x);
        Camera.Rotate(Vector3.up * x);
    }
}
