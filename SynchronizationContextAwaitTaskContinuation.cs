internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 877
{	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x1496520 Offset: 0x1495920 VA: 0x181496520
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x1496250 Offset: 0x1495650 VA: 0x181496250 Slot: 4
	internal sealed override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x14961A0 Offset: 0x14955A0 VA: 0x1814961A0
	private static void PostAction(object state) { }

	// RVA: 0x14960C0 Offset: 0x14954C0 VA: 0x1814960C0
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x1496470 Offset: 0x1495870 VA: 0x181496470
	private static void .cctor() { }

}

private sealed class SynchronizationContextAwaitTaskContinuation.<>c // TypeDefIndex: 878
{	// Fields
	public static readonly SynchronizationContextAwaitTaskContinuation.<>c <>9; // 0x130FA

	// Methods

	// RVA: 0x149EC90 Offset: 0x149E090 VA: 0x18149EC90
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x149EC30 Offset: 0x149E030 VA: 0x18149EC30
	internal void <.cctor>b__7_0(object state) { }

}

