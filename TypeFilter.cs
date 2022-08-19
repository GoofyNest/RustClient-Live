public sealed class TypeFilter : MulticastDelegate // TypeDefIndex: 553
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF1130 Offset: 0xFF0530 VA: 0x180FF1130 Slot: 12
	public virtual bool Invoke(Type m, object filterCriteria) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(Type m, object filterCriteria, AsyncCallback callback, object object) { }

	// RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

