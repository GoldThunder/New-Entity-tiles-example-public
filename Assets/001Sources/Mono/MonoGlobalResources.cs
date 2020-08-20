using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;

public class MonoGlobalResources : MonoBehaviour
{

    public EcsEntity playerEntity;

    public List<EcsEntity> PlayerFactionUnitsList;
    public List<EcsEntity> MachineFactionUnitsList;

    public EcsEntity MainGameGrid;




    public GameObject TilePrefab;
    public EcsEntity MainGameCanvas;
    
    public static MonoGlobalResources Singleton;
    
    // Start is called before the first frame update
    void Start()
    {
        MakeSingleton();
        gameObject.AddComponent<MonoTestEmitter>();
    }

    private void MakeSingleton()
    {
        if (Singleton != null)
        {
            Destroy(this);
        }
        else
        {
            Singleton = this;
        }
    }
    
    
    
}
