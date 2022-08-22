public class GestureCollection : ScriptableObject // TypeDefIndex: 10085
{	public GestureConfig[] AllGestures; // 0x18
	public float GestureVmInDuration; // 0x20
	public AnimationCurve GestureInCurve; // 0x28
	public float GestureVmOutDuration; // 0x30
	public AnimationCurve GestureOutCurve; // 0x38
	public float GestureViewmodelDeployDelay; // 0x40


	public GestureConfig IdToGesture(uint id) { }

	public GestureConfig StringToGesture(string gestureName) { }

	public void .ctor() { }

}

