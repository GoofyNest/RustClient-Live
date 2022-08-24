public class LTDescr // TypeDefIndex: 5569
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
	private void <setMoveX>b__71_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveX>b__71_1() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveY>b__72_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveY>b__72_1() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveZ>b__73_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveZ>b__73_1() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveLocalX>b__74_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveLocalX>b__74_1() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveLocalY>b__75_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveLocalY>b__75_1() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveLocalZ>b__76_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveLocalZ>b__76_1() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveCurved>b__78_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveCurvedLocal>b__79_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveSpline>b__80_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveSplineLocal>b__81_0() { }

	[CompilerGeneratedAttribute] 
	private void <setScaleX>b__82_0() { }

	[CompilerGeneratedAttribute] 
	private void <setScaleX>b__82_1() { }

	[CompilerGeneratedAttribute] 
	private void <setScaleY>b__83_0() { }

	[CompilerGeneratedAttribute] 
	private void <setScaleY>b__83_1() { }

	[CompilerGeneratedAttribute] 
	private void <setScaleZ>b__84_0() { }

	[CompilerGeneratedAttribute] 
	private void <setScaleZ>b__84_1() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateX>b__85_0() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateX>b__85_1() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateY>b__86_0() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateY>b__86_1() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateZ>b__87_0() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateZ>b__87_1() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateAround>b__88_0() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateAround>b__88_1() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateAroundLocal>b__89_0() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateAroundLocal>b__89_1() { }

	[CompilerGeneratedAttribute] 
	private void <setAlpha>b__90_0() { }

	[CompilerGeneratedAttribute] 
	private void <setAlpha>b__90_2() { }

	[CompilerGeneratedAttribute] 
	private void <setAlpha>b__90_1() { }

	[CompilerGeneratedAttribute] 
	private void <setTextAlpha>b__91_0() { }

	[CompilerGeneratedAttribute] 
	private void <setTextAlpha>b__91_1() { }

	[CompilerGeneratedAttribute] 
	private void <setAlphaVertex>b__92_0() { }

	[CompilerGeneratedAttribute] 
	private void <setAlphaVertex>b__92_1() { }

	[CompilerGeneratedAttribute] 
	private void <setColor>b__93_0() { }

	[CompilerGeneratedAttribute] 
	private void <setColor>b__93_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCallbackColor>b__94_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCallbackColor>b__94_1() { }

	[CompilerGeneratedAttribute] 
	private void <setTextColor>b__95_0() { }

	[CompilerGeneratedAttribute] 
	private void <setTextColor>b__95_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasAlpha>b__96_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasAlpha>b__96_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasGroupAlpha>b__97_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasGroupAlpha>b__97_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasColor>b__98_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasColor>b__98_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasMoveX>b__99_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasMoveX>b__99_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasMoveY>b__100_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasMoveY>b__100_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasMoveZ>b__101_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasMoveZ>b__101_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasRotateAround>b__103_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasRotateAroundLocal>b__104_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasPlaySprite>b__105_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasPlaySprite>b__105_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasMove>b__106_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasMove>b__106_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasScale>b__107_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasScale>b__107_1() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasSizeDelta>b__108_0() { }

	[CompilerGeneratedAttribute] 
	private void <setCanvasSizeDelta>b__108_1() { }

	[CompilerGeneratedAttribute] 
	private void <setMove>b__112_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMove>b__112_1() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveLocal>b__113_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveLocal>b__113_1() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveToTransform>b__114_0() { }

	[CompilerGeneratedAttribute] 
	private void <setMoveToTransform>b__114_1() { }

	[CompilerGeneratedAttribute] 
	private void <setRotate>b__115_0() { }

	[CompilerGeneratedAttribute] 
	private void <setRotate>b__115_1() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateLocal>b__116_0() { }

	[CompilerGeneratedAttribute] 
	private void <setRotateLocal>b__116_1() { }

	[CompilerGeneratedAttribute] 
	private void <setScale>b__117_0() { }

	[CompilerGeneratedAttribute] 
	private void <setScale>b__117_1() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIMove>b__118_0() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIMove>b__118_1() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIMoveMargin>b__119_0() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIMoveMargin>b__119_1() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIScale>b__120_0() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIScale>b__120_1() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIAlpha>b__121_0() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIAlpha>b__121_1() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIRotate>b__122_0() { }

	[CompilerGeneratedAttribute] 
	private void <setGUIRotate>b__122_1() { }

	[CompilerGeneratedAttribute] 
	private void <setDelayedSound>b__123_0() { }

}

public sealed class LTDescr.EaseTypeDelegate : MulticastDelegate // TypeDefIndex: 5570
{

	public void .ctor(object object, IntPtr method) { }

	public virtual Vector3 Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual Vector3 EndInvoke(IAsyncResult result) { }

}

public sealed class LTDescr.ActionMethodDelegate : MulticastDelegate // TypeDefIndex: 5571
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class LTDescr.<>c // TypeDefIndex: 5572
{
	public static readonly LTDescr.<>c <>9; 
	public static LTDescr.ActionMethodDelegate <>9__110_0; 
	public static LTDescr.ActionMethodDelegate <>9__111_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <setCallback>b__110_0() { }

	internal void <setValue3>b__111_0() { }

}

