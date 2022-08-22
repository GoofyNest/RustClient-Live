public interface SmallXmlParser.IContentHandler // TypeDefIndex: 25
{
	public abstract void OnStartParsing(SmallXmlParser parser);

	public abstract void OnEndParsing(SmallXmlParser parser);

	public abstract void OnStartElement(string name, SmallXmlParser.IAttrList attrs);

	public abstract void OnEndElement(string name);

	public abstract void OnProcessingInstruction(string name, string text);

	public abstract void OnChars(string text);

	public abstract void OnIgnorableWhitespace(string text);

}

public interface SmallXmlParser.IAttrList // TypeDefIndex: 26
{	public abstract int Length { get; }
	public abstract string[] Names { get; }
	public abstract string[] Values { get; }


	public abstract int get_Length();

	public abstract string GetName(int i);

	public abstract string GetValue(int i);

	public abstract string GetValue(string name);

	public abstract string[] get_Names();

	public abstract string[] get_Values();

}

internal interface IRegistryApi // TypeDefIndex: 100
{
	public abstract RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writtable);

	public abstract void Flush(RegistryKey rkey);

	public abstract void Close(RegistryKey rkey);

	public abstract object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options);

	public abstract string[] GetSubKeyNames(RegistryKey rkey);

	public abstract string ToString(RegistryKey rkey);

	public abstract IntPtr GetHandle(RegistryKey key);

}

internal interface ITupleInternal // TypeDefIndex: 134
{
	public abstract string ToString(StringBuilder sb);

}

public interface IAsyncResult // TypeDefIndex: 246
{	public abstract bool IsCompleted { get; }
	public abstract WaitHandle AsyncWaitHandle { get; }
	public abstract object AsyncState { get; }
	public abstract bool CompletedSynchronously { get; }


	public abstract bool get_IsCompleted();

	public abstract WaitHandle get_AsyncWaitHandle();

	public abstract object get_AsyncState();

	public abstract bool get_CompletedSynchronously();

}

public interface ICloneable // TypeDefIndex: 247
{
	public abstract object Clone();

}

public interface IComparable // TypeDefIndex: 248
{
	public abstract int CompareTo(object obj);

}

public interface IComparable<T> // TypeDefIndex: 249
{
	public abstract int CompareTo(T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComparable<object>.CompareTo
	*/

}

public interface IConvertible // TypeDefIndex: 250
{
	public abstract TypeCode GetTypeCode();

	public abstract bool ToBoolean(IFormatProvider provider);

	public abstract char ToChar(IFormatProvider provider);

	public abstract sbyte ToSByte(IFormatProvider provider);

	public abstract byte ToByte(IFormatProvider provider);

	public abstract short ToInt16(IFormatProvider provider);

	public abstract ushort ToUInt16(IFormatProvider provider);

	public abstract int ToInt32(IFormatProvider provider);

	public abstract uint ToUInt32(IFormatProvider provider);

	public abstract long ToInt64(IFormatProvider provider);

	public abstract ulong ToUInt64(IFormatProvider provider);

	public abstract float ToSingle(IFormatProvider provider);

	public abstract double ToDouble(IFormatProvider provider);

	public abstract Decimal ToDecimal(IFormatProvider provider);

	public abstract DateTime ToDateTime(IFormatProvider provider);

	public abstract string ToString(IFormatProvider provider);

	public abstract object ToType(Type conversionType, IFormatProvider provider);

}

public interface ICustomFormatter // TypeDefIndex: 251
{
	public abstract string Format(string format, object arg, IFormatProvider formatProvider);

}

public interface IDisposable // TypeDefIndex: 252
{
	public abstract void Dispose();

}

public interface IEquatable<T> // TypeDefIndex: 253
{
	public abstract bool Equals(T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEquatable<object>.Equals
	*/

}

public interface IFormatProvider // TypeDefIndex: 254
{
	public abstract object GetFormat(Type formatType);

}

public interface IFormattable // TypeDefIndex: 255
{
	public abstract string ToString(string format, IFormatProvider formatProvider);

}

public interface IProgress<T> // TypeDefIndex: 264
{
	public abstract void Report(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProgress<object>.Report
	*/

}

public interface IServiceProvider // TypeDefIndex: 265
{
	public abstract object GetService(Type serviceType);

}

public struct UInt16 : IComparable, IFormattable, IConvertible, IComparable<ushort>, IEquatable<ushort> // TypeDefIndex: 326
{	private ushort m_value; // 0x0
	public const ushort MaxValue = 65535;
	public const ushort MinValue = 0;


	public int CompareTo(object value) { }

	public int CompareTo(ushort value) { }

	public override bool Equals(object obj) { }

	public bool Equals(ushort obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format) { }

	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static ushort Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	private static ushort Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

	public TypeCode GetTypeCode() { }

	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

public struct UInt32 : IComparable, IFormattable, IConvertible, IComparable<uint>, IEquatable<uint> // TypeDefIndex: 327
{	private uint m_value; // 0x0
	public const uint MaxValue = 4294967295;
	public const uint MinValue = 0;


	public int CompareTo(object value) { }

	public int CompareTo(uint value) { }

	public override bool Equals(object obj) { }

	public bool Equals(uint obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static uint Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static uint Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static bool TryParse(string s, out uint result) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	public TypeCode GetTypeCode() { }

	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

public struct UInt64 : IComparable, IFormattable, IConvertible, IComparable<ulong>, IEquatable<ulong> // TypeDefIndex: 328
{	private ulong m_value; // 0x0
	public const ulong MaxValue = 18446744073709551615;
	public const ulong MinValue = 0;


	public int CompareTo(object value) { }

	public int CompareTo(ulong value) { }

	public override bool Equals(object obj) { }

	public bool Equals(ulong obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format) { }

	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static ulong Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static ulong Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static bool TryParse(string s, out ulong result) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

	public TypeCode GetTypeCode() { }

	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

internal enum UInt16Enum // TypeDefIndex: 365
{	public ushort value__; // 0x0

}

internal enum UInt32Enum // TypeDefIndex: 366
{	public uint value__; // 0x0

}

internal enum UInt64Enum // TypeDefIndex: 367
{	public ulong value__; // 0x0

}

internal interface IConsoleDriver // TypeDefIndex: 368
{	public abstract ConsoleColor BackgroundColor { get; set; }
	public abstract int BufferWidth { get; }
	public abstract int CursorLeft { set; }
	public abstract int CursorTop { get; set; }
	public abstract ConsoleColor ForegroundColor { get; set; }
	public abstract bool KeyAvailable { get; }


	public abstract ConsoleColor get_BackgroundColor();

	public abstract void set_BackgroundColor(ConsoleColor value);

	public abstract int get_BufferWidth();

	public abstract void set_CursorLeft(int value);

	public abstract int get_CursorTop();

	public abstract void set_CursorTop(int value);

	public abstract ConsoleColor get_ForegroundColor();

	public abstract void set_ForegroundColor(ConsoleColor value);

	public abstract bool get_KeyAvailable();

	public abstract ConsoleKeyInfo ReadKey(bool intercept);

}

internal interface TypeName : IEquatable<TypeName> // TypeDefIndex: 405
{	public abstract string DisplayName { get; }


	public abstract string get_DisplayName();

}

internal interface TypeIdentifier : TypeName, IEquatable<TypeName> // TypeDefIndex: 406
{	public abstract string InternalName { get; }


	public abstract string get_InternalName();

}

internal interface ModifierSpec // TypeDefIndex: 411
{
	public abstract Type Resolve(Type type);

	public abstract StringBuilder Append(StringBuilder sb);

}

public struct UIntPtr : ISerializable // TypeDefIndex: 416
{	public static readonly UIntPtr Zero; // 0x0
	private void* _pointer; // 0x0

	public static int Size { get; }


	public void .ctor(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(void* value) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	public static ulong op_Explicit(UIntPtr value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public static UIntPtr op_Explicit(void* value) { }

	public static int get_Size() { }

	private static void .cctor() { }

}

internal interface IResourceGroveler // TypeDefIndex: 483
{
	public abstract ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark);

}

public interface IResourceReader : IEnumerable, IDisposable // TypeDefIndex: 484
{
	public abstract void Close();

	public abstract IDictionaryEnumerator GetEnumerator();

}

public interface ICustomAttributeProvider // TypeDefIndex: 527
{
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	public abstract object[] GetCustomAttributes(bool inherit);

	public abstract bool IsDefined(Type attributeType, bool inherit);

}

public interface IReflectableType // TypeDefIndex: 530
{
	public abstract TypeInfo GetTypeInfo();

}

internal interface IAsyncLocal // TypeDefIndex: 775
{
	public abstract void OnValueChanged(object previousValue, object currentValue, bool contextChanged);

}

internal interface IThreadPoolWorkItem // TypeDefIndex: 805
{
	public abstract void ExecuteWorkItem();

	public abstract void MarkAborted(ThreadAbortException tae);

}

internal interface ITaskCompletionAction // TypeDefIndex: 867
{
internal interface ITaskCompletionAction // TypeDefIndex: 867

	public abstract void Invoke(Task completingTask);

}

public interface IPermission : ISecurityEncodable // TypeDefIndex: 899
{
	public abstract void Demand();

	public abstract bool IsSubsetOf(IPermission target);

}

public interface ISecurityEncodable // TypeDefIndex: 900
{
	public abstract SecurityElement ToXml();

}

internal interface Tokenizer.ITokenReader // TypeDefIndex: 923
{
	public abstract int Read();

}

public interface IIdentity // TypeDefIndex: 928
{	public abstract string AuthenticationType { get; }
	public abstract string Name { get; }


	public abstract string get_AuthenticationType();

	public abstract string get_Name();

}

public interface ICryptoTransform : IDisposable // TypeDefIndex: 967
{	public abstract int InputBlockSize { get; }
	public abstract int OutputBlockSize { get; }
	public abstract bool CanTransformMultipleBlocks { get; }


	public abstract int get_InputBlockSize();

	public abstract int get_OutputBlockSize();

	public abstract bool get_CanTransformMultipleBlocks();

	public abstract int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

	public abstract byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);

}

internal interface INativeCertificateHelper // TypeDefIndex: 1016
{
	public abstract X509CertificateImpl Import(X509Certificate cert);

}

public interface IDeserializationCallback // TypeDefIndex: 1029
{
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IDeserializationCallback // TypeDefIndex: 1029

	public abstract void OnDeserialization(object sender);

}

public interface IFormatterConverter // TypeDefIndex: 1030
{
	public abstract object Convert(object value, Type type);

	public abstract bool ToBoolean(object value);

	public abstract int ToInt32(object value);

	public abstract long ToInt64(object value);

	public abstract float ToSingle(object value);

	public abstract string ToString(object value);

}

public interface IObjectReference // TypeDefIndex: 1031
{
	public abstract object GetRealObject(StreamingContext context);

}

public interface ISerializable // TypeDefIndex: 1032
{
	public abstract void GetObjectData(SerializationInfo info, StreamingContext context);

}

public interface ISerializationSurrogate // TypeDefIndex: 1033
{
	public abstract void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

	public abstract object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);

}

public interface ISurrogateSelector // TypeDefIndex: 1034
{
	public abstract ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);

}

public interface ISafeSerializationData // TypeDefIndex: 1046
{
	public abstract void CompleteDeserialization(object deserialized);

}

public interface IChannelInfo // TypeDefIndex: 1130
{	public abstract object[] ChannelData { get; }


	public abstract object[] get_ChannelData();

}

public interface IEnvoyInfo // TypeDefIndex: 1131
{	public abstract IMessageSink EnvoySinks { get; }


	public abstract IMessageSink get_EnvoySinks();

}

public interface IRemotingTypeInfo // TypeDefIndex: 1132
{	public abstract string TypeName { get; }


	public abstract string get_TypeName();

	public abstract bool CanCastTo(Type fromType, object o);

}

public interface ITrackingHandler // TypeDefIndex: 1157
{
	public abstract void DisconnectedObject(object obj);

	public abstract void MarshaledObject(object obj, ObjRef or);

	public abstract void UnmarshaledObject(object obj, ObjRef or);

}

public interface ILease // TypeDefIndex: 1163
{	public abstract TimeSpan CurrentLeaseTime { get; }
	public abstract LeaseState CurrentState { get; }
	public abstract TimeSpan RenewOnCallTime { get; }


	public abstract TimeSpan get_CurrentLeaseTime();

	public abstract LeaseState get_CurrentState();

	public abstract TimeSpan get_RenewOnCallTime();

	public abstract TimeSpan Renew(TimeSpan renewalTime);

}

public interface ISponsor // TypeDefIndex: 1164
{
	public abstract TimeSpan Renewal(ILease lease);

}

public interface IContextAttribute // TypeDefIndex: 1178
{
	public abstract void GetPropertiesForNewContext(IConstructionCallMessage msg);

	public abstract bool IsContextOK(Context ctx, IConstructionCallMessage msg);

}

public interface IContextProperty // TypeDefIndex: 1179
{	public abstract string Name { get; }


	public abstract string get_Name();

	public abstract void Freeze(Context newContext);

	public abstract bool IsNewContextOK(Context newCtx);

}

public interface IContributeClientContextSink // TypeDefIndex: 1180
{
	public abstract IMessageSink GetClientContextSink(IMessageSink nextSink);

}

public interface IContributeDynamicSink // TypeDefIndex: 1181
{
	public abstract IDynamicMessageSink GetDynamicSink();

}

public interface IContributeEnvoySink // TypeDefIndex: 1182
{
	public abstract IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink);

}

public interface IContributeObjectSink // TypeDefIndex: 1183
{
	public abstract IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);

}

public interface IContributeServerContextSink // TypeDefIndex: 1184
{
	public abstract IMessageSink GetServerContextSink(IMessageSink nextSink);

}

public interface IDynamicMessageSink // TypeDefIndex: 1185
{
	public abstract void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

	public abstract void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);

}

public interface IDynamicProperty // TypeDefIndex: 1186
{	public abstract string Name { get; }


	public abstract string get_Name();

}

public interface IChannel // TypeDefIndex: 1194
{	public abstract string ChannelName { get; }
	public abstract int ChannelPriority { get; }


	public abstract string get_ChannelName();

	public abstract int get_ChannelPriority();

}

public interface IChannelReceiver : IChannel // TypeDefIndex: 1196
{
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IChannelReceiver : IChannel // TypeDefIndex: 1196
	public abstract object ChannelData { get; }


	public abstract object get_ChannelData();

	public abstract void StartListening(object data);

}

public interface IChannelSender : IChannel // TypeDefIndex: 1197
{
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);

}

public interface IClientChannelSinkProvider // TypeDefIndex: 1198
{	public abstract IClientChannelSinkProvider Next { set; }


	public abstract void set_Next(IClientChannelSinkProvider value);

}

public interface ISecurableChannel // TypeDefIndex: 1199
{	public abstract bool IsSecured { set; }


	public abstract void set_IsSecured(bool value);

}

public interface IServerChannelSinkProvider // TypeDefIndex: 1200
{	public abstract IServerChannelSinkProvider Next { set; }


	public abstract void set_Next(IServerChannelSinkProvider value);

}

public interface IActivator // TypeDefIndex: 1206
{	public abstract IActivator NextActivator { get; }


	public abstract IActivator get_NextActivator();

	public abstract IConstructionReturnMessage Activate(IConstructionCallMessage msg);

}

public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1207
{	public abstract Type ActivationType { get; }
	public abstract string ActivationTypeName { get; }
	public abstract IActivator Activator { get; set; }
	public abstract object[] CallSiteActivationAttributes { get; }
	public abstract IList ContextProperties { get; }


	public abstract Type get_ActivationType();

	public abstract string get_ActivationTypeName();

	public abstract IActivator get_Activator();

	public abstract void set_Activator(IActivator value);

	public abstract object[] get_CallSiteActivationAttributes();

	public abstract IList get_ContextProperties();

}

internal interface IInternalMessage // TypeDefIndex: 1239
{	public abstract Identity TargetIdentity { get; set; }
	public abstract string Uri { get; set; }


	public abstract Identity get_TargetIdentity();

	public abstract void set_TargetIdentity(Identity value);

	public abstract string get_Uri();

	public abstract void set_Uri(string value);

}

public interface IMessage // TypeDefIndex: 1240
{	public abstract IDictionary Properties { get; }


	public abstract IDictionary get_Properties();

}

public interface IMessageSink // TypeDefIndex: 1242
{
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IMessageSink // TypeDefIndex: 1242

	public abstract IMessage SyncProcessMessage(IMessage msg);

	public abstract IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);

}

public interface IMethodMessage : IMessage // TypeDefIndex: 1244
{
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IMethodMessage : IMessage // TypeDefIndex: 1244
	public abstract int ArgCount { get; }
	public abstract object[] Args { get; }
	public abstract LogicalCallContext LogicalCallContext { get; }
	public abstract MethodBase MethodBase { get; }
	public abstract string MethodName { get; }
	public abstract object MethodSignature { get; }
	public abstract string TypeName { get; }
	public abstract string Uri { get; }


	public abstract int get_ArgCount();

	public abstract object[] get_Args();

	public abstract LogicalCallContext get_LogicalCallContext();

	public abstract MethodBase get_MethodBase();

	public abstract string get_MethodName();

	public abstract object get_MethodSignature();

	public abstract string get_TypeName();

	public abstract string get_Uri();

	public abstract object GetArg(int argNum);

}

public interface IMethodReturnMessage : IMethodMessage, IMessage // TypeDefIndex: 1245
{	public abstract Exception Exception { get; }
	public abstract object[] OutArgs { get; }
	public abstract object ReturnValue { get; }


	public abstract Exception get_Exception();

	public abstract object[] get_OutArgs();

	public abstract object get_ReturnValue();

}

public interface IAsyncStateMachine // TypeDefIndex: 1283
{
	public abstract void MoveNext();

	public abstract void SetStateMachine(IAsyncStateMachine stateMachine);

}

public interface INotifyCompletion // TypeDefIndex: 1284
{
	public abstract void OnCompleted(Action continuation);

}

public interface ICriticalNotifyCompletion : INotifyCompletion // TypeDefIndex: 1285
{
	public abstract void UnsafeOnCompleted(Action continuation);

}

public interface ICustomMarshaler // TypeDefIndex: 1349
{
	public abstract object MarshalNativeToManaged(IntPtr pNativeData);

	public abstract IntPtr MarshalManagedToNative(object ManagedObj);

	public abstract void CleanUpNativeData(IntPtr pNativeData);

	public abstract void CleanUpManagedData(object ManagedObj);

	public abstract int GetNativeDataSize();

}

public interface ICollection : IEnumerable // TypeDefIndex: 1397
{	public abstract int Count { get; }
	public abstract object SyncRoot { get; }


	public abstract void CopyTo(Array array, int index);

	public abstract int get_Count();

	public abstract object get_SyncRoot();

}

public interface IComparer // TypeDefIndex: 1398
{
	public abstract int Compare(object x, object y);

}

public interface IDictionary : ICollection, IEnumerable // TypeDefIndex: 1399
{	public abstract object Item { get; set; }
	public abstract ICollection Keys { get; }
	public abstract ICollection Values { get; }
	public abstract bool IsReadOnly { get; }


	public abstract object get_Item(object key);

	public abstract void set_Item(object key, object value);

	public abstract ICollection get_Keys();

	public abstract ICollection get_Values();

	public abstract bool Contains(object key);

	public abstract void Add(object key, object value);

	public abstract void Clear();

	public abstract bool get_IsReadOnly();

	public abstract IDictionaryEnumerator GetEnumerator();

	public abstract void Remove(object key);

}

public interface IDictionaryEnumerator : IEnumerator // TypeDefIndex: 1400
{	public abstract object Key { get; }
	public abstract object Value { get; }
	public abstract DictionaryEntry Entry { get; }


	public abstract object get_Key();

	public abstract object get_Value();

	public abstract DictionaryEntry get_Entry();

}

public interface IEnumerable // TypeDefIndex: 1401
{
	[DispIdAttribute] // RVA: 0xE91B0 Offset: 0xE85B0 VA: 0x1800E91B0
	public abstract IEnumerator GetEnumerator();

}

public interface IEnumerator // TypeDefIndex: 1402
{	public abstract object Current { get; }


	public abstract bool MoveNext();

	public abstract object get_Current();

	public abstract void Reset();

}

public interface IEqualityComparer // TypeDefIndex: 1403
{
	public abstract bool Equals(object x, object y);

	public abstract int GetHashCode(object obj);

}

public interface IHashCodeProvider // TypeDefIndex: 1404
{
	public abstract int GetHashCode(object obj);

}

public interface IList : ICollection, IEnumerable // TypeDefIndex: 1405
{	public abstract object Item { get; set; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }


	public abstract object get_Item(int index);

	public abstract void set_Item(int index, object value);

	public abstract int Add(object value);

	public abstract bool Contains(object value);

	public abstract void Clear();

	public abstract bool get_IsReadOnly();

	public abstract bool get_IsFixedSize();

	public abstract int IndexOf(object value);

	public abstract void Insert(int index, object value);

