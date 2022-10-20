public abstract class BaseMonoBehaviour : FacepunchBehaviour // TypeDefIndex: 13038
{

	public virtual bool IsDebugging() { }

	public virtual string GetLogColor() { }

	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1) { }

	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1, object arg2) { }

	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str) { }

	protected void .ctor() { }

}

public enum BaseMonoBehaviour.LogEntryType // TypeDefIndex: 13039
{
	public int value__; 
	public const BaseMonoBehaviour.LogEntryType General = 0;
	public const BaseMonoBehaviour.LogEntryType Network = 1;
	public const BaseMonoBehaviour.LogEntryType Hierarchy = 2;
	public const BaseMonoBehaviour.LogEntryType Serialization = 3;

}

