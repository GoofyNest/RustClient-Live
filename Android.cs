public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
{
// Namespace: UnityEngine
public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x145EF20 Offset: 0x145E320 VA: 0x18145EF20 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AndroidJavaException : Exception // TypeDefIndex: 4464
{	// Fields
	private string mJavaStackTrace; // 0x88

	// Properties
	public override string StackTrace { get; }

	// Methods

	// RVA: 0x2271140 Offset: 0x2270540 VA: 0x182271140
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x22711C0 Offset: 0x22705C0 VA: 0x1822711C0 Slot: 8
	public override string get_StackTrace() { }

}

internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 4466
{	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x2272960 Offset: 0x2271D60 VA: 0x182272960
	public void .ctor(AndroidJavaRunnable runnable) { }

}

public class AndroidJavaProxy // TypeDefIndex: 4467
{	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x2272860 Offset: 0x2271C60 VA: 0x182272860
	public void .ctor(string javaInterface) { }

	// RVA: 0x2272900 Offset: 0x2271D00 VA: 0x182272900
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x2271BF0 Offset: 0x2270FF0 VA: 0x182271BF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2272020 Offset: 0x2271420 VA: 0x182272020 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x2271E40 Offset: 0x2271240 VA: 0x182271E40 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x2271CD0 Offset: 0x22710D0 VA: 0x182271CD0
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x2271D30 Offset: 0x2271130 VA: 0x182271D30
	internal IntPtr GetRawProxy() { }

	// RVA: 0x2272790 Offset: 0x2271B90 VA: 0x182272790
	private static void .cctor() { }

}

public class AndroidJavaObject : IDisposable // TypeDefIndex: 4468
{	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x2271BB0 Offset: 0x2270FB0 VA: 0x182271BB0
	public void .ctor(string className, object[] args) { }

	// RVA: 0x22714C0 Offset: 0x22708C0 VA: 0x1822714C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x4CEC00 Offset: 0x4CE000 VA: 0x1804CEC00
	public IntPtr GetRawObject() { }

	// RVA: 0x8FB8A0 Offset: 0x8FACA0 VA: 0x1808FB8A0
	public IntPtr GetRawClass() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123F4F0 Offset: 0x123E8F0 VA: 0x18123F4F0
	|-AndroidJavaObject.Call<bool>
	|-AndroidJavaObject.Call<char>
	|-AndroidJavaObject.Call<double>
	|-AndroidJavaObject.Call<short>
	|-AndroidJavaObject.Call<int>
	|-AndroidJavaObject.Call<long>
	|-AndroidJavaObject.Call<object>
	|-AndroidJavaObject.Call<sbyte>
	|-AndroidJavaObject.Call<float>
	|-AndroidJavaObject.Call<string>
	|-AndroidJavaObject.Call<AndroidJavaObject>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123F4F0 Offset: 0x123E8F0 VA: 0x18123F4F0
	|-AndroidJavaObject.CallStatic<int>
	|-AndroidJavaObject.CallStatic<object>
	|-AndroidJavaObject.CallStatic<AndroidJavaObject>
	*/

	// RVA: 0x2271430 Offset: 0x2270830 VA: 0x182271430
	protected void DebugPrint(string msg) { }

	// RVA: 0x2271630 Offset: 0x2270A30 VA: 0x182271630
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x2271A60 Offset: 0x2270E60 VA: 0x182271A60
	internal void .ctor(IntPtr jobject) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x2271590 Offset: 0x2270990 VA: 0x182271590 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2271530 Offset: 0x2270930 VA: 0x182271530 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1241100 Offset: 0x1240500 VA: 0x181241100
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x1241F50 Offset: 0x1241350 VA: 0x181241F50
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x1242DA0 Offset: 0x12421A0 VA: 0x181242DA0
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x1243C80 Offset: 0x1243080 VA: 0x181243C80
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x1244AD0 Offset: 0x1243ED0 VA: 0x181244AD0
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x12458F0 Offset: 0x1244CF0 VA: 0x1812458F0
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x1246730 Offset: 0x1245B30 VA: 0x181246730
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x1247500 Offset: 0x1246900 VA: 0x181247500
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x1248350 Offset: 0x1247750 VA: 0x181248350
	|-AndroidJavaObject._Call<float>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123F510 Offset: 0x123E910 VA: 0x18123F510
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x1240330 Offset: 0x123F730 VA: 0x181240330
	|-AndroidJavaObject._CallStatic<object>
	*/

	// RVA: 0x2271310 Offset: 0x2270710 VA: 0x182271310
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x22711F0 Offset: 0x22705F0 VA: 0x1822711F0
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x4CEC00 Offset: 0x4CE000 VA: 0x1804CEC00
	protected IntPtr _GetRawObject() { }

	// RVA: 0x8FB8A0 Offset: 0x8FACA0 VA: 0x1808FB8A0
	protected IntPtr _GetRawClass() { }

	// RVA: 0x2271A20 Offset: 0x2270E20 VA: 0x182271A20
	private static void .cctor() { }

}

public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 4469
{	// Methods

	// RVA: 0x2271010 Offset: 0x2270410 VA: 0x182271010
	public void .ctor(string className) { }

	// RVA: 0x2270E20 Offset: 0x2270220 VA: 0x182270E20
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x2270F10 Offset: 0x2270310 VA: 0x182270F10
	internal void .ctor(IntPtr jclass) { }

}

internal class AndroidReflection // TypeDefIndex: 4470
{	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x2273170 Offset: 0x2272570 VA: 0x182273170
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x2273140 Offset: 0x2272540 VA: 0x182273140
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x2273030 Offset: 0x2272430 VA: 0x182273030
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x2272C60 Offset: 0x2272060 VA: 0x182272C60
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x2272A60 Offset: 0x2271E60 VA: 0x182272A60
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x2272D70 Offset: 0x2272170 VA: 0x182272D70
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2273190 Offset: 0x2272590 VA: 0x182273190
	public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x2273280 Offset: 0x2272680 VA: 0x182273280
	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

	// RVA: 0x22733C0 Offset: 0x22727C0 VA: 0x1822733C0
	private static void .cctor() { }

}

public static class AndroidJNIHelper // TypeDefIndex: 4473
{	// Methods

	// RVA: 0x226D3B0 Offset: 0x226C7B0 VA: 0x18226D3B0
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x226D3C0 Offset: 0x226C7C0 VA: 0x18226D3C0
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x226D050 Offset: 0x226C450 VA: 0x18226D050
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x226CE80 Offset: 0x226C280 VA: 0x18226CE80
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x226CE70 Offset: 0x226C270 VA: 0x18226CE70
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x226D180 Offset: 0x226C580 VA: 0x18226D180
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x226D2B0 Offset: 0x226C6B0 VA: 0x18226D2B0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123F4E0 Offset: 0x123E8E0 VA: 0x18123F4E0
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6CF60 Offset: 0xE6C360 VA: 0x180E6CF60
	|-AndroidJNIHelper.GetMethodID<bool>
	|-AndroidJNIHelper.GetMethodID<char>
	|-AndroidJNIHelper.GetMethodID<double>
	|-AndroidJNIHelper.GetMethodID<short>
	|-AndroidJNIHelper.GetMethodID<int>
	|-AndroidJNIHelper.GetMethodID<long>
	|-AndroidJNIHelper.GetMethodID<object>
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|-AndroidJNIHelper.GetMethodID<float>
	*/

}

public static class AndroidJNI // TypeDefIndex: 4474
{	// Methods

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270510 Offset: 0x226F910 VA: 0x182270510
	public static IntPtr FindClass(string name) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270710 Offset: 0x226FB10 VA: 0x182270710
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22704E0 Offset: 0x226F8E0 VA: 0x1822704E0
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22704B0 Offset: 0x226F8B0 VA: 0x1822704B0
	public static void ExceptionClear() { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270990 Offset: 0x226FD90 VA: 0x182270990
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22703F0 Offset: 0x226F7F0 VA: 0x1822703F0
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270B00 Offset: 0x226FF00 VA: 0x182270B00
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270470 Offset: 0x226F870 VA: 0x182270470
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22709D0 Offset: 0x226FDD0 VA: 0x1822709D0
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270430 Offset: 0x226F830 VA: 0x182270430
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270A60 Offset: 0x226FE60 VA: 0x182270A60
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22708B0 Offset: 0x226FCB0 VA: 0x1822708B0
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270810 Offset: 0x226FC10 VA: 0x182270810
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22708F0 Offset: 0x226FCF0 VA: 0x1822708F0
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2270AC0 Offset: 0x226FEC0 VA: 0x182270AC0
	public static IntPtr NewString(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270AC0 Offset: 0x226FEC0 VA: 0x182270AC0
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270950 Offset: 0x226FD50 VA: 0x182270950
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270390 Offset: 0x226F790 VA: 0x182270390
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FE50 Offset: 0x226F250 VA: 0x18226FE50
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FD90 Offset: 0x226F190 VA: 0x18226FD90
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FC10 Offset: 0x226F010 VA: 0x18226FC10
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FF10 Offset: 0x226F310 VA: 0x18226FF10
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FEB0 Offset: 0x226F2B0 VA: 0x18226FEB0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FC70 Offset: 0x226F070 VA: 0x18226FC70
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FD30 Offset: 0x226F130 VA: 0x18226FD30
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FCD0 Offset: 0x226F0D0 VA: 0x18226FCD0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FDF0 Offset: 0x226F1F0 VA: 0x18226FDF0
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22702D0 Offset: 0x226F6D0 VA: 0x1822702D0
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22701B0 Offset: 0x226F5B0 VA: 0x1822701B0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22700F0 Offset: 0x226F4F0 VA: 0x1822700F0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FF70 Offset: 0x226F370 VA: 0x18226FF70
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270270 Offset: 0x226F670 VA: 0x182270270
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270210 Offset: 0x226F610 VA: 0x182270210
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x226FFD0 Offset: 0x226F3D0 VA: 0x18226FFD0
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270090 Offset: 0x226F490 VA: 0x182270090
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270030 Offset: 0x226F430 VA: 0x182270030
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270150 Offset: 0x226F550 VA: 0x182270150
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270330 Offset: 0x226F730 VA: 0x182270330
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270B90 Offset: 0x226FF90 VA: 0x182270B90
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafeAttribute] // RVA: 0xC1430 Offset: 0xC0830 VA: 0x1800C1430
	[ObsoleteAttribute] // RVA: 0xC1430 Offset: 0xC0830 VA: 0x1800C1430
	// RVA: 0x2270BD0 Offset: 0x226FFD0 VA: 0x182270BD0
	public static IntPtr ToByteArray(byte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270DA0 Offset: 0x22701A0 VA: 0x182270DA0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270C10 Offset: 0x2270010 VA: 0x182270C10
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270DE0 Offset: 0x22701E0 VA: 0x182270DE0
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270CD0 Offset: 0x22700D0 VA: 0x182270CD0
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270D10 Offset: 0x2270110 VA: 0x182270D10
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270C90 Offset: 0x2270090 VA: 0x182270C90
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270C50 Offset: 0x2270050 VA: 0x182270C50
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270D50 Offset: 0x2270150 VA: 0x182270D50
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270550 Offset: 0x226F950 VA: 0x182270550
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ObsoleteAttribute] // RVA: 0xC1C50 Offset: 0xC1050 VA: 0x1800C1C50
	[ThreadSafeAttribute] // RVA: 0xC1C50 Offset: 0xC1050 VA: 0x1800C1C50
	// RVA: 0x2270590 Offset: 0x226F990 VA: 0x182270590
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270750 Offset: 0x226FB50 VA: 0x182270750
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22705D0 Offset: 0x226F9D0 VA: 0x1822705D0
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270790 Offset: 0x226FB90 VA: 0x182270790
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270690 Offset: 0x226FA90 VA: 0x182270690
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22706D0 Offset: 0x226FAD0 VA: 0x1822706D0
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270650 Offset: 0x226FA50 VA: 0x182270650
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270610 Offset: 0x226FA10 VA: 0x182270610
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x22707D0 Offset: 0x226FBD0 VA: 0x1822707D0
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270A10 Offset: 0x226FE10 VA: 0x182270A10
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270870 Offset: 0x226FC70 VA: 0x182270870
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2270B40 Offset: 0x226FF40 VA: 0x182270B40
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

internal class AndroidJNISafe // TypeDefIndex: 4475
{	// Methods

	// RVA: 0x226E4A0 Offset: 0x226D8A0 VA: 0x18226E4A0
	public static void CheckException() { }

	// RVA: 0x226E650 Offset: 0x226DA50 VA: 0x18226E650
	public static void DeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x226E730 Offset: 0x226DB30 VA: 0x18226E730
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x226E6C0 Offset: 0x226DAC0 VA: 0x18226E6C0
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x226F470 Offset: 0x226E870 VA: 0x18226F470
	public static IntPtr NewString(string chars) { }

	// RVA: 0x226F2F0 Offset: 0x226E6F0 VA: 0x18226F2F0
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x226F170 Offset: 0x226E570 VA: 0x18226F170
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x226F220 Offset: 0x226E620 VA: 0x18226F220
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x226EFE0 Offset: 0x226E3E0 VA: 0x18226EFE0
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x226ED20 Offset: 0x226E120 VA: 0x18226ED20
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x226E7A0 Offset: 0x226DBA0 VA: 0x18226E7A0
	public static IntPtr FindClass(string name) { }

	// RVA: 0x226F3A0 Offset: 0x226E7A0 VA: 0x18226F3A0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226E320 Offset: 0x226D720 VA: 0x18226E320
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226DFE0 Offset: 0x226D3E0 VA: 0x18226DFE0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226E250 Offset: 0x226D650 VA: 0x18226E250
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226DBE0 Offset: 0x226CFE0 VA: 0x18226DBE0
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226DCB0 Offset: 0x226D0B0 VA: 0x18226DCB0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226DD80 Offset: 0x226D180 VA: 0x18226DD80
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226DF10 Offset: 0x226D310 VA: 0x18226DF10
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226E180 Offset: 0x226D580 VA: 0x18226E180
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226E0B0 Offset: 0x226D4B0 VA: 0x18226E0B0
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226DB10 Offset: 0x226CF10 VA: 0x18226DB10
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226DE50 Offset: 0x226D250 VA: 0x18226DE50
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226D8A0 Offset: 0x226CCA0 VA: 0x18226D8A0
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226E3D0 Offset: 0x226D7D0 VA: 0x18226E3D0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226D4A0 Offset: 0x226C8A0 VA: 0x18226D4A0
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226D570 Offset: 0x226C970 VA: 0x18226D570
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226D640 Offset: 0x226CA40 VA: 0x18226D640
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226D7D0 Offset: 0x226CBD0 VA: 0x18226D7D0
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226DA40 Offset: 0x226CE40 VA: 0x18226DA40
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226D970 Offset: 0x226CD70 VA: 0x18226D970
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226D3D0 Offset: 0x226C7D0 VA: 0x18226D3D0
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226D710 Offset: 0x226CB10 VA: 0x18226D710
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x226E9B0 Offset: 0x226DDB0 VA: 0x18226E9B0
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x226EA60 Offset: 0x226DE60 VA: 0x18226EA60
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x226EB10 Offset: 0x226DF10 VA: 0x18226EB10
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x226EC70 Offset: 0x226E070 VA: 0x18226EC70
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x226EE80 Offset: 0x226E280 VA: 0x18226EE80
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x226E900 Offset: 0x226DD00 VA: 0x18226E900
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x226EDD0 Offset: 0x226E1D0 VA: 0x18226EDD0
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x226E850 Offset: 0x226DC50 VA: 0x18226E850
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x226EBC0 Offset: 0x226DFC0 VA: 0x18226EBC0
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x226F9F0 Offset: 0x226EDF0 VA: 0x18226F9F0
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x226F680 Offset: 0x226EA80 VA: 0x18226F680
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x226F730 Offset: 0x226EB30 VA: 0x18226F730
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x226F7E0 Offset: 0x226EBE0 VA: 0x18226F7E0
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x226F940 Offset: 0x226ED40 VA: 0x18226F940
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x226FB60 Offset: 0x226EF60 VA: 0x18226FB60
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x226F5D0 Offset: 0x226E9D0 VA: 0x18226F5D0
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x226FAB0 Offset: 0x226EEB0 VA: 0x18226FAB0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x226F520 Offset: 0x226E920 VA: 0x18226F520
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x226F890 Offset: 0x226EC90 VA: 0x18226F890
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x226F0B0 Offset: 0x226E4B0 VA: 0x18226F0B0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x226EF30 Offset: 0x226E330 VA: 0x18226EF30
	public static int GetArrayLength(IntPtr array) { }

}

