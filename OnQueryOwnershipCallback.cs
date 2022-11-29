public sealed class OnQueryOwnershipCallback : MulticastDelegate // TypeDefIndex: 9487
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryOwnershipCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryOwnershipCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryOwnershipCallbackInfo data, IAsyncResult result) { }

}

