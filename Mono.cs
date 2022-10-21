internal struct MonoAssemblyName // TypeDefIndex: 19
{
	internal IntPtr name; 
	internal IntPtr culture; 
	internal IntPtr hash_value; 
	internal IntPtr public_key; 
	[FixedBufferAttribute] 
	internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token; 
	internal uint hash_alg; 
	internal uint hash_len; 
	internal uint flags; 
	internal ushort major; 
	internal ushort minor; 
	internal ushort build; 
	internal ushort revision; 
	internal ushort arch; 

}

public struct MonoAssemblyName.<public_key_token>e__FixedBuffer // TypeDefIndex: 20
{
	public byte FixedElementField; 

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 139
{
	private string comment; 


	public void .ctor() { }

	public void .ctor(string comment) { }

}

internal class MonoLimitationAttribute : MonoTODOAttribute // TypeDefIndex: 140
{

	public void .ctor(string comment) { }

}

internal class MonoTypeInfo // TypeDefIndex: 344
{
	public string full_name; 
	public MonoCMethod default_ctor; 


	public void .ctor() { }

}

internal class MonoAsyncCall // TypeDefIndex: 372
{
	private object msg; 
	private IntPtr cb_method; 
	private object cb_target; 
	private object state; 
	private object res; 
	private object out_args; 


	public void .ctor() { }

}

internal static class MonoCustomAttrs // TypeDefIndex: 373
{
	private static Assembly corlib; 
	[ThreadStaticAttribute] 
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; 
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; 


	private static bool IsUserCattrProvider(object obj) { }

	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	private static object[] GetPseudoCustomAttributes(Type type) { }

	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	private static void .cctor() { }

}

private class MonoCustomAttrs.AttributeInfo // TypeDefIndex: 374
{
	private AttributeUsageAttribute _usage; 
	private int _inheritanceLevel; 

	public AttributeUsageAttribute Usage { get; }
	public int InheritanceLevel { get; }


	public void .ctor(AttributeUsageAttribute usage, int inheritanceLevel) { }

	public AttributeUsageAttribute get_Usage() { }

	public int get_InheritanceLevel() { }

}

internal sealed class MonoListItem // TypeDefIndex: 375
{
	private MonoListItem next; 
	private object data; 


	public void .ctor() { }

}

internal class MonoAssembly : RuntimeAssembly // TypeDefIndex: 573
{

	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	public override Module GetModule(string name) { }

	public override AssemblyName[] GetReferencedAssemblies() { }

	public override Module[] GetModules(bool getResourceModules) { }

	public void .ctor() { }

}

internal struct MonoEventInfo // TypeDefIndex: 574
{
	public Type declaring_type; 
	public Type reflected_type; 
	public string name; 
	public MethodInfo add_method; 
	public MethodInfo remove_method; 
	public MethodInfo raise_method; 
	public EventAttributes attrs; 
	public MethodInfo[] other_methods; 


	private static void get_event_info(MonoEvent ev, out MonoEventInfo info) { }

	internal static MonoEventInfo GetEventInfo(MonoEvent ev) { }

}

internal sealed class MonoEvent : RuntimeEventInfo // TypeDefIndex: 576
{
	private IntPtr klass; 
	private IntPtr handle; 

	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }


	public override MethodInfo GetAddMethod(bool nonPublic) { }

	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	public override Type get_DeclaringType() { }

	public override Type get_ReflectedType() { }

	public override string get_Name() { }

	public override string ToString() { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	public void .ctor() { }

}

internal class MonoField : RtFieldInfo // TypeDefIndex: 579
{
	internal IntPtr klass; 
	internal RuntimeFieldHandle fhandle; 
	private string name; 
	private Type type; 
	private FieldAttributes attrs; 

	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }


	public override FieldAttributes get_Attributes() { }

	public override RuntimeFieldHandle get_FieldHandle() { }

	private Type ResolveType() { }

