internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 4665
{	// Methods

	// RVA: 0xEC6D70 Offset: 0xEC6170 VA: 0x180EC6D70 Slot: 4
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0xEC6DF0 Offset: 0xEC61F0 VA: 0x180EC6DF0 Slot: 5
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private enum MouseCaptureDispatchingStrategy.EventBehavior // TypeDefIndex: 4666
{	// Fields
	public int value__; // 0x0
	public const MouseCaptureDispatchingStrategy.EventBehavior None = 0;
	public const MouseCaptureDispatchingStrategy.EventBehavior IsCapturable = 1;
	public const MouseCaptureDispatchingStrategy.EventBehavior IsSentExclusivelyToCapturingElement = 2;

}

