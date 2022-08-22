internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 794
{	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0


	private void .ctor(object osContext) { }

	public static OSSpecificSynchronizationContext Get() { }

	public override SynchronizationContext CreateCopy() { }

	public override void Send(SendOrPostCallback d, object state) { }

	public override void Post(SendOrPostCallback d, object state) { }

	[OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	private static void InvocationEntry(IntPtr arg) { }

	private static object GetOSContext() { }

	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	private static void .cctor() { }

}

private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 795
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(IntPtr arg) { }

	public virtual IAsyncResult BeginInvoke(IntPtr arg, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 796
{
	public void .ctor(Type t) { }

}

private class OSSpecificSynchronizationContext.InvocationContext // TypeDefIndex: 797
{	private SendOrPostCallback m_Delegate; // 0x10
	private object m_State; // 0x18


	public void .ctor(SendOrPostCallback d, object state) { }

	public void Invoke() { }

}

private sealed class OSSpecificSynchronizationContext.<>c // TypeDefIndex: 798
{	public static readonly OSSpecificSynchronizationContext.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext> <>9__3_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

}

