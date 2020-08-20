﻿using System.Collections;
using System.Collections.Generic;
using Client;
using Leopotam.Ecs;
using UnityEngine;

public class MonoTestEmitter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //imnage offset is 100

        var _world = EcsController.Singleton._world;
        var e = _world.NewEntity();
        ref var reqdata = ref e.Get<EcsCreateGridReq>();
        reqdata.ValueDesiredColumns = 5;
        reqdata.ValueDesiredRows = 5;

    }
}