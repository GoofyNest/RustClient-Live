internal sealed class OnJoinLobbyCallbackInternal : MulticastDelegate // TypeDefIndex: 9210
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinLobbyCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinLobbyCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinLobbyCallbackInfoInternal data, IAsyncResult result) { }

}

