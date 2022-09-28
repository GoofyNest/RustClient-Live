public sealed class OnQueryOwnershipTokenCallback : MulticastDelegate // TypeDefIndex: 9445
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryOwnershipTokenCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryOwnershipTokenCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryOwnershipTokenCallbackInfo data, IAsyncResult result) { }

}

