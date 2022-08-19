internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 5922
{	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x2781

	// Properties
	internal static ReflectionDelegateFactory Instance { get; }

	// Methods

	// RVA: 0x1804EC0 Offset: 0x18042C0 VA: 0x181804EC0
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0x1804CE0 Offset: 0x18040E0 VA: 0x181804CE0 Slot: 5
	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257D90 Offset: 0x1257190 VA: 0x181257D90
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B14E70 Offset: 0x1B14270 VA: 0x181B14E70
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B150E0 Offset: 0x1B144E0 VA: 0x181B150E0
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B14FF0 Offset: 0x1B143F0 VA: 0x181B14FF0
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257EE0 Offset: 0x12572E0 VA: 0x181257EE0
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257FD0 Offset: 0x12573D0 VA: 0x181257FD0
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	*/

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1804E60 Offset: 0x1804260 VA: 0x181804E60
	private static void .cctor() { }

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0 // TypeDefIndex: 5923
{	// Fields
	public ConstructorInfo c; // 0x10
	public MethodBase method; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x180FF40 Offset: 0x180F340 VA: 0x18180FF40
	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	// RVA: 0x180FF60 Offset: 0x180F360 VA: 0x18180FF60
	internal object <CreateParameterizedConstructor>b__1(object[] a) { }

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<T> // TypeDefIndex: 5924
{	// Fields
	public ConstructorInfo c; // 0x0
	public MethodBase method; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <CreateMethodCall>b__0(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD60480 Offset: 0xD5F880 VA: 0x180D60480
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__0
	*/

	// RVA: -1 Offset: -1
	internal object <CreateMethodCall>b__1(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD604B0 Offset: 0xD5F8B0 VA: 0x180D604B0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> // TypeDefIndex: 5925
{	// Fields
	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <CreateDefaultConstructor>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD604D0 Offset: 0xD5F8D0 VA: 0x180D604D0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__0
	*/

	// RVA: -1 Offset: -1
	internal T <CreateDefaultConstructor>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD60540 Offset: 0xD5F940 VA: 0x180D60540
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__1
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> // TypeDefIndex: 5926
{	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD605C0 Offset: 0xD5F9C0 VA: 0x180D605C0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> // TypeDefIndex: 5927
{	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD605F0 Offset: 0xD5F9F0 VA: 0x180D605F0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>.<CreateGet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> // TypeDefIndex: 5928
{	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD60620 Offset: 0xD5FA20 VA: 0x180D60620
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>.<CreateSet>b__0
	*/

}

private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> // TypeDefIndex: 5929
{	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD60640 Offset: 0xD5FA40 VA: 0x180D60640
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>.<CreateSet>b__0
	*/

}

