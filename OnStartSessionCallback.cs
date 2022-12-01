public sealed class OnStartSessionCallback : MulticastDelegate // TypeDefIndex: 8524
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref StartSessionCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref StartSessionCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref StartSessionCallbackInfo data, IAsyncResult result) { }

}

