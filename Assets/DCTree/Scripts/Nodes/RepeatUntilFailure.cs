﻿using UnityEngine;

namespace DerelictComputer.DCTree
{
    public class RepeatUntilFailure : Repeater
    {
        public RepeatUntilFailure(SerializableNode serialized, Node childNode) : base(serialized, childNode)
        {
        }

        protected override Result OnTick(double tickDspTime)
        {
            var result = ChildNode.Tick(tickDspTime);

            if (result == Result.Failure)
            {
                return Result.Success;
            }

            return Result.Running;
        }
    }
}
