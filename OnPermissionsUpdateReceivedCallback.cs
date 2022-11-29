public sealed class OnPermissionsUpdateReceivedCallback : MulticastDelegate // TypeDefIndex: 9338
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref PermissionsUpdateReceivedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref PermissionsUpdateReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref PermissionsUpdateReceivedCallbackInfo data, IAsyncResult result) { }

}

