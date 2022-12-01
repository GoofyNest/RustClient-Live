public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 6792
{
	public int value__;
	public const Compute_DistanceTransform_EventTypes Processing = 0;
	public const Compute_DistanceTransform_EventTypes Completed = 1;

}

public class Compute_DT_EventArgs // TypeDefIndex: 6794
{
	public Compute_DistanceTransform_EventTypes EventType;
	public float ProgressPercentage;
	public Color[] Colors;


	public void .ctor(Compute_DistanceTransform_EventTypes type, float progress) { }

	public void .ctor(Compute_DistanceTransform_EventTypes type, Color[] colors) { }

}

