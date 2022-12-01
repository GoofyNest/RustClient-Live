public sealed class LobbyDetails : Handle // TypeDefIndex: 9132
{
	public const int LobbydetailsCopyattributebyindexApiLatest = 1;
	public const int LobbydetailsCopyattributebykeyApiLatest = 1;
	public const int LobbydetailsCopyinfoApiLatest = 1;
	public const int LobbydetailsCopymemberattributebyindexApiLatest = 1;
	public const int LobbydetailsCopymemberattributebykeyApiLatest = 1;
	public const int LobbydetailsGetattributecountApiLatest = 1;
	public const int LobbydetailsGetlobbyownerApiLatest = 1;
	public const int LobbydetailsGetmemberattributecountApiLatest = 1;
	public const int LobbydetailsGetmemberbyindexApiLatest = 1;
	public const int LobbydetailsGetmembercountApiLatest = 1;
	public const int LobbydetailsInfoApiLatest = 2;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyAttributeByIndex(ref LobbyDetailsCopyAttributeByIndexOptions options, out Nullable<Attribute> outAttribute) { }

	public Result CopyAttributeByKey(ref LobbyDetailsCopyAttributeByKeyOptions options, out Nullable<Attribute> outAttribute) { }

	public Result CopyInfo(ref LobbyDetailsCopyInfoOptions options, out Nullable<LobbyDetailsInfo> outLobbyDetailsInfo) { }

	public Result CopyMemberAttributeByIndex(ref LobbyDetailsCopyMemberAttributeByIndexOptions options, out Nullable<Attribute> outAttribute) { }

	public Result CopyMemberAttributeByKey(ref LobbyDetailsCopyMemberAttributeByKeyOptions options, out Nullable<Attribute> outAttribute) { }

	public uint GetAttributeCount(ref LobbyDetailsGetAttributeCountOptions options) { }

	public ProductUserId GetLobbyOwner(ref LobbyDetailsGetLobbyOwnerOptions options) { }

	public uint GetMemberAttributeCount(ref LobbyDetailsGetMemberAttributeCountOptions options) { }

	public ProductUserId GetMemberByIndex(ref LobbyDetailsGetMemberByIndexOptions options) { }

	public uint GetMemberCount(ref LobbyDetailsGetMemberCountOptions options) { }

	public void Release() { }

}

