public class LeanTween : MonoBehaviour // TypeDefIndex: 5580
{	public static bool throwErrors; // 0x0
	public static float tau; // 0x4
	public static float PI_DIV2; // 0x8
	private static LTSeq[] sequences; // 0x10
	private static LTDescr[] tweens; // 0x18
	private static int[] tweensFinished; // 0x20
	private static int[] tweensFinishedIds; // 0x28
	private static LTDescr tween; // 0x30
	private static int tweenMaxSearch; // 0x38
	private static int maxTweens; // 0x3C
	private static int maxSequences; // 0x40
	private static int frameRendered; // 0x44
	private static GameObject _tweenEmpty; // 0x48
	public static float dtEstimated; // 0x50
	public static float dtManual; // 0x54
	public static float dtActual; // 0x58
	private static uint global_counter; // 0x5C
	private static int i; // 0x60
	private static int j; // 0x64
	private static int finishedCnt; // 0x68
	public static AnimationCurve punch; // 0x70
	public static AnimationCurve shake; // 0x78
	private static int maxTweenReached; // 0x80
	public static int startSearch; // 0x84
	public static LTDescr d; // 0x88
	private static Action<LTEvent>[] eventListeners; // 0x90
	private static GameObject[] goListeners; // 0x98
	private static int eventsMaxSearch; // 0xA0
	public static int EVENTS_MAX; // 0xA4
	public static int LISTENERS_MAX; // 0xA8
	private static int INIT_LISTENERS_MAX; // 0xAC

	public static int maxSearch { get; }
	public static int maxSimulataneousTweens { get; }
	public static int tweensRunning { get; }
	public static GameObject tweenEmpty { get; }


	public static void init() { }

	public static int get_maxSearch() { }

	public static int get_maxSimulataneousTweens() { }

	public static int get_tweensRunning() { }

