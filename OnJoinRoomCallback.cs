public sealed class OnJoinRoomCallback : MulticastDelegate // TypeDefIndex: 8782
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinRoomCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinRoomCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinRoomCallbackInfo data, IAsyncResult result) { }

}

