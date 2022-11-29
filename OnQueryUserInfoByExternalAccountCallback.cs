public sealed class OnQueryUserInfoByExternalAccountCallback : MulticastDelegate // TypeDefIndex: 8311
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryUserInfoByExternalAccountCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryUserInfoByExternalAccountCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryUserInfoByExternalAccountCallbackInfo data, IAsyncResult result) { }

}

