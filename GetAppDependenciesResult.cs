internal struct GetAppDependenciesResult_t : ICallbackData // TypeDefIndex: 5446
{
	internal Result Result; 
	internal PublishedFileId PublishedFileId; 
	internal AppId[] GAppIDs; 
	internal uint NumAppDependencies; 
	internal uint TotalNumAppDependencies; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

