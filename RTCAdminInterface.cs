public sealed class RTCAdminInterface : Handle // TypeDefIndex: 8752
{
	public const int CopyusertokenbyindexApiLatest = 2;
	public const int CopyusertokenbyuseridApiLatest = 2;
	public const int KickApiLatest = 1;
	public const int QueryjoinroomtokenApiLatest = 2;
	public const int SetparticipanthardmuteApiLatest = 1;
	public const int UsertokenApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyUserTokenByIndex(ref CopyUserTokenByIndexOptions options, out Nullable<UserToken> outUserToken) { }

	public Result CopyUserTokenByUserId(ref CopyUserTokenByUserIdOptions options, out Nullable<UserToken> outUserToken) { }

	public void Kick(ref KickOptions options, object clientData, OnKickCompleteCallback completionDelegate) { }

	public void QueryJoinRoomToken(ref QueryJoinRoomTokenOptions options, object clientData, OnQueryJoinRoomTokenCompleteCallback completionDelegate) { }

	public void SetParticipantHardMute(ref SetParticipantHardMuteOptions options, object clientData, OnSetParticipantHardMuteCompleteCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnKickCompleteCallbackInternalImplementation(ref KickCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryJoinRoomTokenCompleteCallbackInternalImplementation(ref QueryJoinRoomTokenCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnSetParticipantHardMuteCompleteCallbackInternalImplementation(ref SetParticipantHardMuteCompleteCallbackInfoInternal data) { }

}

