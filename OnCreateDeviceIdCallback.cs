public sealed class OnCreateDeviceIdCallback : MulticastDelegate // TypeDefIndex: 9605
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref CreateDeviceIdCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref CreateDeviceIdCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref CreateDeviceIdCallbackInfo data, IAsyncResult result) { }

}

