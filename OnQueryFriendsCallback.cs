public sealed class OnQueryFriendsCallback : MulticastDelegate // TypeDefIndex: 9390
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryFriendsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryFriendsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryFriendsCallbackInfo data, IAsyncResult result) { }

}