	public override Type get_FieldType() { }

	private Type GetParentType(bool declaring) { }

	public override Type get_ReflectedType() { }

	public override Type get_DeclaringType() { }

	public override string get_Name() { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	internal override int GetFieldOffset() { }

	private object GetValueInternal(object obj) { }

	public override object GetValue(object obj) { }

	public override string ToString() { }

	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	public override object GetRawConstantValue() { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	private void CheckGeneric() { }

	public void .ctor() { }

}

internal struct MonoMethodInfo // TypeDefIndex: 580
{
	private Type parent; 
	private Type ret; 
	internal MethodAttributes attrs; 
	internal MethodImplAttributes iattrs; 
	private CallingConventions callconv; 


	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	private static int get_method_attributes(IntPtr handle) { }

	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	internal static Type GetDeclaringType(IntPtr handle) { }

	internal static Type GetReturnType(IntPtr handle) { }

	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

}

internal class MonoMethod : RuntimeMethodInfo // TypeDefIndex: 582
{
	internal IntPtr mhandle; 
	private string name; 
	private Type reftype; 

	public override Type ReturnType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }


	internal void .ctor() { }

	internal static string get_name(MethodBase method) { }

	internal static MonoMethod get_base_method(MonoMethod method, bool definition) { }

	public override MethodInfo GetBaseDefinition() { }

	internal override MethodInfo GetBaseMethod() { }

	public override Type get_ReturnType() { }

	public override MethodImplAttributes GetMethodImplementationFlags() { }

	public override ParameterInfo[] GetParameters() { }

	internal override ParameterInfo[] GetParametersInternal() { }

	internal override int GetParametersCount() { }

	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] 
	[DebuggerStepThroughAttribute] 
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	public override RuntimeMethodHandle get_MethodHandle() { }

	public override MethodAttributes get_Attributes() { }

	public override CallingConventions get_CallingConvention() { }

	public override Type get_ReflectedType() { }

	public override Type get_DeclaringType() { }

	public override string get_Name() { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	internal object[] GetPseudoCustomAttributes() { }

	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	public override Type[] GetGenericArguments() { }

	private MethodInfo GetGenericMethodDefinition_impl() { }

	public override MethodInfo GetGenericMethodDefinition() { }

	public override bool get_IsGenericMethodDefinition() { }

	public override bool get_IsGenericMethod() { }

	public override bool get_ContainsGenericParameters() { }

	public override MethodBody GetMethodBody() { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	private static int get_core_clr_security_level() { }

	public override bool get_IsSecurityCritical() { }

}

internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 584
{
	internal IntPtr mhandle; 
	private string name; 
	private Type reftype; 

	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }


	public override MethodImplAttributes GetMethodImplementationFlags() { }

	public override ParameterInfo[] GetParameters() { }

	internal override ParameterInfo[] GetParametersInternal() { }

	internal override int GetParametersCount() { }

	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerStepThroughAttribute] 
	[DebuggerHiddenAttribute] 
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerStepThroughAttribute] 
	[DebuggerHiddenAttribute] 
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public override RuntimeMethodHandle get_MethodHandle() { }

	public override MethodAttributes get_Attributes() { }

	public override CallingConventions get_CallingConvention() { }

	public override bool get_ContainsGenericParameters() { }

	public override Type get_ReflectedType() { }

	public override Type get_DeclaringType() { }

	public override string get_Name() { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override MethodBody GetMethodBody() { }

	public override string ToString() { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	private static int get_core_clr_security_level() { }

	public override bool get_IsSecurityCritical() { }

	public void .ctor() { }

}

internal class MonoModule : RuntimeModule // TypeDefIndex: 586
{
	public override Assembly Assembly { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }


	public override Assembly get_Assembly() { }

	public override string get_ScopeName() { }

	public override Guid get_ModuleVersionId() { }

	public override bool IsResource() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal RuntimeAssembly GetRuntimeAssembly() { }

	public void .ctor() { }

}

internal class MonoParameterInfo : RuntimeParameterInfo // TypeDefIndex: 588
{
	public override object DefaultValue { get; }


	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	public override object get_DefaultValue() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

}

internal struct MonoPropertyInfo // TypeDefIndex: 589
{
	public Type parent; 
	public Type declaring_type; 
	public string name; 
	public MethodInfo get_method; 
	public MethodInfo set_method; 
	public PropertyAttributes attrs; 


	internal static void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info) { }

	internal static Type[] GetTypeModifiers(MonoProperty prop, bool optional) { }

	internal static object get_default_value(MonoProperty prop) { }

}

internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 592
{
	internal IntPtr klass; 
	internal IntPtr prop; 
	private MonoPropertyInfo info; 
	private PInfo cached; 
	private MonoProperty.GetterAdapter cached_getter; 

	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }


	private void CachePropertyInfo(PInfo flags) { }

	public override PropertyAttributes get_Attributes() { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override Type get_PropertyType() { }

	public override Type get_ReflectedType() { }

	public override Type get_DeclaringType() { }

	public override string get_Name() { }

	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	public override MethodInfo GetGetMethod(bool nonPublic) { }

	public override ParameterInfo[] GetIndexParameters() { }

	public override MethodInfo GetSetMethod(bool nonPublic) { }

	public override object GetConstantValue() { }

	public override object GetRawConstantValue() { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	public override object GetValue(object obj, object[] index) { }

	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	public override Type[] GetOptionalCustomModifiers() { }

	public override Type[] GetRequiredCustomModifiers() { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	public void .ctor() { }

}

private sealed class MonoProperty.GetterAdapter : MulticastDelegate // TypeDefIndex: 593
{

	public void .ctor(object object, IntPtr method) { }

	public virtual object Invoke(object _this) { }

	public virtual IAsyncResult BeginInvoke(object _this, AsyncCallback callback, object object) { }

	public virtual object EndInvoke(IAsyncResult result) { }

}

private sealed class MonoProperty.Getter<T, R> : MulticastDelegate // TypeDefIndex: 594
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-MonoProperty.Getter<object, object>..ctor
	*/

	public virtual R Invoke(T _this) { }
	/* GenericInstMethod :
	|
	|-MonoProperty.Getter<object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T _this, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-MonoProperty.Getter<object, object>.BeginInvoke
	*/

	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-MonoProperty.Getter<object, object>.EndInvoke
	*/

}

private sealed class MonoProperty.StaticGetter<R> : MulticastDelegate // TypeDefIndex: 595
{

	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-MonoProperty.StaticGetter<object>..ctor
	*/

	public virtual R Invoke() { }
	/* GenericInstMethod :
	|
	|-MonoProperty.StaticGetter<object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-MonoProperty.StaticGetter<object>.BeginInvoke
	*/

	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-MonoProperty.StaticGetter<object>.EndInvoke
	*/

}

internal enum MonoFileType // TypeDefIndex: 674
{
	public int value__; 
	public const MonoFileType Unknown = 0;
	public const MonoFileType Disk = 1;
	public const MonoFileType Char = 2;
	public const MonoFileType Pipe = 3;
	public const MonoFileType Remote = 32768;

}

internal static class MonoIO // TypeDefIndex: 675
{
	public static readonly IntPtr InvalidHandle; 
	private static bool dump_handles; 

	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }


	public static Exception GetException(MonoIOError error) { }

	public static Exception GetException(string path, MonoIOError error) { }

	private static bool CreateDirectory(char* path, out MonoIOError error) { }

	public static bool CreateDirectory(string path, out MonoIOError error) { }

	private static bool RemoveDirectory(char* path, out MonoIOError error) { }

	public static bool RemoveDirectory(string path, out MonoIOError error) { }

	public static string GetCurrentDirectory(out MonoIOError error) { }

	private static bool MoveFile(char* path, char* dest, out MonoIOError error) { }

	public static bool MoveFile(string path, string dest, out MonoIOError error) { }

	private static bool CopyFile(char* path, char* dest, bool overwrite, out MonoIOError error) { }

	public static bool CopyFile(string path, string dest, bool overwrite, out MonoIOError error) { }

	private static bool DeleteFile(char* path, out MonoIOError error) { }

	public static bool DeleteFile(string path, out MonoIOError error) { }

	private static FileAttributes GetFileAttributes(char* path, out MonoIOError error) { }

	public static FileAttributes GetFileAttributes(string path, out MonoIOError error) { }

	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	private static IntPtr FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	public static IntPtr FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	public static bool FindNextFile(IntPtr hnd, out string fileName, out int fileAttr, out int error) { }

	public static bool FindCloseFile(IntPtr hnd) { }

	public static bool Exists(string path, out MonoIOError error) { }

	public static bool ExistsFile(string path, out MonoIOError error) { }

	public static bool ExistsDirectory(string path, out MonoIOError error) { }

	public static bool ExistsSymlink(string path, out MonoIOError error) { }

	private static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error) { }

	public static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error) { }

	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	public static bool Close(IntPtr handle, out MonoIOError error) { }

	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	private static bool SetFileTime(IntPtr handle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	public static bool SetFileTime(SafeHandle safeHandle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	public static bool SetCreationTime(string path, DateTime dateTime, out MonoIOError error) { }

	public static bool SetLastAccessTime(string path, DateTime dateTime, out MonoIOError error) { }

	public static bool SetLastWriteTime(string path, DateTime dateTime, out MonoIOError error) { }

	public static bool SetFileTime(string path, int type, long creation_time, long last_access_time, long last_write_time, DateTime dateTime, out MonoIOError error) { }

	public static IntPtr get_ConsoleOutput() { }

	public static IntPtr get_ConsoleInput() { }

	public static IntPtr get_ConsoleError() { }

	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	public static char get_VolumeSeparatorChar() { }

	public static char get_DirectorySeparatorChar() { }

	public static char get_AltDirectorySeparatorChar() { }

	public static char get_PathSeparator() { }

	private static void DumpHandles() { }

	public static bool RemapPath(string path, out string newPath) { }

	private static void .cctor() { }

}

internal enum MonoIOError // TypeDefIndex: 676
{
	public int value__; 
	public const MonoIOError ERROR_SUCCESS = 0;
	public const MonoIOError ERROR_FILE_NOT_FOUND = 2;
	public const MonoIOError ERROR_PATH_NOT_FOUND = 3;
	public const MonoIOError ERROR_TOO_MANY_OPEN_FILES = 4;
	public const MonoIOError ERROR_ACCESS_DENIED = 5;
	public const MonoIOError ERROR_INVALID_HANDLE = 6;
	public const MonoIOError ERROR_INVALID_DRIVE = 15;
	public const MonoIOError ERROR_NOT_SAME_DEVICE = 17;
	public const MonoIOError ERROR_NO_MORE_FILES = 18;
	public const MonoIOError ERROR_NOT_READY = 21;
	public const MonoIOError ERROR_WRITE_FAULT = 29;
	public const MonoIOError ERROR_READ_FAULT = 30;
	public const MonoIOError ERROR_GEN_FAILURE = 31;
	public const MonoIOError ERROR_SHARING_VIOLATION = 32;
	public const MonoIOError ERROR_LOCK_VIOLATION = 33;
	public const MonoIOError ERROR_HANDLE_DISK_FULL = 39;
	public const MonoIOError ERROR_FILE_EXISTS = 80;
	public const MonoIOError ERROR_CANNOT_MAKE = 82;
	public const MonoIOError ERROR_INVALID_PARAMETER = 87;
	public const MonoIOError ERROR_BROKEN_PIPE = 109;
	public const MonoIOError ERROR_INVALID_NAME = 123;
	public const MonoIOError ERROR_DIR_NOT_EMPTY = 145;
	public const MonoIOError ERROR_ALREADY_EXISTS = 183;
	public const MonoIOError ERROR_FILENAME_EXCED_RANGE = 206;
	public const MonoIOError ERROR_DIRECTORY = 267;
	public const MonoIOError ERROR_ENCRYPTION_FAILED = 6000;

}

internal struct MonoIOStat // TypeDefIndex: 677
{
	public FileAttributes fileAttributes; 
	public long Length; 
	public long CreationTime; 
	public long LastAccessTime; 
	public long LastWriteTime; 

}

internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 1252
{
	private MonoMethod method; 
	private object[] args; 
	private string[] names; 
	private byte[] arg_types; 
	public LogicalCallContext ctx; 
	public object rval; 
	public Exception exc; 
	private AsyncResult asyncResult; 
	private CallType call_type; 
	private string uri; 
	private MCMDictionary properties; 
	private Type[] methodSignature; 
	private Identity identity; 
	internal static string CallContextKey; 
	internal static string UriKey; 

	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }


	internal void InitMessage(MonoMethod method, object[] out_args) { }

	public void .ctor(MethodBase method, object[] out_args) { }

	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	public void .ctor(Type type, string methodName, object[] in_args) { }

	public IDictionary get_Properties() { }

	public int get_ArgCount() { }

	public object[] get_Args() { }

	public LogicalCallContext get_LogicalCallContext() { }

	public void set_LogicalCallContext(LogicalCallContext value) { }

	public MethodBase get_MethodBase() { }

	public string get_MethodName() { }

	public object get_MethodSignature() { }

	public string get_TypeName() { }

	public string get_Uri() { }

	public void set_Uri(string value) { }

	public object GetArg(int arg_num) { }

	public Exception get_Exception() { }

	public int get_OutArgCount() { }

	public object[] get_OutArgs() { }

	public object get_ReturnValue() { }

	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	public AsyncResult get_AsyncResult() { }

	internal CallType get_CallType() { }

	public bool NeedsOutProcessing(out int outCount) { }

	private static void .cctor() { }

}

