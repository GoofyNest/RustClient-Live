public class TechTreeLine : TechTreeWidget // TypeDefIndex: 10915
{
	public RawImage center; 
	public RawImage topLeft; 
	public RawImage topRight; 
	public RawImage bottomLeft; 
	public RawImage bottomRight; 
	public RawImage centerDotted; 
	public RawImage topLeftDotted; 
	public RawImage topRightDotted; 
	public RawImage bottomLeftDotted; 
	public RawImage bottomRightDotted; 
	public int from; 
	public int to; 
	private bool isLocked; 
	private bool targetAbove; 
	private bool targetLeft; 


	public override void SetLocked(bool wantsLocked) { }

	public void SetTargetAbove(bool isTargetAbove) { }

	public void SetTargetToLeft(bool isLeft) { }

	public void Refresh() { }

	public void .ctor() { }

}

