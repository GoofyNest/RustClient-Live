public sealed class OnRequestPermissionsCallback : MulticastDelegate // TypeDefIndex: 9300
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref RequestPermissionsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref RequestPermissionsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref RequestPermissionsCallbackInfo data, IAsyncResult result) { }

}

