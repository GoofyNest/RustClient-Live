public class LTDescrOptional // TypeDefIndex: 5573
{
	[CompilerGeneratedAttribute] 
	private Transform <toTrans>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <point>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <axis>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <lastVal>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Quaternion <origRotation>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private LTBezierPath <path>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private LTSpline <spline>k__BackingField; 
	public AnimationCurve animationCurve; 
	public int initFrameCount; 
	[CompilerGeneratedAttribute] 
	private LTRect <ltRect>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<float> <onUpdateFloat>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<float, float> <onUpdateFloatRatio>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<float, object> <onUpdateFloatObject>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<Vector2> <onUpdateVector2>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<Vector3> <onUpdateVector3>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<Color> <onUpdateColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<Color, object> <onUpdateColorObject>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action <onComplete>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<object> <onCompleteObject>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <onCompleteParam>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <onUpdateParam>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action <onStart>k__BackingField; 

	public Transform toTrans { get; set; }
	public Vector3 point { get; set; }
	public Vector3 axis { get; set; }
	public float lastVal { get; set; }
	public Quaternion origRotation { get; set; }
	public LTBezierPath path { get; set; }
	public LTSpline spline { get; set; }
	public LTRect ltRect { get; set; }
	public Action<float> onUpdateFloat { get; set; }
	public Action<float, float> onUpdateFloatRatio { get; set; }
	public Action<float, object> onUpdateFloatObject { get; set; }
	public Action<Vector2> onUpdateVector2 { get; set; }
	public Action<Vector3> onUpdateVector3 { get; set; }
	public Action<Vector3, object> onUpdateVector3Object { get; set; }
	public Action<Color> onUpdateColor { get; set; }
	public Action<Color, object> onUpdateColorObject { get; set; }
	public Action onComplete { get; set; }
	public Action<object> onCompleteObject { get; set; }
	public object onCompleteParam { get; set; }
	public object onUpdateParam { get; set; }
	public Action onStart { get; set; }


	[CompilerGeneratedAttribute] 
	public Transform get_toTrans() { }

	[CompilerGeneratedAttribute] 
	public void set_toTrans(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_point() { }

	[CompilerGeneratedAttribute] 
	public void set_point(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_axis() { }

	[CompilerGeneratedAttribute] 
	public void set_axis(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public float get_lastVal() { }

	[CompilerGeneratedAttribute] 
	public void set_lastVal(float value) { }

	[CompilerGeneratedAttribute] 
	public Quaternion get_origRotation() { }

	[CompilerGeneratedAttribute] 
	public void set_origRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] 
	public LTBezierPath get_path() { }

	[CompilerGeneratedAttribute] 
	public void set_path(LTBezierPath value) { }

	[CompilerGeneratedAttribute] 
	public LTSpline get_spline() { }

	[CompilerGeneratedAttribute] 
	public void set_spline(LTSpline value) { }

	[CompilerGeneratedAttribute] 
	public LTRect get_ltRect() { }

	[CompilerGeneratedAttribute] 
	public void set_ltRect(LTRect value) { }

	[CompilerGeneratedAttribute] 
	public Action<float> get_onUpdateFloat() { }

	[CompilerGeneratedAttribute] 
	public void set_onUpdateFloat(Action<float> value) { }

	[CompilerGeneratedAttribute] 
	public Action<float, float> get_onUpdateFloatRatio() { }

	[CompilerGeneratedAttribute] 
	public void set_onUpdateFloatRatio(Action<float, float> value) { }

	[CompilerGeneratedAttribute] 
	public Action<float, object> get_onUpdateFloatObject() { }

	[CompilerGeneratedAttribute] 
	public void set_onUpdateFloatObject(Action<float, object> value) { }

	[CompilerGeneratedAttribute] 
	public Action<Vector2> get_onUpdateVector2() { }

	[CompilerGeneratedAttribute] 
	public void set_onUpdateVector2(Action<Vector2> value) { }

	[CompilerGeneratedAttribute] 
	public Action<Vector3> get_onUpdateVector3() { }

	[CompilerGeneratedAttribute] 
	public void set_onUpdateVector3(Action<Vector3> value) { }

	[CompilerGeneratedAttribute] 
	public Action<Vector3, object> get_onUpdateVector3Object() { }

	[CompilerGeneratedAttribute] 
	public void set_onUpdateVector3Object(Action<Vector3, object> value) { }

	[CompilerGeneratedAttribute] 
	public Action<Color> get_onUpdateColor() { }

	[CompilerGeneratedAttribute] 
	public void set_onUpdateColor(Action<Color> value) { }

	[CompilerGeneratedAttribute] 
	public Action<Color, object> get_onUpdateColorObject() { }

	[CompilerGeneratedAttribute] 
	public void set_onUpdateColorObject(Action<Color, object> value) { }

	[CompilerGeneratedAttribute] 
	public Action get_onComplete() { }

	[CompilerGeneratedAttribute] 
	public void set_onComplete(Action value) { }

	[CompilerGeneratedAttribute] 
	public Action<object> get_onCompleteObject() { }

	[CompilerGeneratedAttribute] 
	public void set_onCompleteObject(Action<object> value) { }

	[CompilerGeneratedAttribute] 
	public object get_onCompleteParam() { }

	[CompilerGeneratedAttribute] 
	public void set_onCompleteParam(object value) { }

	[CompilerGeneratedAttribute] 
	public object get_onUpdateParam() { }

	[CompilerGeneratedAttribute] 
	public void set_onUpdateParam(object value) { }

	[CompilerGeneratedAttribute] 
	public Action get_onStart() { }

	[CompilerGeneratedAttribute] 
	public void set_onStart(Action value) { }

	public void reset() { }

	public void callOnUpdate(float val, float ratioPassed) { }

	public void .ctor() { }

}

