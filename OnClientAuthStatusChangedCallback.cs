public sealed class OnClientAuthStatusChangedCallback : MulticastDelegate // TypeDefIndex: 9735
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnClientAuthStatusChangedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnClientAuthStatusChangedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnClientAuthStatusChangedCallbackInfo data, IAsyncResult result) { }

}

