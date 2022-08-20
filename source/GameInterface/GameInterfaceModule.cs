﻿using Autofac;
using Common.Messaging;
using GameInterface.Serialization.Dynamic;
using GameInterface.Serialization.Dynamic;
using GameInterface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterface
{
    public class GameInterfaceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<MessageBroker>().As<IMessageBroker>().SingleInstance();
            builder.RegisterType<DynamicModelGenerator>().As<IDynamicModelGenerator>().SingleInstance();
            builder.RegisterType<DynamicModelService>().As<IDynamicModelService>().SingleInstance();
            builder.RegisterModule<GameStateModule>();
        }
    }
}
