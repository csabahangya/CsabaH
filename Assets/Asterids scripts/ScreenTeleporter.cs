using UnityEngine;

public class ScreenTeleporter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    new Collider2D collider2D;
    new Camera camera;

    void Start()
    {
        camera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<Collider2D>();
    }

    void Update()
    {
        Vector2 cameraCenter = camera.transform.position;
        Vector2 cameraSize = new(camera.orthographicSize * camera.aspect, camera.orthographicSize);

        Rect cameraRect = new Rect(cameraCenter - cameraSize, cameraSize * 2);
        Bounds objectBounds = collider2D.bounds;

        float yJump = (cameraSize.y * 2 + objectBounds.size.y);
        float xJump = (cameraSize.x * 2 + objectBounds.size.x);


        if (objectBounds.min.y > cameraRect.yMax)
            transform.position += Vector3.down * yJump;
        Physics2D.SyncTransforms();

        if (objectBounds.max.y < cameraRect.yMin)
            transform.position += Vector3.up * yJump;
        Physics2D.SyncTransforms();

        if (objectBounds.min.x > cameraRect.xMax)
            transform.position += Vector3.left * xJump;
        Physics2D.SyncTransforms();

        if (objectBounds.max.x < cameraRect.xMin)
            transform.position += Vector3.right * xJump;
        Physics2D.SyncTransforms();
    }

    void OnDrawGizmos()
    {
        if (collider2D == null) return;

        Bounds bounds = collider2D.bounds;  // Befoglal� t�glatest

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}
