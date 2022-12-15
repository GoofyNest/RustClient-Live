public sealed class OnShowBlockPlayerCallback : MulticastDelegate // TypeDefIndex: 8358
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnShowBlockPlayerCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnShowBlockPlayerCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnShowBlockPlayerCallbackInfo data, IAsyncResult result) { }

}

