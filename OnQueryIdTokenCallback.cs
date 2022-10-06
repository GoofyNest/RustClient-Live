public sealed class OnQueryIdTokenCallback : MulticastDelegate // TypeDefIndex: 9680
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryIdTokenCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryIdTokenCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryIdTokenCallbackInfo data, IAsyncResult result) { }

}

