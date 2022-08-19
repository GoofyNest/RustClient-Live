public abstract class BaseMonoBehaviour : FacepunchBehaviour // TypeDefIndex: 11286
{	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 4
	public virtual bool IsDebugging() { }

	// RVA: 0xA28230 Offset: 0xA27630 VA: 0x180A28230 Slot: 5
	public virtual string GetLogColor() { }

	// RVA: 0xA28850 Offset: 0xA27C50 VA: 0x180A28850
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1) { }

	// RVA: 0xA28550 Offset: 0xA27950 VA: 0x180A28550
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1, object arg2) { }

	// RVA: 0xA28260 Offset: 0xA27660 VA: 0x180A28260
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	protected void .ctor() { }

}

public enum BaseMonoBehaviour.LogEntryType // TypeDefIndex: 11287
{	// Fields
	public int value__; // 0x0
	public const BaseMonoBehaviour.LogEntryType General = 0;
	public const BaseMonoBehaviour.LogEntryType Network = 1;
	public const BaseMonoBehaviour.LogEntryType Hierarchy = 2;
	public const BaseMonoBehaviour.LogEntryType Serialization = 3;

}

