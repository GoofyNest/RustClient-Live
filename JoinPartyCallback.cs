internal struct JoinPartyCallback_t : ICallbackData // TypeDefIndex: 5355
{
	internal Result Result; 
	internal ulong BeaconID; 
	internal ulong SteamIDBeaconOwner; 
	internal byte[] ConnectString; 
	public static int _datasize; 

public int DataSize { get; }
public CallbackType CallbackType { get; }


public int get_DataSize() { }

public CallbackType get_CallbackType() { }

private static void .cctor() { }

}

