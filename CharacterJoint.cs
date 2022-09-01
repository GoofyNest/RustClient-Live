public class CharacterJoint : Joint // TypeDefIndex: 3930
{

[NativeHeaderAttribute] 
[NativeClassAttribute] 
public class CharacterJoint : Joint
	[ObsoleteAttribute] 
	public Quaternion targetRotation; 
	[ObsoleteAttribute] 
	public Vector3 targetAngularVelocity; 
	[ObsoleteAttribute] 
	public JointDrive rotationDrive; 

	public bool enableProjection { set; }


	public void set_enableProjection(bool value) { }

}

