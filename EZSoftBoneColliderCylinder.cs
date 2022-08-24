public class EZSoftBoneColliderCylinder : EZSoftBoneColliderBase // TypeDefIndex: 7135
{
	[SerializeField] 
	private float m_Margin; 
	[SerializeField] 
	private bool m_InsideMode; 

public float margin { get; set; }
public bool insideMode { get; set; }


public float get_margin() { }

public void set_margin(float value) { }

public bool get_insideMode() { }

public void set_insideMode(bool value) { }

public override void Collide(ref Vector3 position, float spacing) { }

public void .ctor() { }

}