	public abstract void Remove(object value);

	public abstract void RemoveAt(int index);

}

public interface IStructuralComparable // TypeDefIndex: 1406
{
	public abstract int CompareTo(object other, IComparer comparer);

}

public interface IStructuralEquatable // TypeDefIndex: 1407
{
	public abstract bool Equals(object other, IEqualityComparer comparer);

	public abstract int GetHashCode(IEqualityComparer comparer);

}

public interface ICollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 1478
{	public abstract int Count { get; }
	public abstract bool IsReadOnly { get; }


	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.get_Count
	*/

	public abstract bool get_IsReadOnly();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.get_IsReadOnly
	*/

	public abstract void Add(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Add
	*/

	public abstract void Clear();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Clear
	*/

	public abstract bool Contains(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Contains
	*/

	public abstract void CopyTo(T[] array, int arrayIndex);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.CopyTo
	*/

	public abstract bool Remove(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<object>.Remove
	*/

}

public interface IComparer<T> // TypeDefIndex: 1479
{
	public abstract int Compare(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComparer<object>.Compare
	*/

}

public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1480
{	public abstract TValue Item { get; set; }
	public abstract ICollection<TKey> Keys { get; }
	public abstract ICollection<TValue> Values { get; }


	public abstract TValue get_Item(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Item
	*/

	public abstract void set_Item(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.set_Item
	*/

	public abstract ICollection<TKey> get_Keys();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Keys
	*/

	public abstract ICollection<TValue> get_Values();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Values
	*/

	public abstract bool ContainsKey(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.ContainsKey
	*/

	public abstract void Add(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.Add
	*/

	public abstract bool Remove(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.Remove
	*/

	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.TryGetValue
	*/

}

public interface IEnumerable<T> : IEnumerable // TypeDefIndex: 1481
{
	public abstract IEnumerator<T> GetEnumerator();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerable<object>.GetEnumerator
	*/

}

public interface IEnumerator<T> : IDisposable, IEnumerator // TypeDefIndex: 1482
{	public abstract T Current { get; }


	public abstract T get_Current();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerator<object>.get_Current
	*/

}

public interface IEqualityComparer<T> // TypeDefIndex: 1483
{
	public abstract bool Equals(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEqualityComparer<object>.Equals
	*/

	public abstract int GetHashCode(T obj);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEqualityComparer<object>.GetHashCode
	*/

}

public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 1484
{	public abstract T Item { get; set; }


	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.get_Item
	*/

	public abstract void set_Item(int index, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.set_Item
	*/

	public abstract int IndexOf(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.IndexOf
	*/

	public abstract void Insert(int index, T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.Insert
	*/

	public abstract void RemoveAt(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.RemoveAt
	*/

}

public interface IReadOnlyCollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 1485
{	public abstract int Count { get; }


	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyCollection<object>.get_Count
	*/

}

public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1486
{
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<object, object>.TryGetValue
	*/

}

public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 1487
{	public abstract T Item { get; }


	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<object>.get_Item
	*/

}

internal sealed class UInt16TypeInfo : TraceLoggingTypeInfo<ushort> // TypeDefIndex: 1536
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public override void WriteData(TraceLoggingDataCollector collector, ref ushort value) { }

	public void .ctor() { }

}

internal sealed class UInt32TypeInfo : TraceLoggingTypeInfo<uint> // TypeDefIndex: 1538
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public override void WriteData(TraceLoggingDataCollector collector, ref uint value) { }

	public void .ctor() { }

}

internal sealed class UInt64TypeInfo : TraceLoggingTypeInfo<ulong> // TypeDefIndex: 1540
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public override void WriteData(TraceLoggingDataCollector collector, ref ulong value) { }

	public void .ctor() { }

}

internal sealed class UIntPtrTypeInfo : TraceLoggingTypeInfo<UIntPtr> // TypeDefIndex: 1542
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public override void WriteData(TraceLoggingDataCollector collector, ref UIntPtr value) { }

	public void .ctor() { }

}

internal sealed class UInt16ArrayTypeInfo : TraceLoggingTypeInfo<ushort[]> // TypeDefIndex: 1550
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public override void WriteData(TraceLoggingDataCollector collector, ref ushort[] value) { }

	public void .ctor() { }

}

internal sealed class UInt32ArrayTypeInfo : TraceLoggingTypeInfo<uint[]> // TypeDefIndex: 1552
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public override void WriteData(TraceLoggingDataCollector collector, ref uint[] value) { }

	public void .ctor() { }

}

internal sealed class UInt64ArrayTypeInfo : TraceLoggingTypeInfo<ulong[]> // TypeDefIndex: 1554
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public override void WriteData(TraceLoggingDataCollector collector, ref ulong[] value) { }

	public void .ctor() { }

}

internal sealed class UIntPtrArrayTypeInfo : TraceLoggingTypeInfo<UIntPtr[]> // TypeDefIndex: 1556
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	public override void WriteData(TraceLoggingDataCollector collector, ref UIntPtr[] value) { }

	public void .ctor() { }

}

public interface ICertificateValidator // TypeDefIndex: 1738
{	public abstract MonoTlsSettings Settings { get; }


	public abstract MonoTlsSettings get_Settings();

	public abstract bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate);

	public abstract ValidationResult ValidateCertificate(string targetHost, bool serverMode, X509CertificateCollection certificates);

}

internal interface ICertificateValidator2 : ICertificateValidator // TypeDefIndex: 1739
{
	public abstract ValidationResult ValidateCertificate(string targetHost, bool serverMode, X509Certificate leaf, X509Chain chain);

}

public interface IMonoSslStream : IDisposable // TypeDefIndex: 1742
{	public abstract bool IsAuthenticated { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; }
	public abstract AuthenticatedStream AuthenticatedStream { get; }
	public abstract int ReadTimeout { get; }
	public abstract int WriteTimeout { get; }
	public abstract X509Certificate InternalLocalCertificate { get; }


	public abstract void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation);

	public abstract IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState);

	public abstract void EndAuthenticateAsServer(IAsyncResult asyncResult);

	public abstract int Read(byte[] buffer, int offset, int count);

	public abstract void Write(byte[] buffer, int offset, int count);

	public abstract IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState);

	public abstract int EndRead(IAsyncResult asyncResult);

	public abstract IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState);

	public abstract void EndWrite(IAsyncResult asyncResult);

	public abstract bool get_IsAuthenticated();

	public abstract bool get_CanRead();

	public abstract bool get_CanWrite();

	public abstract long get_Length();

	public abstract long get_Position();

	public abstract void SetLength(long value);

	public abstract AuthenticatedStream get_AuthenticatedStream();

	public abstract int get_ReadTimeout();

	public abstract int get_WriteTimeout();

	public abstract X509Certificate get_InternalLocalCertificate();

}

internal interface IDtdInfo // TypeDefIndex: 1844
{	public abstract XmlQualifiedName Name { get; }
	public abstract string InternalDtdSubset { get; }
	public abstract bool HasDefaultAttributes { get; }
	public abstract bool HasNonCDataAttributes { get; }


	public abstract XmlQualifiedName get_Name();

	public abstract string get_InternalDtdSubset();

	public abstract bool get_HasDefaultAttributes();

	public abstract bool get_HasNonCDataAttributes();

	public abstract IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

	public abstract IDtdEntityInfo LookupEntity(string name);

}

internal interface IDtdAttributeListInfo // TypeDefIndex: 1845
{	public abstract bool HasNonCDataAttributes { get; }


	public abstract bool get_HasNonCDataAttributes();

	public abstract IDtdAttributeInfo LookupAttribute(string prefix, string localName);

	public abstract IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();

}

internal interface IDtdAttributeInfo // TypeDefIndex: 1846
{	public abstract string Prefix { get; }
	public abstract string LocalName { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }
	public abstract bool IsNonCDataType { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsXmlAttribute { get; }


	public abstract string get_Prefix();

	public abstract string get_LocalName();

	public abstract int get_LineNumber();

	public abstract int get_LinePosition();

	public abstract bool get_IsNonCDataType();

	public abstract bool get_IsDeclaredInExternal();

	public abstract bool get_IsXmlAttribute();

}

internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo // TypeDefIndex: 1847
{	public abstract string DefaultValueExpanded { get; }
	public abstract object DefaultValueTyped { get; }
	public abstract int ValueLineNumber { get; }
	public abstract int ValueLinePosition { get; }


	public abstract string get_DefaultValueExpanded();

	public abstract object get_DefaultValueTyped();

	public abstract int get_ValueLineNumber();

	public abstract int get_ValueLinePosition();

}

internal interface IDtdEntityInfo // TypeDefIndex: 1848
{	public abstract string Name { get; }
	public abstract bool IsExternal { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsUnparsedEntity { get; }
	public abstract bool IsParameterEntity { get; }
	public abstract string BaseUriString { get; }
	public abstract string DeclaredUriString { get; }
	public abstract string SystemId { get; }
	public abstract string PublicId { get; }
	public abstract string Text { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }


	public abstract string get_Name();

	public abstract bool get_IsExternal();

	public abstract bool get_IsDeclaredInExternal();

	public abstract bool get_IsUnparsedEntity();

	public abstract bool get_IsParameterEntity();

	public abstract string get_BaseUriString();

	public abstract string get_DeclaredUriString();

	public abstract string get_SystemId();

	public abstract string get_PublicId();

	public abstract string get_Text();

	public abstract int get_LineNumber();

	public abstract int get_LinePosition();

}

internal interface IDtdParser // TypeDefIndex: 1849
{
	public abstract IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

	public abstract IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);

}

internal interface IDtdParserAdapter // TypeDefIndex: 1850
{	public abstract XmlNameTable NameTable { get; }
	public abstract IXmlNamespaceResolver NamespaceResolver { get; }
	public abstract Uri BaseUri { get; }
	public abstract char[] ParsingBuffer { get; }
	public abstract int ParsingBufferLength { get; }
	public abstract int CurrentPosition { get; set; }
	public abstract int LineNo { get; }
	public abstract int LineStartPosition { get; }
	public abstract bool IsEof { get; }
	public abstract int EntityStackLength { get; }
	public abstract bool IsEntityEolNormalized { get; }


	public abstract XmlNameTable get_NameTable();

	public abstract IXmlNamespaceResolver get_NamespaceResolver();

	public abstract Uri get_BaseUri();

	public abstract char[] get_ParsingBuffer();

	public abstract int get_ParsingBufferLength();

	public abstract int get_CurrentPosition();

	public abstract void set_CurrentPosition(int value);

	public abstract int get_LineNo();

	public abstract int get_LineStartPosition();

	public abstract bool get_IsEof();

	public abstract int get_EntityStackLength();

	public abstract bool get_IsEntityEolNormalized();

	public abstract int ReadData();

	public abstract void OnNewLine(int pos);

	public abstract int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

	public abstract int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

	public abstract void ParsePI(StringBuilder sb);

	public abstract void ParseComment(StringBuilder sb);

	public abstract bool PushEntity(IDtdEntityInfo entity, out int entityId);

	public abstract bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId);

	public abstract bool PushExternalSubset(string systemId, string publicId);

	public abstract void PushInternalDtd(string baseUri, string internalDtd);

	public abstract void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

	public abstract void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

	public abstract void Throw(Exception e);

}

internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter // TypeDefIndex: 1851
{	public abstract bool DtdValidation { get; }
	public abstract IValidationEventHandling ValidationEventHandling { get; }


	public abstract bool get_DtdValidation();

	public abstract IValidationEventHandling get_ValidationEventHandling();

}

internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 1852
{	public abstract bool V1CompatibilityMode { get; }
	public abstract bool Normalization { get; }
	public abstract bool Namespaces { get; }


	public abstract bool get_V1CompatibilityMode();

	public abstract bool get_Normalization();

	public abstract bool get_Namespaces();

}

internal interface IValidationEventHandling // TypeDefIndex: 1854
{	public abstract object EventHandler { get; }


	public abstract object get_EventHandler();

	public abstract void SendEvent(Exception exception, XmlSeverityType severity);

}

public interface IXmlLineInfo // TypeDefIndex: 1985
{	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }


	public abstract bool HasLineInfo();

	public abstract int get_LineNumber();

	public abstract int get_LinePosition();

}

public interface IXmlNamespaceResolver // TypeDefIndex: 1988
{
	public abstract IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);

	public abstract string LookupNamespace(string prefix);

	public abstract string LookupPrefix(string namespaceName);

}

public interface IXmlSerializable // TypeDefIndex: 2054
{
	public abstract XmlSchema GetSchema();

	public abstract void ReadXml(XmlReader reader);

	public abstract void WriteXml(XmlWriter writer);

}

public interface IXmlTextParser // TypeDefIndex: 2055
{	public abstract bool Normalized { get; set; }


	public abstract bool get_Normalized();

	public abstract void set_Normalized(bool value);

}

public interface IXmlSchemaInfo // TypeDefIndex: 2258
{	public abstract XmlSchemaValidity Validity { get; }
	public abstract bool IsDefault { get; }
	public abstract bool IsNil { get; }
	public abstract XmlSchemaSimpleType MemberType { get; }
	public abstract XmlSchemaType SchemaType { get; }
	public abstract XmlSchemaElement SchemaElement { get; }
	public abstract XmlSchemaAttribute SchemaAttribute { get; }


	public abstract XmlSchemaValidity get_Validity();

	public abstract bool get_IsDefault();

	public abstract bool get_IsNil();

	public abstract XmlSchemaSimpleType get_MemberType();

	public abstract XmlSchemaType get_SchemaType();

	public abstract XmlSchemaElement get_SchemaElement();

	public abstract XmlSchemaAttribute get_SchemaAttribute();

}

public interface IChangeTracking // TypeDefIndex: 2711
{
public interface IBindingList : IList, ICollection, IEnumerable // TypeDefIndex: 2710

public interface IChangeTracking // TypeDefIndex: 2711
	public abstract bool IsChanged { get; }


	public abstract bool get_IsChanged();

	public abstract void AcceptChanges();

}

public interface IComponent : IDisposable // TypeDefIndex: 2712
{	public abstract ISite Site { get; }


	public abstract ISite get_Site();

}

public interface IContainer : IDisposable // TypeDefIndex: 2713
{	public abstract ComponentCollection Components { get; }


	public abstract ComponentCollection get_Components();

	public abstract void Remove(IComponent component);

}

public interface ICustomTypeDescriptor // TypeDefIndex: 2714
{
	public abstract AttributeCollection GetAttributes();

	public abstract TypeConverter GetConverter();

	public abstract PropertyDescriptorCollection GetProperties();

	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes);

	public abstract object GetPropertyOwner(PropertyDescriptor pd);

}

public interface IExtenderProvider // TypeDefIndex: 2715
{
	public abstract bool CanExtend(object extendee);

}

public interface IRevertibleChangeTracking : IChangeTracking // TypeDefIndex: 2716
{
	public abstract void RejectChanges();

}

public interface ISite : IServiceProvider // TypeDefIndex: 2717
{	public abstract IContainer Container { get; }
	public abstract bool DesignMode { get; }
	public abstract string Name { get; }


	public abstract IContainer get_Container();

	public abstract bool get_DesignMode();

	public abstract string get_Name();

}

public interface ISynchronizeInvoke // TypeDefIndex: 2718
{	public abstract bool InvokeRequired { get; }


	public abstract bool get_InvokeRequired();

	public abstract IAsyncResult BeginInvoke(Delegate method, object[] args);

}

