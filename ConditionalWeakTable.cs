public sealed class ConditionalWeakTable.CreateValueCallback<TKey, TValue> : MulticastDelegate // TypeDefIndex: 1316
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession>..ctor
	|-ConditionalWeakTable.CreateValueCallback<object, object>..ctor
	|-ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TValue Invoke(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1336020 Offset: 0x1335420 VA: 0x181336020
	|-ConditionalWeakTable.CreateValueCallback<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(TKey key, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497210 Offset: 0x496610 VA: 0x180497210
	|-ConditionalWeakTable.CreateValueCallback<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TValue EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497050 Offset: 0x496450 VA: 0x180497050
	|-ConditionalWeakTable.CreateValueCallback<object, object>.EndInvoke
	*/

}

