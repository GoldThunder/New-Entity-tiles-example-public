using System.Collections.Generic;
using Leopotam.Ecs;

namespace Client {
    struct EcsTileComponentData {
        // add your data here.
        public int ValueGridTileIndex;
        
        public EcsEntity ValueParentGrid;
        public EcsEntity ValueParentRow;
        public EcsEntity ValueParentColumn;
        
        public bool ValueWalkable;

        public List<EcsEntity> ValueListItems;
        public List<EcsEntity> ValueListUnits;
    }
}