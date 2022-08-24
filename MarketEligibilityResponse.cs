internal struct MarketEligibilityResponse_t : ICallbackData // TypeDefIndex: 5305
{
	internal bool Allowed; 
	internal MarketNotAllowedReasonFlags NotAllowedReason; 
	internal uint TAllowedAtTime; 
	internal int CdaySteamGuardRequiredDays; 
	internal int CdayNewDeviceCooldown; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

