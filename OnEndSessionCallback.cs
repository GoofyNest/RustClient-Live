public sealed class OnEndSessionCallback : MulticastDelegate // TypeDefIndex: 8495
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref EndSessionCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref EndSessionCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref EndSessionCallbackInfo data, IAsyncResult result) { }

}

