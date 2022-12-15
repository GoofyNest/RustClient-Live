public sealed class OnQueryEntitlementsCallback : MulticastDelegate // TypeDefIndex: 9487
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryEntitlementsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryEntitlementsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryEntitlementsCallbackInfo data, IAsyncResult result) { }

}

