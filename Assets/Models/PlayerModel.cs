using UnityEngine;

public class PlayerModel : PlayerModelInterface
{
    private Vector2 position;
    private int _health; 

    public Vector2 Position => position;

    public int health   
    {
        get => _health;  
        set => _health = value;  
    }

    public PlayerModel(Vector2 initialPosition, int initialHealth)
    {
        position = initialPosition;
        _health = initialHealth;  

    public void Move(Vector2 direction)
    {
        float speed = 5f;
        position += direction * speed * Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health < 0) _health = 0;

        Debug.Log("Player took damage. Remaining health: " + _health);
    }
}
