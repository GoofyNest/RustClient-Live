public class LocomotiveExtraVisuals : MonoBehaviour // TypeDefIndex: 9764
{	[HeaderAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
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


	public void UpdateTick() { }

	public void StopAll() { }

	private void UpdateNeedle(Transform needle, LocomotiveExtraVisuals.NeedleType type) { }

	private float GetTargetAngle(LocomotiveExtraVisuals.NeedleType type) { }

	private void SetAngle(Transform tr, float angle) { }

	public void .ctor() { }

}

private enum LocomotiveExtraVisuals.NeedleType // TypeDefIndex: 9765
{	public int value__; // 0x0
	public const LocomotiveExtraVisuals.NeedleType Speed = 0;
	public const LocomotiveExtraVisuals.NeedleType Pressure = 1;

}

