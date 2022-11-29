public sealed class OnDeleteDeviceIdCallback : MulticastDelegate // TypeDefIndex: 9605
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DeleteDeviceIdCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref DeleteDeviceIdCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DeleteDeviceIdCallbackInfo data, IAsyncResult result) { }

}

