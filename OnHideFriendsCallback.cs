public sealed class OnHideFriendsCallback : MulticastDelegate // TypeDefIndex: 8343
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref HideFriendsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref HideFriendsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref HideFriendsCallbackInfo data, IAsyncResult result) { }

}