public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 2769
{
private sealed class TypeDescriptor.TypeDescriptorInterface // TypeDefIndex: 2768

public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 2769
	internal override Type TargetType { get; }


	internal override Type get_TargetType() { }

	internal override object FromString(string value, int radix) { }

	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public class UInt32Converter : BaseNumberConverter // TypeDefIndex: 2770
{	internal override Type TargetType { get; }


	internal override Type get_TargetType() { }

	internal override object FromString(string value, int radix) { }

	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public class UInt64Converter : BaseNumberConverter // TypeDefIndex: 2771
{	internal override Type TargetType { get; }


	internal override Type get_TargetType() { }

	internal override object FromString(string value, int radix) { }

	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

}

public interface IComponentChangeService // TypeDefIndex: 2780
{
	public abstract void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

	public abstract void OnComponentChanging(object component, MemberDescriptor member);

}

public interface IDesignerHost : IServiceProvider // TypeDefIndex: 2782
{
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public interface IDesignerHost : IServiceProvider // TypeDefIndex: 2782
	public abstract IComponent RootComponent { get; }


	public abstract IComponent get_RootComponent();

	public abstract IDesigner GetDesigner(IComponent component);

}

public interface IDictionaryService // TypeDefIndex: 2783
{
	public abstract object GetValue(object key);

	public abstract void SetValue(object key, object value);

}

public interface IExtenderListService // TypeDefIndex: 2784
{
	public abstract IExtenderProvider[] GetExtenderProviders();

}

public interface ITypeDescriptorFilterService // TypeDefIndex: 2786
{
public interface ITypeDescriptorFilterService // TypeDefIndex: 2786

	public abstract bool FilterAttributes(IComponent component, IDictionary attributes);

	public abstract bool FilterEvents(IComponent component, IDictionary events);

	public abstract bool FilterProperties(IComponent component, IDictionary properties);

}

internal interface IFileWatcher // TypeDefIndex: 2849
{
	public abstract void StartDispatching(FileSystemWatcher fsw);

	public abstract void StopDispatching(FileSystemWatcher fsw);

}

public interface IAuthenticationModule // TypeDefIndex: 2879
{	public abstract string AuthenticationType { get; }


	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

	public abstract string get_AuthenticationType();

}

public interface ICertificatePolicy // TypeDefIndex: 2880
{
	public abstract bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);

}

public interface ICredentials // TypeDefIndex: 2881
{
	public abstract NetworkCredential GetCredential(Uri uri, string authType);

}

public interface IWebRequestCreate // TypeDefIndex: 2885
{
	public abstract WebRequest Create(Uri uri);

}

internal interface ICloseEx // TypeDefIndex: 2918
{
	public abstract void CloseEx(CloseExState closeState);

}

public interface IWebProxy // TypeDefIndex: 2952
{	public abstract ICredentials Credentials { get; }


	public abstract Uri GetProxy(Uri destination);

	public abstract bool IsBypassed(Uri host);

	public abstract ICredentials get_Credentials();

}

internal interface IWebConnectionState // TypeDefIndex: 3013
{	public abstract WebConnectionGroup Group { get; }


	public abstract WebConnectionGroup get_Group();

	public abstract bool TrySetBusy();

	public abstract void SetIdle();

}

public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3224
{
	public abstract IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IOrderedEnumerable<object>.CreateOrderedEnumerable<object>
	*/

}

public interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3225
{	public abstract TKey Key { get; }


	public abstract TKey get_Key();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGrouping<object, object>.get_Key
	*/

}

public interface IJob // TypeDefIndex: 3298
{
	public abstract void Execute();

}

public interface IJobParallelFor // TypeDefIndex: 3302
{
	public abstract void Execute(int index);

}

public interface ILogger : ILogHandler // TypeDefIndex: 3456
{	public abstract ILogHandler logHandler { get; }
	public abstract bool logEnabled { get; set; }


	public abstract ILogHandler get_logHandler();

	public abstract bool get_logEnabled();

	public abstract void set_logEnabled(bool value);

	public abstract void Log(LogType logType, object message);

	public abstract void Log(LogType logType, object message, Object context);

	public abstract void LogFormat(LogType logType, string format, object[] args);

}

public interface ILogHandler // TypeDefIndex: 3457
{
	public abstract void LogFormat(LogType logType, Object context, string format, object[] args);

	public abstract void LogException(Exception exception, Object context);

}

internal interface IPlayerEditorConnectionNative // TypeDefIndex: 3474
{
	public abstract void Initialize();

	public abstract void DisconnectAll();

	public abstract void SendMessage(Guid messageId, byte[] data, int playerId);

	public abstract bool TrySendMessage(Guid messageId, byte[] data, int playerId);

	public abstract void Poll();

	public abstract void RegisterInternal(Guid messageId);

	public abstract void UnregisterInternal(Guid messageId);

	public abstract bool IsConnected();

}

public interface ISerializationCallbackReceiver // TypeDefIndex: 3548
{
[RequiredByNativeCodeAttribute] // RVA: 0xC8CC0 Offset: 0xC80C0 VA: 0x1800C8CC0
[AttributeUsageAttribute] // RVA: 0xC8CC0 Offset: 0xC80C0 VA: 0x1800C8CC0
public sealed class PreferBinarySerialization : Attribute // TypeDefIndex: 3547

[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public interface ISerializationCallbackReceiver // TypeDefIndex: 3548

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void OnBeforeSerialize();

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void OnAfterDeserialize();

}

public interface IJobParallelForTransform // TypeDefIndex: 3585
{
	public abstract void Execute(int index, TransformAccess transform);

}

public interface INotificationReceiver // TypeDefIndex: 3862
{
[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public interface INotificationReceiver // TypeDefIndex: 3862

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void OnNotify(Playable origin, INotification notification, object context);

}

public interface IPlayableBehaviour // TypeDefIndex: 3863
{
	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void OnGraphStart(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void OnGraphStop(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void OnPlayableCreate(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void OnPlayableDestroy(Playable playable);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void OnBehaviourPlay(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void OnBehaviourPause(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void PrepareFrame(Playable playable, FrameData info);

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData);

}

public interface IScriptableRuntimeReflectionSystem : IDisposable // TypeDefIndex: 3896
{
	public abstract bool TickRealtimeProbes();

}

internal interface ISubsystemDescriptorImpl : ISubsystemDescriptor // TypeDefIndex: 3938
{
public interface ISubsystemDescriptor // TypeDefIndex: 3937

internal interface ISubsystemDescriptorImpl : ISubsystemDescriptor // TypeDefIndex: 3938
	public abstract IntPtr ptr { set; }


	public abstract void set_ptr(IntPtr value);

}

public struct UICharInfo // TypeDefIndex: 3956
{	public Vector2 cursorPos; // 0x0
	public float charWidth; // 0x8

}

public struct UILineInfo // TypeDefIndex: 3957
{	public int startCharIdx; // 0x0
	public int height; // 0x4
	public float topY; // 0x8
	public float leading; // 0xC

}

public struct UIVertex // TypeDefIndex: 3958
{	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector2 uv0; // 0x2C
	public Vector2 uv1; // 0x34
	public Vector2 uv2; // 0x3C
	public Vector2 uv3; // 0x44
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14


	private static void .cctor() { }

}

public interface IEnlistmentNotification // TypeDefIndex: 3978
{
	public abstract void Rollback(Enlistment enlistment);

}

public interface IPromotableSinglePhaseNotification // TypeDefIndex: 3979
{
	public abstract void Rollback(SinglePhaseEnlistment singlePhaseEnlistment);

}

internal interface IFilter // TypeDefIndex: 4262
{
	public abstract bool Invoke(DataRow row, DataRowVersion version);

}

public interface IDataReader : IDisposable, IDataRecord // TypeDefIndex: 4269
{
	public abstract void Close();

	public abstract DataTable GetSchemaTable();

	public abstract bool Read();

}

public interface IDataRecord // TypeDefIndex: 4270
{	public abstract int FieldCount { get; }
	public abstract object Item { get; }


	public abstract int get_FieldCount();

	public abstract object get_Item(int i);

	public abstract string GetName(int i);

	public abstract string GetDataTypeName(int i);

	public abstract Type GetFieldType(int i);

	public abstract int GetValues(object[] values);

}

public interface IDbDataAdapter // TypeDefIndex: 4272
{
public interface IDbDataAdapter // TypeDefIndex: 4272
	public abstract IDbCommand SelectCommand { get; }
	public abstract IDbCommand InsertCommand { get; set; }
	public abstract IDbCommand UpdateCommand { get; set; }
	public abstract IDbCommand DeleteCommand { get; set; }


	public abstract IDbCommand get_SelectCommand();

	public abstract IDbCommand get_InsertCommand();

	public abstract void set_InsertCommand(IDbCommand value);

	public abstract IDbCommand get_UpdateCommand();

	public abstract void set_UpdateCommand(IDbCommand value);

	public abstract IDbCommand get_DeleteCommand();

	public abstract void set_DeleteCommand(IDbCommand value);

}

public interface INullable // TypeDefIndex: 4336
{	public abstract bool IsNull { get; }


	public abstract bool get_IsNull();

}

internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 4433
{	private static readonly ushort s_defaultValue; // 0x0
	private ushort[] _values; // 0x50


	public void .ctor(DataColumn column) { }

	public override object Aggregate(int[] records, AggregateType kind) { }

	public override int Compare(int recordNo1, int recordNo2) { }

	public override int CompareValueTo(int recordNo, object value) { }

	public override object ConvertValue(object value) { }

	public override void Copy(int recordNo1, int recordNo2) { }

	public override object Get(int record) { }

	public override void Set(int record, object value) { }

	public override void SetCapacity(int capacity) { }

	public override object ConvertXmlToObject(string s) { }

	public override string ConvertObjectToXml(object value) { }

	protected override object GetEmptyStorage(int recordCount) { }

	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	protected override void SetStorage(object store, BitArray nullbits) { }

}

internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 4434
{	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50


	public void .ctor(DataColumn column) { }

	public override object Aggregate(int[] records, AggregateType kind) { }

	public override int Compare(int recordNo1, int recordNo2) { }

	public override int CompareValueTo(int recordNo, object value) { }

	public override object ConvertValue(object value) { }

	public override void Copy(int recordNo1, int recordNo2) { }

	public override object Get(int record) { }

	public override void Set(int record, object value) { }

	public override void SetCapacity(int capacity) { }

	public override object ConvertXmlToObject(string s) { }

	public override string ConvertObjectToXml(object value) { }

	protected override object GetEmptyStorage(int recordCount) { }

	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	protected override void SetStorage(object store, BitArray nullbits) { }

}

internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 4435
{	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50


	public void .ctor(DataColumn column) { }

	public override object Aggregate(int[] records, AggregateType kind) { }

	public override int Compare(int recordNo1, int recordNo2) { }

	public override int CompareValueTo(int recordNo, object value) { }

	public override object ConvertValue(object value) { }

	public override void Copy(int recordNo1, int recordNo2) { }

	public override object Get(int record) { }

	public override void Set(int record, object value) { }

	public override void SetCapacity(int capacity) { }

	public override object ConvertXmlToObject(string s) { }

	public override string ConvertObjectToXml(object value) { }

	protected override object GetEmptyStorage(int recordCount) { }

	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	protected override void SetStorage(object store, BitArray nullbits) { }

}

public interface IJobParticleSystem // TypeDefIndex: 4546
{
	public abstract void Execute(ParticleSystemJobData jobData);

}

public interface IFocusRing // TypeDefIndex: 4588
{
	public abstract FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e);

	public abstract Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction);

}

public interface ITransform // TypeDefIndex: 4593
{	public abstract Matrix4x4 matrix { get; }


	public abstract Matrix4x4 get_matrix();

}

public interface IPanel : IDisposable // TypeDefIndex: 4599
{	public abstract VisualElement visualTree { get; }
	public abstract EventDispatcher dispatcher { get; }
	public abstract ContextType contextType { get; }
	public abstract FocusController focusController { get; }


	public abstract VisualElement get_visualTree();

	public abstract EventDispatcher get_dispatcher();

	public abstract ContextType get_contextType();

	public abstract FocusController get_focusController();

}

internal static class UIElementsRuntimeUtility // TypeDefIndex: 4608
{	private static EventDispatcher s_RuntimeDispatcher; // 0x0
	private static bool s_RegisteredPlayerloopCallback; // 0x8
	private static List<Panel> panelsIteration; // 0x10
	internal static readonly string s_RepaintProfilerMarkerName; // 0x18
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x20


	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void RepaintOverlayPanels() { }

	private static void .cctor() { }

}

internal static class UIElementsUtility // TypeDefIndex: 4609
{	private static Stack<IMGUIContainer> s_ContainerStack; // 0x0
	private static Dictionary<int, Panel> s_UIElementsCache; // 0x8
	private static Event s_EventInstance; // 0x10
	internal static Color editorPlayModeTintColor; // 0x18
	internal static readonly string s_RepaintProfilerMarkerName; // 0x28
	internal static readonly string s_EventProfilerMarkerName; // 0x30
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x38
	private static readonly ProfilerMarker s_EventProfilerMarker; // 0x40


	private static void .cctor() { }

	internal static void MakeCurrentIMGUIContainerDirty() { }

	private static void TakeCapture() { }

	private static void ReleaseCapture() { }

	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	public static void RemoveCachedPanel(int instanceID) { }

	private static void CleanupRoots() { }

	private static bool EndContainerGUIFromException(Exception exception) { }

	internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container) { }

	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	internal static EventBase CreateEvent(Event systemEvent) { }

	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	internal static Dictionary.Enumerator<int, Panel> GetPanelsIterator() { }

}

internal interface IVisualTreeUpdater : IDisposable // TypeDefIndex: 4620
{	public abstract ProfilerMarker profilerMarker { get; }


	public abstract ProfilerMarker get_profilerMarker();

	public abstract void Update();

	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);

}

public interface IEventHandler // TypeDefIndex: 4649
{
	public abstract void SendEvent(EventBase e);

	public abstract void HandleEvent(EventBase evt);

}

internal interface IEventDispatchingStrategy // TypeDefIndex: 4657
{
	public abstract bool CanDispatchEvent(EventBase evt);

	public abstract void DispatchEvent(EventBase evt, IPanel panel);

}

public interface IMouseEvent // TypeDefIndex: 4668
{	public abstract EventModifiers modifiers { get; }
	public abstract Vector2 mousePosition { get; }
	public abstract Vector2 mouseDelta { get; }
	public abstract int clickCount { get; }
	public abstract int button { get; }
	public abstract int pressedButtons { get; }


	public abstract EventModifiers get_modifiers();

	public abstract Vector2 get_mousePosition();

	public abstract Vector2 get_mouseDelta();

	public abstract int get_clickCount();

	public abstract int get_button();

	public abstract int get_pressedButtons();

}

internal interface IMouseEventInternal // TypeDefIndex: 4669
{	public abstract bool triggeredByOS { get; set; }
	public abstract bool recomputeTopElementUnderMouse { get; set; }
	public abstract IPointerEvent sourcePointerEvent { get; set; }


	public abstract bool get_triggeredByOS();

	public abstract void set_triggeredByOS(bool value);

	public abstract bool get_recomputeTopElementUnderMouse();

	public abstract void set_recomputeTopElementUnderMouse(bool value);

	public abstract IPointerEvent get_sourcePointerEvent();

	public abstract void set_sourcePointerEvent(IPointerEvent value);

}

public interface IPointerEvent // TypeDefIndex: 4689
{	public abstract int pointerId { get; }
	public abstract string pointerType { get; }
	public abstract bool isPrimary { get; }
	public abstract int button { get; }
	public abstract int pressedButtons { get; }
	public abstract Vector3 position { get; }
	public abstract Vector3 localPosition { get; }
	public abstract Vector3 deltaPosition { get; }
	public abstract float deltaTime { get; }
	public abstract int clickCount { get; }
	public abstract float pressure { get; }
	public abstract float tangentialPressure { get; }
	public abstract float altitudeAngle { get; }
	public abstract float azimuthAngle { get; }
	public abstract float twist { get; }
	public abstract Vector2 radius { get; }
	public abstract Vector2 radiusVariance { get; }
	public abstract EventModifiers modifiers { get; }


	public abstract int get_pointerId();

	public abstract string get_pointerType();

	public abstract bool get_isPrimary();

	public abstract int get_button();

	public abstract int get_pressedButtons();

	public abstract Vector3 get_position();

	public abstract Vector3 get_localPosition();

	public abstract Vector3 get_deltaPosition();

	public abstract float get_deltaTime();

	public abstract int get_clickCount();

	public abstract float get_pressure();

	public abstract float get_tangentialPressure();

	public abstract float get_altitudeAngle();

	public abstract float get_azimuthAngle();

	public abstract float get_twist();

	public abstract Vector2 get_radius();

	public abstract Vector2 get_radiusVariance();

	public abstract EventModifiers get_modifiers();

}

internal interface IPointerEventInternal // TypeDefIndex: 4690
{	public abstract bool triggeredByOS { get; set; }
	public abstract bool recomputeTopElementUnderPointer { get; set; }


	public abstract bool get_triggeredByOS();

	public abstract void set_triggeredByOS(bool value);

	public abstract bool get_recomputeTopElementUnderPointer();

	public abstract void set_recomputeTopElementUnderPointer(bool value);

}

public interface IResolvedStyle // TypeDefIndex: 4707
{	public abstract Visibility visibility { get; }
	public abstract DisplayStyle display { get; }


	public abstract Visibility get_visibility();

	public abstract DisplayStyle get_display();

}

internal interface IStyleValue<T> // TypeDefIndex: 4716
{	public abstract T value { get; }
	public abstract StyleKeyword keyword { get; }


	public abstract T get_value();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<object>.get_value
	*/

	public abstract StyleKeyword get_keyword();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<object>.get_keyword
	*/

}

public interface ICanvasRaycastFilter // TypeDefIndex: 4730
{
public interface ICanvasRaycastFilter // TypeDefIndex: 4730

	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);

}

public static class UISystemProfilerApi // TypeDefIndex: 4738
{
	public static void BeginSample(UISystemProfilerApi.SampleType type) { }

	public static void EndSample(UISystemProfilerApi.SampleType type) { }

	public static void AddMarker(string name, Object obj) { }

}

public enum UISystemProfilerApi.SampleType // TypeDefIndex: 4739
{	public int value__; // 0x0
	public const UISystemProfilerApi.SampleType Layout = 0;
	public const UISystemProfilerApi.SampleType Render = 1;

}

public interface IImmutableStack<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 4797
{	public abstract int Count { get; }


	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.get_Count
	*/

	public abstract IImmutableStack<T> Push(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.Push
	*/

	public abstract IImmutableStack<T> Pop();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.Pop
	*/

	public abstract T Peek();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableStack<object>.Peek
	*/

}

public interface ILinkedListNode<T> // TypeDefIndex: 4803
{	public abstract T next { get; set; }


	public abstract T get_next();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ILinkedListNode<object>.get_next
	*/

	public abstract void set_next(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ILinkedListNode<object>.set_next
	*/

}

public interface IMinHeapNode<T> // TypeDefIndex: 4805
{	public abstract T child { get; set; }
	public abstract int order { get; }


	public abstract T get_child();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMinHeapNode<object>.get_child
	*/

	public abstract void set_child(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMinHeapNode<object>.set_child
	*/

	public abstract int get_order();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMinHeapNode<object>.get_order
	*/

}

public interface Pool.IPooled // TypeDefIndex: 4836
{
	public abstract void EnterPool();

	public abstract void LeavePool();

}

public interface Pool.ICollection // TypeDefIndex: 4837
{	public abstract long ItemsInStack { get; }
	public abstract long ItemsInUse { get; }
	public abstract long ItemsCreated { get; }
	public abstract long ItemsTaken { get; }
	public abstract long ItemsSpilled { get; }


	public abstract long get_ItemsInStack();

	public abstract long get_ItemsInUse();

	public abstract long get_ItemsCreated();

	public abstract long get_ItemsTaken();

	public abstract long get_ItemsSpilled();

	public abstract void Reset();

	public abstract void Add(object obj);

}

internal interface ISQLiteSchemaExtensions // TypeDefIndex: 4857
{
	public abstract void BuildTempSchema(SqliteConnection cnn);

}

public interface ICanvasElement // TypeDefIndex: 4909
{	public abstract Transform transform { get; }


	public abstract void Rebuild(CanvasUpdate executing);

	public abstract Transform get_transform();

	public abstract void LayoutComplete();

	public abstract void GraphicUpdateComplete();

	public abstract bool IsDestroyed();

}

public interface IClipper // TypeDefIndex: 4914
{
	public abstract void PerformClipping();

}

public interface IClippable // TypeDefIndex: 4915
{	public abstract GameObject gameObject { get; }
	public abstract RectTransform rectTransform { get; }


	public abstract GameObject get_gameObject();

	public abstract void RecalculateClipping();

	public abstract RectTransform get_rectTransform();

	public abstract void Cull(Rect clipRect, bool validRect);

	public abstract void SetClipRect(Rect value, bool validRect);

}

public interface DefaultControls.IFactoryControls // TypeDefIndex: 4918
{
	public abstract GameObject CreateGameObject(string name, Type[] components);

}

internal interface IGraphicEnabledDisabled // TypeDefIndex: 4935
{
	public abstract void OnSiblingGraphicEnabledDisabled();

}

public interface IMask // TypeDefIndex: 4936
{	public abstract RectTransform rectTransform { get; }


	public abstract bool Enabled();

	public abstract RectTransform get_rectTransform();

}

public interface IMaskable // TypeDefIndex: 4937
{
	public abstract void RecalculateMasking();

}

public interface ILayoutElement // TypeDefIndex: 4971
{	public abstract float minWidth { get; }
	public abstract float preferredWidth { get; }
	public abstract float flexibleWidth { get; }
	public abstract float minHeight { get; }
	public abstract float preferredHeight { get; }
	public abstract float flexibleHeight { get; }
	public abstract int layoutPriority { get; }


	public abstract void CalculateLayoutInputHorizontal();

	public abstract void CalculateLayoutInputVertical();

	public abstract float get_minWidth();

	public abstract float get_preferredWidth();

	public abstract float get_flexibleWidth();

	public abstract float get_minHeight();

	public abstract float get_preferredHeight();

	public abstract float get_flexibleHeight();

	public abstract int get_layoutPriority();

}

public interface ILayoutController // TypeDefIndex: 4972
{
	public abstract void SetLayoutHorizontal();

	public abstract void SetLayoutVertical();

}

public interface ILayoutIgnorer // TypeDefIndex: 4975
{
public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 4974

public interface ILayoutIgnorer // TypeDefIndex: 4975
	public abstract bool ignoreLayout { get; }


	public abstract bool get_ignoreLayout();

}

public interface IMaterialModifier // TypeDefIndex: 4988
{
	public abstract Material GetModifiedMaterial(Material baseMaterial);

}

public interface IVertexModifier // TypeDefIndex: 5032
{
	[EditorBrowsableAttribute] // RVA: 0x7FC70 Offset: 0x7F070 VA: 0x18007FC70
	[ObsoleteAttribute] // RVA: 0x7FC70 Offset: 0x7F070 VA: 0x18007FC70
	public abstract void ModifyVertices(List<UIVertex> verts);

}

public interface IMeshModifier // TypeDefIndex: 5033
{
	[ObsoleteAttribute] // RVA: 0x7FD90 Offset: 0x7F190 VA: 0x18007FD90
	public abstract void ModifyMesh(Mesh mesh);

	public abstract void ModifyMesh(VertexHelper verts);

}

internal interface ITweenValue // TypeDefIndex: 5038
{	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }


	public abstract void TweenValue(float floatPercentage);

	public abstract bool get_ignoreTimeScale();

	public abstract float get_duration();

	public abstract bool ValidTarget();

}

public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 5054
{
public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 5054

	public abstract void OnPointerEnter(PointerEventData eventData);

}

public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 5055
{
	public abstract void OnPointerExit(PointerEventData eventData);

}

public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 5056
{
	public abstract void OnPointerDown(PointerEventData eventData);

}

public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 5057
{
	public abstract void OnPointerUp(PointerEventData eventData);

}

public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 5058
{
	public abstract void OnPointerClick(PointerEventData eventData);

}

public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 5059
{
	public abstract void OnBeginDrag(PointerEventData eventData);

}

public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 5060
{
	public abstract void OnInitializePotentialDrag(PointerEventData eventData);

}

public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 5061
{
	public abstract void OnDrag(PointerEventData eventData);

}

public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 5062
{
	public abstract void OnEndDrag(PointerEventData eventData);

}

public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 5063
{
	public abstract void OnDrop(PointerEventData eventData);

}

public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 5064
{
	public abstract void OnScroll(PointerEventData eventData);

}

public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 5065
{
	public abstract void OnUpdateSelected(BaseEventData eventData);

}

public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 5066
{
	public abstract void OnSelect(BaseEventData eventData);

}

public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 5067
{
	public abstract void OnDeselect(BaseEventData eventData);

}

public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 5068
{
	public abstract void OnMove(AxisEventData eventData);

}

public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 5069
{
	public abstract void OnSubmit(BaseEventData eventData);

}

public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 5070
{
	public abstract void OnCancel(BaseEventData eventData);

}

public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 5095
{
	protected virtual void Awake() { }

	protected virtual void OnEnable() { }

	protected virtual void Start() { }

	protected virtual void OnDisable() { }

	protected virtual void OnDestroy() { }

	public virtual bool IsActive() { }

	protected virtual void OnRectTransformDimensionsChange() { }

	protected virtual void OnBeforeTransformParentChanged() { }

	protected virtual void OnTransformParentChanged() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnCanvasGroupChanged() { }

	protected virtual void OnCanvasHierarchyChanged() { }

	public bool IsDestroyed() { }

	protected void .ctor() { }

}

internal interface ICallbackData // TypeDefIndex: 5102
{	public abstract CallbackType CallbackType { get; }
	public abstract int DataSize { get; }


	public abstract CallbackType get_CallbackType();

	public abstract int get_DataSize();

}

public interface IConnectionManager // TypeDefIndex: 5180
{
	public abstract void OnConnecting(ConnectionInfo info);

	public abstract void OnConnected(ConnectionInfo info);

	public abstract void OnDisconnected(ConnectionInfo info);

	public abstract void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel);

}

public interface ISocketManager // TypeDefIndex: 5181
{
	public abstract void OnConnecting(Connection connection, ConnectionInfo info);

	public abstract void OnConnected(Connection connection, ConnectionInfo info);

	public abstract void OnDisconnected(Connection connection, ConnectionInfo info);

	public abstract void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel);

}

internal interface ICommandCenterListener // TypeDefIndex: 5633
{
	public abstract void OnCommandCenterUpdated();

}

public interface IAchievement // TypeDefIndex: 5686
{	public abstract string Key { get; }
	public abstract bool IsUnlocked { get; }


	public abstract string get_Key();

	public abstract bool get_IsUnlocked();

	public abstract void Unlock();

}

public interface IAuthTicket : IDisposable // TypeDefIndex: 5687
{	public abstract string Token { get; }
	public abstract byte[] Data { get; }


	public abstract string get_Token();

	public abstract byte[] get_Data();

}

public interface IDownloadableContent // TypeDefIndex: 5688
{	public abstract int AppId { get; }
	public abstract bool IsInstalled { get; }


	public abstract int get_AppId();

	public abstract bool get_IsInstalled();

}

public interface IPlatformHooks // TypeDefIndex: 5689
{	public abstract uint SteamAppId { get; }


	public abstract uint get_SteamAppId();

	public abstract void Abort();

	public abstract void OnItemDefinitionsChanged();

	public abstract void OnInventoryChanged(IPlayerInventory inventory);

}

public interface IPlatformService // TypeDefIndex: 5690
{	public abstract bool IsValid { get; }
	public abstract ulong UserId { get; }
	public abstract string UserName { get; }
	public abstract string Country { get; }
	public abstract string Language { get; }
	public abstract string Version { get; }
	public abstract string Branch { get; }
	public abstract IEnumerable<IPlayerInfo> Friends { get; }
	public abstract IReadOnlyList<ServerInfo> FavoriteServers { get; }
	public abstract uint OptimalSampleRate { get; }
	public abstract bool VoiceRecord { get; set; }
	public abstract bool HasVoiceData { get; }
	public abstract IReadOnlyList<IPlayerItemDefinition> ItemDefinitions { get; }
	public abstract IReadOnlyList<IPlayerItem> Items { get; }


	public abstract bool Initialize(IPlatformHooks hooks);

	public abstract void Shutdown();

	public abstract void Update();

	public abstract bool get_IsValid();

	public abstract ulong get_UserId();

	public abstract string get_UserName();

	public abstract string get_Country();

	public abstract string get_Language();

	public abstract string get_Version();

	public abstract string get_Branch();

	public abstract IAuthTicket GetAuthSessionTicket();

	public abstract Task<IAuthTicket> GetAuthSessionTicketAsync();

	public abstract IEnumerable<IPlayerInfo> get_Friends();

	public abstract IPlayerInfo GetPlayerInformation(ulong userId);

	public abstract Task<IPlayerInfo> GetPlayerInformationAsync(ulong userId);

	public abstract Texture2D GetAvatarTexture(ulong userId);

	public abstract IServerQuery CreateServerQuery(ServerQuerySet querySet);

	public abstract IServerQuery CreateServerQuery(IEnumerable<string> endpoints);

	public abstract void AddServerToHistory(ServerInfo server);

	public abstract void RemoveServerFromHistory(ServerInfo server);

	public abstract IReadOnlyList<ServerInfo> get_FavoriteServers();

	public abstract void AddServerToFavorites(ServerInfo server);

	public abstract void RemoveServerFromFavorites(ServerInfo server);

	public abstract string FilterChat(ulong userId, string message);

	public abstract string FilterName(ulong userId, string name);

	public abstract string FilterGeneric(string text);

	public abstract uint get_OptimalSampleRate();

	public abstract bool get_VoiceRecord();

	public abstract void set_VoiceRecord(bool value);

	public abstract bool get_HasVoiceData();

	public abstract byte[] GetCompressedVoiceData();

	public abstract int DecompressVoiceData(byte[] data, MemoryStream outputStream);

	public abstract IReadOnlyList<IPlayerItemDefinition> get_ItemDefinitions();

	public abstract void RefreshItemDefinitions();

	public abstract IPlayerItemDefinition GetItemDefinition(int definitionId);

	public abstract IReadOnlyList<IPlayerItem> get_Items();

	public abstract void RefreshItems();

	public abstract Task<IPlayerInventory> RefreshAndGetItems();

	public abstract Task<IPlayerInventory> CraftItem(IEnumerable<IPlayerItem> inputs, IPlayerItemDefinition output);

	public abstract Task<List<IPlayerItemDefinition>> GetItemDefinitionsWithPrices();

	public abstract string FormatPrice(int price);

	public abstract IDownloadableContent GetDownloadableContent(int appId);

	public abstract IWorkshopContent GetWorkshopContent(ulong workshopId);

	public abstract void ClearRichPresence();

	public abstract string GetRichPresence(string key);

	public abstract void SetRichPresence(string key, string value);

	public abstract IAchievement GetAchievement(string key);

	public abstract void RequestCurrentStats();

	public abstract long GetGlobalStatInt(string key);

	public abstract long GetPlayerStatInt(string key);

	public abstract void SetPlayerStatInt(string key, long value);

	public abstract double GetGlobalStatFloat(string key);

	public abstract double GetPlayerStatFloat(string key);

	public abstract void SetPlayerStatFloat(string key, double value);

}

public interface IPlayerInfo // TypeDefIndex: 5691
{	public abstract ulong UserId { get; }
	public abstract string UserName { get; }
	public abstract bool IsOnline { get; }
	public abstract bool IsMe { get; }
	public abstract bool IsFriend { get; }
	public abstract bool IsPlayingThisGame { get; }
	public abstract string ServerEndpoint { get; }


	public abstract ulong get_UserId();

	public abstract string get_UserName();

	public abstract bool get_IsOnline();

	public abstract bool get_IsMe();

	public abstract bool get_IsFriend();

	public abstract bool get_IsPlayingThisGame();

	public abstract string get_ServerEndpoint();

}

public interface IPlayerInventory : IDisposable // TypeDefIndex: 5692
{	public abstract IReadOnlyList<IPlayerItem> Items { get; }


	public abstract bool BelongsTo(ulong userId);

	public abstract IReadOnlyList<IPlayerItem> get_Items();

	public abstract byte[] Serialize();

}

public interface IPlayerItem // TypeDefIndex: 5693
{	public abstract int DefinitionId { get; }
	public abstract int Quantity { get; }
	public abstract DateTimeOffset Acquired { get; }
	public abstract ulong WorkshopId { get; }
	public abstract string ItemShortName { get; }


	public abstract int get_DefinitionId();

	public abstract int get_Quantity();

	public abstract DateTimeOffset get_Acquired();

	public abstract ulong get_WorkshopId();

	public abstract string get_ItemShortName();

}

public interface IPlayerItemDefinition : IEquatable<IPlayerItemDefinition> // TypeDefIndex: 5694
{	public abstract int DefinitionId { get; }
	public abstract string Name { get; }
	public abstract string Description { get; }
	public abstract string Type { get; }
	public abstract string IconUrl { get; }
	public abstract int LocalPrice { get; }
	public abstract string LocalPriceFormatted { get; }
	public abstract string PriceCategory { get; }
	public abstract bool IsGenerator { get; }
	public abstract bool IsMarketable { get; }
	public abstract string StoreTags { get; }
	public abstract string ItemShortName { get; }
	public abstract ulong WorkshopId { get; }
	public abstract ulong WorkshopDownload { get; }


	public abstract int get_DefinitionId();

	public abstract string get_Name();

	public abstract string get_Description();

	public abstract string get_Type();

	public abstract string get_IconUrl();

	public abstract int get_LocalPrice();

	public abstract string get_LocalPriceFormatted();

	public abstract string get_PriceCategory();

	public abstract bool get_IsGenerator();

	public abstract bool get_IsMarketable();

	public abstract string get_StoreTags();

	public abstract string get_ItemShortName();

	public abstract ulong get_WorkshopId();

	public abstract ulong get_WorkshopDownload();

	public abstract IEnumerable<PlayerItemRecipe> GetRecipesContainingThis();

}

public interface IServerQuery : IDisposable // TypeDefIndex: 5696
{	public abstract ServerQuerySet QuerySet { get; }
	public abstract IReadOnlyList<ServerInfo> Servers { get; }


	public abstract ServerQuerySet get_QuerySet();

	public abstract IReadOnlyList<ServerInfo> get_Servers();

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void add_OnServerFound(Action<ServerInfo> value);

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract void remove_OnServerFound(Action<ServerInfo> value);

	public abstract void AddFilter(string key, string value);

	public abstract Task RunQueryAsync(double timeoutInSeconds);

}

public interface IWorkshopContent // TypeDefIndex: 5697
{	public abstract ulong WorkshopId { get; }
	public abstract string Title { get; }
	public abstract string Description { get; }
	public abstract IEnumerable<string> Tags { get; }
	public abstract string Url { get; }
	public abstract string PreviewImageUrl { get; }
	public abstract ulong OwnerId { get; }
	public abstract IPlayerInfo Owner { get; }
	public abstract bool IsInstalled { get; }
	public abstract bool IsDownloadPending { get; }
	public abstract bool IsDownloading { get; }
	public abstract string Directory { get; }


	public abstract ulong get_WorkshopId();

	public abstract string get_Title();

	public abstract string get_Description();

	public abstract IEnumerable<string> get_Tags();

	public abstract string get_Url();

	public abstract string get_PreviewImageUrl();

	public abstract ulong get_OwnerId();

	public abstract IPlayerInfo get_Owner();

	public abstract bool get_IsInstalled();

	public abstract bool get_IsDownloadPending();

	public abstract bool get_IsDownloading();

	public abstract string get_Directory();

	public abstract bool Download();

}

public interface IArrayPool<T> // TypeDefIndex: 5871
{
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<object>.Rent
	*/

	public abstract void Return(T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<object>.Return
	*/

}

public interface IJsonLineInfo // TypeDefIndex: 5883
{	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }


	public abstract bool HasLineInfo();

	public abstract int get_LineNumber();

	public abstract int get_LinePosition();

}

internal interface IWrappedCollection : IList, ICollection, IEnumerable // TypeDefIndex: 5947
{	public abstract object UnderlyingCollection { get; }


	public abstract object get_UnderlyingCollection();

}

internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 5950
{	public abstract object UnderlyingDictionary { get; }


	public abstract object get_UnderlyingDictionary();

}

public interface ITraceWriter // TypeDefIndex: 5976
{
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public interface ITraceWriter // TypeDefIndex: 5976
	public abstract TraceLevel LevelFilter { get; }


	public abstract TraceLevel get_LevelFilter();

	public abstract void Trace(TraceLevel level, string message, Exception ex);

}

public interface IContractResolver // TypeDefIndex: 6003
{
	public abstract JsonContract ResolveContract(Type type);

}

public interface IValueProvider // TypeDefIndex: 6004
{
	public abstract void SetValue(object target, object value);

	public abstract object GetValue(object target);

}

public interface IReferenceResolver // TypeDefIndex: 6017
{
	public abstract object ResolveReference(object context, string reference);

	public abstract string GetReference(object context, object value);

	public abstract bool IsReferenced(object context, object value);

	public abstract void AddReference(object context, string reference, object value);

}

internal interface IXmlDocument : IXmlNode // TypeDefIndex: 6116
{	public abstract IXmlElement DocumentElement { get; }


	public abstract IXmlNode CreateComment(string text);

	public abstract IXmlNode CreateTextNode(string text);

	public abstract IXmlNode CreateCDataSection(string data);

	public abstract IXmlNode CreateWhitespace(string text);

	public abstract IXmlNode CreateSignificantWhitespace(string text);

	public abstract IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

	public abstract IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

	public abstract IXmlNode CreateProcessingInstruction(string target, string data);

	public abstract IXmlElement CreateElement(string elementName);

	public abstract IXmlElement CreateElement(string qualifiedName, string namespaceUri);

	public abstract IXmlNode CreateAttribute(string name, string value);

	public abstract IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

	public abstract IXmlElement get_DocumentElement();

}

internal interface IXmlDeclaration : IXmlNode // TypeDefIndex: 6117
{	public abstract string Version { get; }
	public abstract string Encoding { get; }
	public abstract string Standalone { get; }


	public abstract string get_Version();

	public abstract string get_Encoding();

	public abstract string get_Standalone();

}

internal interface IXmlDocumentType : IXmlNode // TypeDefIndex: 6118
{	public abstract string Name { get; }
	public abstract string System { get; }
	public abstract string Public { get; }
	public abstract string InternalSubset { get; }


	public abstract string get_Name();

	public abstract string get_System();

	public abstract string get_Public();

	public abstract string get_InternalSubset();

}

internal interface IXmlElement : IXmlNode // TypeDefIndex: 6119
{	public abstract bool IsEmpty { get; }


	public abstract void SetAttributeNode(IXmlNode attribute);

	public abstract string GetPrefixOfNamespace(string namespaceUri);

	public abstract bool get_IsEmpty();

}

internal interface IXmlNode // TypeDefIndex: 6120
{	public abstract XmlNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract List<IXmlNode> ChildNodes { get; }
	public abstract List<IXmlNode> Attributes { get; }
	public abstract IXmlNode ParentNode { get; }
	public abstract string Value { get; }
	public abstract string NamespaceUri { get; }
	public abstract object WrappedNode { get; }


	public abstract XmlNodeType get_NodeType();

	public abstract string get_LocalName();

	public abstract List<IXmlNode> get_ChildNodes();

	public abstract List<IXmlNode> get_Attributes();

	public abstract IXmlNode get_ParentNode();

	public abstract string get_Value();

	public abstract IXmlNode AppendChild(IXmlNode newChild);

	public abstract string get_NamespaceUri();

	public abstract object get_WrappedNode();

}

public interface IProto // TypeDefIndex: 6279
{
	public abstract void WriteToStream(Stream stream);

	public abstract void ReadFromStream(Stream stream, int size, bool isDelta = False);

}

public interface ICustomMaterialReplacer // TypeDefIndex: 6573
{
	public abstract void Replace(Material[] find, Material[] replace);

}

public interface IPrefabPreProcess // TypeDefIndex: 6578
{
public interface IServerComponent // TypeDefIndex: 6576

public interface IClientComponent // TypeDefIndex: 6577

public interface IPrefabPreProcess // TypeDefIndex: 6578

	public abstract void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling);

}

public interface IPrefabPostProcess // TypeDefIndex: 6579
{
	public abstract void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling);

}

