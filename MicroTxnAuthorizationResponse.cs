internal struct MicroTxnAuthorizationResponse_t : ICallbackData // TypeDefIndex: 5306
{
	internal uint AppID; 
	internal ulong OrderID; 
	internal byte Authorized; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

