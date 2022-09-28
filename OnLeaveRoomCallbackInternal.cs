internal sealed class OnLeaveRoomCallbackInternal : MulticastDelegate // TypeDefIndex: 8741
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LeaveRoomCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref LeaveRoomCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LeaveRoomCallbackInfoInternal data, IAsyncResult result) { }

}

