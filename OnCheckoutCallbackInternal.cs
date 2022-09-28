internal sealed class OnCheckoutCallbackInternal : MulticastDelegate // TypeDefIndex: 9438
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref CheckoutCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref CheckoutCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref CheckoutCallbackInfoInternal data, IAsyncResult result) { }

}