public interface IPrefabProcessor // TypeDefIndex: 6580
{
	public abstract void RemoveComponent(Component component);

	public abstract void NominateForDeletion(GameObject obj);

}

public interface IServerComponentEx // TypeDefIndex: 6581
{
	public abstract void PreServerComponentCull(IPrefabProcessor p);

}

public interface IClientComponentEx // TypeDefIndex: 6582
{
	public abstract void PreClientComponentCull(IPrefabProcessor p);

}

public interface IPropRenderNotify // TypeDefIndex: 6583
{
	public abstract void PreRender();

	public abstract void PostRender();

}

public interface IEntity // TypeDefIndex: 6622
{	public abstract bool IsDestroyed { get; }


	public abstract bool get_IsDestroyed();

}

public interface INetworkCryptocraphy // TypeDefIndex: 6678
{
	public abstract bool IsEnabledIncoming(Connection connection);

	public abstract bool IsEnabledOutgoing(Connection connection);

	public abstract MemoryStream EncryptCopy(Connection connection, MemoryStream stream, int offset);

	public abstract MemoryStream DecryptCopy(Connection connection, MemoryStream stream, int offset);

	public abstract void Encrypt(Connection connection, MemoryStream stream, int offset);

	public abstract void Decrypt(Connection connection, MemoryStream stream, int offset);

}

public interface IDemoHeader // TypeDefIndex: 6681
{	public abstract long Length { get; set; }


	public abstract long get_Length();

	public abstract void set_Length(long value);

	public abstract void Write(BinaryWriter writer);

}

public interface IClientCallback // TypeDefIndex: 6686
{
	public abstract void OnNetworkMessage(Message message);

	public abstract void OnClientDisconnected(string reason);

}

public interface NetworkHandler // TypeDefIndex: 6699
{
	public abstract void OnNetworkSubscribersEnter(List<Connection> connections);

	public abstract void OnNetworkSubscribersLeave(List<Connection> connections);

	public abstract void OnNetworkGroupChange();

	public abstract void OnNetworkGroupLeave(Group group);

	public abstract void OnNetworkGroupEnter(Group group);

}

public interface IServerCallback // TypeDefIndex: 6702
{
	public abstract void OnNetworkMessage(Message message);

	public abstract bool OnUnconnectedMessage(int type, NetRead read, uint ip, int port);

	public abstract void OnDisconnected(string reason, Connection connection);

}

public interface Provider // TypeDefIndex: 6706
{
	public abstract void OnGroupAdded(Group group);

	public abstract bool IsInside(Group group, Vector3 vPos);

	public abstract Group GetGroup(Vector3 vPos);

	public abstract void GetVisibleFromFar(Group group, List<Group> groups);

	public abstract void GetVisibleFromNear(Group group, List<Group> groups);

}

public interface ILocalize // TypeDefIndex: 6720
{	public abstract string LanguageToken { get; }
	public abstract string LanguageEnglish { get; }


	public abstract string get_LanguageToken();

	public abstract string get_LanguageEnglish();

}

internal interface ITweenValue // TypeDefIndex: 6749
{	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }


	public abstract void TweenValue(float floatPercentage);

	public abstract bool get_ignoreTimeScale();

	public abstract float get_duration();

	public abstract bool ValidTarget();

}

public interface ITextElement // TypeDefIndex: 6825
{	public abstract Material sharedMaterial { get; }


	public abstract Material get_sharedMaterial();

	public abstract void Rebuild(CanvasUpdate update);

	public abstract int GetInstanceID();

}

public interface ConsoleSystem.IConsoleCommand // TypeDefIndex: 6882
{
	public abstract void Call(ConsoleSystem.Arg arg);

}

public interface ConsoleSystem.IConsoleButton // TypeDefIndex: 6883
{	public abstract bool IsPressed { get; set; }


	public abstract bool get_IsPressed();

	public abstract void set_IsPressed(bool value);

}

public interface IHandler : IDisposable // TypeDefIndex: 6909
{
	public abstract void Receive(Span<byte> newData);

	public abstract MemoryBuffer CreateHandshake();

	public abstract MemoryBuffer FrameText(string text);

	public abstract MemoryBuffer FrameClose(ushort code);

}

public interface ISocket // TypeDefIndex: 6910
{	public abstract bool Connected { get; }
	public abstract IPAddress RemoteIpAddress { get; }
	public abstract int RemotePort { get; }
	public abstract Stream Stream { get; }
	public abstract bool NoDelay { set; }
	public abstract EndPoint LocalEndPoint { get; }


	public abstract bool get_Connected();

	public abstract IPAddress get_RemoteIpAddress();

	public abstract int get_RemotePort();

	public abstract Stream get_Stream();

	public abstract void set_NoDelay(bool value);

	public abstract EndPoint get_LocalEndPoint();

	public abstract Task<ISocket> Accept(Action<ISocket> callback, Action<Exception> error);

	public abstract Task Authenticate(X509Certificate2 certificate, SslProtocols enabledSslProtocols, Action callback, Action<Exception> error);

	public abstract void Dispose();

	public abstract void Close();

	public abstract void Bind(EndPoint ipLocal);

	public abstract void Listen(int backlog);

}

public interface IWebSocketConnection // TypeDefIndex: 6912
{	public abstract Action OnOpen { set; }
	public abstract Action OnClose { get; set; }
	public abstract Action<string> OnMessage { get; set; }
	public abstract BinaryDataHandler OnBinary { get; }
	public abstract BinaryDataHandler OnPing { get; }
	public abstract BinaryDataHandler OnPong { get; }
	public abstract Action<Exception> OnError { set; }
	public abstract IWebSocketConnectionInfo ConnectionInfo { get; }
	public abstract bool IsAvailable { get; }


	public abstract void set_OnOpen(Action value);

	public abstract Action get_OnClose();

	public abstract void set_OnClose(Action value);

	public abstract Action<string> get_OnMessage();

	public abstract void set_OnMessage(Action<string> value);

	public abstract BinaryDataHandler get_OnBinary();

	public abstract BinaryDataHandler get_OnPing();

	public abstract BinaryDataHandler get_OnPong();

	public abstract void set_OnError(Action<Exception> value);

	public abstract void Send(string message);

	public abstract void Close();

	public abstract IWebSocketConnectionInfo get_ConnectionInfo();

	public abstract bool get_IsAvailable();

}

public interface IWebSocketConnectionInfo // TypeDefIndex: 6913
{	public abstract string Path { get; }
	public abstract IPAddress ClientIpAddress { get; }


	public abstract string get_Path();

	public abstract IPAddress get_ClientIpAddress();

}

internal interface ILZ4Service // TypeDefIndex: 6985
{
	public abstract int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);

	public abstract int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);

	public abstract int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength);

}

public interface IAutoLayout // TypeDefIndex: 7001
{
	public abstract void DoLayout();

}