public class MonoTlsConnectionInfo // TypeDefIndex: 1743
{
	[CompilerGeneratedAttribute] 
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TlsProtocols <ProtocolVersion>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <PeerDomainName>k__BackingField; 

	[CLSCompliantAttribute] 
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }


	[CompilerGeneratedAttribute] 
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGeneratedAttribute] 
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGeneratedAttribute] 
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGeneratedAttribute] 
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGeneratedAttribute] 
	public void set_PeerDomainName(string value) { }

	public override string ToString() { }

	public void .ctor() { }

}

public enum MonoSslPolicyErrors // TypeDefIndex: 1744
{
	public int value__; 
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;

}

public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 1745
{

	public void .ctor(object object, IntPtr method) { }

	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	public virtual IAsyncResult BeginInvoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

}

public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 1746
{

	public void .ctor(object object, IntPtr method) { }

	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

}

public abstract class MonoTlsProvider // TypeDefIndex: 1747
{
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }


	internal void .ctor() { }

	public abstract Guid get_ID();

	public abstract string get_Name();

	public abstract bool get_SupportsSslStream();

	public abstract bool get_SupportsConnectionInfo();

	public abstract bool get_SupportsMonoExtensions();

	public abstract SslProtocols get_SupportedProtocols();

	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11);

	internal abstract bool get_SupportsCleanShutdown();

}

