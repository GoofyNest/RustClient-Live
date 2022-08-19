public class GestureCollection : ScriptableObject // TypeDefIndex: 10085
{	// Fields
	public GestureConfig[] AllGestures; // 0x18
	public float GestureVmInDuration; // 0x20
	public AnimationCurve GestureInCurve; // 0x28
	public float GestureVmOutDuration; // 0x30
	public AnimationCurve GestureOutCurve; // 0x38
	public float GestureViewmodelDeployDelay; // 0x40

	// Methods

	// RVA: 0xC780C0 Offset: 0xC774C0 VA: 0x180C780C0
	public GestureConfig IdToGesture(uint id) { }

	// RVA: 0xC78120 Offset: 0xC77520 VA: 0x180C78120
	public GestureConfig StringToGesture(string gestureName) { }

	// RVA: 0xC781B0 Offset: 0xC775B0 VA: 0x180C781B0
	public void .ctor() { }

}

