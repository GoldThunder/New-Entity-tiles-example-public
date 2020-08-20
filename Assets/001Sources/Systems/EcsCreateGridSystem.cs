using Leopotam.Ecs;
using Unity.Mathematics;
using UnityEngine;

namespace Client {
    sealed class EcsCreateGridSystem : IEcsRunSystem {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private EcsFilter<EcsCreateGridReq> _filter;
        
        void IEcsRunSystem.Run () {
            // add your run code here.
            foreach (var compI in _filter)
            {
                var e = _filter.GetEntity(compI);

                ref var reqdata = ref _filter.Get1(compI);

                var e_mainCanvas = MonoGlobalResources.Singleton.MainGameCanvas;
                ref var canvasgo = ref e_mainCanvas.Get<EcsGoViewData>().Value;

                for (int i = 0; i < reqdata.ValueDesiredColumns; i++)
                {
                    //now for rows.. neeed to create row and column data..
                }

                GameObject.Instantiate(MonoGlobalResources.Singleton.TilePrefab,canvasgo.transform );







                e.Del<EcsCreateGridReq>();
            }
        }
    }
}