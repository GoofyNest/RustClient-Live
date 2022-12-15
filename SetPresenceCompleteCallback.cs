public sealed class SetPresenceCompleteCallback : MulticastDelegate // TypeDefIndex: 8867
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref SetPresenceCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref SetPresenceCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref SetPresenceCallbackInfo data, IAsyncResult result) { }

}

