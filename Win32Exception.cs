public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 2772
{	// Fields
	private readonly int nativeErrorCode; // 0x88
	private static bool s_ErrorMessagesInitialized; // 0x0
	private static Dictionary<int, string> s_ErrorMessage; // 0x8

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x173DF70 Offset: 0x173D370 VA: 0x18173DF70
	public void .ctor() { }

	// RVA: 0x173DDD0 Offset: 0x173D1D0 VA: 0x18173DDD0
	public void .ctor(int error) { }

	// RVA: 0x173DF40 Offset: 0x173D340 VA: 0x18173DF40
	public void .ctor(int error, string message) { }

	// RVA: 0x173E120 Offset: 0x173D520 VA: 0x18173E120
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0
	public int get_NativeErrorCode() { }

	// RVA: 0x173C8C0 Offset: 0x173BCC0 VA: 0x18173C8C0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x173C7B0 Offset: 0x173BBB0 VA: 0x18173C7B0
	internal static string GetErrorMessage(int error) { }

	// RVA: 0x173C970 Offset: 0x173BD70 VA: 0x18173C970
	private static void InitializeErrorMessages() { }

	// RVA: 0x173DD50 Offset: 0x173D150 VA: 0x18173DD50
	private static void .cctor() { }

}

