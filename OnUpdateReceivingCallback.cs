public sealed class OnUpdateReceivingCallback : MulticastDelegate // TypeDefIndex: 8694
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UpdateReceivingCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UpdateReceivingCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UpdateReceivingCallbackInfo data, IAsyncResult result) { }

}