public static class MonoTlsProviderFactory // TypeDefIndex: 1748
{

	public static MonoTlsProvider GetProvider() { }

}

public sealed class MonoTlsSettings // TypeDefIndex: 1749
{
	[CompilerGeneratedAttribute] 
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private X509CertificateCollection <TrustAnchors>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <UserSettings>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string[] <CertificateSearchPaths>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <SendCloseNotify>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; 
	private bool cloned; 
	private bool checkCertName; 
	private bool checkCertRevocationStatus; 
	private Nullable<bool> useServicePointManagerCallback; 
	private bool skipSystemValidators; 
	private bool callbackNeedsChain; 
	private ICertificateValidator certificateValidator; 
	private static MonoTlsSettings defaultSettings; 

	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliantAttribute] 
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[ObsoleteAttribute] 
	public ICertificateValidator CertificateValidator { get; }


	[CompilerGeneratedAttribute] 
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGeneratedAttribute] 
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGeneratedAttribute] 
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	public Nullable<bool> get_UseServicePointManagerCallback() { }

	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGeneratedAttribute] 
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGeneratedAttribute] 
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGeneratedAttribute] 
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGeneratedAttribute] 
	public object get_UserSettings() { }

	[CompilerGeneratedAttribute] 
	public void set_UserSettings(object value) { }

	[CompilerGeneratedAttribute] 
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGeneratedAttribute] 
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGeneratedAttribute] 
	internal bool get_SendCloseNotify() { }

	[CompilerGeneratedAttribute] 
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGeneratedAttribute] 
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGeneratedAttribute] 
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGeneratedAttribute] 
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	public void .ctor() { }

	public static MonoTlsSettings get_DefaultSettings() { }

	public static MonoTlsSettings CopyDefaultSettings() { }

	public ICertificateValidator get_CertificateValidator() { }

	[ObsoleteAttribute] 
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	public MonoTlsSettings Clone() { }

	private void .ctor(MonoTlsSettings other) { }

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 1810
{

	public void .ctor() { }

}

