public class TriggerParentEnclosed : TriggerParent // TypeDefIndex: 11750
{
	public float Padding; 
	[TooltipAttribute] 
	public TriggerParentEnclosed.TriggerMode intersectionMode; 
	public bool CheckBoundsOnUnparent; 


	public void .ctor() { }

}

public enum TriggerParentEnclosed.TriggerMode // TypeDefIndex: 11751
{
	public int value__; 
	public const TriggerParentEnclosed.TriggerMode TriggerPoint = 0;
	public const TriggerParentEnclosed.TriggerMode PivotPoint = 1;

}

