public sealed class OnFriendsUpdateCallback : MulticastDelegate // TypeDefIndex: 9397
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnFriendsUpdateInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnFriendsUpdateInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnFriendsUpdateInfo data, IAsyncResult result) { }

}