internal sealed class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 2454
{

	public void .ctor(Type t) { }

}

internal static class MonoTlsProviderFactory // TypeDefIndex: 2552
{
	private static object locker; 
	private static bool initialized; 
	private static MonoTlsProvider defaultProvider; 
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; 
	private static Dictionary<Guid, MonoTlsProvider> providerCache; 
	internal static readonly Guid UnityTlsId; 
	internal static readonly Guid AppleTlsId; 
	internal static readonly Guid BtlsId; 
	internal static readonly Guid LegacyId; 


	internal static MonoTlsProvider GetProviderInternal() { }

	internal static void InitializeInternal() { }

	private static MonoTlsProvider LookupProvider(string name, bool throwOnError) { }

	private static void InitializeProviderRegistration() { }

	private static MonoTlsProvider CreateDefaultProviderImpl() { }

	internal static MonoTlsProvider GetProvider() { }

	private static void .cctor() { }

}

internal class MonoTlsStream // TypeDefIndex: 2553
{
	private readonly MonoTlsProvider provider; 
	private readonly NetworkStream networkStream; 
	private readonly HttpWebRequest request; 
	private readonly MonoTlsSettings settings; 
	private IMonoSslStream sslStream; 
	private WebExceptionStatus status; 
	[CompilerGeneratedAttribute] 
	private bool <CertificateValidationFailed>k__BackingField; 

	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal bool CertificateValidationFailed { get; set; }


	internal HttpWebRequest get_Request() { }

	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGeneratedAttribute] 
	internal bool get_CertificateValidationFailed() { }

	[CompilerGeneratedAttribute] 
	internal void set_CertificateValidationFailed(bool value) { }

	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	internal Stream CreateStream(byte[] buffer) { }

}

