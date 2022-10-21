public sealed class OnQueryUserInfoByDisplayNameCallback : MulticastDelegate // TypeDefIndex: 8300
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryUserInfoByDisplayNameCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryUserInfoByDisplayNameCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryUserInfoByDisplayNameCallbackInfo data, IAsyncResult result) { }

}

