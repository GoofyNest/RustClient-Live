public sealed class OnPeerAuthStatusChangedCallback : MulticastDelegate // TypeDefIndex: 9796
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnClientAuthStatusChangedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnClientAuthStatusChangedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnClientAuthStatusChangedCallbackInfo data, IAsyncResult result) { }

}

