public sealed class OnUpdateSendingCallback : MulticastDelegate // TypeDefIndex: 8650
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UpdateSendingCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UpdateSendingCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UpdateSendingCallbackInfo data, IAsyncResult result) { }

}

