public sealed class OnCheckoutCallback : MulticastDelegate // TypeDefIndex: 9483
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref CheckoutCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref CheckoutCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref CheckoutCallbackInfo data, IAsyncResult result) { }

}

