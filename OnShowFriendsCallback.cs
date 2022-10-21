public sealed class OnShowFriendsCallback : MulticastDelegate // TypeDefIndex: 8349
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref ShowFriendsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref ShowFriendsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref ShowFriendsCallbackInfo data, IAsyncResult result) { }

}

