internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 794
{	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x10B06F0 Offset: 0x10AFAF0 VA: 0x1810B06F0
	private void .ctor(object osContext) { }

	// RVA: 0x1492300 Offset: 0x1491700 VA: 0x181492300
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x1492280 Offset: 0x1491680 VA: 0x181492280 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x1492710 Offset: 0x1491B10 VA: 0x181492710 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x14925D0 Offset: 0x14919D0 VA: 0x1814925D0 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	// RVA: 0x1492470 Offset: 0x1491870 VA: 0x181492470
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x14922F0 Offset: 0x14916F0 VA: 0x1814922F0
	private static object GetOSContext() { }

	// RVA: 0x14925C0 Offset: 0x14919C0 VA: 0x1814925C0
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x1492760 Offset: 0x1491B60 VA: 0x181492760
	private static void .cctor() { }

}

private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 795
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x148F6F0 Offset: 0x148EAF0 VA: 0x18148F6F0 Slot: 12
	public virtual void Invoke(IntPtr arg) { }

	// RVA: 0x148F670 Offset: 0x148EA70 VA: 0x18148F670 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr arg, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 796
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor(Type t) { }

}

private class OSSpecificSynchronizationContext.InvocationContext // TypeDefIndex: 797
{	// Fields
	private SendOrPostCallback m_Delegate; // 0x10
	private object m_State; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(SendOrPostCallback d, object state) { }

	// RVA: 0x148F640 Offset: 0x148EA40 VA: 0x18148F640
	public void Invoke() { }

}

private sealed class OSSpecificSynchronizationContext.<>c // TypeDefIndex: 798
{	// Fields
	public static readonly OSSpecificSynchronizationContext.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x149ECF0 Offset: 0x149E0F0 VA: 0x18149ECF0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x149EB70 Offset: 0x149DF70 VA: 0x18149EB70
	internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

}

