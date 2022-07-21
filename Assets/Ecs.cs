using UnityEngine;
using Leopotam.Ecs;
using Voody.UniLeo;

public class Ecs : MonoBehaviour
{
    private EcsWorld world;
    private EcsSystems systems;

    private void Start()
    {
        world = new EcsWorld();
        systems = new EcsSystems(world);

        systems.ConvertScene();

        systems.Init();
    }

    private void Update()
    {
        systems.Run();
    }

    private void LateUpdate()
    {
        systems.Run();
    }



}
