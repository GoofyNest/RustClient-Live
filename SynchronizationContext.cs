public class SynchronizationContext // TypeDefIndex: 793
{	// Fields
	private SynchronizationContextProperties _props; // 0x10
	private static Type s_cachedPreparedType1; // 0x0
	private static Type s_cachedPreparedType2; // 0x8
	private static Type s_cachedPreparedType3; // 0x10
	private static Type s_cachedPreparedType4; // 0x18
	private static Type s_cachedPreparedType5; // 0x20

	// Properties
	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1496800 Offset: 0x1495C00 VA: 0x181496800 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1496780 Offset: 0x1495B80 VA: 0x181496780 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	public virtual void OperationCompleted() { }

	// RVA: 0x1496830 Offset: 0x1495C30 VA: 0x181496830
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x14968D0 Offset: 0x1495CD0 VA: 0x1814968D0
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1496890 Offset: 0x1495C90 VA: 0x181496890
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x14965C0 Offset: 0x14959C0 VA: 0x1814965C0
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x1496570 Offset: 0x1495970 VA: 0x181496570 Slot: 8
	public virtual SynchronizationContext CreateCopy() { }

}

