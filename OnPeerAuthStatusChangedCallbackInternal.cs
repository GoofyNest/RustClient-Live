internal sealed class OnPeerAuthStatusChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 9845
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnClientAuthStatusChangedCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref OnClientAuthStatusChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnClientAuthStatusChangedCallbackInfoInternal data, IAsyncResult result) { }

}

