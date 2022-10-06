internal sealed class OnAudioOutputStateCallbackInternal : MulticastDelegate // TypeDefIndex: 8675
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioOutputStateCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioOutputStateCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioOutputStateCallbackInfoInternal data, IAsyncResult result) { }

}

