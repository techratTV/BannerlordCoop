﻿using Common.Serialization;
using LiteNetLib;
using ProtoBuf;

namespace Missions.Network
{
    [ProtoContract(SkipConstructor = true)]
    public readonly struct EventPacket : IPacket
    {
        public DeliveryMethod DeliveryMethod => DeliveryMethod.ReliableSequenced;
        public PacketType PacketType => PacketType.Event;
        public byte[] Data => m_Data;
        [ProtoMember(1)]

        private readonly byte[] m_Data;

        public EventPacket(object payload)
        {
            m_Data = CommonSerializer.Serialize(payload, SerializationMethod.ProtoBuf);
        }
    }
}