	public static void init(int maxSimultaneousTweens) { }

	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences) { }

	public static void reset() { }

	public void Update() { }

	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode) { }

	private static void internalOnLevelWasLoaded(int lvl) { }

	public static void update() { }

	public static void removeTween(int i, int uniqueId) { }

	public static void removeTween(int i) { }

	public static Vector3[] add(Vector3[] a, Vector3 b) { }

	public static float closestRot(float from, float to) { }

	public static void cancelAll() { }

	public static void cancelAll(bool callComplete) { }

	public static void cancel(GameObject gameObject) { }

	public static void cancel(GameObject gameObject, bool callOnComplete) { }

	public static void cancel(RectTransform rect) { }

	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = False) { }

	public static void cancel(LTRect ltRect, int uniqueId) { }

	public static void cancel(int uniqueId) { }

	public static void cancel(int uniqueId, bool callOnComplete) { }

	public static LTDescr descr(int uniqueId) { }

	public static LTDescr description(int uniqueId) { }

	public static LTDescr[] descriptions(GameObject gameObject) { }

	[ObsoleteAttribute] // RVA: 0xB4910 Offset: 0xB3D10 VA: 0x1800B4910
	public static void pause(GameObject gameObject, int uniqueId) { }

	public static void pause(int uniqueId) { }

	public static void pause(GameObject gameObject) { }

	public static void pauseAll() { }

	public static void resumeAll() { }

	[ObsoleteAttribute] // RVA: 0xB49E0 Offset: 0xB3DE0 VA: 0x1800B49E0
	public static void resume(GameObject gameObject, int uniqueId) { }

	public static void resume(int uniqueId) { }

	public static void resume(GameObject gameObject) { }

	public static bool isTweening(GameObject gameObject) { }

	public static bool isTweening(RectTransform rect) { }

	public static bool isTweening(int uniqueId) { }

	public static bool isTweening(LTRect ltRect) { }

	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0, Transform arrowTransform) { }

	public static object logError(string error) { }

	public static LTDescr options(LTDescr seed) { }

	public static LTDescr options() { }

	public static GameObject get_tweenEmpty() { }

	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween) { }

	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites) { }

	public static LTDescr alpha(GameObject gameObject, float to, float time) { }

	public static LTSeq sequence(bool initSequence = True) { }

	public static LTDescr alpha(LTRect ltRect, float to, float time) { }

	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time) { }

	public static LTDescr alphaText(RectTransform rectTransform, float to, float time) { }

	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time) { }

	public static LTDescr alphaVertex(GameObject gameObject, float to, float time) { }

	public static LTDescr color(GameObject gameObject, Color to, float time) { }

	public static LTDescr textColor(RectTransform rectTransform, Color to, float time) { }

	public static LTDescr colorText(RectTransform rectTransform, Color to, float time) { }

	public static LTDescr delayedCall(float delayTime, Action callback) { }

	public static LTDescr delayedCall(float delayTime, Action<object> callback) { }

	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback) { }

	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback) { }

	public static LTDescr destroyAfter(LTRect rect, float delayTime) { }

	public static LTDescr move(GameObject gameObject, Vector3 to, float time) { }

	public static LTDescr move(GameObject gameObject, Vector2 to, float time) { }

	public static LTDescr move(GameObject gameObject, Vector3[] to, float time) { }

	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time) { }

	public static LTDescr move(GameObject gameObject, LTSpline to, float time) { }

	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time) { }

	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time) { }

	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time) { }

	public static LTDescr move(LTRect ltRect, Vector2 to, float time) { }

	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time) { }

	public static LTDescr moveX(GameObject gameObject, float to, float time) { }

	public static LTDescr moveY(GameObject gameObject, float to, float time) { }

	public static LTDescr moveZ(GameObject gameObject, float to, float time) { }

	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time) { }

	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time) { }

	public static LTDescr moveLocalX(GameObject gameObject, float to, float time) { }

	public static LTDescr moveLocalY(GameObject gameObject, float to, float time) { }

	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time) { }

	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time) { }

	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time) { }

	public static LTDescr move(GameObject gameObject, Transform to, float time) { }

	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time) { }

	public static LTDescr rotate(LTRect ltRect, float to, float time) { }

	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time) { }

	public static LTDescr rotateX(GameObject gameObject, float to, float time) { }

	public static LTDescr rotateY(GameObject gameObject, float to, float time) { }

	public static LTDescr rotateZ(GameObject gameObject, float to, float time) { }

	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time) { }

	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time) { }

	public static LTDescr scale(GameObject gameObject, Vector3 to, float time) { }

	public static LTDescr scale(LTRect ltRect, Vector2 to, float time) { }

	public static LTDescr scaleX(GameObject gameObject, float to, float time) { }

	public static LTDescr scaleY(GameObject gameObject, float to, float time) { }

	public static LTDescr scaleZ(GameObject gameObject, float to, float time) { }

	public static LTDescr value(GameObject gameObject, float from, float to, float time) { }

	public static LTDescr value(float from, float to, float time) { }

	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time) { }

	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time) { }

	public static LTDescr value(GameObject gameObject, Color from, Color to, float time) { }

	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time) { }

	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time) { }

	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time) { }

	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time) { }

	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { }

	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { }

	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time) { }

	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume) { }

	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume) { }

	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time) { }

	public static LTDescr moveX(RectTransform rectTrans, float to, float time) { }

	public static LTDescr moveY(RectTransform rectTrans, float to, float time) { }

	public static LTDescr moveZ(RectTransform rectTrans, float to, float time) { }

	public static LTDescr rotate(RectTransform rectTrans, float to, float time) { }

	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time) { }

	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time) { }

	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time) { }

	public static LTDescr alpha(RectTransform rectTrans, float to, float time) { }

	public static LTDescr color(RectTransform rectTrans, Color to, float time) { }

	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed) { }

	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed) { }

	public static float easeOutQuadOpt(float start, float diff, float ratioPassed) { }

	public static float easeInQuadOpt(float start, float diff, float ratioPassed) { }

	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed) { }

	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed) { }

	public static float linear(float start, float end, float val) { }

	public static float clerp(float start, float end, float val) { }

	public static float spring(float start, float end, float val) { }

	public static float easeInQuad(float start, float end, float val) { }

	public static float easeOutQuad(float start, float end, float val) { }

	public static float easeInOutQuad(float start, float end, float val) { }

	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2) { }

	public static float easeInCubic(float start, float end, float val) { }

	public static float easeOutCubic(float start, float end, float val) { }

	public static float easeInOutCubic(float start, float end, float val) { }

	public static float easeInQuart(float start, float end, float val) { }

	public static float easeOutQuart(float start, float end, float val) { }

	public static float easeInOutQuart(float start, float end, float val) { }

	public static float easeInQuint(float start, float end, float val) { }

	public static float easeOutQuint(float start, float end, float val) { }

	public static float easeInOutQuint(float start, float end, float val) { }

	public static float easeInSine(float start, float end, float val) { }

	public static float easeOutSine(float start, float end, float val) { }

	public static float easeInOutSine(float start, float end, float val) { }

	public static float easeInExpo(float start, float end, float val) { }

	public static float easeOutExpo(float start, float end, float val) { }

	public static float easeInOutExpo(float start, float end, float val) { }

	public static float easeInCirc(float start, float end, float val) { }

	public static float easeOutCirc(float start, float end, float val) { }

	public static float easeInOutCirc(float start, float end, float val) { }

	public static float easeInBounce(float start, float end, float val) { }

	public static float easeOutBounce(float start, float end, float val) { }

	public static float easeInOutBounce(float start, float end, float val) { }

	public static float easeInBack(float start, float end, float val, float overshoot = 1) { }

	public static float easeOutBack(float start, float end, float val, float overshoot = 1) { }

	public static float easeInOutBack(float start, float end, float val, float overshoot = 1) { }

	public static float easeInElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	public static float easeOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	public static void addListener(int eventId, Action<LTEvent> callback) { }

	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	public static bool removeListener(int eventId, Action<LTEvent> callback) { }

	public static bool removeListener(int eventId) { }

	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	public static void dispatchEvent(int eventId) { }

	public static void dispatchEvent(int eventId, object data) { }

	public void .ctor() { }

	private static void .cctor() { }

}

