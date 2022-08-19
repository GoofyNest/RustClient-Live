public class LeanTween : MonoBehaviour // TypeDefIndex: 5580
{	// Fields
	public static bool throwErrors; // 0x0
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

	// Properties
	public static int maxSearch { get; }
	public static int maxSimulataneousTweens { get; }
	public static int tweensRunning { get; }
	public static GameObject tweenEmpty { get; }

	// Methods

	// RVA: 0x21AF3D0 Offset: 0x21AE7D0 VA: 0x1821AF3D0
	public static void init() { }

	// RVA: 0x21AECE0 Offset: 0x21AE0E0 VA: 0x1821AECE0
	public static int get_maxSearch() { }

	// RVA: 0x21AED40 Offset: 0x21AE140 VA: 0x1821AED40
	public static int get_maxSimulataneousTweens() { }

	// RVA: 0x21AEE60 Offset: 0x21AE260 VA: 0x1821AEE60
	public static int get_tweensRunning() { }

	// RVA: 0x21AF480 Offset: 0x21AE880 VA: 0x1821AF480
	public static void init(int maxSimultaneousTweens) { }

	// RVA: 0x21AEF40 Offset: 0x21AE340 VA: 0x1821AEF40
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences) { }

	// RVA: 0x21B3930 Offset: 0x21B2D30 VA: 0x1821B3930
	public static void reset() { }

	// RVA: 0x21A90E0 Offset: 0x21A84E0 VA: 0x1821A90E0
	public void Update() { }

	// RVA: 0x21B2220 Offset: 0x21B1620 VA: 0x1821B2220
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x21AF4F0 Offset: 0x21AE8F0 VA: 0x1821AF4F0
	private static void internalOnLevelWasLoaded(int lvl) { }

	// RVA: 0x21B5BB0 Offset: 0x21B4FB0 VA: 0x1821B5BB0
	public static void update() { }

	// RVA: 0x21B3390 Offset: 0x21B2790 VA: 0x1821B3390
	public static void removeTween(int i, int uniqueId) { }

	// RVA: 0x21B3460 Offset: 0x21B2860 VA: 0x1821B3460
	public static void removeTween(int i) { }

	// RVA: 0x21A9E90 Offset: 0x21A9290 VA: 0x1821A9E90
	public static Vector3[] add(Vector3[] a, Vector3 b) { }

	// RVA: 0x21AB610 Offset: 0x21AAA10 VA: 0x1821AB610
	public static float closestRot(float from, float to) { }

	// RVA: 0x21AA690 Offset: 0x21A9A90 VA: 0x1821AA690
	public static void cancelAll() { }

	// RVA: 0x21AA6E0 Offset: 0x21A9AE0 VA: 0x1821AA6E0
	public static void cancelAll(bool callComplete) { }

	// RVA: 0x21AAF90 Offset: 0x21AA390 VA: 0x1821AAF90
	public static void cancel(GameObject gameObject) { }

	// RVA: 0x21AA950 Offset: 0x21A9D50 VA: 0x1821AA950
	public static void cancel(GameObject gameObject, bool callOnComplete) { }

	// RVA: 0x21AB4D0 Offset: 0x21AA8D0 VA: 0x1821AB4D0
	public static void cancel(RectTransform rect) { }

	// RVA: 0x21AB190 Offset: 0x21AA590 VA: 0x1821AB190
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = False) { }

	// RVA: 0x21AAFF0 Offset: 0x21AA3F0 VA: 0x1821AAFF0
	public static void cancel(LTRect ltRect, int uniqueId) { }

	// RVA: 0x21AB130 Offset: 0x21AA530 VA: 0x1821AB130
	public static void cancel(int uniqueId) { }

	// RVA: 0x21AAC50 Offset: 0x21AA050 VA: 0x1821AAC50
	public static void cancel(int uniqueId, bool callOnComplete) { }

	// RVA: 0x21AC220 Offset: 0x21AB620 VA: 0x1821AC220
	public static LTDescr descr(int uniqueId) { }

	// RVA: 0x21AC570 Offset: 0x21AB970 VA: 0x1821AC570
	public static LTDescr description(int uniqueId) { }

	// RVA: 0x21AC5C0 Offset: 0x21AB9C0 VA: 0x1821AC5C0
	public static LTDescr[] descriptions(GameObject gameObject) { }

	[ObsoleteAttribute] // RVA: 0xB4910 Offset: 0xB3D10 VA: 0x1800B4910
	// RVA: 0x21B2B70 Offset: 0x21B1F70 VA: 0x1821B2B70
	public static void pause(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B2A60 Offset: 0x21B1E60 VA: 0x1821B2A60
	public static void pause(int uniqueId) { }

	// RVA: 0x21B28C0 Offset: 0x21B1CC0 VA: 0x1821B28C0
	public static void pause(GameObject gameObject) { }

	// RVA: 0x21B27C0 Offset: 0x21B1BC0 VA: 0x1821B27C0
	public static void pauseAll() { }

	// RVA: 0x21B3B20 Offset: 0x21B2F20 VA: 0x1821B3B20
	public static void resumeAll() { }

	[ObsoleteAttribute] // RVA: 0xB49E0 Offset: 0xB3DE0 VA: 0x1800B49E0
	// RVA: 0x21B3ED0 Offset: 0x21B32D0 VA: 0x1821B3ED0
	public static void resume(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B3DC0 Offset: 0x21B31C0 VA: 0x1821B3DC0
	public static void resume(int uniqueId) { }

	// RVA: 0x21B3C20 Offset: 0x21B3020 VA: 0x1821B3C20
	public static void resume(GameObject gameObject) { }

	// RVA: 0x21AF6A0 Offset: 0x21AEAA0 VA: 0x1821AF6A0
	public static bool isTweening(GameObject gameObject) { }

	// RVA: 0x21AF910 Offset: 0x21AED10 VA: 0x1821AF910
	public static bool isTweening(RectTransform rect) { }

	// RVA: 0x21AF540 Offset: 0x21AE940 VA: 0x1821AF540
	public static bool isTweening(int uniqueId) { }

	// RVA: 0x21AF980 Offset: 0x21AED80 VA: 0x1821AF980
	public static bool isTweening(LTRect ltRect) { }

	// RVA: 0x21ACC80 Offset: 0x21AC080 VA: 0x1821ACC80
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0, Transform arrowTransform) { }

	// RVA: 0x21AFB60 Offset: 0x21AEF60 VA: 0x1821AFB60
	public static object logError(string error) { }

	// RVA: 0x21B22C0 Offset: 0x21B16C0 VA: 0x1821B22C0
	public static LTDescr options(LTDescr seed) { }

	// RVA: 0x21B2320 Offset: 0x21B1720 VA: 0x1821B2320
	public static LTDescr options() { }

	// RVA: 0x21AEDA0 Offset: 0x21AE1A0 VA: 0x1821AEDA0
	public static GameObject get_tweenEmpty() { }

	// RVA: 0x21B2DF0 Offset: 0x21B21F0 VA: 0x1821B2DF0
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween) { }

	// RVA: 0x21B2CC0 Offset: 0x21B20C0 VA: 0x1821B2CC0
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites) { }

	// RVA: 0x21AA470 Offset: 0x21A9870 VA: 0x1821AA470
	public static LTDescr alpha(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B51D0 Offset: 0x21B45D0 VA: 0x1821B51D0
	public static LTSeq sequence(bool initSequence = True) { }

	// RVA: 0x21AA360 Offset: 0x21A9760 VA: 0x1821AA360
	public static LTDescr alpha(LTRect ltRect, float to, float time) { }

	// RVA: 0x21B5790 Offset: 0x21B4B90 VA: 0x1821B5790
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AA190 Offset: 0x21A9590 VA: 0x1821AA190
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AA0A0 Offset: 0x21A94A0 VA: 0x1821AA0A0
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time) { }

	// RVA: 0x21AA280 Offset: 0x21A9680 VA: 0x1821AA280
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time) { }

	// RVA: 0x21AB9C0 Offset: 0x21AADC0 VA: 0x1821AB9C0
	public static LTDescr color(GameObject gameObject, Color to, float time) { }

	// RVA: 0x21B5880 Offset: 0x21B4C80 VA: 0x1821B5880
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21AB6F0 Offset: 0x21AAAF0 VA: 0x1821AB6F0
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21ABC40 Offset: 0x21AB040 VA: 0x1821ABC40
	public static LTDescr delayedCall(float delayTime, Action callback) { }

	// RVA: 0x21ABD50 Offset: 0x21AB150 VA: 0x1821ABD50
	public static LTDescr delayedCall(float delayTime, Action<object> callback) { }

	// RVA: 0x21ABE60 Offset: 0x21AB260 VA: 0x1821ABE60
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback) { }

	// RVA: 0x21ABB40 Offset: 0x21AAF40 VA: 0x1821ABB40
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback) { }

	// RVA: 0x21AC850 Offset: 0x21ABC50 VA: 0x1821AC850
	public static LTDescr destroyAfter(LTRect rect, float delayTime) { }

	// RVA: 0x21B1580 Offset: 0x21B0980 VA: 0x1821B1580
	public static LTDescr move(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B1BC0 Offset: 0x21B0FC0 VA: 0x1821B1BC0
	public static LTDescr move(GameObject gameObject, Vector2 to, float time) { }

	// RVA: 0x21B1630 Offset: 0x21B0A30 VA: 0x1821B1630
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B1970 Offset: 0x21B0D70 VA: 0x1821B1970
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B1ED0 Offset: 0x21B12D0 VA: 0x1821B1ED0
	public static LTDescr move(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B0D30 Offset: 0x21B0130 VA: 0x1821B0D30
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B0AE0 Offset: 0x21AFEE0 VA: 0x1821B0AE0
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B0860 Offset: 0x21AFC60 VA: 0x1821B0860
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B1CE0 Offset: 0x21B10E0 VA: 0x1821B1CE0
	public static LTDescr move(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B0750 Offset: 0x21AFB50 VA: 0x1821B0750
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B10C0 Offset: 0x21B04C0 VA: 0x1821B10C0
	public static LTDescr moveX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B12B0 Offset: 0x21B06B0 VA: 0x1821B12B0
	public static LTDescr moveY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B1390 Offset: 0x21B0790 VA: 0x1821B1390
	public static LTDescr moveZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B0200 Offset: 0x21AF600 VA: 0x1821B0200
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21AFEC0 Offset: 0x21AF2C0 VA: 0x1821AFEC0
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21AFC20 Offset: 0x21AF020 VA: 0x1821AFC20
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21AFD00 Offset: 0x21AF100 VA: 0x1821AFD00
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21AFDE0 Offset: 0x21AF1E0 VA: 0x1821AFDE0
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B02B0 Offset: 0x21AF6B0 VA: 0x1821B02B0
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B0500 Offset: 0x21AF900 VA: 0x1821B0500
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B2120 Offset: 0x21B1520 VA: 0x1821B2120
	public static LTDescr move(GameObject gameObject, Transform to, float time) { }

	// RVA: 0x21B4AA0 Offset: 0x21B3EA0 VA: 0x1821B4AA0
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B49A0 Offset: 0x21B3DA0 VA: 0x1821B49A0
	public static LTDescr rotate(LTRect ltRect, float to, float time) { }

	// RVA: 0x21B44E0 Offset: 0x21B38E0 VA: 0x1821B44E0
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B4590 Offset: 0x21B3990 VA: 0x1821B4590
	public static LTDescr rotateX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B4670 Offset: 0x21B3A70 VA: 0x1821B4670
	public static LTDescr rotateY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B4750 Offset: 0x21B3B50 VA: 0x1821B4750
	public static LTDescr rotateZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B43D0 Offset: 0x21B37D0 VA: 0x1821B43D0
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21B4170 Offset: 0x21B3570 VA: 0x1821B4170
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21B5040 Offset: 0x21B4440 VA: 0x1821B5040
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B4F30 Offset: 0x21B4330 VA: 0x1821B4F30
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B4C90 Offset: 0x21B4090 VA: 0x1821B4C90
	public static LTDescr scaleX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B4D70 Offset: 0x21B4170 VA: 0x1821B4D70
	public static LTDescr scaleY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B4E50 Offset: 0x21B4250 VA: 0x1821B4E50
	public static LTDescr scaleZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B6420 Offset: 0x21B5820 VA: 0x1821B6420
	public static LTDescr value(GameObject gameObject, float from, float to, float time) { }

	// RVA: 0x21B6E40 Offset: 0x21B6240 VA: 0x1821B6E40
	public static LTDescr value(float from, float to, float time) { }

	// RVA: 0x21B68E0 Offset: 0x21B5CE0 VA: 0x1821B68E0
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21B7440 Offset: 0x21B6840 VA: 0x1821B7440
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21B6720 Offset: 0x21B5B20 VA: 0x1821B6720
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time) { }

	// RVA: 0x21B6FA0 Offset: 0x21B63A0 VA: 0x1821B6FA0
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21B6C90 Offset: 0x21B6090 VA: 0x1821B6C90
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time) { }

	// RVA: 0x21B6A70 Offset: 0x21B5E70 VA: 0x1821B6A70
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21B6200 Offset: 0x21B5600 VA: 0x1821B6200
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21B6580 Offset: 0x21B5980 VA: 0x1821B6580
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21B7310 Offset: 0x21B6710 VA: 0x1821B7310
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21B7150 Offset: 0x21B6550 VA: 0x1821B7150
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21ABF60 Offset: 0x21AB360 VA: 0x1821ABF60
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21AC0C0 Offset: 0x21AB4C0 VA: 0x1821AC0C0
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21B1DF0 Offset: 0x21B11F0 VA: 0x1821B1DF0
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B0FB0 Offset: 0x21B03B0 VA: 0x1821B0FB0
	public static LTDescr moveX(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B11A0 Offset: 0x21B05A0 VA: 0x1821B11A0
	public static LTDescr moveY(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B1470 Offset: 0x21B0870 VA: 0x1821B1470
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B4830 Offset: 0x21B3C30 VA: 0x1821B4830
	public static LTDescr rotate(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B4B50 Offset: 0x21B3F50 VA: 0x1821B4B50
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B4280 Offset: 0x21B3680 VA: 0x1821B4280
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21B4020 Offset: 0x21B3420 VA: 0x1821B4020
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21B50F0 Offset: 0x21B44F0 VA: 0x1821B50F0
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B5550 Offset: 0x21B4950 VA: 0x1821B5550
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time) { }

	// RVA: 0x21AA580 Offset: 0x21A9980 VA: 0x1821AA580
	public static LTDescr alpha(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21AB850 Offset: 0x21AAC50 VA: 0x1821AB850
	public static LTDescr color(RectTransform rectTrans, Color to, float time) { }

	// RVA: 0x21B5B50 Offset: 0x21B4F50 VA: 0x1821B5B50
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21B59E0 Offset: 0x21B4DE0 VA: 0x1821B59E0
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21AEB80 Offset: 0x21ADF80 VA: 0x1821AEB80
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21AE650 Offset: 0x21ADA50 VA: 0x1821AE650
	public static float easeInQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21AE3F0 Offset: 0x21AD7F0 VA: 0x1821AE3F0
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21AE1E0 Offset: 0x21AD5E0 VA: 0x1821AE1E0
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed) { }

	// RVA: 0x21AFAE0 Offset: 0x21AEEE0 VA: 0x1821AFAE0
	public static float linear(float start, float end, float val) { }

	// RVA: 0x21AB540 Offset: 0x21AA940 VA: 0x1821AB540
	public static float clerp(float start, float end, float val) { }

	// RVA: 0x21B5670 Offset: 0x21B4A70 VA: 0x1821B5670
	public static float spring(float start, float end, float val) { }

	// RVA: 0x21AE660 Offset: 0x21ADA60 VA: 0x1821AE660
	public static float easeInQuad(float start, float end, float val) { }

	// RVA: 0x21AEBA0 Offset: 0x21ADFA0 VA: 0x1821AEBA0
	public static float easeOutQuad(float start, float end, float val) { }

	// RVA: 0x21AE450 Offset: 0x21AD850 VA: 0x1821AE450
	public static float easeInOutQuad(float start, float end, float val) { }

	// RVA: 0x21AE1A0 Offset: 0x21AD5A0 VA: 0x1821AE1A0
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2) { }

	// RVA: 0x21AD900 Offset: 0x21ACD00 VA: 0x1821AD900
	public static float easeInCubic(float start, float end, float val) { }

	// RVA: 0x21AE950 Offset: 0x21ADD50 VA: 0x1821AE950
	public static float easeOutCubic(float start, float end, float val) { }

	// RVA: 0x21ADE30 Offset: 0x21AD230 VA: 0x1821ADE30
	public static float easeInOutCubic(float start, float end, float val) { }

	// RVA: 0x21AE680 Offset: 0x21ADA80 VA: 0x1821AE680
	public static float easeInQuart(float start, float end, float val) { }

	// RVA: 0x21AEBD0 Offset: 0x21ADFD0 VA: 0x1821AEBD0
	public static float easeOutQuart(float start, float end, float val) { }

	// RVA: 0x21AE4C0 Offset: 0x21AD8C0 VA: 0x1821AE4C0
	public static float easeInOutQuart(float start, float end, float val) { }

	// RVA: 0x21AE6A0 Offset: 0x21ADAA0 VA: 0x1821AE6A0
	public static float easeInQuint(float start, float end, float val) { }

	// RVA: 0x21AEC10 Offset: 0x21AE010 VA: 0x1821AEC10
	public static float easeOutQuint(float start, float end, float val) { }

	// RVA: 0x21AE530 Offset: 0x21AD930 VA: 0x1821AE530
	public static float easeInOutQuint(float start, float end, float val) { }

	// RVA: 0x21AE6C0 Offset: 0x21ADAC0 VA: 0x1821AE6C0
	public static float easeInSine(float start, float end, float val) { }

	// RVA: 0x21AEC50 Offset: 0x21AE050 VA: 0x1821AEC50
	public static float easeOutSine(float start, float end, float val) { }

	// RVA: 0x21AE5A0 Offset: 0x21AD9A0 VA: 0x1821AE5A0
	public static float easeInOutSine(float start, float end, float val) { }

	// RVA: 0x21ADA80 Offset: 0x21ACE80 VA: 0x1821ADA80
	public static float easeInExpo(float start, float end, float val) { }

	// RVA: 0x21AEAD0 Offset: 0x21ADED0 VA: 0x1821AEAD0
	public static float easeOutExpo(float start, float end, float val) { }

	// RVA: 0x21AE090 Offset: 0x21AD490 VA: 0x1821AE090
	public static float easeInOutExpo(float start, float end, float val) { }

	// RVA: 0x21AD850 Offset: 0x21ACC50 VA: 0x1821AD850
	public static float easeInCirc(float start, float end, float val) { }

	// RVA: 0x21AE8B0 Offset: 0x21ADCB0 VA: 0x1821AE8B0
	public static float easeOutCirc(float start, float end, float val) { }

	// RVA: 0x21ADD30 Offset: 0x21AD130 VA: 0x1821ADD30
	public static float easeInOutCirc(float start, float end, float val) { }

	// RVA: 0x21AD7B0 Offset: 0x21ACBB0 VA: 0x1821AD7B0
	public static float easeInBounce(float start, float end, float val) { }

	// RVA: 0x21AE7B0 Offset: 0x21ADBB0 VA: 0x1821AE7B0
	public static float easeOutBounce(float start, float end, float val) { }

	// RVA: 0x21ADBC0 Offset: 0x21ACFC0 VA: 0x1821ADBC0
	public static float easeInOutBounce(float start, float end, float val) { }

	// RVA: 0x21AD770 Offset: 0x21ACB70 VA: 0x1821AD770
	public static float easeInBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21AE760 Offset: 0x21ADB60 VA: 0x1821AE760
	public static float easeOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21ADB20 Offset: 0x21ACF20 VA: 0x1821ADB20
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21AD920 Offset: 0x21ACD20 VA: 0x1821AD920
	public static float easeInElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21AE980 Offset: 0x21ADD80 VA: 0x1821AE980
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21ADE90 Offset: 0x21AD290 VA: 0x1821ADE90
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21A9E20 Offset: 0x21A9220 VA: 0x1821A9E20
	public static void addListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21A9890 Offset: 0x21A8C90 VA: 0x1821A9890
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B3220 Offset: 0x21B2620 VA: 0x1821B3220
	public static bool removeListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B3290 Offset: 0x21B2690 VA: 0x1821B3290
	public static bool removeListener(int eventId) { }

	// RVA: 0x21B2F50 Offset: 0x21B2350 VA: 0x1821B2F50
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21AC970 Offset: 0x21ABD70 VA: 0x1821AC970
	public static void dispatchEvent(int eventId) { }

	// RVA: 0x21AC9D0 Offset: 0x21ABDD0 VA: 0x1821AC9D0
	public static void dispatchEvent(int eventId, object data) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x21A9130 Offset: 0x21A8530 VA: 0x1821A9130
	private static void .cctor() { }

}

