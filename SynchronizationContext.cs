public class SynchronizationContext // TypeDefIndex: 793
{	private SynchronizationContextProperties _props; // 0x10
	private static Type s_cachedPreparedType1; // 0x0
	private static Type s_cachedPreparedType2; // 0x8
	private static Type s_cachedPreparedType3; // 0x10
	private static Type s_cachedPreparedType4; // 0x18
	private static Type s_cachedPreparedType5; // 0x20

	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }


	public void .ctor() { }

	public virtual void Send(SendOrPostCallback d, object state) { }

	public virtual void Post(SendOrPostCallback d, object state) { }

	public virtual void OperationStarted() { }

	public virtual void OperationCompleted() { }

	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static SynchronizationContext get_CurrentNoFlow() { }

	private static SynchronizationContext GetThreadLocalContext() { }

	public virtual SynchronizationContext CreateCopy() { }

}

