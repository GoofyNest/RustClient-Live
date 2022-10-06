public sealed class OnLogoutCallback : MulticastDelegate // TypeDefIndex: 9678
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LogoutCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref LogoutCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LogoutCallbackInfo data, IAsyncResult result) { }

}

