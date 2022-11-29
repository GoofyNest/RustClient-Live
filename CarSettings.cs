public class CarSettings // TypeDefIndex: 11440
{
	[HeaderAttribute] 
	[RangeAttribute] 
	public float rollingResistance; 
	[RangeAttribute] 
	public float antiRoll; 
	public bool canSleep; 
	[HeaderAttribute] 
	public bool tankSteering; 
	[RangeAttribute] 
	public float maxSteerAngle; 
	public bool steeringAssist; 
	[RangeAttribute] 
	public float steeringAssistRatio; 
	public bool steeringLimit; 
	[RangeAttribute] 
	public float minSteerLimitAngle; 
	[RangeAttribute] 
	public float minSteerLimitSpeed; 
	[RangeAttribute] 
	public float rearWheelSteer; 
	public float steerMinLerpSpeed; 
	public float steerMaxLerpSpeed; 
	public float steerReturnLerpSpeed; 
	[HeaderAttribute] 
	public float maxDriveSlip; 
	public float driveForceToMaxSlip; 
	public float reversePercentSpeed; 
	[HeaderAttribute] 
	public float brakeForceMultiplier; 
	[HeaderAttribute] 
	[RangeAttribute] 
	public float handlingBias; 


	public void .ctor() { }

}

