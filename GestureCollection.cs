public class GestureCollection : ScriptableObject // TypeDefIndex: 10085
{
	public GestureConfig[] AllGestures; 
	public float GestureVmInDuration; 
	public AnimationCurve GestureInCurve; 
	public float GestureVmOutDuration; 
	public AnimationCurve GestureOutCurve; 
	public float GestureViewmodelDeployDelay; 


public GestureConfig IdToGesture(uint id) { }

public GestureConfig StringToGesture(string gestureName) { }

public void .ctor() { }

}

