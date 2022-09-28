internal sealed class OnQueryOwnershipCallbackInternal : MulticastDelegate // TypeDefIndex: 9444
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryOwnershipCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryOwnershipCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryOwnershipCallbackInfoInternal data, IAsyncResult result) { }

}

