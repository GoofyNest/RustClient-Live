internal class ActivityTracker // TypeDefIndex: 1592
{	// Fields
	private AsyncLocal<ActivityTracker.ActivityInfo> m_current; // 0x10
	private bool m_checkedForEnable; // 0x18
	private static ActivityTracker s_activityTrackerInstance; // 0x0
	private static long m_nextId; // 0x8

	// Properties
	public static ActivityTracker Instance { get; }

	// Methods

	// RVA: 0xD626A0 Offset: 0xD61AA0 VA: 0x180D626A0
	public void OnStart(string providerName, string activityName, int task, ref Guid activityId, ref Guid relatedActivityId, EventActivityOptions options) { }

	// RVA: 0xD62C40 Offset: 0xD62040 VA: 0x180D62C40
	public void OnStop(string providerName, string activityName, int task, ref Guid activityId) { }

	// RVA: 0xD624C0 Offset: 0xD618C0 VA: 0x180D624C0
	public void Enable() { }

	// RVA: 0xD63010 Offset: 0xD62410 VA: 0x180D63010
	public static ActivityTracker get_Instance() { }

	// RVA: 0xD62560 Offset: 0xD61960 VA: 0x180D62560
	private ActivityTracker.ActivityInfo FindActiveActivity(string name, ActivityTracker.ActivityInfo startLocation) { }

	// RVA: 0xD625C0 Offset: 0xD619C0 VA: 0x180D625C0
	private string NormalizeActivityName(string providerName, string activityName, int task) { }

	// RVA: 0xD623B0 Offset: 0xD617B0 VA: 0x180D623B0
	private void ActivityChanging(AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo> args) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xD62FA0 Offset: 0xD623A0 VA: 0x180D62FA0
	private static void .cctor() { }

}

private class ActivityTracker.ActivityInfo // TypeDefIndex: 1593
{	// Fields
	internal readonly string m_name; // 0x10
	private readonly long m_uniqueId; // 0x18
	internal readonly Guid m_guid; // 0x20
	internal readonly int m_activityPathGuidOffset; // 0x30
	internal readonly int m_level; // 0x34
	internal readonly EventActivityOptions m_eventOptions; // 0x38
	internal long m_lastChildID; // 0x40
	internal int m_stopped; // 0x48
	internal readonly ActivityTracker.ActivityInfo m_creator; // 0x50
	internal readonly Guid m_activityIdToRestore; // 0x58

	// Properties
	public Guid ActivityId { get; }

	// Methods

	// RVA: 0xD62270 Offset: 0xD61670 VA: 0x180D62270
	public void .ctor(string name, long uniqueId, ActivityTracker.ActivityInfo creator, Guid activityIDToRestore, EventActivityOptions options) { }

	// RVA: 0xD623A0 Offset: 0xD617A0 VA: 0x180D623A0
	public Guid get_ActivityId() { }

	// RVA: 0xD61F10 Offset: 0xD61310 VA: 0x180D61F10
	public static string Path(ActivityTracker.ActivityInfo activityInfo) { }

	// RVA: 0xD61FA0 Offset: 0xD613A0 VA: 0x180D61FA0 Slot: 3
	public override string ToString() { }

	// RVA: 0xD61E90 Offset: 0xD61290 VA: 0x180D61E90
	public static string LiveActivities(ActivityTracker.ActivityInfo list) { }

	// RVA: 0xD61D40 Offset: 0xD61140 VA: 0x180D61D40
	public bool CanBeOrphan() { }

	// RVA: 0xD61D50 Offset: 0xD61150 VA: 0x180D61D50
	private void CreateActivityPathGuid(out Guid idRet, out int activityPathGuidOffset) { }

	// RVA: 0xD61E20 Offset: 0xD61220 VA: 0x180D61E20
	private void CreateOverflowGuid(Guid* outPtr) { }

	// RVA: 0xD61C10 Offset: 0xD61010 VA: 0x180D61C10
	private static int AddIdToGuid(Guid* outPtr, int whereToAddId, uint id, bool overflow = False) { }

	// RVA: 0xD62250 Offset: 0xD61650 VA: 0x180D62250
	private static void WriteNibble(ref byte* ptr, byte* endPtr, uint value) { }

}

