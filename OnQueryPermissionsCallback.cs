public sealed class OnQueryPermissionsCallback : MulticastDelegate // TypeDefIndex: 9342
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryPermissionsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryPermissionsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryPermissionsCallbackInfo data, IAsyncResult result) { }

}

