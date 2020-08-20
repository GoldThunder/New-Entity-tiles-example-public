using System.Collections;
using System.Collections.Generic;
using Client;
using Leopotam.Ecs;
using UnityEngine;

public class MonoCanvasRegistration : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var _world = EcsController.Singleton._world;

        var e = _world.NewEntity();
        e.Get<EcsGameCanvasRegistrationReq>();
        ref var newviewdata = ref e.Get<EcsGoViewData>();
        newviewdata.Value = gameObject;

    }

}
