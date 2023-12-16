using UnityEngine;

public class DondurmeKodu : MonoBehaviour
{
    public float donmeHizi = 5f;

    void Update()
    {
        // Etrafta dönme hareketini sağla
        transform.Rotate(Vector3.up, donmeHizi * Time.deltaTime);
    }
}
