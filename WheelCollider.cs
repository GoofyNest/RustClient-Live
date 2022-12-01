public class WheelCollider : Collider // TypeDefIndex: 4777
{

[NativeHeaderAttribute]
[NativeHeaderAttribute]
public class WheelCollider : Collider
	public float radius { get; }
	public float suspensionDistance { get; }
	public float motorTorque { get; set; }
	public float brakeTorque { set; }
	public float steerAngle { set; }
	public bool isGrounded { get; }


	public float get_radius() { }

	public float get_suspensionDistance() { }

	public float get_motorTorque() { }

	public void set_motorTorque(float value) { }

	public void set_brakeTorque(float value) { }

	public void set_steerAngle(float value) { }

	[NativeNameAttribute]
	public bool get_isGrounded() { }

}

