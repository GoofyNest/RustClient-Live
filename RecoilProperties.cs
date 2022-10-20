public class RecoilProperties : ScriptableObject // TypeDefIndex: 12484
{
	public float recoilYawMin; 
	public float recoilYawMax; 
	public float recoilPitchMin; 
	public float recoilPitchMax; 
	public float timeToTakeMin; 
	public float timeToTakeMax; 
	public float ADSScale; 
	public float movementPenalty; 
	public float clampPitch; 
	public AnimationCurve pitchCurve; 
	public AnimationCurve yawCurve; 
	public bool useCurves; 
	public bool curvesAsScalar; 
	public int shotsUntilMax; 
	public float maxRecoilRadius; 
	[HeaderAttribute] 
	public bool overrideAimconeWithCurve; 
	public float aimconeCurveScale; 
	[TooltipAttribute] 
	public AnimationCurve aimconeCurve; 
	[TooltipAttribute] 
	public AnimationCurve aimconeProbabilityCurve; 
	public RecoilProperties newRecoilOverride; 


	public RecoilProperties GetRecoil() { }

	public void .ctor() { }

}

