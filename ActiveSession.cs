public sealed class ActiveSession : Handle // TypeDefIndex: 8405
{
	public const int ActivesessionCopyinfoApiLatest = 1;
	public const int ActivesessionGetregisteredplayerbyindexApiLatest = 1;
	public const int ActivesessionGetregisteredplayercountApiLatest = 1;
	public const int ActivesessionInfoApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyInfo(ref ActiveSessionCopyInfoOptions options, out Nullable<ActiveSessionInfo> outActiveSessionInfo) { }

	public ProductUserId GetRegisteredPlayerByIndex(ref ActiveSessionGetRegisteredPlayerByIndexOptions options) { }

	public uint GetRegisteredPlayerCount(ref ActiveSessionGetRegisteredPlayerCountOptions options) { }

	public void Release() { }

}

