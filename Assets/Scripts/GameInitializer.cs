using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    private PlayerController playerController;

    void Start()
    {
        Vector2 initialPosition = new Vector2(0, 0);
        int initialHealth = 100;

        PlayerViewInterface playerView = FindObjectOfType<PlayerView>();

        if (playerView == null)
        {
            Debug.LogError("PlayerView não encontrado! Certifique-se de que o GameObject com PlayerView está presente e ativo na cena.");
            return;
        }

        PlayerModelInterface playerModel = new PlayerModel(initialPosition, initialHealth);
        playerController = new PlayerController(playerModel, playerView);
    }

    void Update()
    {
        if (playerController != null)
        {
            playerController.HandleInput();
            playerController.UpdatePlayer();
        }
    }
}
