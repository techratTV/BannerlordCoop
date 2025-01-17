﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Library;
using TaleWorlds.ObjectSystem;

namespace Missions.Serialization.Surrogates
{
    [ProtoContract(SkipConstructor = true)]
    internal readonly struct Vec3Surrogate
    {
        [ProtoMember(1)]
        public float X { get; }
        [ProtoMember(2)]
        public float Y { get; }
        [ProtoMember(3)]
        public float Z { get; }
        [ProtoMember(4)]
        public float W { get; }

        public Vec3Surrogate(Vec3 obj)
        {
            X = obj.X;
            Y = obj.Y;
            Z = obj.Z;
            W = obj.w;
        }

        private Vec3 Deserialize()
        {
            return new Vec3(X, Y, Z, W);
        }

        public static implicit operator Vec3Surrogate(Vec3 obj)
        {
            return new Vec3Surrogate(obj);
        }

        public static implicit operator Vec3(Vec3Surrogate surrogate)
        {

            return surrogate.Deserialize();
        }
    }
}
