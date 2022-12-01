public class LTDescr // TypeDefIndex: 5578
{
	public bool toggle;
	public bool useEstimatedTime;
	public bool useFrames;
	public bool useManualTime;
	public bool usesNormalDt;
	public bool hasInitiliazed;
	public bool hasExtraOnCompletes;
	public bool hasPhysics;
	public bool onCompleteOnRepeat;
	public bool onCompleteOnStart;
	public bool useRecursion;
	public float ratioPassed;
	public float passed;
	public float delay;
	public float time;
	public float speed;
	public float lastVal;
	private uint _id;
	public int loopCount;
	public uint counter;
	public float direction;
	public float directionLast;
	public float overshoot;
	public float period;
	public float scale;
	public bool destroyOnComplete;
	public Transform trans;
	public LTRect ltRect;
	internal Vector3 fromInternal;
	internal Vector3 toInternal;
	internal Vector3 diff;
	internal Vector3 diffDiv2;
	public TweenAction type;
	private LeanTweenType easeType;
	public LeanTweenType loopType;
	public bool hasUpdateCallback;
	public LTDescr.EaseTypeDelegate easeMethod;
	[CompilerGeneratedAttribute]
	private LTDescr.ActionMethodDelegate <easeInternal>k__BackingField;
	[CompilerGeneratedAttribute]
	private LTDescr.ActionMethodDelegate <initInternal>k__BackingField;
	public SpriteRenderer spriteRen;
	public RectTransform rectTransform;
	public Text uiText;
	public Image uiImage;
	public RawImage rawImage;
	public Sprite[] sprites;
	public LTDescrOptional _optional;
	public static float val;
	public static float dt;
	public static Vector3 newVect;

	public Vector3 from { get; set; }
	public Vector3 to { get; set; }
	public LTDescr.ActionMethodDelegate easeInternal { get; set; }
	public LTDescr.ActionMethodDelegate initInternal { get; set; }
	public int uniqueId { get; }
	public int id { get; }
	public LTDescrOptional optional { get; set; }


	public Vector3 get_from() { }

	public void set_from(Vector3 value) { }

	public Vector3 get_to() { }

	public void set_to(Vector3 value) { }

	[CompilerGeneratedAttribute]
	public LTDescr.ActionMethodDelegate get_easeInternal() { }

	[CompilerGeneratedAttribute]
	public void set_easeInternal(LTDescr.ActionMethodDelegate value) { }

	[CompilerGeneratedAttribute]
	public LTDescr.ActionMethodDelegate get_initInternal() { }

	[CompilerGeneratedAttribute]
	public void set_initInternal(LTDescr.ActionMethodDelegate value) { }

	public override string ToString() { }

	public void .ctor() { }

	[ObsoleteAttribute]
	public LTDescr cancel(GameObject gameObject) { }

	public int get_uniqueId() { }

	public int get_id() { }

	public LTDescrOptional get_optional() { }

	public void set_optional(LTDescrOptional value) { }

	public void reset() { }

	public LTDescr setMoveX() { }

	public LTDescr setMoveY() { }

	public LTDescr setMoveZ() { }

	public LTDescr setMoveLocalX() { }

	public LTDescr setMoveLocalY() { }

	public LTDescr setMoveLocalZ() { }

	private void initFromInternal() { }

	public LTDescr setMoveCurved() { }

	public LTDescr setMoveCurvedLocal() { }

	public LTDescr setMoveSpline() { }

	public LTDescr setMoveSplineLocal() { }

	public LTDescr setScaleX() { }

	public LTDescr setScaleY() { }

	public LTDescr setScaleZ() { }

	public LTDescr setRotateX() { }

	public LTDescr setRotateY() { }

	public LTDescr setRotateZ() { }

	public LTDescr setRotateAround() { }

	public LTDescr setRotateAroundLocal() { }

	public LTDescr setAlpha() { }

	public LTDescr setTextAlpha() { }

	public LTDescr setAlphaVertex() { }

	public LTDescr setColor() { }

	public LTDescr setCallbackColor() { }

	public LTDescr setTextColor() { }

	public LTDescr setCanvasAlpha() { }

	public LTDescr setCanvasGroupAlpha() { }

	public LTDescr setCanvasColor() { }

	public LTDescr setCanvasMoveX() { }

	public LTDescr setCanvasMoveY() { }

	public LTDescr setCanvasMoveZ() { }

	private void initCanvasRotateAround() { }

	public LTDescr setCanvasRotateAround() { }

	public LTDescr setCanvasRotateAroundLocal() { }

	public LTDescr setCanvasPlaySprite() { }

	public LTDescr setCanvasMove() { }

	public LTDescr setCanvasScale() { }

	public LTDescr setCanvasSizeDelta() { }

	private void callback() { }

	public LTDescr setCallback() { }

	public LTDescr setValue3() { }

	public LTDescr setMove() { }

	public LTDescr setMoveLocal() { }

	public LTDescr setMoveToTransform() { }

	public LTDescr setRotate() { }

	public LTDescr setRotateLocal() { }

	public LTDescr setScale() { }

	public LTDescr setGUIMove() { }

	public LTDescr setGUIMoveMargin() { }

	public LTDescr setGUIScale() { }

	public LTDescr setGUIAlpha() { }

	public LTDescr setGUIRotate() { }

	public LTDescr setDelayedSound() { }

	private void init() { }

	private void initSpeed() { }

	public LTDescr updateNow() { }

	public bool updateInternal() { }

	public void callOnCompletes() { }

	public LTDescr setFromColor(Color col) { }

	private static void alphaRecursive(Transform transform, float val, bool useRecursion = True) { }

	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = True) { }

	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0) { }

	private static void alphaRecursiveSprite(Transform transform, float val) { }

	private static void colorRecursiveSprite(Transform transform, Color toColor) { }

	private static void colorRecursive(RectTransform rectTransform, Color toColor) { }

	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = True) { }

	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = True) { }

	private static void textColorRecursive(Transform trans, Color toColor) { }

	private static Color tweenColor(LTDescr tween, float val) { }

	public LTDescr pause() { }

	public LTDescr resume() { }

	public LTDescr setAxis(Vector3 axis) { }

	public LTDescr setDelay(float delay) { }

	public LTDescr setEase(LeanTweenType easeType) { }

	public LTDescr setEaseLinear() { }

	public LTDescr setEaseSpring() { }

	public LTDescr setEaseInQuad() { }

	public LTDescr setEaseOutQuad() { }

	public LTDescr setEaseInOutQuad() { }

	public LTDescr setEaseInCubic() { }

	public LTDescr setEaseOutCubic() { }

	public LTDescr setEaseInOutCubic() { }

	public LTDescr setEaseInQuart() { }

	public LTDescr setEaseOutQuart() { }

	public LTDescr setEaseInOutQuart() { }

	public LTDescr setEaseInQuint() { }

	public LTDescr setEaseOutQuint() { }

	public LTDescr setEaseInOutQuint() { }

	public LTDescr setEaseInSine() { }

	public LTDescr setEaseOutSine() { }

	public LTDescr setEaseInOutSine() { }

	public LTDescr setEaseInExpo() { }

	public LTDescr setEaseOutExpo() { }

	public LTDescr setEaseInOutExpo() { }

	public LTDescr setEaseInCirc() { }

	public LTDescr setEaseOutCirc() { }

	public LTDescr setEaseInOutCirc() { }

	public LTDescr setEaseInBounce() { }

	public LTDescr setEaseOutBounce() { }

	public LTDescr setEaseInOutBounce() { }

	public LTDescr setEaseInBack() { }

	public LTDescr setEaseOutBack() { }

	public LTDescr setEaseInOutBack() { }

	public LTDescr setEaseInElastic() { }

	public LTDescr setEaseOutElastic() { }

	public LTDescr setEaseInOutElastic() { }

	public LTDescr setEasePunch() { }

	public LTDescr setEaseShake() { }

	private Vector3 tweenOnCurve() { }

	private Vector3 easeInOutQuad() { }

	private Vector3 easeInQuad() { }

	private Vector3 easeOutQuad() { }

	private Vector3 easeLinear() { }

	private Vector3 easeSpring() { }

	private Vector3 easeInCubic() { }

	private Vector3 easeOutCubic() { }

	private Vector3 easeInOutCubic() { }

	private Vector3 easeInQuart() { }

	private Vector3 easeOutQuart() { }

	private Vector3 easeInOutQuart() { }

	private Vector3 easeInQuint() { }

	private Vector3 easeOutQuint() { }

	private Vector3 easeInOutQuint() { }

	private Vector3 easeInSine() { }

	private Vector3 easeOutSine() { }

	private Vector3 easeInOutSine() { }

	private Vector3 easeInExpo() { }

	private Vector3 easeOutExpo() { }

	private Vector3 easeInOutExpo() { }

	private Vector3 easeInCirc() { }

	private Vector3 easeOutCirc() { }

	private Vector3 easeInOutCirc() { }

	private Vector3 easeInBounce() { }

	private Vector3 easeOutBounce() { }

	private Vector3 easeInOutBounce() { }

	private Vector3 easeInBack() { }

	private Vector3 easeOutBack() { }

	private Vector3 easeInOutBack() { }

	private Vector3 easeInElastic() { }

	private Vector3 easeOutElastic() { }

	private Vector3 easeInOutElastic() { }

	public LTDescr setOvershoot(float overshoot) { }

	public LTDescr setPeriod(float period) { }

	public LTDescr setScale(float scale) { }

	public LTDescr setEase(AnimationCurve easeCurve) { }

	public LTDescr setTo(Vector3 to) { }

	public LTDescr setTo(Transform to) { }

	public LTDescr setFrom(Vector3 from) { }

	public LTDescr setFrom(float from) { }

	public LTDescr setDiff(Vector3 diff) { }

	public LTDescr setHasInitialized(bool has) { }

	public LTDescr setId(uint id, uint global_counter) { }

	public LTDescr setPassed(float passed) { }

	public LTDescr setTime(float time) { }

	public LTDescr setSpeed(float speed) { }

	public LTDescr setRepeat(int repeat) { }

	public LTDescr setLoopType(LeanTweenType loopType) { }

	public LTDescr setUseEstimatedTime(bool useEstimatedTime) { }

	public LTDescr setIgnoreTimeScale(bool useUnScaledTime) { }

	public LTDescr setUseFrames(bool useFrames) { }

	public LTDescr setUseManualTime(bool useManualTime) { }

	public LTDescr setLoopCount(int loopCount) { }

	public LTDescr setLoopOnce() { }

	public LTDescr setLoopClamp() { }

	public LTDescr setLoopClamp(int loops) { }

	public LTDescr setLoopPingPong() { }

	public LTDescr setLoopPingPong(int loops) { }

	public LTDescr setOnComplete(Action onComplete) { }

	public LTDescr setOnComplete(Action<object> onComplete) { }

	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam) { }

	public LTDescr setOnCompleteParam(object onCompleteParam) { }

	public LTDescr setOnUpdate(Action<float> onUpdate) { }

	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate) { }

	public LTDescr setOnUpdateObject(Action<float, object> onUpdate) { }

	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate) { }

	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate) { }

	public LTDescr setOnUpdateColor(Action<Color> onUpdate) { }

	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate) { }

	public LTDescr setOnUpdate(Action<Color> onUpdate) { }

	public LTDescr setOnUpdate(Action<Color, object> onUpdate) { }

	public LTDescr setOnUpdate(Action<float, object> onUpdate, object onUpdateParam) { }

	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, object onUpdateParam) { }

	public LTDescr setOnUpdate(Action<Vector2> onUpdate, object onUpdateParam) { }

	public LTDescr setOnUpdate(Action<Vector3> onUpdate, object onUpdateParam) { }

	public LTDescr setOnUpdateParam(object onUpdateParam) { }

	public LTDescr setOrientToPath(bool doesOrient) { }

	public LTDescr setOrientToPath2d(bool doesOrient2d) { }

	public LTDescr setRect(LTRect rect) { }

	public LTDescr setRect(Rect rect) { }

	public LTDescr setPath(LTBezierPath path) { }

	public LTDescr setPoint(Vector3 point) { }

	public LTDescr setDestroyOnComplete(bool doesDestroy) { }

	public LTDescr setAudio(object audio) { }

	public LTDescr setOnCompleteOnRepeat(bool isOn) { }

	public LTDescr setOnCompleteOnStart(bool isOn) { }

	public LTDescr setRect(RectTransform rect) { }

	public LTDescr setSprites(Sprite[] sprites) { }

	public LTDescr setFrameRate(float frameRate) { }

	public LTDescr setOnStart(Action onStart) { }

	public LTDescr setDirection(float direction) { }

	public LTDescr setRecursive(bool useRecursion) { }

	[CompilerGeneratedAttribute]
	private void <setMoveX>

	[CompilerGeneratedAttribute]
	private void <setMoveX>

	[CompilerGeneratedAttribute]
	private void <setMoveY>

	[CompilerGeneratedAttribute]
	private void <setMoveY>

	[CompilerGeneratedAttribute]
	private void <setMoveZ>

	[CompilerGeneratedAttribute]
	private void <setMoveZ>

	[CompilerGeneratedAttribute]
	private void <setMoveLocalX>

	[CompilerGeneratedAttribute]
	private void <setMoveLocalX>

	[CompilerGeneratedAttribute]
	private void <setMoveLocalY>

	[CompilerGeneratedAttribute]
	private void <setMoveLocalY>

	[CompilerGeneratedAttribute]
	private void <setMoveLocalZ>

	[CompilerGeneratedAttribute]
	private void <setMoveLocalZ>

	[CompilerGeneratedAttribute]
	private void <setMoveCurved>

	[CompilerGeneratedAttribute]
	private void <setMoveCurvedLocal>

	[CompilerGeneratedAttribute]
	private void <setMoveSpline>

	[CompilerGeneratedAttribute]
	private void <setMoveSplineLocal>

	[CompilerGeneratedAttribute]
	private void <setScaleX>

	[CompilerGeneratedAttribute]
	private void <setScaleX>

	[CompilerGeneratedAttribute]
	private void <setScaleY>

	[CompilerGeneratedAttribute]
	private void <setScaleY>

	[CompilerGeneratedAttribute]
	private void <setScaleZ>

	[CompilerGeneratedAttribute]
	private void <setScaleZ>

	[CompilerGeneratedAttribute]
	private void <setRotateX>

	[CompilerGeneratedAttribute]
	private void <setRotateX>

	[CompilerGeneratedAttribute]
	private void <setRotateY>

	[CompilerGeneratedAttribute]
	private void <setRotateY>

	[CompilerGeneratedAttribute]
	private void <setRotateZ>

	[CompilerGeneratedAttribute]
	private void <setRotateZ>

	[CompilerGeneratedAttribute]
	private void <setRotateAround>

	[CompilerGeneratedAttribute]
	private void <setRotateAround>

	[CompilerGeneratedAttribute]
	private void <setRotateAroundLocal>

	[CompilerGeneratedAttribute]
	private void <setRotateAroundLocal>

	[CompilerGeneratedAttribute]
	private void <setAlpha>

	[CompilerGeneratedAttribute]
	private void <setAlpha>

	[CompilerGeneratedAttribute]
	private void <setAlpha>

	[CompilerGeneratedAttribute]
	private void <setTextAlpha>

	[CompilerGeneratedAttribute]
	private void <setTextAlpha>

	[CompilerGeneratedAttribute]
	private void <setAlphaVertex>

	[CompilerGeneratedAttribute]
	private void <setAlphaVertex>

	[CompilerGeneratedAttribute]
	private void <setColor>

	[CompilerGeneratedAttribute]
	private void <setColor>

	[CompilerGeneratedAttribute]
	private void <setCallbackColor>

	[CompilerGeneratedAttribute]
	private void <setCallbackColor>

	[CompilerGeneratedAttribute]
	private void <setTextColor>

	[CompilerGeneratedAttribute]
	private void <setTextColor>

	[CompilerGeneratedAttribute]
	private void <setCanvasAlpha>

	[CompilerGeneratedAttribute]
	private void <setCanvasAlpha>

	[CompilerGeneratedAttribute]
	private void <setCanvasGroupAlpha>

	[CompilerGeneratedAttribute]
	private void <setCanvasGroupAlpha>

	[CompilerGeneratedAttribute]
	private void <setCanvasColor>

	[CompilerGeneratedAttribute]
	private void <setCanvasColor>

	[CompilerGeneratedAttribute]
	private void <setCanvasMoveX>

	[CompilerGeneratedAttribute]
	private void <setCanvasMoveX>

	[CompilerGeneratedAttribute]
	private void <setCanvasMoveY>

	[CompilerGeneratedAttribute]
	private void <setCanvasMoveY>

	[CompilerGeneratedAttribute]
	private void <setCanvasMoveZ>

	[CompilerGeneratedAttribute]
	private void <setCanvasMoveZ>

	[CompilerGeneratedAttribute]
	private void <setCanvasRotateAround>

	[CompilerGeneratedAttribute]
	private void <setCanvasRotateAroundLocal>

	[CompilerGeneratedAttribute]
	private void <setCanvasPlaySprite>

	[CompilerGeneratedAttribute]
	private void <setCanvasPlaySprite>

	[CompilerGeneratedAttribute]
	private void <setCanvasMove>

	[CompilerGeneratedAttribute]
	private void <setCanvasMove>

	[CompilerGeneratedAttribute]
	private void <setCanvasScale>

	[CompilerGeneratedAttribute]
	private void <setCanvasScale>

	[CompilerGeneratedAttribute]
	private void <setCanvasSizeDelta>

	[CompilerGeneratedAttribute]
	private void <setCanvasSizeDelta>

	[CompilerGeneratedAttribute]
	private void <setMove>

	[CompilerGeneratedAttribute]
	private void <setMove>

	[CompilerGeneratedAttribute]
	private void <setMoveLocal>

	[CompilerGeneratedAttribute]
	private void <setMoveLocal>

	[CompilerGeneratedAttribute]
	private void <setMoveToTransform>

	[CompilerGeneratedAttribute]
	private void <setMoveToTransform>

	[CompilerGeneratedAttribute]
	private void <setRotate>

	[CompilerGeneratedAttribute]
	private void <setRotate>

	[CompilerGeneratedAttribute]
	private void <setRotateLocal>

	[CompilerGeneratedAttribute]
	private void <setRotateLocal>

	[CompilerGeneratedAttribute]
	private void <setScale>

	[CompilerGeneratedAttribute]
	private void <setScale>

	[CompilerGeneratedAttribute]
	private void <setGUIMove>

	[CompilerGeneratedAttribute]
	private void <setGUIMove>

	[CompilerGeneratedAttribute]
	private void <setGUIMoveMargin>

	[CompilerGeneratedAttribute]
	private void <setGUIMoveMargin>

	[CompilerGeneratedAttribute]
	private void <setGUIScale>

	[CompilerGeneratedAttribute]
	private void <setGUIScale>

	[CompilerGeneratedAttribute]
	private void <setGUIAlpha>

	[CompilerGeneratedAttribute]
	private void <setGUIAlpha>

	[CompilerGeneratedAttribute]
	private void <setGUIRotate>

	[CompilerGeneratedAttribute]
	private void <setGUIRotate>

	[CompilerGeneratedAttribute]
	private void <setDelayedSound>

}

public sealed class LTDescr.EaseTypeDelegate : MulticastDelegate // TypeDefIndex: 5579
{

	public void .ctor(object object, IntPtr method) { }

	public virtual Vector3 Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual Vector3 EndInvoke(IAsyncResult result) { }

}

public sealed class LTDescr.ActionMethodDelegate : MulticastDelegate // TypeDefIndex: 5580
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class LTDescr.<>c // TypeDefIndex: 5581
{
	public static readonly LTDescr.<>c <>9;
	public static LTDescr.ActionMethodDelegate <>9__110_0;
	public static LTDescr.ActionMethodDelegate <>9__111_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal void <setCallback>

	internal void <setValue3>

}

