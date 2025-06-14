using UnityEngine;
using DG.Tweening;

public class ObstaclePulse : MonoBehaviour
{
    [SerializeField] private float escalaMaxima = 3f;
    [SerializeField] private float duracion = 0.5f;

    private void Start()
    {
        Vector3 escalaOriginal = transform.localScale;
        Vector3 escalaDestino = escalaOriginal * escalaMaxima;

        transform.DOScale(escalaDestino, duracion)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.InOutSine);
    }
}
