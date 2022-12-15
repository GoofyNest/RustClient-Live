public sealed class SanctionsInterface : Handle // TypeDefIndex: 8635
{
	public const int CopyplayersanctionbyindexApiLatest = 1;
	public const int GetplayersanctioncountApiLatest = 1;
	public const int PlayersanctionApiLatest = 2;
	public const int QueryactiveplayersanctionsApiLatest = 2;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyPlayerSanctionByIndex(ref CopyPlayerSanctionByIndexOptions options, out Nullable<PlayerSanction> outSanction) { }

	public uint GetPlayerSanctionCount(ref GetPlayerSanctionCountOptions options) { }

	public void QueryActivePlayerSanctions(ref QueryActivePlayerSanctionsOptions options, object clientData, OnQueryActivePlayerSanctionsCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnQueryActivePlayerSanctionsCallbackInternalImplementation(ref QueryActivePlayerSanctionsCallbackInfoInternal data) { }

}

