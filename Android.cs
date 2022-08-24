public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
{

public sealed class AndroidJavaRunnable : MulticastDelegate 

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke() { }

public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AndroidJavaException : Exception // TypeDefIndex: 4464
{
	private string mJavaStackTrace; 

public override string StackTrace { get; }


internal void .ctor(string message, string javaStackTrace) { }

public override string get_StackTrace() { }

}

internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 4466
{
	private AndroidJavaRunnable mRunnable; 


public void .ctor(AndroidJavaRunnable runnable) { }

}

public class AndroidJavaProxy // TypeDefIndex: 4467
{
	public readonly AndroidJavaClass javaInterface; 
	internal IntPtr proxyObject; 
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; 
	private static readonly IntPtr s_HashCodeMethodID; 


public void .ctor(string javaInterface) { }

public void .ctor(AndroidJavaClass javaInterface) { }

protected override void Finalize() { }

public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

internal AndroidJavaObject GetProxyObject() { }

internal IntPtr GetRawProxy() { }

private static void .cctor() { }

}

public class AndroidJavaObject : IDisposable // TypeDefIndex: 4468
{
	private static bool enableDebugPrints; 
	internal GlobalJavaObjectRef m_jobject; 
	internal GlobalJavaObjectRef m_jclass; 


public void .ctor(string className, object[] args) { }

public void Dispose() { }

public IntPtr GetRawObject() { }

public IntPtr GetRawClass() { }

public ReturnType Call<ReturnType>(string methodName, object[] args) { }
/* GenericInstMethod :
|
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

public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
/* GenericInstMethod :
|
|-AndroidJavaObject.CallStatic<int>
|-AndroidJavaObject.CallStatic<object>
|-AndroidJavaObject.CallStatic<AndroidJavaObject>
*/

protected void DebugPrint(string msg) { }

private void _AndroidJavaObject(string className, object[] args) { }

internal void .ctor(IntPtr jobject) { }

internal void .ctor() { }

protected override void Finalize() { }

protected virtual void Dispose(bool disposing) { }

protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
/* GenericInstMethod :
|
|-AndroidJavaObject._Call<bool>
|
|-AndroidJavaObject._Call<char>
|
|-AndroidJavaObject._Call<double>
|
|-AndroidJavaObject._Call<short>
|
|-AndroidJavaObject._Call<int>
|
|-AndroidJavaObject._Call<long>
|
|-AndroidJavaObject._Call<object>
|
|-AndroidJavaObject._Call<sbyte>
|
|-AndroidJavaObject._Call<float>
*/

protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
/* GenericInstMethod :
|
|-AndroidJavaObject._CallStatic<int>
|
|-AndroidJavaObject._CallStatic<object>
*/

internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

protected IntPtr _GetRawObject() { }

protected IntPtr _GetRawClass() { }

private static void .cctor() { }

}

public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 4469
{

public void .ctor(string className) { }

private void _AndroidJavaClass(string className) { }

internal void .ctor(IntPtr jclass) { }

}

internal class AndroidReflection // TypeDefIndex: 4470
{
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; 
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; 
	private static readonly IntPtr s_ReflectionHelperGetMethodID; 
	private static readonly IntPtr s_ReflectionHelperGetFieldID; 
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; 
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; 
	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; 
	private static readonly IntPtr s_FieldGetDeclaringClass; 


public static bool IsPrimitive(Type t) { }

public static bool IsAssignableFrom(Type t, Type from) { }

private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

private static void .cctor() { }

}

public static class AndroidJNIHelper // TypeDefIndex: 4473
{

public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

public static jvalue[] CreateJNIArgArray(object[] args) { }

public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
/* GenericInstMethod :
|
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

public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
/* GenericInstMethod :
|
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
{

	[ThreadSafeAttribute] 
public static IntPtr FindClass(string name) { }

	[ThreadSafeAttribute] 
public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafeAttribute] 
public static IntPtr ExceptionOccurred() { }

	[ThreadSafeAttribute] 
public static void ExceptionClear() { }

	[ThreadSafeAttribute] 
public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] 
public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] 
public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] 
public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] 
public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] 
public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] 
public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafeAttribute] 
public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafeAttribute] 
public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

public static IntPtr NewString(string chars) { }

	[ThreadSafeAttribute] 
private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafeAttribute] 
public static string GetStringChars(IntPtr str) { }

	[ThreadSafeAttribute] 
public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] 
public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafeAttribute] 
	[ObsoleteAttribute] 
public static IntPtr ToByteArray(byte[] array) { }

	[ThreadSafeAttribute] 
public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafeAttribute] 
public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafeAttribute] 
public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafeAttribute] 
public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafeAttribute] 
public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafeAttribute] 
public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafeAttribute] 
public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafeAttribute] 
public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafeAttribute] 
public static bool[] FromBooleanArray(IntPtr array) { }

	[ObsoleteAttribute] 
	[ThreadSafeAttribute] 
public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafeAttribute] 
public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafeAttribute] 
public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafeAttribute] 
public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafeAttribute] 
public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafeAttribute] 
public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafeAttribute] 
public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafeAttribute] 
public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafeAttribute] 
public static int GetArrayLength(IntPtr array) { }

	[ThreadSafeAttribute] 
public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafeAttribute] 
public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafeAttribute] 
public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

internal class AndroidJNISafe // TypeDefIndex: 4475
{

public static void CheckException() { }

public static void DeleteGlobalRef(IntPtr globalref) { }

public static void DeleteWeakGlobalRef(IntPtr globalref) { }

public static void DeleteLocalRef(IntPtr localref) { }

public static IntPtr NewString(string chars) { }

public static string GetStringChars(IntPtr str) { }

public static IntPtr GetObjectClass(IntPtr ptr) { }

public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

public static IntPtr FindClass(string name) { }

public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

public static char[] FromCharArray(IntPtr array) { }

public static double[] FromDoubleArray(IntPtr array) { }

public static float[] FromFloatArray(IntPtr array) { }

public static long[] FromLongArray(IntPtr array) { }

public static short[] FromShortArray(IntPtr array) { }

public static byte[] FromByteArray(IntPtr array) { }

public static sbyte[] FromSByteArray(IntPtr array) { }

public static bool[] FromBooleanArray(IntPtr array) { }

public static int[] FromIntArray(IntPtr array) { }

public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

public static IntPtr ToCharArray(char[] array) { }

public static IntPtr ToDoubleArray(double[] array) { }

public static IntPtr ToFloatArray(float[] array) { }

public static IntPtr ToLongArray(long[] array) { }

public static IntPtr ToShortArray(short[] array) { }

public static IntPtr ToByteArray(byte[] array) { }

public static IntPtr ToSByteArray(sbyte[] array) { }

public static IntPtr ToBooleanArray(bool[] array) { }

public static IntPtr ToIntArray(int[] array) { }

public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

public static int GetArrayLength(IntPtr array) { }

}

