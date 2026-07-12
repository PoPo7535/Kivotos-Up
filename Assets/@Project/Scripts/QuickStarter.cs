using Fusion;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(NetworkRunner))]
public class QuickStarter : SimulationBehaviour
{
#if UNITY_EDITOR
    [SerializeField] private bool _quickStart = true;
    private NetworkRunner _networkRunner;
    private void Start()
    {
        if (false == _quickStart)
            return;
        _networkRunner = GetComponent<NetworkRunner>();
        StartGame();
    }


    private void StartGame()
    {
        var sceneRef =  SceneRef.FromIndex(1);
        var info = new NetworkSceneInfo();
        info.AddSceneRef(sceneRef, LoadSceneMode.Single);
        
        _networkRunner.StartGame(new StartGameArgs()
        {
            Scene = info,
            GameMode = GameMode.Shared,
            SessionName = "QuickStarter",
            PlayerCount = 20,
            IsOpen = true,
            IsVisible = true,
        });
    }
#endif
}
