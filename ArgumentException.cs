public class ArgumentException : SystemException, ISerializable // TypeDefIndex: 166
{
	private string m_paramName;

	public override string Message { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception innerException) { }

	public void .ctor(string message, string paramName, Exception innerException) { }

	public void .ctor(string message, string paramName) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentNullException : ArgumentException // TypeDefIndex: 167
{

	public void .ctor() { }

	public void .ctor(string paramName) { }

	public void .ctor(string paramName, string message) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentOutOfRangeException : ArgumentException, ISerializable // TypeDefIndex: 168
{
	private static string _rangeMessage;
	private object m_actualValue;

	private static string RangeMessage { get; }
	public override string Message { get; }


	private static string get_RangeMessage() { }

	public void .ctor() { }

	public void .ctor(string paramName) { }

	public void .ctor(string paramName, string message) { }

	public void .ctor(string paramName, object actualValue, string message) { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public struct ArgIterator // TypeDefIndex: 347
{
	private IntPtr sig;
	private IntPtr args;
	private int next_arg;
	private int num_args;


	public override bool Equals(object o) { }

	public override int GetHashCode() { }

}

internal enum ArgInfoType // TypeDefIndex: 1221
{
	public byte value__;
	public const ArgInfoType In = 0;
	public const ArgInfoType Out = 1;

}

internal class ArgInfo // TypeDefIndex: 1222
{
	private int[] _paramMap;
	private int _inoutArgCount;
	private MethodBase _method;


	public void .ctor(MethodBase method, ArgInfoType type) { }

	public object[] GetInOutArgs(object[] args) { }

}

internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 3629
{
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private Object m_ObjectArgument;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private string m_ObjectArgumentAssemblyTypeName;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private int m_IntArgument;
	[SerializeField]
	[FormerlySerializedAsAttribute]
	private float m_FloatArgument;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private string m_StringArgument;
	[SerializeField]
	private bool m_BoolArgument;

	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }


	public Object get_unityObjectArgument() { }

	public string get_unityObjectArgumentAssemblyTypeName() { }

	public int get_intArgument() { }

	public float get_floatArgument() { }

	public string get_stringArgument() { }

	public bool get_boolArgument() { }

	private void TidyAssemblyTypeName() { }

	public void OnBeforeSerialize() { }

	public void OnAfterDeserialize() { }

	public void .ctor() { }

}

public static class ArgEx // TypeDefIndex: 13500
{

	[ExtensionAttribute]
	public static BasePlayer GetPlayer_Clientside(ConsoleSystem.Arg arg, int iArgNum) { }

}

