public sealed class ConditionalWeakTable.CreateValueCallback<TKey, TValue> : MulticastDelegate // TypeDefIndex: 1316
{

public void .ctor(object object, IntPtr method) { }
/* GenericInstMethod :
|
|-ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession>..ctor
|-ConditionalWeakTable.CreateValueCallback<object, object>..ctor
|-ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext>..ctor
*/

public virtual TValue Invoke(TKey key) { }
/* GenericInstMethod :
|
|-ConditionalWeakTable.CreateValueCallback<object, object>.Invoke
*/

public virtual IAsyncResult BeginInvoke(TKey key, AsyncCallback callback, object object) { }
/* GenericInstMethod :
|
|-ConditionalWeakTable.CreateValueCallback<object, object>.BeginInvoke
*/

public virtual TValue EndInvoke(IAsyncResult result) { }
/* GenericInstMethod :
|
|-ConditionalWeakTable.CreateValueCallback<object, object>.EndInvoke
*/

}

