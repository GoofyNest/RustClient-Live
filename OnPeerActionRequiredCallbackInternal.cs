internal sealed class OnPeerActionRequiredCallbackInternal : MulticastDelegate // TypeDefIndex: 9829
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnClientActionRequiredCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref OnClientActionRequiredCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnClientActionRequiredCallbackInfoInternal data, IAsyncResult result) { }

}

