﻿using Common.Messages;
using Coop.Mod.LogicStates.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coop.Mod.Client.States
{
    internal class CampaignState : ClientStateBase
    {
        public CampaignState(IClientLogic logic, IMessageBroker messageBroker) : base(logic, messageBroker)
        {
        }
    }
}
