public sealed class OnDestroySessionCallback : MulticastDelegate // TypeDefIndex: 8492
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DestroySessionCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref DestroySessionCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DestroySessionCallbackInfo data, IAsyncResult result) { }

}

