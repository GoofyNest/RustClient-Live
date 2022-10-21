internal sealed class OnPresenceChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 8829
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref PresenceChangedCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref PresenceChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref PresenceChangedCallbackInfoInternal data, IAsyncResult result) { }

}

