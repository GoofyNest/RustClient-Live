internal class PointerDispatchState // TypeDefIndex: 4604
{	// Fields
	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20

	// Methods

	// RVA: 0xECB600 Offset: 0xECAA00 VA: 0x180ECB600
	public void .ctor() { }

	// RVA: 0xECB460 Offset: 0xECA860 VA: 0x180ECB460
	internal void Reset() { }

	// RVA: 0xA4F9F0 Offset: 0xA4EDF0 VA: 0x180A4F9F0
	public IEventHandler GetCapturingElement(int pointerId) { }

	// RVA: 0xECAC90 Offset: 0xECA090 VA: 0x180ECAC90
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0xECAB30 Offset: 0xEC9F30 VA: 0x180ECAB30
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0xECB410 Offset: 0xECA810 VA: 0x180ECB410
	public void ReleasePointer(int pointerId) { }

	// RVA: 0xECB3B0 Offset: 0xECA7B0 VA: 0x180ECB3B0
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0xECAD10 Offset: 0xECA110 VA: 0x180ECAD10
	public void ProcessPointerCapture(int pointerId) { }

	// RVA: 0xECAAF0 Offset: 0xEC9EF0 VA: 0x180ECAAF0
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0xECACD0 Offset: 0xECA0D0 VA: 0x180ECACD0
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0xECB550 Offset: 0xECA950 VA: 0x180ECB550
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

