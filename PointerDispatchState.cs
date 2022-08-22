internal class PointerDispatchState // TypeDefIndex: 4604
{	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20


	public void .ctor() { }

	internal void Reset() { }

	public IEventHandler GetCapturingElement(int pointerId) { }

	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	public void CapturePointer(IEventHandler handler, int pointerId) { }

	public void ReleasePointer(int pointerId) { }

	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	public void ProcessPointerCapture(int pointerId) { }

	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	public void PreventCompatibilityMouseEvents(int pointerId) { }

	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

