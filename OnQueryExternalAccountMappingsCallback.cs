public sealed class OnQueryExternalAccountMappingsCallback : MulticastDelegate // TypeDefIndex: 9604
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryExternalAccountMappingsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryExternalAccountMappingsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryExternalAccountMappingsCallbackInfo data, IAsyncResult result) { }

}

