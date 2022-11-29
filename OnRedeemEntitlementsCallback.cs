public sealed class OnRedeemEntitlementsCallback : MulticastDelegate // TypeDefIndex: 9491
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref RedeemEntitlementsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref RedeemEntitlementsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref RedeemEntitlementsCallbackInfo data, IAsyncResult result) { }

}

