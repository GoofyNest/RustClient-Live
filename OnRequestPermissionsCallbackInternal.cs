internal sealed class OnRequestPermissionsCallbackInternal : MulticastDelegate // TypeDefIndex: 9335
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref RequestPermissionsCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref RequestPermissionsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref RequestPermissionsCallbackInfoInternal data, IAsyncResult result) { }

}

