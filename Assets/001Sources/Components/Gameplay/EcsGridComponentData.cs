using System.Collections.Generic;
using Leopotam.Ecs;

namespace Client {
    struct EcsGridComponentData {
        // add your data here.
        public int ValueGridIndex;//if more grids..
        public List<EcsEntity>  ValueRows;
        public List<EcsEntity> ValueColumns;
        //row count is rowlist count same for columns
    }
}