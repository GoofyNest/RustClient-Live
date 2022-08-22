public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 6850
{	public int value__; // 0x0
	public const Compute_DistanceTransform_EventTypes Processing = 0;
	public const Compute_DistanceTransform_EventTypes Completed = 1;

}

public class Compute_DT_EventArgs // TypeDefIndex: 6852
{	public Compute_DistanceTransform_EventTypes EventType; // 0x10
	public float ProgressPercentage; // 0x14
	public Color[] Colors; // 0x18


	public void .ctor(Compute_DistanceTransform_EventTypes type, float progress) { }

	public void .ctor(Compute_DistanceTransform_EventTypes type, Color[] colors) { }

}

