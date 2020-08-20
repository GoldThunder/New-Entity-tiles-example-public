using System.Collections.Generic;
using Leopotam.Ecs;

namespace Client {
    struct EcsColumnData {
        // add your data here.
        public EcsEntity ValueParentGrid;
        public EcsEntity ValueColumnIndex;
        //we need also an vector 3 entrypoint for the grid command and there sttart populating..
        //public  List<EcsEntity> ValueTyles or columns //we need a grid start data so we can build up from there..
    }
}