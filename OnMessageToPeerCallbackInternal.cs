internal sealed class OnMessageToPeerCallbackInternal : MulticastDelegate // TypeDefIndex: 9833
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnMessageToClientCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref OnMessageToClientCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnMessageToClientCallbackInfoInternal data, IAsyncResult result) { }

}

