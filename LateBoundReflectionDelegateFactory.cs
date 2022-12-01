internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5931
{
	private static readonly LateBoundReflectionDelegateFactory _instance;

	internal static ReflectionDelegateFactory Instance { get; }


	internal static ReflectionDelegateFactory get_Instance() { }

	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	*/

	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0 // TypeDefIndex: 5932
{
	public ConstructorInfo c;
	public MethodBase method;


	public void .ctor() { }

	internal object <CreateParameterizedConstructor>

	internal object <CreateParameterizedConstructor>

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<T> // TypeDefIndex: 5933
{
	public ConstructorInfo c;
	public MethodBase method;


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

	internal object <CreateMethodCall>
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

	internal object <CreateMethodCall>
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> // TypeDefIndex: 5934
{
	public Type type;
	public ConstructorInfo constructorInfo;


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

	internal T <CreateDefaultConstructor>
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

	internal T <CreateDefaultConstructor>
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> // TypeDefIndex: 5935
{
	public PropertyInfo propertyInfo;


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

	internal object <CreateGet>
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> // TypeDefIndex: 5936
{
	public FieldInfo fieldInfo;


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

	internal object <CreateGet>
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> // TypeDefIndex: 5937
{
	public FieldInfo fieldInfo;


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

	internal void <CreateSet>
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> // TypeDefIndex: 5938
{
	public PropertyInfo propertyInfo;


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

	internal void <CreateSet>
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c
	*/

}

