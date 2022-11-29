public sealed class OnUpdateReceivingVolumeCallback : MulticastDelegate // TypeDefIndex: 8692
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UpdateReceivingVolumeCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UpdateReceivingVolumeCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UpdateReceivingVolumeCallbackInfo data, IAsyncResult result) { }

}

