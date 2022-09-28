internal sealed class OnAudioInputStateCallbackInternal : MulticastDelegate // TypeDefIndex: 8639
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioInputStateCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioInputStateCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioInputStateCallbackInfoInternal data, IAsyncResult result) { }

}

