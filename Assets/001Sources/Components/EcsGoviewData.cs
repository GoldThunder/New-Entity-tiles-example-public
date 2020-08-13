using System;
using Leopotam.Ecs;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Client {
    struct EcsGoviewData : IEcsAutoReset<EcsGoviewData> {
        // add your data here.
        public GameObject Value;
        public void AutoReset(ref EcsGoviewData c)
        {
            if (c.Value!=null)
            {
                Object.Destroy(Value);
            }
        }
    }
}