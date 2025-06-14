using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    [SerializeField] private float saltoFrecuencia;
    [SerializeField] private float saltoAltura;
    [SerializeField] private AnimationCurve curvaSalto;
    [SerializeField] private float multiplicadorCurva;
    [SerializeField] private float velocidadMovimiento = 5f;

    private float tiempo;
    private Vector3 posicionInicial;
    private Vector2 inputMovimiento;

    private void OnEnable()
    {
        InputReader.OnMove += Mover;
    }

    private void OnDisable()
    {
        InputReader.OnMove -= Mover;
    }

    private void Start()
    {
        tiempo = 0f;
        posicionInicial = transform.position;
    }

    private void Update()
    {
        tiempo += Time.deltaTime * saltoFrecuencia;
        float valorCurva = curvaSalto.Evaluate(Mathf.Sin(tiempo));
        float altura = valorCurva * saltoAltura * multiplicadorCurva;

        Vector3 direccion = new Vector3(inputMovimiento.x, 0f, inputMovimiento.y);
        transform.position += direccion * velocidadMovimiento * Time.deltaTime;

        transform.position = new Vector3(
            transform.position.x,
            posicionInicial.y + altura,
            transform.position.z
        );
    }

    private void Mover(Vector2 input)
    {
        inputMovimiento = input;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("gameover");
        }
    }
}
