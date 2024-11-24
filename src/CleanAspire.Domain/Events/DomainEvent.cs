﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using CleanAspire.Domain.Common;
using MediatR;

namespace CleanAspire.Domain;

public abstract class DomainEvent : INotification
{
    protected DomainEvent()
    {
        DateOccurred = DateTimeOffset.UtcNow;
    }

    public bool IsPublished { get; set; }
    public DateTimeOffset DateOccurred { get; protected set; }
}
 
