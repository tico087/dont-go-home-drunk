using UnityEngine;

public class PlayerController : PlayerControllerInterface
{
    private PlayerModelInterface playerModel;
    private PlayerViewInterface playerView;

    public PlayerController(PlayerModelInterface model, PlayerViewInterface view)
    {
        playerModel = model;
        playerView = view;
    }

    public void HandleInput()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        
        playerModel.Move(direction);
    }

    public void UpdatePlayer()
    {
        playerView.UpdatePosition(playerModel.Position);
    }

    public void PlayerTakesDamage(int damage)
    {
        playerModel.TakeDamage(damage);
        playerView.PlayDamageEffect();
    }
}