public static class UIBehaviourEx // TypeDefIndex: 7003
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void SetParent(UIBehaviour self, Transform parent) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void SetParent(UIBehaviour self, Canvas parent) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void SetParent(UIBehaviour self, UIBehaviour parent) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void SetParentRootCanvas(UIBehaviour self, Transform tx) { }

}

public interface IValueTaskSource // TypeDefIndex: 7089
{
	public abstract ValueTaskSourceStatus GetStatus(short token);

	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

	public abstract void GetResult(short token);

}

public interface IValueTaskSource<TResult> // TypeDefIndex: 7090
{
	public abstract ValueTaskSourceStatus GetStatus(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.GetStatus
	*/

	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.OnCompleted
	*/

	public abstract TResult GetResult(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<object>.GetResult
	*/

}

private interface NativeClient.INativeModule // TypeDefIndex: 7160
{
	public abstract IntPtr Create();

	public abstract void Destroy(IntPtr Instance);

	public abstract void Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter);

	public abstract void ConnectionReset(IntPtr Instance);

	public abstract bool PopNetworkMessage(IntPtr Instance, ref byte[] MessageBuffer, out int MessageLength);

	public abstract void PushNetworkMessage(IntPtr Instance, byte[] MessageBuffer, int MessageLength);

	public abstract void PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter);

	public abstract void SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, int AuthTicketLength);

	public abstract IntPtr NetProtect(IntPtr Instance);

}

public interface INetProtect // TypeDefIndex: 7164
{
	public abstract bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset);

	public abstract bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset);

}

public interface IFrameDecoder // TypeDefIndex: 7399
{
	public abstract void DecodeFrame();

}

public interface ILengthedObject : ITimedObject // TypeDefIndex: 7436
{	public abstract long Length { get; }


	public abstract long get_Length();

}

internal interface ITempoMapValuesCache // TypeDefIndex: 7450
{	public abstract IEnumerable<TempoMapLine> InvalidateOnLines { get; }


	public abstract IEnumerable<TempoMapLine> get_InvalidateOnLines();

	public abstract void Invalidate(TempoMap tempoMap);

}

public interface ITimedObject // TypeDefIndex: 7463
{	public abstract long Time { get; }


	public abstract long get_Time();

}

internal interface ITimeSpanConverter // TypeDefIndex: 7472
{
	public abstract ITimeSpan ConvertTo(long timeSpan, long time, TempoMap tempoMap);

	public abstract long ConvertFrom(ITimeSpan timeSpan, long time, TempoMap tempoMap);

}

public interface ITimeSpan : IComparable // TypeDefIndex: 7482
{
	public abstract ITimeSpan Subtract(ITimeSpan timeSpan, TimeSpanMode mode);

	public abstract ITimeSpan Clone();

}

internal interface IEventReader // TypeDefIndex: 7554
{
	public abstract MidiEvent Read(MidiReader reader, ReadingSettings settings, byte currentStatusByte);

}

public interface IRgbService // TypeDefIndex: 7677
{	public abstract bool IsConnected { get; }
	public abstract Vector3 ColorCorrection { get; set; }


	public abstract bool get_IsConnected();

	public abstract Vector3 get_ColorCorrection();

	public abstract void set_ColorCorrection(Vector3 value);

	public abstract ValueTask Start();

	public abstract ValueTask Stop();

	public abstract ValueTask Update();

	public abstract void StaticColor(Color color);

	public abstract void PulseColor(Color color, float duration);

	public abstract void Event(RgbEventType type);

}

public interface IImageEffect // TypeDefIndex: 8029
{
	public abstract bool IsActive();

	public abstract void OnRenderImage(RenderTexture source, RenderTexture destination);

}

public interface IRemoteControllable // TypeDefIndex: 8682
{	public abstract bool RequiresMouse { get; }


	public abstract Transform GetEyes();

	public abstract BaseEntity GetEnt();

	public abstract bool Occupied();

	public abstract void UpdateIdentifier(string newID, bool clientSend = False);

	public abstract string GetIdentifier();

	public abstract void RCSetup();

	public abstract void RCShutdown();

	public abstract bool CanControl();

	public abstract bool get_RequiresMouse();

}

public interface IVendingMachineInterface // TypeDefIndex: 8733
{
	public abstract void BuyButtonClicked(int index, int multiplier);

}

public class UIMarketSearch : MonoBehaviour // TypeDefIndex: 8803
{	public GameObjectRef StoreEntryRef; // 0x18
	public RectTransform StoreRoot; // 0x20
	public UIMarketTerminal Terminal; // 0x28


	public void UpdateFilter(string filter) { }

	private void FilterSellOrders(VendingMachine machine, string filter, List<VendingMachine.SellOrder> orders) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <UpdateFilter>g__CreateStoreEntry|3_0(VendingMachineMapMarker marker, List<VendingMachine.SellOrder> matchingOrders) { }

}

public class UIMarketSearchOrderEntry : MonoBehaviour // TypeDefIndex: 8804
{	public RustText ItemName; // 0x18
	public GameObject OutOfStockRoot; // 0x20
	public GameObject BpRoot; // 0x28


	public void Populate(VendingMachine.SellOrder order) { }

	public void .ctor() { }

}

public class UIMarketSearchStore : MonoBehaviour // TypeDefIndex: 8805
{	public RustText StoreName; // 0x18
	public List<UIMarketSearchOrderEntry> Entries; // 0x20
	private VendingMachineMapMarker cachedMarker; // 0x28
	private UIMarketTerminal cachedTerminal; // 0x30


	public void Populate(VendingMachineMapMarker machine, List<VendingMachine.SellOrder> matchingEntries, UIMarketTerminal terminal) { }

	public void OnCLickedGoTo() { }

	public void .ctor() { }

}

public class UIMarketTerminal : UIDialog, IVendingMachineInterface // TypeDefIndex: 8806
{	public static readonly Translate.Phrase PendingDeliveryPluralPhrase; // 0x0
	public static readonly Translate.Phrase PendingDeliverySingularPhrase; // 0x8
	public Canvas canvas; // 0x30
	public MapView mapView; // 0x38
	public RectTransform shopDetailsPanel; // 0x40
	public float shopDetailsMargin; // 0x48
	public float easeDuration; // 0x4C
	public LeanTweenType easeType; // 0x50
	public RustText shopName; // 0x58
	public GameObject shopOrderingPanel; // 0x60
	public RectTransform sellOrderContainer; // 0x68
	public GameObjectRef sellOrderPrefab; // 0x70
	public VirtualItemIcon deliveryFeeIcon; // 0x78
	public GameObject deliveryFeeCantAffordIndicator; // 0x80
	public GameObject inventoryFullIndicator; // 0x88
	public GameObject notEligiblePanel; // 0x90
	public GameObject pendingDeliveryPanel; // 0x98
	public RustText pendingDeliveryLabel; // 0xA0
	public RectTransform itemNoticesContainer; // 0xA8
	public GameObjectRef itemRemovedPrefab; // 0xB0
	public GameObjectRef itemPendingPrefab; // 0xB8
	public GameObjectRef itemAddedPrefab; // 0xC0
	public CanvasGroup gettingStartedTip; // 0xC8
	public SoundDefinition buyItemSoundDef; // 0xD0
	public SoundDefinition buttonPressSoundDef; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MarketTerminal <currentTerminal>k__BackingField; // 0xE0
	private uint _currentVendingMachine; // 0xE8
	private HashSet<uint> _eligibleVendingMachines; // 0xF0
	private List<SellOrderEntry> _shopEntries; // 0xF8
	private Action<SellOrderEntry, int> _onShopEntryAmountChangedCached; // 0x100

	public MarketTerminal currentTerminal { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public MarketTerminal get_currentTerminal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentTerminal(MarketTerminal value) { }

	public void Setup(MarketTerminal terminal, List<uint> eligibleVendingMachineIds) { }

	public override void OpenDialog() { }

	public override void CloseDialog() { }

	public void OnVendingMachineClicked(UIMapVendingMachineMarker marker) { }

	public void SelectVendingMachine(VendingMachine vmData) { }

	public void HideVendingMachine(bool immediate = False) { }

	public void BuyButtonClicked(int index, int multiplier) { }

	public void AddItemNotice(int itemDefId, int quantity, bool isPending) { }

	public void UpdateShopDetails(VendingMachine vmData) { }

	private void OnShopEntryAmountChanged(SellOrderEntry changedEntry, int newAmount) { }

	public void UpdateIndicators() { }

	private bool CanAffordCurrentOrder() { }

	public static bool IsOpen(out UIMarketTerminal marketTerminal) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class UIMarketTerminal.<>c // TypeDefIndex: 8807
{	public static readonly UIMarketTerminal.<>c <>9; // 0x0
	public static Predicate<SellOrderEntry> <>9__44_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CanAffordCurrentOrder>b__44_0(SellOrderEntry e) { }

}

public class UITwitchTrophy : UIDialog // TypeDefIndex: 8819
{	public HttpImage EventImage; // 0x30
	public RustText EventName; // 0x38
	public RustText WinningTeamName; // 0x40
	public RectTransform TeamMembersRoot; // 0x48
	public GameObject TeamMemberNamePrefab; // 0x50
	public GameObject MissingDataOverlay; // 0x58


	public override void OpenDialog() { }

	public void .ctor() { }

}

private class UITwitchTrophy.TrophyPage // TypeDefIndex: 8820
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <EventTitle>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Logo>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <WinningTeam>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<string> <TeamMembers>k__BackingField; // 0x28

	public string EventTitle { get; set; }
	public string Logo { get; set; }
	public string WinningTeam { get; set; }
	public List<string> TeamMembers { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_EventTitle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_EventTitle(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Logo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Logo(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_WinningTeam() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_WinningTeam(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public List<string> get_TeamMembers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_TeamMembers(List<string> value) { }

	public void .ctor() { }

}

public interface IConversationProvider // TypeDefIndex: 8848
{
	public abstract void ResponsePressed(int index);

	public abstract void EndConversation(bool fromServer);

	public abstract void DoAction(string actionString);

	public abstract Vector3 GetConversationWorldOrigin();

	public abstract bool ProviderBusy();

}

public interface IThinker // TypeDefIndex: 8932
{
	public abstract void TryThink();

}

public interface ISoundBudgetedUpdate // TypeDefIndex: 8996
{
	public abstract void DoUpdate();

	public abstract bool IsSyncedToParent();

}

public interface ILerpInfo // TypeDefIndex: 9219
{
	public abstract float GetExtrapolationTime();

	public abstract float GetInterpolationDelay();

	public abstract float GetInterpolationSmoothing();

}

public interface IPosLerpTarget : ILerpInfo // TypeDefIndex: 9220
{
	public abstract float GetInterpolationInertia();

	public abstract Vector3 GetNetworkPosition();

	public abstract Quaternion GetNetworkRotation();

	public abstract void SetNetworkPosition(Vector3 pos);

	public abstract void SetNetworkRotation(Quaternion rot);

	public abstract void DrawInterpolationState(Interpolator.Segment<TransformSnapshot> segment, List<TransformSnapshot> entries);

	public abstract void LerpIdleDisable();

}

internal interface IRagdollInhert // TypeDefIndex: 9226
{
	public abstract Transform RagdollInhertTransform();

}

public interface IEffectRecycle // TypeDefIndex: 9335
{
	public abstract void Recycle();

}

public interface IEffect // TypeDefIndex: 9336
{
	public abstract void SetupEffect(Effect effect);

}

public interface IAnimationEventReceiver // TypeDefIndex: 9349
{
	public abstract void OnAnimationEvent(string eventName);

}

public interface IAIEventListener // TypeDefIndex: 9399
{
	public abstract void EventTriggeredStateChange(int newStateContainerID, int sourceEventID);

}

internal interface IAIDesign // TypeDefIndex: 9426
{
	public abstract bool CanPlayerDesignAI(BasePlayer player);

}

public interface IPet // TypeDefIndex: 9431
{
	public abstract bool IsPet();

	public abstract void SetPetOwner(BasePlayer player);

	public abstract bool IsOwnedBy(BasePlayer player);

	public abstract bool IssuePetCommand(PetCommandType cmd, int param, Nullable<Ray> ray);

}

public interface ICassettePlayer // TypeDefIndex: 9437
{	public abstract BaseEntity ToBaseEntity { get; }


	public abstract BaseEntity get_ToBaseEntity();

	public abstract void OnLoadedWithCassette(Cassette c);

	public abstract void OnCensorRecordingsChanged();

}

public interface IAudioConnectionSource // TypeDefIndex: 9443
{	public abstract float VolumeVisualisationMultiplier { get; }


	public abstract void SpeakerConnected(ConnectedSpeaker speaker);

	public abstract void SpeakerDisconnected(ConnectedSpeaker repeater);

	public abstract AudioSource GetSource();

	public abstract float get_VolumeVisualisationMultiplier();

	public abstract float GetFakeInput();

	public abstract IOEntity ToEntity();

}

public interface IServerFileReceiver // TypeDefIndex: 9457
{
	public abstract void OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data);

}

public interface IFlagNotify // TypeDefIndex: 9495
{
	public abstract void OnFlagToggled(bool state);

}

public interface IImageReceiver // TypeDefIndex: 9512
{
	public abstract void OnImageLoaded(Texture2D texture);

}

public interface ISignage // TypeDefIndex: 9517
{	public abstract Vector2i TextureSize { get; }
	public abstract int TextureCount { get; }
	public abstract uint NetworkID { get; }
	public abstract FileStorage.Type FileType { get; }


	public abstract bool CanUpdateSign(BasePlayer player);

	public abstract float Distance(Vector3 position);

	public abstract Vector2i get_TextureSize();

	public abstract int get_TextureCount();

	public abstract uint[] GetTextureCRCs();

	public abstract uint get_NetworkID();

	public abstract FileStorage.Type get_FileType();

	public abstract void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile);

}

public interface IItemContainerEntity // TypeDefIndex: 9547
{
	public abstract int GetMoveToContainerIndex(BasePlayer player, Item item);

	public abstract int GetMoveToSlotIndex(BasePlayer player, Item item);

}

public interface IVehicleLockUser // TypeDefIndex: 9742
{
	public abstract bool PlayerHasUnlockPermission(BasePlayer player);

	public abstract bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType);

	public abstract bool PlayerCanDestroyLock(BasePlayer player, BaseVehicleModule viaModule);

}

public interface ITrainCollidable // TypeDefIndex: 9763
{
	public abstract bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger);

	public abstract bool EqualNetID(BaseNetworkable other);

}

public interface VehicleChassisVisuals.IClientWheelUser<T> // TypeDefIndex: 9781
{	public abstract Vector3 Velocity { get; }
	public abstract float DriveWheelVelocity { get; }
	public abstract float SteerAngle { get; }
	public abstract float MaxSteerAngle { get; }


	public abstract Vector3 get_Velocity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_Velocity
	*/

	public abstract float get_DriveWheelVelocity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_DriveWheelVelocity
	*/

	public abstract float get_SteerAngle();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_SteerAngle
	*/

	public abstract float get_MaxSteerAngle();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.get_MaxSteerAngle
	*/

	public abstract float GetThrottleInput();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals.IClientWheelUser<object>.GetThrottleInput
	*/

}

public interface IEngineControllerUser : IEntity // TypeDefIndex: 9785
{
	public abstract bool HasFlag(BaseEntity.Flags f);

}

public interface IRFObject // TypeDefIndex: 9812
{
	public abstract void ClientSetFrequency(int newFreq);

	public abstract int GetFrequency();

}

public interface IInstanceDataReceiver // TypeDefIndex: 9903
{
	public abstract void ReceiveInstanceData(Item.InstanceData data);

}

public interface IOnParentDestroying // TypeDefIndex: 9904
{
	public abstract void OnParentDestroying();

}

public interface IOnParentSpawning // TypeDefIndex: 9906
{
	public abstract void OnParentSpawning();

}

public interface IOnPostNetworkUpdate // TypeDefIndex: 9908
{
	public abstract void OnPostNetworkUpdate(BaseEntity entity);

}

public interface IOnSendNetworkUpdate // TypeDefIndex: 9910
{
	public abstract void OnSendNetworkUpdate(BaseEntity entity);

}

public interface ILOD // TypeDefIndex: 9927
{
	public abstract void ChangeLOD();

	public abstract void RefreshLOD();

}

public interface INotifyLOD // TypeDefIndex: 9944
{
	public abstract void Show();

	public abstract void Hide();

}

public interface ISpawnGroup // TypeDefIndex: 9999
{	public abstract int currentPopulation { get; }


	public abstract void Clear();

	public abstract void Fill();

	public abstract void SpawnInitial();

	public abstract void SpawnRepeating();

	public abstract int get_currentPopulation();

}

public interface ISpawnPointUser // TypeDefIndex: 10000
{
	public abstract void ObjectSpawned(SpawnPointInstance instance);

	public abstract void ObjectRetired(SpawnPointInstance instance);

}

public interface TriggerHurtNotChild.IHurtTriggerUser // TypeDefIndex: 10027
{
	public abstract BasePlayer GetPlayerDamageInitiator();

	public abstract float GetPlayerDamageMultiplier();

	public abstract void OnHurtTriggerOccupant(BaseEntity hurtEntity, DamageType damageType, float damageTotal);

}

public interface INotifyTrigger // TypeDefIndex: 10032
{
	public abstract void OnObjects(TriggerNotify trigger);

	public abstract void OnEmpty();

}

public interface INotifyEntityTrigger // TypeDefIndex: 10034
{
	public abstract void OnEntityEnter(BaseEntity ent);

	public abstract void OnEntityLeave(BaseEntity ent);

}

public interface IItemUpdate // TypeDefIndex: 10108
{
	public abstract void OnItemUpdate(Item item);

}

public interface IItemSetup // TypeDefIndex: 10109
{
	public abstract void OnItemSetup(Item item);

}

public interface IAirSupply // TypeDefIndex: 10160
{	public abstract ItemModGiveOxygen.AirSupplyType AirType { get; }


	public abstract ItemModGiveOxygen.AirSupplyType get_AirType();

	public abstract float GetAirTimeRemaining();

}

public interface IMissionProvider // TypeDefIndex: 10212
{
	public abstract uint ProviderID();

	public abstract Vector3 ProviderPosition();

	public abstract BaseEntity Entity();

}

public class UIAIDesignerScreen : SingletonComponent<UIAIDesignerScreen>, IUIScreen // TypeDefIndex: 10816
{	public GameObject SaveEntityButton; // 0x18
	public GameObject SaveServerButton; // 0x20
	public GameObject SaveDefaultButton; // 0x28
	public RustInput InputAIDescription; // 0x30
	public RustText TextDefaultStateContainer; // 0x38
	public Transform PrefabAddNewStateButton; // 0x40
	public Transform StateContainer; // 0x48
	public Transform PrefabState; // 0x50
	public EnumListUI PopupList; // 0x58
	public static EnumListUI EnumList; // 0x0
	public NeedsCursor needsCursor; // 0x60
	protected CanvasGroup canvasGroup; // 0x68
	public GameObject RootPanel; // 0x70
	private bool visible; // 0x78
	public AIDesign DesignProto; // 0x80
	private Transform addNewStateButton; // 0x88


	protected override void Awake() { }

	public void Init(AIDesign design) { }

	[IteratorStateMachineAttribute] // RVA: 0x7C7C0 Offset: 0x7BBC0 VA: 0x18007C7C0
	private IEnumerator SetInitialStateContainer(int id) { }

	public void SetVisible(bool flag) { }

	public void ClearStates() { }

	private void AddNewStateButton() { }

	public List<AIState> GetAvailableStates() { }

	public List<int> GetStateContainerIDs() { }

	private BaseStateUI GetStateContainer(int id) { }

	public int GetNextStateContainerID() { }

	public BaseStateUI AddState(AIState state, int stateContainerID) { }

	public void DeleteState(BaseStateUI state) { }

	public void DuplicateState(BaseStateUI state) { }

	public void OnDebugStateChanged(int previousStateContainerID, int newStateContainerID, int triggerEventID) { }

	public void OnSetDefaultStateClicked() { }

	public void SetDefaultStateClicked(object value) { }

	private void SetDefaultOutputStateContainer(int id) { }

	public void Exit() { }

	public void ClearClicked() { }

	private void Clear() { }

	public void OnSaveClicked() { }

	public void OnSaveEntityClicked() { }

	public void OnSaveServerWideClicked() { }

	public void OnSaveDefaultClicked() { }

	public void Save(AIDesignScope scope) { }

	public void ToggleFade() { }

