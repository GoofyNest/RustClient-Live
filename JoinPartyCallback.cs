internal struct JoinPartyCallback_t : ICallbackData // TypeDefIndex: 5355
{	internal Result Result; // 0x0
	internal ulong BeaconID; // 0x8
	internal ulong SteamIDBeaconOwner; // 0x10
	internal byte[] ConnectString; // 0x18
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

