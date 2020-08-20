using Leopotam.Ecs;

namespace Client {
    sealed class EcsCanvasRegistrationSystem : IEcsRunSystem {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private EcsFilter<EcsGameCanvasRegistrationReq> _filter;
        
        void IEcsRunSystem.Run () {
            // add your run code here.
            foreach (var compI in _filter)
            {
                var e = _filter.GetEntity(compI);

                MonoGlobalResources.Singleton.MainGameCanvas = e;





                e.Get<EcsGameCanvasTag>();
                
                    
                e.Del<EcsGameCanvasRegistrationReq>();
            }
        }
    }
}