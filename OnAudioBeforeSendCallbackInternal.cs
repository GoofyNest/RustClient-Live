internal sealed class OnAudioBeforeSendCallbackInternal : MulticastDelegate // TypeDefIndex: 8681
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioBeforeSendCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioBeforeSendCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioBeforeSendCallbackInfoInternal data, IAsyncResult result) { }

}

