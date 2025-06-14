using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float rangoMovimiento;
    [SerializeField] private Vector3 direccionMovimiento = Vector3.right;

    private Vector3 posicionInicial;

    private void Start()
    {
        posicionInicial = transform.position;
    }

    private void Update()
    {
        float desplazamiento = Mathf.PingPong(Time.time * velocidad, rangoMovimiento);
        transform.position = posicionInicial + direccionMovimiento * desplazamiento;
    }
}
