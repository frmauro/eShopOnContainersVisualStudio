﻿namespace Ordering.BackgroundTasks.Events;

using EventBus.Events;

public record GracePeriodConfirmedIntegrationEvent : IntegrationEvent
{
    public int OrderId { get; }

    public GracePeriodConfirmedIntegrationEvent(int orderId) =>
        OrderId = orderId;
}
