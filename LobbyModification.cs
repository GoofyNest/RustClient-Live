public sealed class LobbyModification : Handle // TypeDefIndex: 9156
{
	public const int LobbymodificationAddattributeApiLatest = 1;
	public const int LobbymodificationAddmemberattributeApiLatest = 1;
	public const int LobbymodificationMaxAttributeLength = 64;
	public const int LobbymodificationMaxAttributes = 64;
	public const int LobbymodificationRemoveattributeApiLatest = 1;
	public const int LobbymodificationRemovememberattributeApiLatest = 1;
	public const int LobbymodificationSetbucketidApiLatest = 1;
	public const int LobbymodificationSetinvitesallowedApiLatest = 1;
	public const int LobbymodificationSetmaxmembersApiLatest = 1;
	public const int LobbymodificationSetpermissionlevelApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result AddAttribute(ref LobbyModificationAddAttributeOptions options) { }

	public Result AddMemberAttribute(ref LobbyModificationAddMemberAttributeOptions options) { }

	public void Release() { }

	public Result RemoveAttribute(ref LobbyModificationRemoveAttributeOptions options) { }

	public Result RemoveMemberAttribute(ref LobbyModificationRemoveMemberAttributeOptions options) { }

	public Result SetBucketId(ref LobbyModificationSetBucketIdOptions options) { }

	public Result SetInvitesAllowed(ref LobbyModificationSetInvitesAllowedOptions options) { }

	public Result SetMaxMembers(ref LobbyModificationSetMaxMembersOptions options) { }

	public Result SetPermissionLevel(ref LobbyModificationSetPermissionLevelOptions options) { }

}

