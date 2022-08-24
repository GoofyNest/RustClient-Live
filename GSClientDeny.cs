internal struct GSClientDeny_t : ICallbackData // TypeDefIndex: 5491
{
	internal ulong SteamID; 
	internal DenyReason DenyReason; 
	internal byte[] OptionalText; 
	public static int _datasize; 

public int DataSize { get; }
public CallbackType CallbackType { get; }


public int get_DataSize() { }

public CallbackType get_CallbackType() { }

private static void .cctor() { }

}

