public enum CheckFileSignature // TypeDefIndex: 5151
{
	public int value__; 
	public const CheckFileSignature InvalidSignature = 0;
	public const CheckFileSignature ValidSignature = 1;
	public const CheckFileSignature FileNotFound = 2;
	public const CheckFileSignature NoSignaturesFoundForThisApp = 3;
	public const CheckFileSignature NoSignaturesFoundForThisFile = 4;

}

internal struct CheckFileSignature_t : ICallbackData // TypeDefIndex: 5331
{
	internal CheckFileSignature CheckFileSignature; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

