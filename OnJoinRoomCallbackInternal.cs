internal sealed class OnJoinRoomCallbackInternal : MulticastDelegate // TypeDefIndex: 8785
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinRoomCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinRoomCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinRoomCallbackInfoInternal data, IAsyncResult result) { }

}

