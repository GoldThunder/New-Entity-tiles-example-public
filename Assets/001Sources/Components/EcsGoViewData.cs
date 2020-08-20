using System;
using Leopotam.Ecs;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Client {
    struct EcsGoViewData : IEcsAutoReset<EcsGoViewData> {
        // add your data here.
        public GameObject Value;
        public void AutoReset(ref EcsGoViewData c)
        {
            if (c.Value!=null)
            {
                Object.Destroy(Value);
            }
        }
    }
}