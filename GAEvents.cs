internal class GAEvents // TypeDefIndex: 5674
{	// Fields
	private static readonly GAEvents _instance; // 0x0
	private bool isRunning; // 0x10
	private bool keepRunning; // 0x11

	// Properties
	private static GAEvents Instance { get; }

	// Methods

	// RVA: 0x13AFED0 Offset: 0x13AF2D0 VA: 0x1813AFED0
	private static GAEvents get_Instance() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x13AFB80 Offset: 0x13AEF80 VA: 0x1813AFB80
	public static void StopEventQueue() { }

	// RVA: 0x13ADE80 Offset: 0x13AD280 VA: 0x1813ADE80
	public static void EnsureEventQueueIsRunning() { }

	// RVA: 0x13ADBE0 Offset: 0x13ACFE0 VA: 0x1813ADBE0
	public static void AddSessionStartEvent() { }

	// RVA: 0x13AD9B0 Offset: 0x13ACDB0 VA: 0x1813AD9B0
	public static void AddSessionEndEvent() { }

	// RVA: 0x13AC0D0 Offset: 0x13AB4D0 VA: 0x1813AC0D0
	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType, IDictionary<string, object> fields) { }

	// RVA: 0x13AC950 Offset: 0x13ABD50 VA: 0x1813AC950
	public static void AddDesignEvent(string eventId, double value, bool sendValue, IDictionary<string, object> fields) { }

	// RVA: 0x13AE530 Offset: 0x13AD930 VA: 0x1813AE530
	private static void ProcessEventQueue() { }

	// RVA: 0x13AE6C0 Offset: 0x13ADAC0 VA: 0x1813AE6C0
	private static void ProcessEvents(string category, bool performCleanUp) { }

	// RVA: 0x13AF630 Offset: 0x13AEA30 VA: 0x1813AF630
	public static void ProcessEvents(EGAHTTPApiResponse responseEnum, JSONNode dataDict, string putbackSql, string deleteSql, int eventCount) { }

	// RVA: 0x13ADE30 Offset: 0x13AD230 VA: 0x1813ADE30
	private static void CleanupEvents() { }

	// RVA: 0x13AE070 Offset: 0x13AD470 VA: 0x1813AE070
	private static void FixMissingSessionEndEvents() { }

	// RVA: 0x13ACFC0 Offset: 0x13AC3C0 VA: 0x1813ACFC0
	private static void AddEventToStore(JSONObject eventData) { }

	// RVA: 0x13ACDD0 Offset: 0x13AC1D0 VA: 0x1813ACDD0
	private static void AddDimensionsToEvent(JSONObject eventData) { }

	// RVA: 0x13AD910 Offset: 0x13ACD10 VA: 0x1813AD910
	private static void AddFieldsToEvent(JSONObject eventData, JSONObject fields) { }

	// RVA: 0x13AFC30 Offset: 0x13AF030 VA: 0x1813AFC30
	private static void UpdateSessionTime() { }

	// RVA: 0x13AFE70 Offset: 0x13AF270 VA: 0x1813AFE70
	private static void .cctor() { }

}

