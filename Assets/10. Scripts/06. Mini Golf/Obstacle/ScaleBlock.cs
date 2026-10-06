using UnityEngine;

public class ScaleBlock : MonoBehaviour
{
    public float amplitude = 0.2f;
    public float pulsePerSecond = 0.5f;

    private Vector3 startScale;

    private void Awake()
    {
        startScale = transform.localScale;
    }

    private void Update()
    {
        float wave = Mathf.Sin(Time.time * pulsePerSecond * Mathf.PI * 2f);
        Vector3 scale = transform.localScale;
        scale.x = startScale.x * (1f + wave * amplitude);
        scale.z = startScale.z * (1f + wave * amplitude);
        transform.localScale = scale;
    }
}
