internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5923
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

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0 // TypeDefIndex: 5924
{
	public ConstructorInfo c; 
	public MethodBase method; 


	public void .ctor() { }

	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	internal object <CreateParameterizedConstructor>b__1(object[] a) { }

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<T> // TypeDefIndex: 5925
{
	public ConstructorInfo c; 
	public MethodBase method; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>..ctor
	*/

	internal object <CreateMethodCall>b__0(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__0
	*/

	internal object <CreateMethodCall>b__1(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> // TypeDefIndex: 5926
{
	public Type type; 
	public ConstructorInfo constructorInfo; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>..ctor
	*/

	internal T <CreateDefaultConstructor>b__0() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__0
	*/

	internal T <CreateDefaultConstructor>b__1() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> // TypeDefIndex: 5927
{
	public PropertyInfo propertyInfo; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>..ctor
	*/

	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> // TypeDefIndex: 5928
{
	public FieldInfo fieldInfo; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>..ctor
	*/

	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> // TypeDefIndex: 5929
{
	public FieldInfo fieldInfo; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>..ctor
	*/

	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>.<CreateSet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> // TypeDefIndex: 5930
{
	public PropertyInfo propertyInfo; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>..ctor
	*/

	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>.<CreateSet>b__0
	*/

}

