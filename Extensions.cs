public static class Extensions // TypeDefIndex: 6047
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
internal static U Convert<T, U>(T token) { }
/* GenericInstMethod :
|
|-Extensions.Convert<object, object>
|
|-Extensions.Convert<object, float>
*/

}

private sealed class Extensions.<>c__0<T> // TypeDefIndex: 6048
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

private sealed class Extensions.<>c__1<T> // TypeDefIndex: 6049
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

private sealed class Extensions.<>c__2<T> // TypeDefIndex: 6050
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

private sealed class Extensions.<>c__3<T> // TypeDefIndex: 6051
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

private sealed class Extensions.<>c // TypeDefIndex: 6052
{
	public static readonly Extensions.<>c <>9; 


private static void .cctor() { }

public void .ctor() { }

}

private sealed class Extensions.<>c__13<T, U> // TypeDefIndex: 6054
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

public static class Extensions // TypeDefIndex: 8137
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

public static class Extensions // TypeDefIndex: 11568
{

	[ExtensionAttribute] 
public static bool AnyOfType<TSource>(IEnumerable<TSource> source, Type expectedType) { }
/* GenericInstMethod :
|
|-Extensions.AnyOfType<object>
*/

}

