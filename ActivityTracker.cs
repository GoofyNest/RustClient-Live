internal class ActivityTracker // TypeDefIndex: 1592
{	private AsyncLocal<ActivityTracker.ActivityInfo> m_current; // 0x10
	private bool m_checkedForEnable; // 0x18
	private static ActivityTracker s_activityTrackerInstance; // 0x0
	private static long m_nextId; // 0x8

	public static ActivityTracker Instance { get; }


	public void OnStart(string providerName, string activityName, int task, ref Guid activityId, ref Guid relatedActivityId, EventActivityOptions options) { }

	public void OnStop(string providerName, string activityName, int task, ref Guid activityId) { }

	public void Enable() { }

	public static ActivityTracker get_Instance() { }

	private ActivityTracker.ActivityInfo FindActiveActivity(string name, ActivityTracker.ActivityInfo startLocation) { }

	private string NormalizeActivityName(string providerName, string activityName, int task) { }

	private void ActivityChanging(AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo> args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class ActivityTracker.ActivityInfo // TypeDefIndex: 1593
{	internal readonly string m_name; // 0x10
	private readonly long m_uniqueId; // 0x18
	internal readonly Guid m_guid; // 0x20
	internal readonly int m_activityPathGuidOffset; // 0x30
	internal readonly int m_level; // 0x34
	internal readonly EventActivityOptions m_eventOptions; // 0x38
	internal long m_lastChildID; // 0x40
	internal int m_stopped; // 0x48
	internal readonly ActivityTracker.ActivityInfo m_creator; // 0x50
	internal readonly Guid m_activityIdToRestore; // 0x58

	public Guid ActivityId { get; }


	public void .ctor(string name, long uniqueId, ActivityTracker.ActivityInfo creator, Guid activityIDToRestore, EventActivityOptions options) { }

	public Guid get_ActivityId() { }

	public static string Path(ActivityTracker.ActivityInfo activityInfo) { }

	public override string ToString() { }

	public static string LiveActivities(ActivityTracker.ActivityInfo list) { }

	public bool CanBeOrphan() { }

	private void CreateActivityPathGuid(out Guid idRet, out int activityPathGuidOffset) { }

	private void CreateOverflowGuid(Guid* outPtr) { }

	private static int AddIdToGuid(Guid* outPtr, int whereToAddId, uint id, bool overflow = False) { }

	private static void WriteNibble(ref byte* ptr, byte* endPtr, uint value) { }

}

