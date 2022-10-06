public sealed class OnSessionInviteReceivedCallback : MulticastDelegate // TypeDefIndex: 8510
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref SessionInviteReceivedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref SessionInviteReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref SessionInviteReceivedCallbackInfo data, IAsyncResult result) { }

}

