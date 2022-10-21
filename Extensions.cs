public static class Extensions // TypeDefIndex: 6052
{

	[ExtensionAttribute] 
	public static U Value<U>(IEnumerable<JToken> value) { }
	/* GenericInstMethod :
	|
	|-Extensions.Value<string>
	|-Extensions.Value<object>
	|-Extensions.Value<float>
	*/

	[ExtensionAttribute] 
	public static U Value<T, U>(IEnumerable<T> value) { }
	/* GenericInstMethod :
	|
	|-Extensions.Value<object, object>
	|
	|-Extensions.Value<object, float>
	*/

	[ExtensionAttribute] 
	internal static IEnumerable<U> Convert<T, U>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-Extensions.Convert<object, object>
	*/

	[ExtensionAttribute] 
	internal static U Convert<T, U>(T token) { }
	/* GenericInstMethod :
	|
	|-Extensions.Convert<object, object>
	|
	|-Extensions.Convert<object, float>
	*/

}

private sealed class Extensions.<>c__0<T> // TypeDefIndex: 6053
{
	public static readonly Extensions.<>c__0<T> <>9; 


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__0<object>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__0<object>..ctor
	*/

}

private sealed class Extensions.<>c__1<T> // TypeDefIndex: 6054
{
	public static readonly Extensions.<>c__1<T> <>9; 


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__1<object>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__1<object>..ctor
	*/

}

private sealed class Extensions.<>c__2<T> // TypeDefIndex: 6055
{
	public static readonly Extensions.<>c__2<T> <>9; 


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__2<object>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__2<object>..ctor
	*/

}

private sealed class Extensions.<>c__3<T> // TypeDefIndex: 6056
{
	public static readonly Extensions.<>c__3<T> <>9; 


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__3<object>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__3<object>..ctor
	*/

}

private sealed class Extensions.<>c // TypeDefIndex: 6057
{
	public static readonly Extensions.<>c <>9; 


	private static void .cctor() { }

	public void .ctor() { }

}

private sealed class Extensions.<>c__13<T, U> // TypeDefIndex: 6059
{

[CompilerGeneratedAttribute] 
[Serializable]
private sealed class Extensions.<>c__13<T, U>
	public static readonly Extensions.<>c__13<T, U> <>9; 


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__13<object, object>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Extensions.<>c__13<object, object>..ctor
	*/

}

private sealed class Extensions.<Convert>d__14<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IDisposable, IEnumerator // TypeDefIndex: 6060
{
	private int <>1__state; 
	private U <>2__current; 
	private int <>l__initialThreadId; 
	private IEnumerable<T> source; 
	public IEnumerable<T> <>3__source; 
	private IEnumerator<T> <>7__wrap1; 

	private U System.Collections.Generic.IEnumerator<U>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-Extensions.<Convert>d__14<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-Extensions.<Convert>d__14<object, object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-Extensions.<Convert>d__14<object, object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-Extensions.<Convert>d__14<object, object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] 
	private U System.Collections.Generic.IEnumerator<U>.get_Current() { }
	/* GenericInstMethod :
	|
	|-Extensions.<Convert>d__14<object, object>.System.Collections.Generic.IEnumerator<U>.get_Current
	*/

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-Extensions.<Convert>d__14<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-Extensions.<Convert>d__14<object, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] 
	private IEnumerator<U> System.Collections.Generic.IEnumerable<U>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Extensions.<Convert>d__14<object, object>.System.Collections.Generic.IEnumerable<U>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Extensions.<Convert>d__14<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

public static class Extensions // TypeDefIndex: 8146
{

	[ExtensionAttribute] 
	public static T Pop<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-Extensions.Pop<int>
	|
	|-Extensions.Pop<object>
	|-Extensions.Pop<string>
	*/

}

public static class Extensions // TypeDefIndex: 8256
{

	[ExtensionAttribute] 
	public static bool IsOperationComplete(Result result) { }

	[ExtensionAttribute] 
	public static string ToHexString(byte[] byteArray) { }

}

public static class Extensions // TypeDefIndex: 13322
{

	[ExtensionAttribute] 
	public static bool AnyOfType<TSource>(IEnumerable<TSource> source, Type expectedType) { }
	/* GenericInstMethod :
	|
	|-Extensions.AnyOfType<object>
	*/

}

