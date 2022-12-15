public sealed class OnAcceptInviteCallback : MulticastDelegate // TypeDefIndex: 9397
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AcceptInviteCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref AcceptInviteCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AcceptInviteCallbackInfo data, IAsyncResult result) { }

}

