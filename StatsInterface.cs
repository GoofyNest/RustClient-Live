public sealed class StatsInterface : Handle // TypeDefIndex: 8448
{
	public const int CopystatbyindexApiLatest = 1;
	public const int CopystatbynameApiLatest = 1;
	public const int GetstatcountApiLatest = 1;
	public const int GetstatscountApiLatest = 1;
	public const int IngestdataApiLatest = 1;
	public const int IngeststatApiLatest = 3;
	public const int MaxIngestStats = 3000;
	public const int MaxQueryStats = 1000;
	public const int QuerystatsApiLatest = 3;
	public const int StatApiLatest = 1;
	public const int TimeUndefined = -1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyStatByIndex(ref CopyStatByIndexOptions options, out Nullable<Stat> outStat) { }

	public Result CopyStatByName(ref CopyStatByNameOptions options, out Nullable<Stat> outStat) { }

	public uint GetStatsCount(ref GetStatCountOptions options) { }

	public void IngestStat(ref IngestStatOptions options, object clientData, OnIngestStatCompleteCallback completionDelegate) { }

	public void QueryStats(ref QueryStatsOptions options, object clientData, OnQueryStatsCompleteCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnIngestStatCompleteCallbackInternalImplementation(ref IngestStatCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryStatsCompleteCallbackInternalImplementation(ref OnQueryStatsCompleteCallbackInfoInternal data) { }

}

