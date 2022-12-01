internal class PointerDispatchState // TypeDefIndex: 4609
{
	private IEventHandler[] m_PendingPointerCapture;
	private IEventHandler[] m_PointerCapture;
	private bool[] m_ShouldSendCompatibilityMouseEvents;


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

