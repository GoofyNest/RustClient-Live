public class Alert // TypeDefIndex: 1736
{	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	public AlertLevel Level { get; }
	public AlertDescription Description { get; }


	public AlertLevel get_Level() { }

	public AlertDescription get_Description() { }

	public void .ctor(AlertDescription description) { }

	private void inferAlertLevel() { }

	public override string ToString() { }

}

