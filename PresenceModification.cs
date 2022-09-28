public sealed class PresenceModification : Handle // TypeDefIndex: 8800
{
	public const int PresencemodificationDatarecordidApiLatest = 1;
	public const int PresencemodificationDeletedataApiLatest = 1;
	public const int PresencemodificationJoininfoMaxLength = 255;
	public const int PresencemodificationSetdataApiLatest = 1;
	public const int PresencemodificationSetjoininfoApiLatest = 1;
	public const int PresencemodificationSetrawrichtextApiLatest = 1;
	public const int PresencemodificationSetstatusApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result DeleteData(ref PresenceModificationDeleteDataOptions options) { }

	public void Release() { }

	public Result SetData(ref PresenceModificationSetDataOptions options) { }

	public Result SetJoinInfo(ref PresenceModificationSetJoinInfoOptions options) { }

	public Result SetRawRichText(ref PresenceModificationSetRawRichTextOptions options) { }

	public Result SetStatus(ref PresenceModificationSetStatusOptions options) { }

}

