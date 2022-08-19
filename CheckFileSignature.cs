public enum CheckFileSignature // TypeDefIndex: 5151
{	// Fields
	public int value__; // 0x0
	public const CheckFileSignature InvalidSignature = 0;
	public const CheckFileSignature ValidSignature = 1;
	public const CheckFileSignature FileNotFound = 2;
	public const CheckFileSignature NoSignaturesFoundForThisApp = 3;
	public const CheckFileSignature NoSignaturesFoundForThisFile = 4;

}

internal struct CheckFileSignature_t : ICallbackData // TypeDefIndex: 5331
{	// Fields
	internal CheckFileSignature CheckFileSignature; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E44B0 Offset: 0x1E38B0 VA: 0x1801E44B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E44A0 Offset: 0x1E38A0 VA: 0x1801E44A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1368BF0 Offset: 0x1367FF0 VA: 0x181368BF0
	private static void .cctor() { }

}