	public void .ctor() { }

}

private sealed class UIAIDesignerScreen.<SetInitialStateContainer>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10817
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UIAIDesignerScreen <>4__this; // 0x20
	public int id; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public class UIChat : PriorityListComponent<UIChat> // TypeDefIndex: 10829
{	public GameObject inputArea; // 0x18
	public GameObject chatArea; // 0x20
	public TMP_InputField inputField; // 0x28
	public TextMeshProUGUI channelLabel; // 0x30
	public ScrollRect scrollRect; // 0x38
	public CanvasGroup canvasGroup; // 0x40
	public GameObjectRef chatItemPlayer; // 0x48
	public GameObject userPopup; // 0x50
	public static bool isOpen; // 0x0
	private Chat.ChatChannel activeChannel; // 0x58
	private UIChatPopup popup; // 0x60


	protected void Awake() { }

	public static void Open() { }

	protected override void OnEnable() { }

	public void FocusInput() { }

	public void SetChannel(Chat.ChatChannel channel, bool autoSwitched = False) { }

	private void SetChannelLabel(Chat.ChatChannel channel) { }

	public void SubmitText() { }

	public bool ClickedInsideTransformOrChild(Transform t) { }

	public void Cancel() { }

	private void TrimMessages() { }

	private void ClearText() { }

	public void ClearChat() { }

	public void Update() { }

	private void CycleActiveChatChannel() { }

	public static void Add(Chat.ChatChannel channel, ulong steamid, string text, float volume) { }

	private void InternalAdd(Chat.ChatChannel channel, ulong steamid, string text, float volume) { }

	public static void OnMessageClicked(ChatEntry entry) { }

	public void ShowUserMenu(ChatEntry entry) { }

	public void OpenMuteList() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Cancel>b__19_0() { }

}

public class UIChatPopup : MonoBehaviour // TypeDefIndex: 10830
{	public TextMeshProUGUI TextToggleMute; // 0x18
	public TextMeshProUGUI TextToggleGlobalMute; // 0x20
	public Button MuteButton; // 0x28
	public Button ReportButton; // 0x30
	public GameObject InviteToTeamButton; // 0x38
	private ulong steamID; // 0x40
	private string text; // 0x48


	public void Init(ChatEntry entry) { }

	private void Update() { }

	public void OnToggleMuteGlobalClicked() { }

	public void OnToggleMuteClicked() { }

	public void OnInviteToTeamClicked() { }

	public void OnViewSteamProfileClicked() { }

	public void OnCopyTextClicked() { }

	public void OnClearChatClicked() { }

	public void OnReportClicked() { }

	public void Hide() { }

	public void .ctor() { }

}

public interface CardTableUI.ICardGameSubUI // TypeDefIndex: 10878
{	public abstract int DynamicBetAmount { get; }


	public abstract int get_DynamicBetAmount();

	public abstract void UpdateInGameUI(CardTableUI ui, CardGameController game);

	public abstract string GetSecondaryInfo(CardTableUI ui, CardGameController game, out CardTableUI.InfoTextUI.Attitude attitude);

	public abstract void UpdateInGameUI_NoPlayer(CardTableUI ui);

}

public class UIColorPickerButton : MonoBehaviour // TypeDefIndex: 10889
{	public Image Image; // 0x18
	public Color Color; // 0x20


	public void .ctor() { }

}

public class UIFireworkDesignItem : MonoBehaviour // TypeDefIndex: 10890
{	public static readonly Translate.Phrase EmptyPhrase; // 0x0
	public static readonly Translate.Phrase UntitledPhrase; // 0x8
	public RustText Title; // 0x18
	public RustButton LoadButton; // 0x20
	public RustButton SaveButton; // 0x28
	public RustButton EraseButton; // 0x30
	public UIFireworkDesigner Designer; // 0x38
	public int Index; // 0x40
	private PatternFirework.SavedDesign _saved; // 0x48

	private string Key { get; }


	private string get_Key() { }

	public void OnEnable() { }

	public void OnDisable() { }

	public void Load() { }

	public void Save() { }

	public void Erase() { }

	private void UpdateState() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class UIFireworkDesigner : UIDialog // TypeDefIndex: 10891
{	public RustInput Title; // 0x30
	public RustText StarsPlaced; // 0x38
	public RectTransform Canvas; // 0x40
	public RectTransform InnerCanvas; // 0x48
	public GameObject StarPrefab; // 0x50
	public UIFireworkDesigner.Tools Tool; // 0x58
	public Color SelectedColor; // 0x5C
	private PatternFirework _firework; // 0x70
	private Dictionary<int, UIFireworkStar> _stars; // 0x78


	public void Initialize(PatternFirework firework) { }

	public void Save() { }

	public void SelectPlacer() { }

	public void SelectRemover() { }

	public void SelectColor(UIColorPickerButton colorButton) { }

	public void ClearCanvas() { }

	private void PlaceStar(Vector2 localPosition, Color color) { }

	public void PlaceStar() { }

	public void RemoveStar(UIFireworkStar star) { }

	private void UpdateStarsPlacedCount() { }

	public Vector2 GetMousePositionOnCanvas() { }

	private Nullable<int> ChooseIndex() { }

	public void Import(PatternFirework.Design design) { }

	public PatternFirework.Design Export() { }

	private Vector2 GetScaledPositionOnCanvas(Vector2 localPosition) { }

	public void .ctor() { }

}

public enum UIFireworkDesigner.Tools // TypeDefIndex: 10892
{	public int value__; // 0x0
	public const UIFireworkDesigner.Tools Placer = 0;
	public const UIFireworkDesigner.Tools Remover = 1;

}

public class UIFireworkStar : EventTrigger // TypeDefIndex: 10893
{	public Image Image; // 0x20
	public RustText Text; // 0x28
	private UIFireworkDesigner _designer; // 0x30
	public int Index; // 0x38
	public Color Color; // 0x3C


	public void Initialize(UIFireworkDesigner designer, int index, Color color) { }

	private void SetColor(Color color) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnDrag(PointerEventData eventData) { }

	public void .ctor() { }

}

public class UIDialog : ListComponent<UIDialog> // TypeDefIndex: 10919
{	public SoundDefinition openSoundDef; // 0x18
	public SoundDefinition closeSoundDef; // 0x20
	public bool isClosing; // 0x28

	public static bool isOpen { get; }


	public static bool get_isOpen() { }

	public virtual void OpenDialog() { }

	public virtual void CloseDialog() { }

	public static T Spawn<T>(string prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0E80 Offset: 0x14C0280 VA: 0x1814C0E80
	|-UIDialog.Spawn<ChangeSignText>
	|-UIDialog.Spawn<MLRSUIDialog>
	|-UIDialog.Spawn<MuteListController>
	|-UIDialog.Spawn<ReportBug>
	|-UIDialog.Spawn<ReportPlayer>
	|-UIDialog.Spawn<object>
	|-UIDialog.Spawn<UIMarketTerminal>
	|-UIDialog.Spawn<UITwitchTrophy>
	*/

	public void .ctor() { }

}

public class UIMapExplosion : MonoBehaviour // TypeDefIndex: 10962
{
	public void .ctor() { }

}

public class UIMapGenericRadius : MonoBehaviour // TypeDefIndex: 10963
{	public Image radialImage; // 0x18
	public Image outlineImage; // 0x20
	public float radius; // 0x28
	public CanvasGroup fade; // 0x30
	public RectTransform rect; // 0x38


	public void UpdateColors(Color col, Color col2, float totalAlpha) { }

	public void SetRadius(float newRadius, bool force = False) { }

	public void Update() { }

	public void .ctor() { }

}

public class UIMapVendingMachineMarker : MonoBehaviour // TypeDefIndex: 10964
{	public Color inStock; // 0x18
	public Color outOfStock; // 0x28
	public Image colorBackground; // 0x38
	public string displayName; // 0x40
	public Tooltip toolTip; // 0x48
	public RustButton button; // 0x50
	public bool isInStock; // 0x58
	public EntityRef<VendingMachine> vendingMachine; // 0x60
	public VendingMachine vendingMachineData; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<UIMapVendingMachineMarker> onClicked; // 0x0


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_onClicked(Action<UIMapVendingMachineMarker> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void remove_onClicked(Action<UIMapVendingMachineMarker> value) { }

	public void SetOutOfStock(bool stock) { }

	public void UpdateInfo(VendingMachine vendingMachineData) { }

	public void Clicked() { }

	public static void RemoveAllHandlers() { }

	public void .ctor() { }

}

public class UIMapVendingMachineMarkerCluster : MonoBehaviour // TypeDefIndex: 10965
{	public List<UIMapVendingMachineMarker> markers; // 0x18
	public GameObject OpenRoot; // 0x20
	public TextMeshProUGUI CountText; // 0x28
	public static UIMapVendingMachineMarkerCluster currentlyOpen; // 0x0
	private bool open; // 0x30


	private void OnEnable() { }

	public void UpdateDisplay(List<VendingMachine> vendingMachines, List<bool> outOfStock) { }

	private UIMapVendingMachineMarker GetLine() { }

	public void ToggleOpen() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <ToggleOpen>b__8_0() { }

}

public class UIPaintBox : MonoBehaviour // TypeDefIndex: 10966
{	public UIPaintBox.OnBrushChanged onBrushChanged; // 0x18
	public Brush brush; // 0x20


	public void UpdateBrushSize(int size) { }

	public void UpdateBrushTexture(Texture2D tex) { }

	public void UpdateBrushColor(Color col) { }

	public void UpdateBrushAlpha(float a) { }

	public void UpdateBrushEraser(bool b) { }

	private void OnChanged() { }

	public void .ctor() { }

}

public class UIPaintBox.OnBrushChanged : UnityEvent<Brush> // TypeDefIndex: 10967
{
	public void .ctor() { }

}

public class UIBuffs : SingletonComponent<UIBuffs> // TypeDefIndex: 10970
{	public bool Enabled; // 0x18
	public Transform PrefabBuffIcon; // 0x20


	public void Refresh(PlayerModifiers modifiers) { }

	private void RemoveAll() { }

	public void .ctor() { }

}

public class UIBuffsIcon : SingletonComponent<UIBuffsIcon>, IPointerEnterHandler, IEventSystemHandler // TypeDefIndex: 10971
{	public TextMeshProUGUI Text; // 0x18
	public Tooltip ToolTip; // 0x20
	public CanvasGroup Group; // 0x28
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string Buffs; // 0x30


	public virtual void OnPointerEnter(PointerEventData eventData) { }

	private void Refresh() { }

	public void Refresh(PlayerModifiers modifiers) { }

	public void .ctor() { }

}

public class UICompass : MonoBehaviour // TypeDefIndex: 10972
{	public RawImage compassStrip; // 0x18
	public CanvasGroup compassGroup; // 0x20
	public CompassMapMarker CompassMarker; // 0x28
	public CompassMapMarker TeamLeaderCompassMarker; // 0x30
	public List<CompassMissionMarker> MissionMarkers; // 0x38
	private bool compassToggle; // 0x40
	private Material compassStripMaterial; // 0x48
	private Material compassStripMaterialInst; // 0x50

	private static BasePlayer LocalPlayerEntity { get; }


	private static BasePlayer get_LocalPlayerEntity() { }

	private void OnEnable() { }

	public void CompassUpdate() { }

	private void UpdateCompassMarker(Vector3 rot, CompassMapMarker marker, MapNote forNote) { }

	private void UpdateCompassMarker(Vector3 rot, CompassMissionMarker marker, BaseMission.MissionInstance mission) { }

	private void CalculateCompassPosition(Vector3 worldPosition, Vector3 eyeRot, out bool show, out float xPos) { }

	private void OnDisable() { }

	public void .ctor() { }

}

public class UIFadeOut : MonoBehaviour // TypeDefIndex: 10973
{	public float secondsToFadeOut; // 0x18
	public bool destroyOnFaded; // 0x1C
	public CanvasGroup targetGroup; // 0x20
	public float fadeDelay; // 0x28
	private float timeStarted; // 0x2C


	private void Start() { }

	private void Update() { }

	public void .ctor() { }

}

public class UIFishing : SingletonComponent<UIFishing> // TypeDefIndex: 10974
{	public Slider TensionLine; // 0x18
	public Image FillImage; // 0x20
	public Gradient FillGradient; // 0x28
	private float lerpedValue; // 0x30


	private void Start() { }

	public void Toggle(bool state) { }

	public void ForceSetValue(float value) { }

	public void UpdateInfo(float tension) { }

	public void .ctor() { }

}

public class UIHUD : SingletonComponent<UIHUD>, IUIScreen // TypeDefIndex: 10975
{	public UIChat chatPanel; // 0x18
	public HudElement Hunger; // 0x20
	public HudElement Thirst; // 0x28
	public HudElement Health; // 0x30
	public HudElement PendingHealth; // 0x38
	public HudElement VehicleHealth; // 0x40
	public HudElement AnimalStamina; // 0x48
	public HudElement AnimalStaminaMax; // 0x50
	public RectTransform vitalsRect; // 0x58
	public Canvas healthCanvas; // 0x60
	public UICompass CompassWidget; // 0x68
	public GameObject KeyboardCaptureMode; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CanvasGroup <canvasGroup>k__BackingField; // 0x78
	private bool visible; // 0x80

	public CanvasGroup canvasGroup { get; set; }
	private bool shouldShowHud { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public CanvasGroup get_canvasGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_canvasGroup(CanvasGroup value) { }

	protected override void Awake() { }

	private void Update() { }

	private void UpdateVitals() { }

	private bool get_shouldShowHud() { }

	public void SetVisible(bool b) { }

	public void .ctor() { }

}

public class UIRecordingInfo : SingletonComponent<UIRecordingInfo> // TypeDefIndex: 10976
{	public RustText CountdownText; // 0x18
	public Slider TapeProgressSlider; // 0x20
	public GameObject CountdownRoot; // 0x28
	public GameObject RecordingRoot; // 0x30
	public Transform Spinner; // 0x38
	public float SpinSpeed; // 0x40
	public Image CassetteImage; // 0x48
	private RecorderTool cachedRecorder; // 0x50


	private void Start() { }

	public void StartRecording(RecorderTool forRecorder) { }

	public void StopRecording() { }

	private void Update() { }

	public void OnEscape() { }

	public void .ctor() { }

}

public class UIUnderlay : SingletonComponent<UIUnderlay> // TypeDefIndex: 10977
{	public GameObject damageDirectional; // 0x18
	public GameObject waterDirectional; // 0x20


	public void DirectionalDamage(Vector3 pos, DamageType dmgType, float damageTotal) { }

	public void DirectionalDamage_OLD(Vector3 pos, DamageType dmgType) { }

	private GameObject GetDamageTypePrefab(DamageType dmgType) { }

	private Vector2 RectProjectEdge(Rect r, Vector2 v) { }

	public void .ctor() { }

}

public class UIBlueprints : ListComponent<UIBlueprints> // TypeDefIndex: 10994
{	public GameObjectRef buttonPrefab; // 0x18
	public ScrollRect scrollRect; // 0x20
	public CanvasGroup ScrollRectCanvasGroup; // 0x28
	public InputField searchField; // 0x30
	public GameObject searchFieldPlaceholder; // 0x38
	public GameObject listAvailable; // 0x40
	public GameObject listLocked; // 0x48
	public GameObject Categories; // 0x50
	public VerticalLayoutGroup CategoryVerticalLayoutGroup; // 0x58
	public BlueprintCategoryButton FavouriteCategoryButton; // 0x60
	public bool needsResort; // 0x68
	private ItemCategory category; // 0x6C
	private List<BlueprintButton> buttons; // 0x70
	private BlueprintCategoryButton[] categoryButtons; // 0x78
	private static ItemCategory[] miscInclusive; // 0x0


	public void ChangeCategory(string strCategory) { }

	private void UpdateFlash() { }

