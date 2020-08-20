using Client;
using Leopotam.Ecs;

namespace _001Sources.Systems.Mono
{
    sealed class GoViewRenamingReqProcSystem : IEcsRunSystem
    {
        // auto-injected fields.
        readonly EcsWorld _world = null;
        private EcsFilter<EcsGoViewData, GoViewRenameReq> filter;

        void IEcsRunSystem.Run()
        {
            // add your run code here.
            foreach (var compI in filter)
            {
                ref var e = ref filter.GetEntity(compI);
                ref var compdata1 = ref filter.Get1(compI);
                ref var compdata2 = ref filter.Get2(compI);

                compdata1.Value.name = compdata2.Value;





                e.Del<GoViewRenameReq>();
            }
        }
    }
}