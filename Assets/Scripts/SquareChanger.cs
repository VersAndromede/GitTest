using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SquareChanger : MonoBehaviour
{
    [SerializeField] private float _minScaleX;
    [SerializeField] private float _maxScaleX;
    [SerializeField] private float _minScaleY;
    [SerializeField] private float _maxScaleY;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        ChangeColor();
        ChangeScale();
    }

    private void ChangeColor()
    {
        float randomR = Random.Range(0.0f, 1.0f);
        float randomB = Random.Range(0.0f, 1.0f);
        float randomG = Random.Range(0.0f, 1.0f);

        _spriteRenderer.color = new Color(randomR, randomB, randomG);
    }

    private void ChangeScale()
    {
        float randomScaleX = Random.Range(_minScaleX, _maxScaleX);
        float randomScaleY = Random.Range(_minScaleY, _maxScaleY);

        transform.localScale = new Vector2(randomScaleX, randomScaleY);
    }
}
