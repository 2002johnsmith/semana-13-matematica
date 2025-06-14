using UnityEngine;

public class CamerraFollow : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Vector3 Position;

    private void LateUpdate()
    {
        transform.position = Player.position + Position;
    }
}