internal class MonoChunkStream // TypeDefIndex: 3014
{
	internal WebHeaderCollection headers; 
	private int chunkSize; 
	private int chunkRead; 
	private int totalWritten; 
	private MonoChunkStream.State state; 
	private StringBuilder saved; 
	private bool sawCR; 
	private bool gotit; 
	private int trailerState; 
	private ArrayList chunks; 

	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }


	public void .ctor(byte[] buffer, int offset, int size, WebHeaderCollection headers) { }

	public void .ctor(WebHeaderCollection headers) { }

	public void ResetBuffer() { }

	public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read) { }

	public int Read(byte[] buffer, int offset, int size) { }

	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	public void Write(byte[] buffer, int offset, int size) { }

	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	public bool get_WantMore() { }

	public bool get_DataAvailable() { }

	public int get_ChunkLeft() { }

	private MonoChunkStream.State ReadBody(byte[] buffer, ref int offset, int size) { }

	private MonoChunkStream.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	private static string RemoveChunkExtension(string input) { }

	private MonoChunkStream.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	private MonoChunkStream.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	private static void ThrowProtocolViolation(string message) { }

}

private enum MonoChunkStream.State // TypeDefIndex: 3015
{
	public int value__; 
	public const MonoChunkStream.State None = 0;
	public const MonoChunkStream.State PartialSize = 1;
	public const MonoChunkStream.State Body = 2;
	public const MonoChunkStream.State BodyFinished = 3;
	public const MonoChunkStream.State Trailer = 4;

}

private class MonoChunkStream.Chunk // TypeDefIndex: 3016
{
	public byte[] Bytes; 
	public int Offset; 


	public void .ctor(byte[] chunk) { }

	public int Read(byte[] buffer, int offset, int size) { }

}

public class MonoBehaviour : Behaviour // TypeDefIndex: 3520
{
	public bool useGUILayout { get; set; }


	public bool IsInvoking() { }

	public void CancelInvoke() { }

	public void Invoke(string methodName, float time) { }

	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	public void CancelInvoke(string methodName) { }

	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocsAttribute] 
	public Coroutine StartCoroutine(string methodName) { }

	public Coroutine StartCoroutine(string methodName, object value) { }

	public Coroutine StartCoroutine(IEnumerator routine) { }

	[ObsoleteAttribute] 
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	public void StopCoroutine(IEnumerator routine) { }

	public void StopCoroutine(Coroutine routine) { }

	public void StopCoroutine(string methodName) { }

	public void StopAllCoroutines() { }

	public bool get_useGUILayout() { }

	public void set_useGUILayout(bool value) { }

	public static void print(object message) { }

	[FreeFunctionAttribute] 
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] 
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] 
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunctionAttribute] 
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] 
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] 
	private static bool IsObjectMonoBehaviour(Object obj) { }

	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	private void StopCoroutineManaged(Coroutine routine) { }

	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	internal string GetScriptClassName() { }

	public void .ctor() { }

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 3977
{

[AttributeUsageAttribute] 
internal class MonoTODOAttribute : Attribute
	private string comment; 


	public void .ctor() { }

	public void .ctor(string comment) { }

}

internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 5260
{

	public void .ctor() { }

}

internal static class Mono // TypeDefIndex: 6232
{

	internal static void FixHttpsValidation() { }

}

private sealed class Mono.<>c // TypeDefIndex: 6233
{
	public static readonly Mono.<>c <>9; 
	public static RemoteCertificateValidationCallback <>9__0_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <FixHttpsValidation>b__0_0(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

public abstract class MonoEncoding : Encoding // TypeDefIndex: 7381
{
	private readonly int win_code_page; 

	public override int WindowsCodePage { get; }


	public void .ctor(int codePage) { }

	public void .ctor(int codePage, int windowsCodePage) { }

	public override int get_WindowsCodePage() { }

	public void HandleFallback(ref EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetByteCount(char* chars, int count) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public abstract int GetByteCountImpl(char* chars, int charCount);

	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);

}

public abstract class MonoEncoder : Encoder // TypeDefIndex: 7382
{
	private MonoEncoding encoding; 


	public void .ctor(MonoEncoding encoding) { }

	public override int GetByteCount(char[] chars, int index, int count, bool refresh) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	public abstract int GetByteCountImpl(char* chars, int charCount, bool refresh);

	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	public void HandleFallback(char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

}

internal sealed class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 8267
{

	public void .ctor(Type type) { }

}

