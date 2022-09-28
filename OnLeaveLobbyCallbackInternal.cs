internal sealed class OnLeaveLobbyCallbackInternal : MulticastDelegate // TypeDefIndex: 9179
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LeaveLobbyCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref LeaveLobbyCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LeaveLobbyCallbackInfoInternal data, IAsyncResult result) { }

}

