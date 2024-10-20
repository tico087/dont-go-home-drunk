using UnityEngine;

public interface PlayerModelInterface
{
    int health { get; set; }
    Vector2 Position { get;}
    void TakeDamage(int damage);
    void Move(Vector2 direction);
}

