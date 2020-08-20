using Leopotam.Ecs;

namespace Client
{
    sealed class GoViewEcsMonoPairingSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private EcsFilter<GoViewEcsMonoEntityPairingReq, EcsGoViewData> filter;

        void IEcsRunSystem.Run()
        {
            // add your run code here.
            foreach (var compI in filter)
            {
                var e = filter.GetEntity(compI);

                ref var compdata2 = ref filter.Get2(compI);
                var monoeid = compdata2.Value.AddComponent<MonoEntityID>();
                monoeid.Value = e;




                e.Del<GoViewEcsMonoEntityPairingReq>();
            }
        }
    }
}