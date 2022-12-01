public sealed class OnSessionInviteAcceptedCallback : MulticastDelegate // TypeDefIndex: 8520
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref SessionInviteAcceptedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref SessionInviteAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref SessionInviteAcceptedCallbackInfo data, IAsyncResult result) { }

}

