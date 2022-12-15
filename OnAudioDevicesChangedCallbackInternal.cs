internal sealed class OnAudioDevicesChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 8685
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioDevicesChangedCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioDevicesChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioDevicesChangedCallbackInfoInternal data, IAsyncResult result) { }

}

