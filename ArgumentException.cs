public class ArgumentException : SystemException, ISerializable // TypeDefIndex: 166
{	// Fields
	private string m_paramName; // 0x88

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1580CD0 Offset: 0x15800D0 VA: 0x181580CD0
	public void .ctor() { }

	// RVA: 0x1580D80 Offset: 0x1580180 VA: 0x181580D80
	public void .ctor(string message) { }

	// RVA: 0x1580BC0 Offset: 0x157FFC0 VA: 0x181580BC0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1580D30 Offset: 0x1580130 VA: 0x181580D30
	public void .ctor(string message, string paramName, Exception innerException) { }

	// RVA: 0x1580BF0 Offset: 0x157FFF0 VA: 0x181580BF0
	public void .ctor(string message, string paramName) { }

	// RVA: 0x1580C40 Offset: 0x1580040 VA: 0x181580C40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1580DB0 Offset: 0x15801B0 VA: 0x181580DB0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1580AD0 Offset: 0x157FED0 VA: 0x181580AD0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentNullException : ArgumentException // TypeDefIndex: 167
{	// Methods

	// RVA: 0x1580EC0 Offset: 0x15802C0 VA: 0x181580EC0
	public void .ctor() { }

	// RVA: 0x1580F90 Offset: 0x1580390 VA: 0x181580F90
	public void .ctor(string paramName) { }

	// RVA: 0x1580F30 Offset: 0x1580330 VA: 0x181580F30
	public void .ctor(string paramName, string message) { }

	// RVA: 0x1580C40 Offset: 0x1580040 VA: 0x181580C40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class ArgumentOutOfRangeException : ArgumentException, ISerializable // TypeDefIndex: 168
{	// Fields
	private static string _rangeMessage; // 0x0
	private object m_actualValue; // 0x90

	// Properties
	private static string RangeMessage { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1581650 Offset: 0x1580A50 VA: 0x181581650
	private static string get_RangeMessage() { }

	// RVA: 0x1581190 Offset: 0x1580590 VA: 0x181581190
	public void .ctor() { }

	// RVA: 0x1581240 Offset: 0x1580640 VA: 0x181581240
	public void .ctor(string paramName) { }

	// RVA: 0x15811E0 Offset: 0x15805E0 VA: 0x1815811E0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x15813C0 Offset: 0x15807C0 VA: 0x1815813C0
	public void .ctor(string paramName, object actualValue, string message) { }

	// RVA: 0x1581440 Offset: 0x1580840 VA: 0x181581440 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1581020 Offset: 0x1580420 VA: 0x181581020 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15812B0 Offset: 0x15806B0 VA: 0x1815812B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public struct ArgIterator // TypeDefIndex: 347
{	// Fields
	private IntPtr sig; // 0x0
	private IntPtr args; // 0x8
	private int next_arg; // 0x10
	private int num_args; // 0x14

	// Methods

	// RVA: 0x1F2450 Offset: 0x1F1850 VA: 0x1801F2450 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360 Slot: 2
	public override int GetHashCode() { }

}

internal enum ArgInfoType // TypeDefIndex: 1221
{	// Fields
	public byte value__; // 0x0
	public const ArgInfoType In = 0;
	public const ArgInfoType Out = 1;

}

internal class ArgInfo // TypeDefIndex: 1222
{	// Fields
	private int[] _paramMap; // 0x10
	private int _inoutArgCount; // 0x18
	private MethodBase _method; // 0x20

	// Methods

	// RVA: 0x1468F60 Offset: 0x1468360 VA: 0x181468F60
	public void .ctor(MethodBase method, ArgInfoType type) { }

	// RVA: 0x1468E40 Offset: 0x1468240 VA: 0x181468E40
	public object[] GetInOutArgs(object[] args) { }

}

internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 3626
{	// Fields
	[SerializeField] // RVA: 0xDEF50 Offset: 0xDE350 VA: 0x1800DEF50
	[FormerlySerializedAsAttribute] // RVA: 0xDEF50 Offset: 0xDE350 VA: 0x1800DEF50
	private Object m_ObjectArgument; // 0x10
	[SerializeField] // RVA: 0xDF0A0 Offset: 0xDE4A0 VA: 0x1800DF0A0
	[FormerlySerializedAsAttribute] // RVA: 0xDF0A0 Offset: 0xDE4A0 VA: 0x1800DF0A0
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0xDF1B0 Offset: 0xDE5B0 VA: 0x1800DF1B0
	[SerializeField] // RVA: 0xDF1B0 Offset: 0xDE5B0 VA: 0x1800DF1B0
	private int m_IntArgument; // 0x20
	[SerializeField] // RVA: 0xDF380 Offset: 0xDE780 VA: 0x1800DF380
	[FormerlySerializedAsAttribute] // RVA: 0xDF380 Offset: 0xDE780 VA: 0x1800DF380
	private float m_FloatArgument; // 0x24
	[FormerlySerializedAsAttribute] // RVA: 0xDF3C0 Offset: 0xDE7C0 VA: 0x1800DF3C0
	[SerializeField] // RVA: 0xDF3C0 Offset: 0xDE7C0 VA: 0x1800DF3C0
	private string m_StringArgument; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }

	// Methods

	// RVA: 0x1818780 Offset: 0x1817B80 VA: 0x181818780
	public Object get_unityObjectArgument() { }

	// RVA: 0x1818770 Offset: 0x1817B70 VA: 0x181818770
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x1818750 Offset: 0x1817B50 VA: 0x181818750
	public int get_intArgument() { }

	// RVA: 0x1818740 Offset: 0x1817B40 VA: 0x181818740
	public float get_floatArgument() { }

	// RVA: 0x1818760 Offset: 0x1817B60 VA: 0x181818760
	public string get_stringArgument() { }

	// RVA: 0x1818730 Offset: 0x1817B30 VA: 0x181818730
	public bool get_boolArgument() { }

	// RVA: 0x1818540 Offset: 0x1817940 VA: 0x181818540
	private void TidyAssemblyTypeName() { }

	// RVA: 0x1818530 Offset: 0x1817930 VA: 0x181818530 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1818530 Offset: 0x1817930 VA: 0x181818530 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public static class ArgEx // TypeDefIndex: 11691
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9CB7E0 Offset: 0x9CABE0 VA: 0x1809CB7E0
	public static BasePlayer GetPlayer_Clientside(ConsoleSystem.Arg arg, int iArgNum) { }

}

