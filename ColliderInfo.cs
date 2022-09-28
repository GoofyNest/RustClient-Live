public class ColliderInfo : MonoBehaviour // TypeDefIndex: 11509
{
	public const ColliderInfo.Flags FlagsNone = 0;
	public const ColliderInfo.Flags FlagsEverything = -1;
	public const ColliderInfo.Flags FlagsDefault = 15;
	[InspectorFlagsAttribute] 
	public ColliderInfo.Flags flags; 


	public bool HasFlag(ColliderInfo.Flags f) { }

	public void SetFlag(ColliderInfo.Flags f, bool b) { }

	public bool Filter(HitTest info) { }

	public void .ctor() { }

}

public enum ColliderInfo.Flags // TypeDefIndex: 11510
{
	public int value__; 
	public const ColliderInfo.Flags Usable = 1;
	public const ColliderInfo.Flags Shootable = 2;
	public const ColliderInfo.Flags Melee = 4;
	public const ColliderInfo.Flags Opaque = 8;
	public const ColliderInfo.Flags Airflow = 16;

}

