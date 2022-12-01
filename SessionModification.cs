public sealed class SessionModification : Handle // TypeDefIndex: 8568
{
	public const int SessionmodificationAddattributeApiLatest = 1;
	public const int SessionmodificationMaxSessionAttributeLength = 64;
	public const int SessionmodificationMaxSessionAttributes = 64;
	public const int SessionmodificationMaxSessionidoverrideLength = 64;
	public const int SessionmodificationMinSessionidoverrideLength = 16;
	public const int SessionmodificationRemoveattributeApiLatest = 1;
	public const int SessionmodificationSetbucketidApiLatest = 1;
	public const int SessionmodificationSethostaddressApiLatest = 1;
	public const int SessionmodificationSetinvitesallowedApiLatest = 1;
	public const int SessionmodificationSetjoininprogressallowedApiLatest = 1;
	public const int SessionmodificationSetmaxplayersApiLatest = 1;
	public const int SessionmodificationSetpermissionlevelApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result AddAttribute(ref SessionModificationAddAttributeOptions options) { }

	public void Release() { }

	public Result RemoveAttribute(ref SessionModificationRemoveAttributeOptions options) { }

	public Result SetBucketId(ref SessionModificationSetBucketIdOptions options) { }

	public Result SetHostAddress(ref SessionModificationSetHostAddressOptions options) { }

	public Result SetInvitesAllowed(ref SessionModificationSetInvitesAllowedOptions options) { }

	public Result SetJoinInProgressAllowed(ref SessionModificationSetJoinInProgressAllowedOptions options) { }

	public Result SetMaxPlayers(ref SessionModificationSetMaxPlayersOptions options) { }

	public Result SetPermissionLevel(ref SessionModificationSetPermissionLevelOptions options) { }

}

