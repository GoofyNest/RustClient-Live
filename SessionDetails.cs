public sealed class SessionDetails : Handle // TypeDefIndex: 8538
{
	public const int SessiondetailsAttributeApiLatest = 1;
	public const int SessiondetailsCopyinfoApiLatest = 1;
	public const int SessiondetailsCopysessionattributebyindexApiLatest = 1;
	public const int SessiondetailsCopysessionattributebykeyApiLatest = 1;
	public const int SessiondetailsGetsessionattributecountApiLatest = 1;
	public const int SessiondetailsInfoApiLatest = 1;
	public const int SessiondetailsSettingsApiLatest = 3;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyInfo(ref SessionDetailsCopyInfoOptions options, out Nullable<SessionDetailsInfo> outSessionInfo) { }

	public Result CopySessionAttributeByIndex(ref SessionDetailsCopySessionAttributeByIndexOptions options, out Nullable<SessionDetailsAttribute> outSessionAttribute) { }

	public Result CopySessionAttributeByKey(ref SessionDetailsCopySessionAttributeByKeyOptions options, out Nullable<SessionDetailsAttribute> outSessionAttribute) { }

	public uint GetSessionAttributeCount(ref SessionDetailsGetSessionAttributeCountOptions options) { }

	public void Release() { }

}

