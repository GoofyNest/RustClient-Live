public class LocomotiveExtraVisuals : MonoBehaviour // TypeDefIndex: 9764
{	// Fields
	[HeaderAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	[SerializeField] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	private TrainEngine trainEngine; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform needleA; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform needleB; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform needleC; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxAngle; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float speedoMoveSpeed; // 0x3C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float pressureMoveSpeed; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float fanAcceleration; // 0x44
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float fanMaxSpeed; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float speedoMax; // 0x4C
	[HeaderAttribute] // RVA: 0x94520 Offset: 0x93920 VA: 0x180094520
	[SerializeField] // RVA: 0x94520 Offset: 0x93920 VA: 0x180094520
	private Transform[] engineFans; // 0x50
	private Vector3 _v3; // 0x58
	private float fanPrevSpeed; // 0x64
	private float[] fanSpeedVariation; // 0x68

	// Methods

	// RVA: 0x4FC690 Offset: 0x4FBA90 VA: 0x1804FC690
	public void UpdateTick() { }

	// RVA: 0x4FC4D0 Offset: 0x4FB8D0 VA: 0x1804FC4D0
	public void StopAll() { }

	// RVA: 0x4FC580 Offset: 0x4FB980 VA: 0x1804FC580
	private void UpdateNeedle(Transform needle, LocomotiveExtraVisuals.NeedleType type) { }

	// RVA: 0x4FC2C0 Offset: 0x4FB6C0 VA: 0x1804FC2C0
	private float GetTargetAngle(LocomotiveExtraVisuals.NeedleType type) { }

	// RVA: 0x4FC490 Offset: 0x4FB890 VA: 0x1804FC490
	private void SetAngle(Transform tr, float angle) { }

	// RVA: 0x4FCBC0 Offset: 0x4FBFC0 VA: 0x1804FCBC0
	public void .ctor() { }

}

private enum LocomotiveExtraVisuals.NeedleType // TypeDefIndex: 9765
{	// Fields
	public int value__; // 0x0
	public const LocomotiveExtraVisuals.NeedleType Speed = 0;
	public const LocomotiveExtraVisuals.NeedleType Pressure = 1;

}

