internal sealed class OnQueryPresenceCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8842
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryPresenceCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryPresenceCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryPresenceCallbackInfoInternal data, IAsyncResult result) { }

}

