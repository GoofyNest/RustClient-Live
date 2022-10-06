public sealed class OnLeaveRoomCallback : MulticastDelegate // TypeDefIndex: 8774
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LeaveRoomCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LeaveRoomCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LeaveRoomCallbackInfo data, IAsyncResult result) { }

}

