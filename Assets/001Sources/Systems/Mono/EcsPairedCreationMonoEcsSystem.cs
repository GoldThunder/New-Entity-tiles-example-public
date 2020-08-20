using Leopotam.Ecs;

namespace Client
{
    sealed class EcsPairedCreationMonoEcsSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private EcsFilter<CreatePairedGoviewReq> _filter;

        void IEcsRunSystem.Run()
        {
            // add your run code here.
            foreach (var compI in _filter)
            {
                var e = _filter.GetEntity(compI);
                e.Get<GoViewInitEcsReq>();
                e.Get<GoViewEcsMonoEntityPairingReq>();





                e.Del<CreatePairedGoviewReq>();
            }
        }
    }
}