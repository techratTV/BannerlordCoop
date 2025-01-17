﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missions.Messages.BoardGames
{
    [ProtoContract]
    public readonly struct BoardGameMoveRequest
    {
        public BoardGameMoveRequest(Guid gameId, int fromIndex, int toIndex)
        {
            GameId = gameId;
            FromIndex = fromIndex;
            ToIndex = toIndex;
        }

        [ProtoMember(1)]
        public Guid GameId { get; }
        [ProtoMember(2)]
        public int FromIndex { get; }
        [ProtoMember(3)]
        public int ToIndex { get; }
    }
}
