public sealed class OnSendCustomInviteCallback : MulticastDelegate // TypeDefIndex: 9531
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref SendCustomInviteCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref SendCustomInviteCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref SendCustomInviteCallbackInfo data, IAsyncResult result) { }

}

