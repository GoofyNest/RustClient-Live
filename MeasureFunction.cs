internal sealed class MeasureFunction : MulticastDelegate // TypeDefIndex: 4576
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22F0C90 Offset: 0x22F0090 VA: 0x1822F0C90 Slot: 12
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F0BC0 Offset: 0x22EFFC0 VA: 0x1822F0BC0 Slot: 13
	public virtual IAsyncResult BeginInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, AsyncCallback callback, object object) { }

	// RVA: 0x121BE10 Offset: 0x121B210 VA: 0x18121BE10 Slot: 14
	public virtual YogaSize EndInvoke(IAsyncResult result) { }

}

