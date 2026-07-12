using Fusion;
using UnityEngine;

public class PlayerSpawner : NetworkBehaviour, IPlayerJoined
{
    public GameObject PlayerPrefab;

    // public override void Spawned()
    // {
    //     Debug.Log(11);
    //     base.Spawned();
    // }

    void IPlayerJoined.PlayerJoined(PlayerRef player)
    {
        Debug.Log(player);
        if (player == Runner.LocalPlayer)
        {
            Runner.Spawn(PlayerPrefab, new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}