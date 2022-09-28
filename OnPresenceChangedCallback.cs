public sealed class OnPresenceChangedCallback : MulticastDelegate // TypeDefIndex: 8793
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref PresenceChangedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref PresenceChangedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref PresenceChangedCallbackInfo data, IAsyncResult result) { }

}

