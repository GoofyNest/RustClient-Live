public class TechTreeLine : TechTreeWidget // TypeDefIndex: 10915
{	// Fields
	public RawImage center; // 0x28
	public RawImage topLeft; // 0x30
	public RawImage topRight; // 0x38
	public RawImage bottomLeft; // 0x40
	public RawImage bottomRight; // 0x48
	public RawImage centerDotted; // 0x50
	public RawImage topLeftDotted; // 0x58
	public RawImage topRightDotted; // 0x60
	public RawImage bottomLeftDotted; // 0x68
	public RawImage bottomRightDotted; // 0x70
	public int from; // 0x78
	public int to; // 0x7C
	private bool isLocked; // 0x80
	private bool targetAbove; // 0x81
	private bool targetLeft; // 0x82

	// Methods

	// RVA: 0x7ACC50 Offset: 0x7AC050 VA: 0x1807ACC50 Slot: 8
	public override void SetLocked(bool wantsLocked) { }

	// RVA: 0x7ACC60 Offset: 0x7AC060 VA: 0x1807ACC60
	public void SetTargetAbove(bool isTargetAbove) { }

	// RVA: 0x7ACC70 Offset: 0x7AC070 VA: 0x1807ACC70
	public void SetTargetToLeft(bool isLeft) { }

	// RVA: 0x7AC9F0 Offset: 0x7ABDF0 VA: 0x1807AC9F0
	public void Refresh() { }

	// RVA: 0x7AC980 Offset: 0x7ABD80 VA: 0x1807AC980
	public void .ctor() { }

}