	private void RetireChildren(GameObject go) { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	public static IEnumerable<ItemBlueprint> GetForCategory(ItemCategory category) { }

	public static IEnumerable<ItemBlueprint> GetCraftableForCategory(ItemCategory category) { }

	public static int CountCraftableForCategory(ItemCategory category) { }

	public static int CountForCategory(ItemCategory category, bool onlyUnlocked = True) { }

	public void UpdateBlueprintList() { }

	private BlueprintCategoryButton[] GetCategoryButtons() { }

	private void UpdateBlueprints(IEnumerable<ItemBlueprint> list) { }

	public static void Refresh() { }

	public void Search(string search) { }

	public static void BounceFavouriteCategories() { }

	public void BounceFavouriteCategory() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class UIBlueprints.<>c__DisplayClass20_0 // TypeDefIndex: 10995
{	public ItemCategory category; // 0x10


	public void .ctor() { }

	internal bool <GetForCategory>b__3(ItemBlueprint x) { }

	internal bool <GetForCategory>b__6(ItemBlueprint x) { }

}

private sealed class UIBlueprints.<>c // TypeDefIndex: 10996
{	public static readonly UIBlueprints.<>c <>9; // 0x0
	public static Func<ItemBlueprint, bool> <>9__20_0; // 0x8
	public static Func<ItemBlueprint, bool> <>9__20_1; // 0x10
	public static Func<ItemBlueprint, int> <>9__20_2; // 0x18
	public static Func<ItemBlueprint, bool> <>9__20_4; // 0x20
	public static Func<ItemBlueprint, Rarity> <>9__20_5; // 0x28
	public static Func<ItemBlueprint, bool> <>9__20_7; // 0x30
	public static Func<ItemBlueprint, Rarity> <>9__20_8; // 0x38


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetForCategory>b__20_0(ItemBlueprint x) { }

	internal bool <GetForCategory>b__20_1(ItemBlueprint x) { }

	internal int <GetForCategory>b__20_2(ItemBlueprint y) { }

	internal bool <GetForCategory>b__20_4(ItemBlueprint x) { }

	internal Rarity <GetForCategory>b__20_5(ItemBlueprint x) { }

	internal bool <GetForCategory>b__20_7(ItemBlueprint x) { }

	internal Rarity <GetForCategory>b__20_8(ItemBlueprint x) { }

}

private sealed class UIBlueprints.<>c__DisplayClass28_0 // TypeDefIndex: 10997
{	public string search; // 0x10


	public void .ctor() { }

	internal bool <Search>b__0(ItemBlueprint x) { }

}

public interface LootPanel.IHasLootPanel // TypeDefIndex: 11026
{	public abstract Translate.Phrase LootPanelTitle { get; }


	public abstract Translate.Phrase get_LootPanelTitle();

}

public class UIBelt : SingletonComponent<UIBelt> // TypeDefIndex: 11051
{	public List<ItemIcon> ItemIcons; // 0x18


	protected override void Awake() { }

	public ItemIcon GetItemIconAtSlot(int slot) { }

	public void .ctor() { }

}

private sealed class UIBelt.<>c // TypeDefIndex: 11052
{	public static readonly UIBelt.<>c <>9; // 0x0
	public static Func<ItemIcon, int> <>9__1_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <Awake>b__1_0(ItemIcon s) { }

}

public class UIContacts : SingletonComponent<UIContacts> // TypeDefIndex: 11053
{	public static bool isOpen; // 0x0
	public static float LastOpened; // 0x4
	public ContactsPanel contactsPanel; // 0x18
	private GameObject Inset; // 0x20
	private float returnX; // 0x28
	private static CanvasGroup canvasGroup; // 0x8
	private static GraphicRaycaster graphicRaycster; // 0x10
	private ItemIcon[] inventoryItemIcons; // 0x30


	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void togglecontacts() { }

	protected override void Awake() { }

	public static void Open() { }

	public static void Toggle() { }

	public static void Close() { }

	private void Update() { }

	private bool ShouldShow() { }

	public void ContactsPressed() { }

	public void .ctor() { }

}

public class UICrafting : SingletonComponent<UICrafting> // TypeDefIndex: 11054
{	public static bool isOpen; // 0x0
	public static float LastOpened; // 0x4
	private static CanvasGroup canvasGroup; // 0x8
	private static GraphicRaycaster graphicRaycster; // 0x10
	private GameObject Inset; // 0x18
	private float returnX; // 0x20


	protected override void Awake() { }

	public static void Open() { }

	public static void Toggle() { }

	public static void Close() { }

	private void Update() { }

	private bool ShouldShow() { }

	public void .ctor() { }

}

public class UIIntegerEntry : MonoBehaviour // TypeDefIndex: 11055
{	public InputField textEntry; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action textChanged; // 0x20


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_textChanged(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_textChanged(Action value) { }

	public void OnAmountTextChanged() { }

	public void SetAmount(int amount) { }

	public int GetIntAmount() { }

	public void PlusMinus(int delta) { }

	public void .ctor() { }

}

public class UIInventory : SingletonComponent<UIInventory> // TypeDefIndex: 11056
{	public TextMeshProUGUI PlayerName; // 0x18
	public static bool isOpen; // 0x0
	public static float LastOpened; // 0x4
	public VerticalLayoutGroup rightContents; // 0x20
	public GameObject QuickCraft; // 0x28
	public Transform InventoryIconContainer; // 0x30
	public ContactsPanel contactsPanel; // 0x38
	private static uint currentQuickLootContainerID; // 0x8
	private GameObject Inset; // 0x40
	private float returnX; // 0x48
	private static CanvasGroup canvasGroup; // 0x10
	private static GraphicRaycaster graphicRaycster; // 0x18
	private ItemIcon[] inventoryItemIcons; // 0x50
	public UnderwearSkinPicker underwearSkinPicker; // 0x58
	private static TimeSince lastCloseSoundPlay; // 0x20


	protected override void Awake() { }

	public static void Open(bool selectHeldItem = True) { }

	public static void ToggleInventory() { }

	public static void Close() { }

	private static void PlayCloseSound() { }

	public static void OpenLoot(string lootType) { }

	public static bool CanQuickLootItem(Item item, ItemContainerSource containerSource) { }

	private void Update() { }

	private bool ShouldShow() { }

	public void CloseUnderwearPicker() { }

	public void ToggleUnderwearPicker() { }

	public void ContactsPressed() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public interface IContainerSounds // TypeDefIndex: 11057
{	public abstract SoundDefinition OpenSound { get; }
	public abstract SoundDefinition CloseSound { get; }


	public abstract SoundDefinition get_OpenSound();

	public abstract SoundDefinition get_CloseSound();

}

public class UIMixingTableItem : MonoBehaviour // TypeDefIndex: 11058
{	public Image ItemIcon; // 0x18
	public Tooltip ItemTooltip; // 0x20
	public RustText TextItemNameAndQuantity; // 0x28
	public UIMixingTableItemIngredient[] Ingredients; // 0x30


	public void Init(Recipe recipe) { }

	public void .ctor() { }

}

public class UIMixingTableItemIngredient : MonoBehaviour // TypeDefIndex: 11059
{	public Image ItemIcon; // 0x18
	public Text ItemCount; // 0x20
	public Tooltip ToolTip; // 0x28


	public void Init(Recipe.RecipeIngredient ingredient) { }

	public void InitBlank() { }

	public void .ctor() { }

}

public interface VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 11065
{	public abstract int SocketsTaken { get; }


	public abstract int get_SocketsTaken();

}

public class UIPaintableImage : MonoBehaviour // TypeDefIndex: 11186
{	public RawImage image; // 0x18
	public int texSize; // 0x20
	public Color clearColor; // 0x24
	public FilterMode filterMode; // 0x34
	public bool mipmaps; // 0x38
	public int imageNumber; // 0x3C
	public uint imageHash; // 0x40
	public bool isLocked; // 0x44
	public bool isLoading; // 0x45
	public bool isBlank; // 0x46
	public bool needsApply; // 0x47
	internal Texture2D texture; // 0x48

	public RectTransform rectTransform { get; }


	public RectTransform get_rectTransform() { }

	private void Start() { }

	private void Update() { }

	public void SetupTexture() { }

	public void Clear() { }

	private void OnDestroy() { }

	public void ClearTexture() { }

	public void FromData(byte[] data) { }

	public byte[] ToPng(BaseEntity ent) { }

	public byte[] ToJpg(BaseEntity ent, int quality) { }

	public void DrawTexture(Vector2 pos, Vector2 size, Texture2D brush, Color textureColor, UIPaintableImage.DrawMode mode) { }

	public void .ctor() { }

}

public enum UIPaintableImage.DrawMode // TypeDefIndex: 11187
{	public int value__; // 0x0
	public const UIPaintableImage.DrawMode AlphaBlended = 0;
	public const UIPaintableImage.DrawMode Additive = 1;
	public const UIPaintableImage.DrawMode Lighten = 2;
	public const UIPaintableImage.DrawMode Erase = 3;

}

public class UIParticle : BaseMonoBehaviour // TypeDefIndex: 11188
{	public Vector2 LifeTime; // 0x18
	public Vector2 Gravity; // 0x20
	public Vector2 InitialX; // 0x28
	public Vector2 InitialY; // 0x30
	public Vector2 InitialScale; // 0x38
	public Vector2 InitialDelay; // 0x40
	public Vector2 ScaleVelocity; // 0x48
	public Gradient InitialColor; // 0x50
	private float lifetime; // 0x58
	private float gravity; // 0x5C
	private Vector2 velocity; // 0x60
	private float scaleVelocity; // 0x68


	public static void Add(UIParticle particleSource, RectTransform spawnPosition, RectTransform particleCanvas) { }

	private void Start() { }

	private void Update() { }

	private void Die() { }

	public void .ctor() { }

}

public static class UISound // TypeDefIndex: 11195
{	private static AudioSource source; // 0x2B0AAB0


	private static AudioSource GetAudioSource() { }

	public static void Play(AudioClip clip, float volume = 1) { }

}

public class UIPlayerPreviewControls : SingletonComponent<UIPlayerPreviewControls>, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11200
{	public float RotationSpeed; // 0x18
	public float RotationLerpSpeed; // 0x1C
	public float RotationStopLerpSpeed; // 0x20
	private bool rotating; // 0x24
	private bool pointerInControlArea; // 0x25
	private float rotationVelocity; // 0x28
	private float horizRotationPerc; // 0x2C
	private float startingRotation; // 0x30
	private Vector3 dragInputPos; // 0x34
	private Vector3 currentDragInputPos; // 0x40
	private Vector3 rotation; // 0x4C
	private Transform previewModel; // 0x58
	private CanvasGroup canvasGroup; // 0x60
	private bool showInventoryPlayer; // 0x68


	protected override void Awake() { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	private void Update() { }

	private void ToggleDisplay() { }

	private void ApplyRotation() { }

	private void HandleRotationControl() { }

	public void ResetToDefault() { }

	private Transform GetPlayerModel() { }

	public void .ctor() { }

}

public class UIInvertedMaskImage : Image // TypeDefIndex: 11203
{	private Material cachedMaterial; // 0x100

	public override Material materialForRendering { get; }


	public override Material get_materialForRendering() { }

	public void .ctor() { }

}

public class UIAutoPanelCloser : MonoBehaviour // TypeDefIndex: 11241
{	public UIDialog Dialog; // 0x18


	private void Update() { }

	public void .ctor() { }

}

public class UIBackgroundBlur : ListComponent<UIBackgroundBlur>, IClientComponent // TypeDefIndex: 11242
{	public float amount; // 0x18

	public static float currentMax { get; }


	public static float get_currentMax() { }

	public void .ctor() { }

}

public class UIBlackoutOverlay : MonoBehaviour // TypeDefIndex: 11243
{	public CanvasGroup group; // 0x18
	public static Dictionary<UIBlackoutOverlay.blackoutType, UIBlackoutOverlay> instances; // 0x0
	public UIBlackoutOverlay.blackoutType overlayType; // 0x20
	private Vector3 initialPosition; // 0x24
	private float myAlpha; // 0x30


	public static void AddOverlay(UIBlackoutOverlay.blackoutType type, UIBlackoutOverlay overlay) { }

	public static UIBlackoutOverlay Get(UIBlackoutOverlay.blackoutType type) { }

	public static void HideAll() { }

	private void Awake() { }

	public void ResetPosition() { }

	public void SetPosition(Vector3 position) { }

	public Vector3 GetPosition() { }

	public void Update() { }

	public void SetAlpha(float alpha) { }

	public float GetAlpha() { }

	public void .ctor() { }

}

public enum UIBlackoutOverlay.blackoutType // TypeDefIndex: 11244
{	public int value__; // 0x0
	public const UIBlackoutOverlay.blackoutType FULLBLACK = 0;
	public const UIBlackoutOverlay.blackoutType BINOCULAR = 1;
	public const UIBlackoutOverlay.blackoutType SCOPE = 2;
	public const UIBlackoutOverlay.blackoutType HELMETSLIT = 3;
	public const UIBlackoutOverlay.blackoutType SNORKELGOGGLE = 4;
	public const UIBlackoutOverlay.blackoutType NVG = 5;
	public const UIBlackoutOverlay.blackoutType FULLWHITE = 6;
	public const UIBlackoutOverlay.blackoutType SUNGLASSES = 7;
	public const UIBlackoutOverlay.blackoutType NONE = 64;

}

public class UICameraOverlay : SingletonComponent<UICameraOverlay> // TypeDefIndex: 11245
{	public static readonly Translate.Phrase FocusOffText; // 0x0
	public static readonly Translate.Phrase FocusAutoText; // 0x8
	public static readonly Translate.Phrase FocusManualText; // 0x10
	public CanvasGroup CanvasGroup; // 0x18
	public RustText FocusModeLabel; // 0x20


	public void Show() { }

	public void Hide() { }

	public void SetFocusMode(CameraFocusMode mode) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class UIConversationScreen : SingletonComponent<UIConversationScreen>, IUIScreen // TypeDefIndex: 11246
{	public NeedsCursor needsCursor; // 0x18
	public RectTransform conversationPanel; // 0x20
	public RustText conversationSpeechBody; // 0x28
	public RustText conversationProviderName; // 0x30
	public RustButton[] responseButtons; // 0x38
	public RectTransform letterBoxTop; // 0x40
	public RectTransform letterBoxBottom; // 0x48
	protected CanvasGroup canvasGroup; // 0x50
	private int currentlyDisplayedSpeechIndex; // 0x58
	private bool visible; // 0x5C
	private LayoutGroup[] layoutGroups; // 0x60
	private bool wasTalking; // 0x68


	protected override void Awake() { }

	public void SetVisible(bool b) { }

	public void Exit() { }

	public void FastForward() { }

	public void Update() { }

	public void Refresh(bool force = False) { }

	public void ResponsePressed(int responseIndex) { }

	public void .ctor() { }

}

public class UIDeathScreen : SingletonComponent<UIDeathScreen>, IUIScreen // TypeDefIndex: 11247
{	public LifeInfographic previousLifeInfographic; // 0x18
	public Animator screenAnimator; // 0x20
	public bool fadeIn; // 0x28
	public Button ReportCheatButton; // 0x30
	public MapView View; // 0x38
	public List<SleepingBagButton> sleepingBagButtons; // 0x40
	public UIDeathScreen.RespawnColourScheme[] RespawnColourSchemes; // 0x48
	public GameObject RespawnScrollGradient; // 0x50
	public ScrollRect RespawnScrollRect; // 0x58
	public ExpandedLifeStats ExpandedStats; // 0x60
	public CanvasGroup StreamerModeContainer; // 0x68
	protected CanvasGroup canvasGroup; // 0x70
	protected GraphicRaycaster graphicRaycaster; // 0x78
	protected NeedsCursor needsCursor; // 0x80
	private bool visible; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RespawnInformation <currentRespawnInfo>k__BackingField; // 0x90

	public RespawnInformation currentRespawnInfo { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public RespawnInformation get_currentRespawnInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentRespawnInfo(RespawnInformation value) { }

	protected override void Awake() { }

	public void SetVisible(bool b) { }

	private void OnEnable() { }

	public void OnRespawn() { }

	private void UpdateRespawnInformation(RespawnInformation info) { }

	private void UpdateRespawnOptions(List<RespawnInformation.SpawnOptions> spawnOptions) { }

	private SleepingBagButton GetSleepingBagButton() { }

	public void PopulateDeathInfo() { }

	public void EnableInteraction() { }

	public static void OnRespawnInformation(RespawnInformation info) { }

	public void ReportCheater() { }

	public UIDeathScreen.RespawnColourScheme GetRespawnColourScheme(RespawnInformation.SpawnOptions option) { }

	public UIDeathScreen.RespawnColourScheme GetRespawnColourScheme(int index) { }

	public void UpdateBottomScrollGradient() { }

	public void .ctor() { }

}

public struct UIDeathScreen.RespawnColourScheme // TypeDefIndex: 11248
{	public Color BackgroundColour; // 0x0
	public Color CircleRimColour; // 0x10
	public Color CircleFillColour; // 0x20

}

public class UIEscapeCapture : ListComponent<UIEscapeCapture> // TypeDefIndex: 11249
{	public UnityEvent onEscape; // 0x18


	public static bool EscapePressed() { }

	public void .ctor() { }

}

public class UIFogOverlay : MonoBehaviour // TypeDefIndex: 11250
{	public static UIFogOverlay Instance; // 0x0
	public CanvasGroup group; // 0x18
	public Color baseColor; // 0x20
	public Image overlayImage; // 0x30


	public static void SetAlpha(float alpha) { }

	public void OnEnable() { }

	public void Update() { }

	public void .ctor() { }

}

public class UIGene : MonoBehaviour // TypeDefIndex: 11251
{	public GameObject Child; // 0x18
	public Color PositiveColour; // 0x20
	public Color NegativeColour; // 0x30
	public Color PositiveTextColour; // 0x40
	public Color NegativeTextColour; // 0x50
	public Image ImageBG; // 0x60
	public Text TextGene; // 0x68


	public void Init(GrowableGene gene) { }

	public void InitPrevious(GrowableGene gene) { }

	public void Hide() { }

	public void Show() { }

	public void .ctor() { }

}

public class UIGenesDisplay : MonoBehaviour // TypeDefIndex: 11252
{	public UIGene[] GeneUI; // 0x18
	public Text[] TextLinks; // 0x20
	public Text[] TextDiagLinks; // 0x28


	public void Init(GrowableGenes genes) { }

	public void InitDualRow(GrowableGenes genes, bool firstRow) { }

	private void InitFirstRow(GrowableGenes genes) { }

	private void InitSecondRow(GrowableGenes genes) { }

	private void ShowDiagLink(int index, float rotation, GrowableGene nextGene) { }

	public void .ctor() { }

}

public class UIIngame : SingletonComponent<UIIngame> // TypeDefIndex: 11253
{
	private void Update() { }

	private IUIScreen DetermineActiveUI() { }

	public void .ctor() { }

}

public class UIPrefab : MonoBehaviour // TypeDefIndex: 11254
{	public GameObject prefabSource; // 0x18
	internal GameObject createdGameObject; // 0x20


	private void Awake() { }

	public void SetVisible(bool visible) { }

	public void .ctor() { }

}

public abstract class UIRoot : MonoBehaviour // TypeDefIndex: 11255
{	private GraphicRaycaster[] graphicRaycasters; // 0x18
	public Canvas overlayCanvas; // 0x20


	private void ToggleRaycasters(bool state) { }

	protected virtual void Awake() { }

	protected virtual void Start() { }

	protected void Update() { }

	protected abstract void Refresh();

	protected void .ctor() { }

}

public class UIRootPixel : UIRoot // TypeDefIndex: 11256
{
	protected override void Refresh() { }

	public void .ctor() { }

}

public class UIRootScaled : UIRoot // TypeDefIndex: 11257
{	private static UIRootScaled Instance; // 0x0
	public bool OverrideReference; // 0x28
	public Vector2 TargetReference; // 0x2C
	public CanvasScaler scaler; // 0x38

	public static Canvas DragOverlayCanvas { get; }


	public static Canvas get_DragOverlayCanvas() { }

	protected override void Awake() { }

	protected override void Refresh() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class UIScale : MonoBehaviour, IClientComponent // TypeDefIndex: 11258
{	public CanvasScaler scaler; // 0x18


	private void Update() { }

	public void .ctor() { }

}

public class UIScalerOverride : MonoBehaviour // TypeDefIndex: 11259
{	public AnimationCurve scaleCurve; // 0x18
	private CanvasScaler rootScaler; // 0x20
	private Canvas rootCanvas; // 0x28
	private Vector3 defaultScale; // 0x30


	private void Start() { }

	private void Update() { }

	public void .ctor() { }

}

public class UIScopeOverlay : MonoBehaviour // TypeDefIndex: 11260
{	public CanvasGroup group; // 0x18
	public static UIScopeOverlay instance; // 0x0
	public Image scopeImage; // 0x20
	private Vector3 initialPosition; // 0x28


	public void SetScopeMaterial(Material newMat) { }

	private void Awake() { }

	public void SetPosition(Vector3 position) { }

	public Vector3 GetPosition() { }

	public void SetAlpha(float alpha) { }

	public float GetAlpha() { }

	public void .ctor() { }

}

public interface IUIScreen // TypeDefIndex: 11261
{
	public abstract void SetVisible(bool b);

}

public class UISleepingScreen : SingletonComponent<UISleepingScreen>, IUIScreen // TypeDefIndex: 11262
{	protected CanvasGroup canvasGroup; // 0x18
	private bool visible; // 0x20


	protected override void Awake() { }

	public void SetVisible(bool b) { }

	public void .ctor() { }

}

public class UISoundPlayer : MonoBehaviour // TypeDefIndex: 11263
{
	public void PlaySound(AudioClip clip) { }

	public void PlaySoundDef(SoundDefinition sound) { }

	public void .ctor() { }

}

public class UIVoiceIcon : MonoBehaviour // TypeDefIndex: 11264
{	public Text nameText; // 0x18
	public RawImage avatar; // 0x20


	public void Setup(ulong steamid, string name) { }

	public void UpdateVolume(float volume) { }

	public void .ctor() { }

}

public class UIWounded : MonoBehaviour // TypeDefIndex: 11265
{	public CanvasGroup group; // 0x18


	private void Update() { }

	private bool ShouldShow() { }

	public void .ctor() { }

}

public class UI_LocalVoice : PriorityListComponent<UI_LocalVoice> // TypeDefIndex: 11266
{	public CanvasGroup voiceCanvas; // 0x18
	public CanvasGroup levelImage; // 0x20


	protected override void OnEnable() { }

	public void SetRecording(bool b) { }

	public void SetLevel(float f) { }

	public void .ctor() { }

}

public interface IDraggable // TypeDefIndex: 11268
{
	public abstract object GetDragData();

	public abstract string GetDragType();

	public abstract Sprite GetDragSprite();

}

public interface IVitalNotice // TypeDefIndex: 11277
{	public abstract bool IsActive { get; }


	public abstract void Refresh();

	public abstract bool get_IsActive();

}

public interface IInventoryChanged // TypeDefIndex: 11374
{
	public abstract void OnInventoryChanged();

}

public interface IViewModeChanged // TypeDefIndex: 11375
{
	public abstract void OnViewModeChanged();

}

public interface IClothingChanged // TypeDefIndex: 11376
{
	public abstract void OnClothingChanged();

}

public interface IViewModelUpdated // TypeDefIndex: 11377
{
	public abstract void OnViewModelUpdated();

}

public interface IBlueprintsChanged // TypeDefIndex: 11378
{
	public abstract void OnBlueprintsChanged();

}

public interface IItemAmountChanged // TypeDefIndex: 11379
{
	public abstract void OnItemAmountChanged();

}

public interface IItemIconChanged // TypeDefIndex: 11380
{
	public abstract void OnItemIconChanged();

}

public interface IProvider // TypeDefIndex: 11671
{
	public abstract Info GetMenuInformation(GameObject primaryObject, BasePlayer player);

	public abstract List<Option> GetMenuItems(BasePlayer player);

}

public static class UIEx // TypeDefIndex: 11706
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Vector2 Unpivot(RectTransform rect, Vector2 localPos) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void CenterOnPosition(ScrollRect scrollrect, Vector2 pos) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void RebuildHackUnity2019(Image image) { }

}

public class UICircle : UIPrimitiveBase // TypeDefIndex: 11712
{	[TooltipAttribute] // RVA: 0xD9530 Offset: 0xD8930 VA: 0x1800D9530
	public bool ArcInvert; // 0xF0
	[TooltipAttribute] // RVA: 0xD9620 Offset: 0xD8A20 VA: 0x1800D9620
	[RangeAttribute] // RVA: 0xD9620 Offset: 0xD8A20 VA: 0x1800D9620
	public float Arc; // 0xF4
	[TooltipAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	[RangeAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	public int ArcSteps; // 0xF8
	[TooltipAttribute] // RVA: 0xD99A0 Offset: 0xD8DA0 VA: 0x1800D99A0
	[RangeAttribute] // RVA: 0xD99A0 Offset: 0xD8DA0 VA: 0x1800D99A0
	public int ArcRotation; // 0xFC
	[TooltipAttribute] // RVA: 0xD9B90 Offset: 0xD8F90 VA: 0x1800D9B90
	[RangeAttribute] // RVA: 0xD9B90 Offset: 0xD8F90 VA: 0x1800D9B90
	public float Progress; // 0x100
	private float _progress; // 0x104
	public Color ProgressColor; // 0x108
	public bool Fill; // 0x118
	public float Thickness; // 0x11C
	public int Padding; // 0x120
	private List<int> indices; // 0x128
	private List<UIVertex> vertices; // 0x130
	private Vector2 uvCenter; // 0x138


	protected override void OnPopulateMesh(VertexHelper vh) { }

	public void SetProgress(float progress) { }

	public void SetArcSteps(int steps) { }

	public void SetInvertArc(bool invert) { }

	public void SetArcRotation(int rotation) { }

	public void SetFill(bool fill) { }

	public void SetBaseColor(Color color) { }

	public void UpdateBaseAlpha(float value) { }

	public void SetProgressColor(Color color) { }

	public void UpdateProgressAlpha(float value) { }

	public void SetPadding(int padding) { }

	public void SetThickness(int thickness) { }

	public void .ctor() { }

}

public class UICircleSimple : UIPrimitiveBase // TypeDefIndex: 11713
{	[TooltipAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	[RangeAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	public int ArcSteps; // 0xF0
	public bool Fill; // 0xF4
	public float Thickness; // 0xF8
	public bool ThicknessIsOutside; // 0xFC
	private List<int> indices; // 0x100
	private List<UIVertex> vertices; // 0x108
	private Vector2 uvCenter; // 0x110


	protected override void OnPopulateMesh(VertexHelper vh) { }

	public void SetArcSteps(int steps) { }

	public void SetFill(bool fill) { }

	public void SetBaseColor(Color color) { }

	public void UpdateBaseAlpha(float value) { }

	public void SetThickness(int thickness) { }

	public void .ctor() { }

}

public class UICornerCut : UIPrimitiveBase // TypeDefIndex: 11714
{	public Vector2 cornerSize; // 0xF0
	[HeaderAttribute] // RVA: 0xD9F70 Offset: 0xD9370 VA: 0x1800D9F70
	[SerializeField] // RVA: 0xD9F70 Offset: 0xD9370 VA: 0x1800D9F70
	private bool m_cutUL; // 0xF8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_cutUR; // 0xF9
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_cutLL; // 0xFA
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_cutLR; // 0xFB
	[TooltipAttribute] // RVA: 0xDA130 Offset: 0xD9530 VA: 0x1800DA130
	[SerializeField] // RVA: 0xDA130 Offset: 0xD9530 VA: 0x1800DA130
	private bool m_makeColumns; // 0xFC
	[HeaderAttribute] // RVA: 0xDA330 Offset: 0xD9730 VA: 0x1800DA330
	[SerializeField] // RVA: 0xDA330 Offset: 0xD9730 VA: 0x1800DA330
	private bool m_useColorUp; // 0xFD
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color32 m_colorUp; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_useColorDown; // 0x104
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color32 m_colorDown; // 0x108

	public bool CutUL { get; set; }
	public bool CutUR { get; set; }
	public bool CutLL { get; set; }
	public bool CutLR { get; set; }
	public bool MakeColumns { get; set; }
	public bool UseColorUp { get; set; }
	public Color32 ColorUp { get; set; }
	public bool UseColorDown { get; set; }
	public Color32 ColorDown { get; set; }


	public bool get_CutUL() { }

	public void set_CutUL(bool value) { }

	public bool get_CutUR() { }

	public void set_CutUR(bool value) { }

	public bool get_CutLL() { }

	public void set_CutLL(bool value) { }

	public bool get_CutLR() { }

	public void set_CutLR(bool value) { }

	public bool get_MakeColumns() { }

	public void set_MakeColumns(bool value) { }

	public bool get_UseColorUp() { }

	public void set_UseColorUp(bool value) { }

	public Color32 get_ColorUp() { }

	public void set_ColorUp(Color32 value) { }

	public bool get_UseColorDown() { }

	public void set_UseColorDown(bool value) { }

	public Color32 get_ColorDown() { }

	public void set_ColorDown(Color32 value) { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	private static void AddSquare(Rect rect, Rect rectUV, Color32 color32, VertexHelper vh) { }

	private static void AddSquare(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Rect rectUV, Color32 color32, VertexHelper vh) { }

	private static int AddVert(float x, float y, Rect area, Color32 color32, VertexHelper vh) { }

	public void .ctor() { }

}

public class UIGoldenRatioRenderer : UILineRenderer // TypeDefIndex: 11715
{	private readonly List<Vector2> _points; // 0x118
	private readonly List<Rect> _rects; // 0x120
	private int canvasWidth; // 0x128
	private int canvasHeight; // 0x12C
	public float lineThickness2; // 0x130


	private void DrawSpiral(VertexHelper vh) { }

	private void DrawPhiRectangles(VertexHelper vh, List<Vector2> points, float x, float y, float width, float height, UIGoldenRatioRenderer.Orientations orientation) { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	private void DrawRect(VertexHelper vh, Rect rect) { }

	public void .ctor() { }

}

private enum UIGoldenRatioRenderer.Orientations // TypeDefIndex: 11716
{	public int value__; // 0x0
	public const UIGoldenRatioRenderer.Orientations Left = 0;
	public const UIGoldenRatioRenderer.Orientations Top = 1;
	public const UIGoldenRatioRenderer.Orientations Right = 2;
	public const UIGoldenRatioRenderer.Orientations Bottom = 3;

}

public class UIGridRenderer : UILineRenderer // TypeDefIndex: 11717
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_GridColumns; // 0x118
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_GridRows; // 0x11C

	public int GridColumns { get; set; }
	public int GridRows { get; set; }


	public int get_GridColumns() { }

	public void set_GridColumns(int value) { }

	public int get_GridRows() { }

	public void set_GridRows(int value) { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	public void .ctor() { }

}

public class UILineRenderer : UIPrimitiveBase // TypeDefIndex: 11718
{	private const float MIN_MITER_JOIN = 0,2617994;
	private const float MIN_BEVEL_NICE_JOIN = 0,5235988;
	private static Vector2 UV_TOP_LEFT; // 0x0
	private static Vector2 UV_BOTTOM_LEFT; // 0x8
	private static Vector2 UV_TOP_CENTER_LEFT; // 0x10
	private static Vector2 UV_TOP_CENTER_RIGHT; // 0x18
	private static Vector2 UV_BOTTOM_CENTER_LEFT; // 0x20
	private static Vector2 UV_BOTTOM_CENTER_RIGHT; // 0x28
	private static Vector2 UV_TOP_RIGHT; // 0x30
	private static Vector2 UV_BOTTOM_RIGHT; // 0x38
	private static Vector2[] startUvs; // 0x40
	private static Vector2[] middleUvs; // 0x48
	private static Vector2[] endUvs; // 0x50
	private static Vector2[] fullUvs; // 0x58
	[SerializeField] // RVA: 0xDAAE0 Offset: 0xD9EE0 VA: 0x1800DAAE0
	[TooltipAttribute] // RVA: 0xDAAE0 Offset: 0xD9EE0 VA: 0x1800DAAE0
	internal Vector2[] m_points; // 0xF0
	[SerializeField] // RVA: 0xDAC00 Offset: 0xDA000 VA: 0x1800DAC00
	[TooltipAttribute] // RVA: 0xDAC00 Offset: 0xDA000 VA: 0x1800DAC00
	internal List<Vector2[]> m_segments; // 0xF8
	[SerializeField] // RVA: 0xDAE80 Offset: 0xDA280 VA: 0x1800DAE80
	[TooltipAttribute] // RVA: 0xDAE80 Offset: 0xDA280 VA: 0x1800DAE80
	internal float lineThickness; // 0x100
	[SerializeField] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	[TooltipAttribute] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	internal bool relativeSize; // 0x104
	[SerializeField] // RVA: 0xDB1B0 Offset: 0xDA5B0 VA: 0x1800DB1B0
	[TooltipAttribute] // RVA: 0xDB1B0 Offset: 0xDA5B0 VA: 0x1800DB1B0
	internal bool lineList; // 0x105
	[SerializeField] // RVA: 0xDB2C0 Offset: 0xDA6C0 VA: 0x1800DB2C0
	[TooltipAttribute] // RVA: 0xDB2C0 Offset: 0xDA6C0 VA: 0x1800DB2C0
	internal bool lineCaps; // 0x106
	[SerializeField] // RVA: 0xDB470 Offset: 0xDA870 VA: 0x1800DB470
	[TooltipAttribute] // RVA: 0xDB470 Offset: 0xDA870 VA: 0x1800DB470
	internal int bezierSegmentsPerCurve; // 0x108
	[TooltipAttribute] // RVA: 0xDB5F0 Offset: 0xDA9F0 VA: 0x1800DB5F0
	public UILineRenderer.JoinType LineJoins; // 0x10C
	[TooltipAttribute] // RVA: 0xDB820 Offset: 0xDAC20 VA: 0x1800DB820
	public UILineRenderer.BezierType BezierMode; // 0x110
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool drivenExternally; // 0x114

	public float LineThickness { get; set; }
	public bool RelativeSize { get; set; }
	public bool LineList { get; set; }
	public bool LineCaps { get; set; }
	public int BezierSegmentsPerCurve { get; set; }
	public Vector2[] Points { get; set; }
	public List<Vector2[]> Segments { get; set; }


	public float get_LineThickness() { }

	public void set_LineThickness(float value) { }

	public bool get_RelativeSize() { }

	public void set_RelativeSize(bool value) { }

	public bool get_LineList() { }

	public void set_LineList(bool value) { }

	public bool get_LineCaps() { }

	public void set_LineCaps(bool value) { }

	public int get_BezierSegmentsPerCurve() { }

	public void set_BezierSegmentsPerCurve(int value) { }

	public Vector2[] get_Points() { }

	public void set_Points(Vector2[] value) { }

	public List<Vector2[]> get_Segments() { }

	public void set_Segments(List<Vector2[]> value) { }

	private void PopulateMesh(VertexHelper vh, Vector2[] pointsToDraw) { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRenderer.SegmentType type) { }

	private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRenderer.SegmentType type, UIVertex[] previousVert) { }

	protected override void GeneratedUVs() { }

	protected override void ResolutionToNativeSize(float distance) { }

	private int GetSegmentPointCount() { }

	public Vector2 GetPosition(int index, int segmentIndex = 0) { }

	public Vector2 GetPositionBySegment(int index, int segment) { }

	public Vector2 GetClosestPoint(Vector2 p1, Vector2 p2, Vector2 p3) { }

	public void .ctor() { }

}

private enum UILineRenderer.SegmentType // TypeDefIndex: 11719
{	public int value__; // 0x0
	public const UILineRenderer.SegmentType Start = 0;
	public const UILineRenderer.SegmentType Middle = 1;
	public const UILineRenderer.SegmentType End = 2;
	public const UILineRenderer.SegmentType Full = 3;

}

public enum UILineRenderer.JoinType // TypeDefIndex: 11720
{	public int value__; // 0x0
	public const UILineRenderer.JoinType Bevel = 0;
	public const UILineRenderer.JoinType Miter = 1;

}

public enum UILineRenderer.BezierType // TypeDefIndex: 11721
{	public int value__; // 0x0
	public const UILineRenderer.BezierType None = 0;
	public const UILineRenderer.BezierType Quick = 1;
	public const UILineRenderer.BezierType Basic = 2;
	public const UILineRenderer.BezierType Improved = 3;
	public const UILineRenderer.BezierType Catenary = 4;

}

public class UILineRendererList : UIPrimitiveBase // TypeDefIndex: 11722
{	private const float MIN_MITER_JOIN = 0,2617994;
	private const float MIN_BEVEL_NICE_JOIN = 0,5235988;
	private static Vector2 UV_TOP_LEFT; // 0x0
	private static Vector2 UV_BOTTOM_LEFT; // 0x8
	private static Vector2 UV_TOP_CENTER_LEFT; // 0x10
	private static Vector2 UV_TOP_CENTER_RIGHT; // 0x18
	private static Vector2 UV_BOTTOM_CENTER_LEFT; // 0x20
	private static Vector2 UV_BOTTOM_CENTER_RIGHT; // 0x28
	private static Vector2 UV_TOP_RIGHT; // 0x30
	private static Vector2 UV_BOTTOM_RIGHT; // 0x38
	private static Vector2[] startUvs; // 0x40
	private static Vector2[] middleUvs; // 0x48
	private static Vector2[] endUvs; // 0x50
	private static Vector2[] fullUvs; // 0x58
	[SerializeField] // RVA: 0xDAAE0 Offset: 0xD9EE0 VA: 0x1800DAAE0
	[TooltipAttribute] // RVA: 0xDAAE0 Offset: 0xD9EE0 VA: 0x1800DAAE0
	internal List<Vector2> m_points; // 0xF0
	[SerializeField] // RVA: 0xDAE80 Offset: 0xDA280 VA: 0x1800DAE80
	[TooltipAttribute] // RVA: 0xDAE80 Offset: 0xDA280 VA: 0x1800DAE80
	internal float lineThickness; // 0xF8
	[SerializeField] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	[TooltipAttribute] // RVA: 0xDAF70 Offset: 0xDA370 VA: 0x1800DAF70
	internal bool relativeSize; // 0xFC
	[SerializeField] // RVA: 0xDB1B0 Offset: 0xDA5B0 VA: 0x1800DB1B0
	[TooltipAttribute] // RVA: 0xDB1B0 Offset: 0xDA5B0 VA: 0x1800DB1B0
	internal bool lineList; // 0xFD
	[SerializeField] // RVA: 0xDB2C0 Offset: 0xDA6C0 VA: 0x1800DB2C0
	[TooltipAttribute] // RVA: 0xDB2C0 Offset: 0xDA6C0 VA: 0x1800DB2C0
	internal bool lineCaps; // 0xFE
	[SerializeField] // RVA: 0xDB470 Offset: 0xDA870 VA: 0x1800DB470
	[TooltipAttribute] // RVA: 0xDB470 Offset: 0xDA870 VA: 0x1800DB470
	internal int bezierSegmentsPerCurve; // 0x100
	[TooltipAttribute] // RVA: 0xDB5F0 Offset: 0xDA9F0 VA: 0x1800DB5F0
	public UILineRendererList.JoinType LineJoins; // 0x104
	[TooltipAttribute] // RVA: 0xDB820 Offset: 0xDAC20 VA: 0x1800DB820
	public UILineRendererList.BezierType BezierMode; // 0x108
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool drivenExternally; // 0x10C

	public float LineThickness { get; set; }
	public bool RelativeSize { get; set; }
	public bool LineList { get; set; }
	public bool LineCaps { get; set; }
	public int BezierSegmentsPerCurve { get; set; }
	public List<Vector2> Points { get; set; }


	public float get_LineThickness() { }

	public void set_LineThickness(float value) { }

	public bool get_RelativeSize() { }

	public void set_RelativeSize(bool value) { }

	public bool get_LineList() { }

	public void set_LineList(bool value) { }

	public bool get_LineCaps() { }

	public void set_LineCaps(bool value) { }

	public int get_BezierSegmentsPerCurve() { }

	public void set_BezierSegmentsPerCurve(int value) { }

	public List<Vector2> get_Points() { }

	public void set_Points(List<Vector2> value) { }

	public void AddPoint(Vector2 pointToAdd) { }

	public void RemovePoint(Vector2 pointToRemove) { }

	public void ClearPoints() { }

	private void PopulateMesh(VertexHelper vh, List<Vector2> pointsToDraw) { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRendererList.SegmentType type) { }

	private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRendererList.SegmentType type) { }

	protected override void GeneratedUVs() { }

	protected override void ResolutionToNativeSize(float distance) { }

	public void .ctor() { }

}

private enum UILineRendererList.SegmentType // TypeDefIndex: 11723
{	public int value__; // 0x0
	public const UILineRendererList.SegmentType Start = 0;
	public const UILineRendererList.SegmentType Middle = 1;
	public const UILineRendererList.SegmentType End = 2;
	public const UILineRendererList.SegmentType Full = 3;

}

public enum UILineRendererList.JoinType // TypeDefIndex: 11724
{	public int value__; // 0x0
	public const UILineRendererList.JoinType Bevel = 0;
	public const UILineRendererList.JoinType Miter = 1;

}

public enum UILineRendererList.BezierType // TypeDefIndex: 11725
{	public int value__; // 0x0
	public const UILineRendererList.BezierType None = 0;
	public const UILineRendererList.BezierType Quick = 1;
	public const UILineRendererList.BezierType Basic = 2;
	public const UILineRendererList.BezierType Improved = 3;
	public const UILineRendererList.BezierType Catenary = 4;

}

public class UILineTextureRenderer : UIPrimitiveBase // TypeDefIndex: 11726
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Rect m_UVRect; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2[] m_points; // 0x100
	public float LineThickness; // 0x108
	public bool UseMargins; // 0x10C
	public Vector2 Margin; // 0x110
	public bool relativeSize; // 0x118

	public Rect uvRect { get; set; }
	public Vector2[] Points { get; set; }


	public Rect get_uvRect() { }

	public void set_uvRect(Rect value) { }

	public Vector2[] get_Points() { }

	public void set_Points(Vector2[] value) { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) { }

	public void .ctor() { }

}

public class UIPolygon : UIPrimitiveBase // TypeDefIndex: 11727
{	public bool fill; // 0xF0
	public float thickness; // 0xF4
	[RangeAttribute] // RVA: 0xDEF90 Offset: 0xDE390 VA: 0x1800DEF90
	public int sides; // 0xF8
	[RangeAttribute] // RVA: 0x9EEE0 Offset: 0x9E2E0 VA: 0x18009EEE0
	public float rotation; // 0xFC
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float[] VerticesDistances; // 0x100
	private float size; // 0x108


	public void DrawPolygon(int _sides) { }

	public void DrawPolygon(int _sides, float[] _VerticesDistances) { }

	public void DrawPolygon(int _sides, float[] _VerticesDistances, float _rotation) { }

	private void Update() { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	public void .ctor() { }

}

public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 11730
{	protected static Material s_ETC1DefaultUI; // 0x0
	private List<Vector2> outputList; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite m_Sprite; // 0xD0
	private Sprite m_OverrideSprite; // 0xD8
	internal float m_EventAlphaThreshold; // 0xE0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ResolutionMode m_improveResolution; // 0xE4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_Resolution; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_useNativeSize; // 0xEC

	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	protected Sprite activeSprite { get; }
	public float eventAlphaThreshold { get; set; }
	public ResolutionMode ImproveResolution { get; set; }
	public float Resoloution { get; set; }
	public bool UseNativeSize { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }


	public Sprite get_sprite() { }

	public void set_sprite(Sprite value) { }

	public Sprite get_overrideSprite() { }

	public void set_overrideSprite(Sprite value) { }

	protected Sprite get_activeSprite() { }

	public float get_eventAlphaThreshold() { }

	public void set_eventAlphaThreshold(float value) { }

	public ResolutionMode get_ImproveResolution() { }

	public void set_ImproveResolution(ResolutionMode value) { }

	public float get_Resoloution() { }

	public void set_Resoloution(float value) { }

	public bool get_UseNativeSize() { }

	public void set_UseNativeSize(bool value) { }

	protected void .ctor() { }

	public static Material get_defaultETC1GraphicMaterial() { }

	public override Texture get_mainTexture() { }

	public bool get_hasBorder() { }

	public float get_pixelsPerUnit() { }

	public override Material get_material() { }

	public override void set_material(Material value) { }

	protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs) { }

	protected Vector2[] IncreaseResolution(Vector2[] input) { }

	protected List<Vector2> IncreaseResolution(List<Vector2> input) { }

	protected virtual void GeneratedUVs() { }

	protected virtual void ResolutionToNativeSize(float distance) { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual float get_minWidth() { }

	public virtual float get_preferredWidth() { }

	public virtual float get_flexibleWidth() { }

	public virtual float get_minHeight() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_flexibleHeight() { }

	public virtual int get_layoutPriority() { }

	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	private Vector4 GetAdjustedBorders(Vector4 border, Rect rect) { }

	protected override void OnEnable() { }

	private static void .cctor() { }

}

public class UIRing : UIPrimitiveBase // TypeDefIndex: 11731
{	public float innerRadius; // 0xF0
	public float outerRadius; // 0xF4
	[TooltipAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	[RangeAttribute] // RVA: 0xD9880 Offset: 0xD8C80 VA: 0x1800D9880
	public int ArcSteps; // 0xF8
	private List<int> indices; // 0x100
	private List<UIVertex> vertices; // 0x108


	protected override void OnPopulateMesh(VertexHelper vh) { }

	public void SetArcSteps(int steps) { }

	public void SetBaseColor(Color color) { }

	public void UpdateBaseAlpha(float value) { }

	public void .ctor() { }

}

internal interface IAmbientOcclusionMethod // TypeDefIndex: 11757
{
	public abstract DepthTextureMode GetCameraFlags();

	public abstract void RenderAfterOpaque(PostProcessRenderContext context);

	public abstract void RenderAmbientOnly(PostProcessRenderContext context);

	public abstract void CompositeAmbientOnly(PostProcessRenderContext context);

	public abstract void Release();

}

public class UI : ConsoleSystem // TypeDefIndex: 11967
{	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool showinventoryplayer; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool autoswitchchannel; // 0x1


	public void .ctor() { }

	private static void .cctor() { }

}

public interface VirtualScroll.IDataSource // TypeDefIndex: 11998
{
	public abstract int GetItemCount();

	public abstract void SetItemData(int i, GameObject obj);

}

public interface IGenericLerpTarget<T> : ILerpInfo // TypeDefIndex: 12115
{
	public abstract void SetFrom(T snapshot);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericLerpTarget<object>.SetFrom
	*/

	public abstract T GetCurrentState();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericLerpTarget<object>.GetCurrentState
	*/

	public abstract void DebugInterpolationState(Interpolator.Segment<T> segment, List<T> entries);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericLerpTarget<object>.DebugInterpolationState
	*/

}

public interface ISnapshot<T> // TypeDefIndex: 12117
{	public abstract float Time { get; set; }


	public abstract float get_Time();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.get_Time
	*/

	public abstract void set_Time(float value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.set_Time
	*/

	public abstract void MatchValuesTo(T entry);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.MatchValuesTo
	*/

	public abstract void Lerp(T prev, T next, float delta);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.Lerp
	*/

	public abstract T GetNew();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISnapshot<object>.GetNew
	*/

}

