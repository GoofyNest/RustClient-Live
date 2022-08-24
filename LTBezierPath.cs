public class LTBezierPath // TypeDefIndex: 5583
{
	public Vector3[] pts; 
	public float length; 
	public bool orientToPath; 
	public bool orientToPath2d; 
	private LTBezier[] beziers; 
	private float[] lengthRatio; 
	private int currentBezier; 
	private int previousBezier; 

public float distance { get; }


public void .ctor() { }

public void .ctor(Vector3[] pts_) { }

public void setPoints(Vector3[] pts_) { }

public float get_distance() { }

public Vector3 point(float ratio) { }

public void place2d(Transform transform, float ratio) { }

public void placeLocal2d(Transform transform, float ratio) { }

public void place(Transform transform, float ratio) { }

public void place(Transform transform, float ratio, Vector3 worldUp) { }

public void placeLocal(Transform transform, float ratio) { }

public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

public void gizmoDraw(float t = -1) { }

}

