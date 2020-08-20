using Leopotam.Ecs;
using UnityEngine;

namespace Client {
    sealed class EcsGoViewInitReqProcSystem : IEcsRunSystem {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private EcsFilter<GoViewInitEcsReq> filter;

        void IEcsRunSystem.Run()
        {
            // add your run code here.
            foreach (var compI in filter)
            {
                var e = filter.GetEntity(compI);
                ref var compdata = ref e.Get<EcsGoViewData>();
                compdata.Value = new GameObject();

                //maybe add coupling req..

                e.Del<GoViewInitEcsReq>();
            }
        }
    }
}