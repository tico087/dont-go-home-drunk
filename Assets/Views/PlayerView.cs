using UnityEngine;

public class PlayerView : MonoBehaviour, PlayerViewInterface
{
    public void UpdatePosition(Vector2 newPosition)
    {
        transform.position = newPosition;
    }

    public void PlayDamageEffect()
    {
        Debug.Log("Player took damage, playing damage effect.");
    }
}
