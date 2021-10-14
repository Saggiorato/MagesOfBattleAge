using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform player;

    public float smoothSpeed = 15f;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {

        offset = transform.position - player.transform.position;
    }

    private void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }

    //void LateUpdate()
    //{
    //    // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
    //    //transform.position = player.transform.position + offset;
    //}
}
