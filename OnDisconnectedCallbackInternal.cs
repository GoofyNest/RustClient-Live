internal sealed class OnDisconnectedCallbackInternal : MulticastDelegate // TypeDefIndex: 8737
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DisconnectedCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref DisconnectedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DisconnectedCallbackInfoInternal data, IAsyncResult result) { }

}

