internal sealed class Listeners.Action<TElem, T1, T2, T3, T4> : MulticastDelegate // TypeDefIndex: 4310
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool>..ctor
	|-Listeners.Action<DataViewListener, DataViewListener, ListChangedType, DataRow, bool>..ctor
	|-Listeners.Action<object, object, Int32Enum, object, bool>..ctor
	|-Listeners.Action<object, object, object, bool, bool>..ctor
	|-Listeners.Action<object, object, object, object, object>..ctor
	*/

	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-Listeners.Action<object, object, Int32Enum, object, bool>.Invoke
	|
	|-Listeners.Action<object, object, object, bool, bool>.Invoke
	|
	|-Listeners.Action<object, object, object, object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-Listeners.Action<object, object, Int32Enum, object, bool>.BeginInvoke
	|
	|-Listeners.Action<object, object, object, bool, bool>.BeginInvoke
	|
	|-Listeners.Action<object, object, object, object, object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-Listeners.Action<object, object, Int32Enum, object, bool>.EndInvoke
	|-Listeners.Action<object, object, object, bool, bool>.EndInvoke
	|-Listeners.Action<object, object, object, object, object>.EndInvoke
	*/

}

internal sealed class Listeners.Func<TElem, T1, TResult> : MulticastDelegate // TypeDefIndex: 4311
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-Listeners.Func<DataViewListener, DataViewListener, bool>..ctor
	|-Listeners.Func<object, object, bool>..ctor
	|-Listeners.Func<object, object, object>..ctor
	*/

	public virtual TResult Invoke(T1 arg1) { }
	/* GenericInstMethod :
	|
	|-Listeners.Func<object, object, bool>.Invoke
	|
	|-Listeners.Func<object, object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-Listeners.Func<object, object, bool>.BeginInvoke
	|-Listeners.Func<object, object, object>.BeginInvoke
	*/

	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-Listeners.Func<object, object, bool>.EndInvoke
	|
	|-Listeners.Func<object, object, object>.EndInvoke
	*/

}

