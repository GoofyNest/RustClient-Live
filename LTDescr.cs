public class LTDescr // TypeDefIndex: 5569
{	// Fields
	public bool toggle; // 0x10
	public bool useEstimatedTime; // 0x11
	public bool useFrames; // 0x12
	public bool useManualTime; // 0x13
	public bool usesNormalDt; // 0x14
	public bool hasInitiliazed; // 0x15
	public bool hasExtraOnCompletes; // 0x16
	public bool hasPhysics; // 0x17
	public bool onCompleteOnRepeat; // 0x18
	public bool onCompleteOnStart; // 0x19
	public bool useRecursion; // 0x1A
	public float ratioPassed; // 0x1C
	public float passed; // 0x20
	public float delay; // 0x24
	public float time; // 0x28
	public float speed; // 0x2C
	public float lastVal; // 0x30
	private uint _id; // 0x34
	public int loopCount; // 0x38
	public uint counter; // 0x3C
	public float direction; // 0x40
	public float directionLast; // 0x44
	public float overshoot; // 0x48
	public float period; // 0x4C
	public float scale; // 0x50
	public bool destroyOnComplete; // 0x54
	public Transform trans; // 0x58
	public LTRect ltRect; // 0x60
	internal Vector3 fromInternal; // 0x68
	internal Vector3 toInternal; // 0x74
	internal Vector3 diff; // 0x80
	internal Vector3 diffDiv2; // 0x8C
	public TweenAction type; // 0x98
	private LeanTweenType easeType; // 0x9C
	public LeanTweenType loopType; // 0xA0
	public bool hasUpdateCallback; // 0xA4
	public LTDescr.EaseTypeDelegate easeMethod; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private LTDescr.ActionMethodDelegate <easeInternal>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private LTDescr.ActionMethodDelegate <initInternal>k__BackingField; // 0xB8
	public SpriteRenderer spriteRen; // 0xC0
	public RectTransform rectTransform; // 0xC8
	public Text uiText; // 0xD0
	public Image uiImage; // 0xD8
	public RawImage rawImage; // 0xE0
	public Sprite[] sprites; // 0xE8
	public LTDescrOptional _optional; // 0xF0
	public static float val; // 0x0
	public static float dt; // 0x4
	public static Vector3 newVect; // 0x8

	// Properties
	public Vector3 from { get; set; }
	public Vector3 to { get; set; }
	public LTDescr.ActionMethodDelegate easeInternal { get; set; }
	public LTDescr.ActionMethodDelegate initInternal { get; set; }
	public int uniqueId { get; }
	public int id { get; }
	public LTDescrOptional optional { get; set; }

	// Methods

	// RVA: 0x1993B90 Offset: 0x1992F90 VA: 0x181993B90
	public Vector3 get_from() { }

	// RVA: 0x1999C10 Offset: 0x1999010 VA: 0x181999C10
	public void set_from(Vector3 value) { }

	// RVA: 0x1993BC0 Offset: 0x1992FC0 VA: 0x181993BC0
	public Vector3 get_to() { }

	// RVA: 0x1999C30 Offset: 0x1999030 VA: 0x181999C30
	public void set_to(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280
	public LTDescr.ActionMethodDelegate get_easeInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE00 Offset: 0xA2B200 VA: 0x180A2BE00
	public void set_easeInternal(LTDescr.ActionMethodDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	public LTDescr.ActionMethodDelegate get_initInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE10 Offset: 0xA2B210 VA: 0x180A2BE10
	public void set_initInternal(LTDescr.ActionMethodDelegate value) { }

	// RVA: 0x1988DF0 Offset: 0x19881F0 VA: 0x181988DF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x198F6C0 Offset: 0x198EAC0 VA: 0x18198F6C0
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0xA7EC0 Offset: 0xA72C0 VA: 0x1800A7EC0
	// RVA: 0x19902A0 Offset: 0x198F6A0 VA: 0x1819902A0
	public LTDescr cancel(GameObject gameObject) { }

	// RVA: 0x1993BB0 Offset: 0x1992FB0 VA: 0x181993BB0
	public int get_uniqueId() { }

	// RVA: 0x1993BB0 Offset: 0x1992FB0 VA: 0x181993BB0
	public int get_id() { }

	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public LTDescrOptional get_optional() { }

	// RVA: 0x1999C20 Offset: 0x1999020 VA: 0x181999C20
	public void set_optional(LTDescrOptional value) { }

	// RVA: 0x1993FD0 Offset: 0x19933D0 VA: 0x181993FD0
	public void reset() { }

	// RVA: 0x19981E0 Offset: 0x19975E0 VA: 0x1819981E0
	public LTDescr setMoveX() { }

	// RVA: 0x19982B0 Offset: 0x19976B0 VA: 0x1819982B0
	public LTDescr setMoveY() { }

	// RVA: 0x1998380 Offset: 0x1997780 VA: 0x181998380
	public LTDescr setMoveZ() { }

	// RVA: 0x1997C30 Offset: 0x1997030 VA: 0x181997C30
	public LTDescr setMoveLocalX() { }

	// RVA: 0x1997D00 Offset: 0x1997100 VA: 0x181997D00
	public LTDescr setMoveLocalY() { }

	// RVA: 0x1997DD0 Offset: 0x19971D0 VA: 0x181997DD0
	public LTDescr setMoveLocalZ() { }

	// RVA: 0x1993C30 Offset: 0x1993030 VA: 0x181993C30
	private void initFromInternal() { }

	// RVA: 0x1997B60 Offset: 0x1996F60 VA: 0x181997B60
	public LTDescr setMoveCurved() { }

	// RVA: 0x1997A90 Offset: 0x1996E90 VA: 0x181997A90
	public LTDescr setMoveCurvedLocal() { }

	// RVA: 0x1998040 Offset: 0x1997440 VA: 0x181998040
	public LTDescr setMoveSpline() { }

	// RVA: 0x1997F70 Offset: 0x1997370 VA: 0x181997F70
	public LTDescr setMoveSplineLocal() { }

	// RVA: 0x1999420 Offset: 0x1998820 VA: 0x181999420
	public LTDescr setScaleX() { }

	// RVA: 0x19994F0 Offset: 0x19988F0 VA: 0x1819994F0
	public LTDescr setScaleY() { }

	// RVA: 0x19995C0 Offset: 0x19989C0 VA: 0x1819995C0
	public LTDescr setScaleZ() { }

	// RVA: 0x19990E0 Offset: 0x19984E0 VA: 0x1819990E0
	public LTDescr setRotateX() { }

	// RVA: 0x19991B0 Offset: 0x19985B0 VA: 0x1819991B0
	public LTDescr setRotateY() { }

	// RVA: 0x1999280 Offset: 0x1998680 VA: 0x181999280
	public LTDescr setRotateZ() { }

	// RVA: 0x1998F40 Offset: 0x1998340 VA: 0x181998F40
	public LTDescr setRotateAround() { }

	// RVA: 0x1998E70 Offset: 0x1998270 VA: 0x181998E70
	public LTDescr setRotateAroundLocal() { }

	// RVA: 0x1994340 Offset: 0x1993740 VA: 0x181994340
	public LTDescr setAlpha() { }

	// RVA: 0x19997D0 Offset: 0x1998BD0 VA: 0x1819997D0
	public LTDescr setTextAlpha() { }

	// RVA: 0x1994270 Offset: 0x1993670 VA: 0x181994270
	public LTDescr setAlphaVertex() { }

	// RVA: 0x1995060 Offset: 0x1994460 VA: 0x181995060
	public LTDescr setColor() { }

	// RVA: 0x1994480 Offset: 0x1993880 VA: 0x181994480
	public LTDescr setCallbackColor() { }

	// RVA: 0x19998A0 Offset: 0x1998CA0 VA: 0x1819998A0
	public LTDescr setTextColor() { }

	// RVA: 0x19946A0 Offset: 0x1993AA0 VA: 0x1819946A0
	public LTDescr setCanvasAlpha() { }

	// RVA: 0x1994840 Offset: 0x1993C40 VA: 0x181994840
	public LTDescr setCanvasGroupAlpha() { }

	// RVA: 0x1994770 Offset: 0x1993B70 VA: 0x181994770
	public LTDescr setCanvasColor() { }

	// RVA: 0x1994910 Offset: 0x1993D10 VA: 0x181994910
	public LTDescr setCanvasMoveX() { }

	// RVA: 0x19949E0 Offset: 0x1993DE0 VA: 0x1819949E0
	public LTDescr setCanvasMoveY() { }

	// RVA: 0x1994AB0 Offset: 0x1993EB0 VA: 0x181994AB0
	public LTDescr setCanvasMoveZ() { }

	// RVA: 0x1993BE0 Offset: 0x1992FE0 VA: 0x181993BE0
	private void initCanvasRotateAround() { }

	// RVA: 0x1994DF0 Offset: 0x19941F0 VA: 0x181994DF0
	public LTDescr setCanvasRotateAround() { }

	// RVA: 0x1994D20 Offset: 0x1994120 VA: 0x181994D20
	public LTDescr setCanvasRotateAroundLocal() { }

	// RVA: 0x1994C50 Offset: 0x1994050 VA: 0x181994C50
	public LTDescr setCanvasPlaySprite() { }

	// RVA: 0x1994B80 Offset: 0x1993F80 VA: 0x181994B80
	public LTDescr setCanvasMove() { }

	// RVA: 0x1994EC0 Offset: 0x19942C0 VA: 0x181994EC0
	public LTDescr setCanvasScale() { }

	// RVA: 0x1994F90 Offset: 0x1994390 VA: 0x181994F90
	public LTDescr setCanvasSizeDelta() { }

	// RVA: 0x1990220 Offset: 0x198F620 VA: 0x181990220
	private void callback() { }

	// RVA: 0x1994550 Offset: 0x1993950 VA: 0x181994550
	public LTDescr setCallback() { }

	// RVA: 0x1999AC0 Offset: 0x1998EC0 VA: 0x181999AC0
	public LTDescr setValue3() { }

	// RVA: 0x1998450 Offset: 0x1997850 VA: 0x181998450
	public LTDescr setMove() { }

	// RVA: 0x1997EA0 Offset: 0x19972A0 VA: 0x181997EA0
	public LTDescr setMoveLocal() { }

	// RVA: 0x1998110 Offset: 0x1997510 VA: 0x181998110
	public LTDescr setMoveToTransform() { }

	// RVA: 0x1999350 Offset: 0x1998750 VA: 0x181999350
	public LTDescr setRotate() { }

	// RVA: 0x1999010 Offset: 0x1998410 VA: 0x181999010
	public LTDescr setRotateLocal() { }

	// RVA: 0x19996A0 Offset: 0x1998AA0 VA: 0x1819996A0
	public LTDescr setScale() { }

	// RVA: 0x1997750 Offset: 0x1996B50 VA: 0x181997750
	public LTDescr setGUIMove() { }

	// RVA: 0x1997680 Offset: 0x1996A80 VA: 0x181997680
	public LTDescr setGUIMoveMargin() { }

	// RVA: 0x19978F0 Offset: 0x1996CF0 VA: 0x1819978F0
	public LTDescr setGUIScale() { }

	// RVA: 0x19975B0 Offset: 0x19969B0 VA: 0x1819975B0
	public LTDescr setGUIAlpha() { }

	// RVA: 0x1997820 Offset: 0x1996C20 VA: 0x181997820
	public LTDescr setGUIRotate() { }

	// RVA: 0x1995140 Offset: 0x1994540 VA: 0x181995140
	public LTDescr setDelayedSound() { }

	// RVA: 0x1993DB0 Offset: 0x19931B0 VA: 0x181993DB0
	private void init() { }

	// RVA: 0x1993C40 Offset: 0x1993040 VA: 0x181993C40
	private void initSpeed() { }

	// RVA: 0x199ABA0 Offset: 0x1999FA0 VA: 0x18199ABA0
	public LTDescr updateNow() { }

	// RVA: 0x199A6B0 Offset: 0x1999AB0 VA: 0x18199A6B0
	public bool updateInternal() { }

	// RVA: 0x1990100 Offset: 0x198F500 VA: 0x181990100
	public void callOnCompletes() { }

	// RVA: 0x1997200 Offset: 0x1996600 VA: 0x181997200
	public LTDescr setFromColor(Color col) { }

	// RVA: 0x198FCB0 Offset: 0x198F0B0 VA: 0x18198FCB0
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = True) { }

	// RVA: 0x1990610 Offset: 0x198FA10 VA: 0x181990610
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = True) { }

	// RVA: 0x198F9D0 Offset: 0x198EDD0 VA: 0x18198F9D0
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0) { }

	// RVA: 0x198F730 Offset: 0x198EB30 VA: 0x18198F730
	private static void alphaRecursiveSprite(Transform transform, float val) { }

	// RVA: 0x1990370 Offset: 0x198F770 VA: 0x181990370
	private static void colorRecursiveSprite(Transform transform, Color toColor) { }

	// RVA: 0x1990900 Offset: 0x198FD00 VA: 0x181990900
	private static void colorRecursive(RectTransform rectTransform, Color toColor) { }

	// RVA: 0x1999C40 Offset: 0x1999040 VA: 0x181999C40
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x1999EB0 Offset: 0x19992B0 VA: 0x181999EB0
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x199A160 Offset: 0x1999560 VA: 0x18199A160
	private static void textColorRecursive(Transform trans, Color toColor) { }

	// RVA: 0x199A390 Offset: 0x1999790 VA: 0x18199A390
	private static Color tweenColor(LTDescr tween, float val) { }

	// RVA: 0x1993FB0 Offset: 0x19933B0 VA: 0x181993FB0
	public LTDescr pause() { }

	// RVA: 0x1994260 Offset: 0x1993660 VA: 0x181994260
	public LTDescr resume() { }

	// RVA: 0x1994450 Offset: 0x1993850 VA: 0x181994450
	public LTDescr setAxis(Vector3 axis) { }

	// RVA: 0x1995130 Offset: 0x1994530 VA: 0x181995130
	public LTDescr setDelay(float delay) { }

	// RVA: 0x1996870 Offset: 0x1995C70 VA: 0x181996870
	public LTDescr setEase(LeanTweenType easeType) { }

	// RVA: 0x1995F40 Offset: 0x1995340 VA: 0x181995F40
	public LTDescr setEaseLinear() { }

	// RVA: 0x1996730 Offset: 0x1995B30 VA: 0x181996730
	public LTDescr setEaseSpring() { }

	// RVA: 0x1995D00 Offset: 0x1995100 VA: 0x181995D00
	public LTDescr setEaseInQuad() { }

	// RVA: 0x1996330 Offset: 0x1995730 VA: 0x181996330
	public LTDescr setEaseOutQuad() { }

	// RVA: 0x1995AC0 Offset: 0x1994EC0 VA: 0x181995AC0
	public LTDescr setEaseInOutQuad() { }

	// RVA: 0x19955B0 Offset: 0x19949B0 VA: 0x1819955B0
	public LTDescr setEaseInCubic() { }

	// RVA: 0x1996180 Offset: 0x1995580 VA: 0x181996180
	public LTDescr setEaseOutCubic() { }

	// RVA: 0x1995910 Offset: 0x1994D10 VA: 0x181995910
	public LTDescr setEaseInOutCubic() { }

	// RVA: 0x1995D90 Offset: 0x1995190 VA: 0x181995D90
	public LTDescr setEaseInQuart() { }

	// RVA: 0x19963C0 Offset: 0x19957C0 VA: 0x1819963C0
	public LTDescr setEaseOutQuart() { }

	// RVA: 0x1995B50 Offset: 0x1994F50 VA: 0x181995B50
	public LTDescr setEaseInOutQuart() { }

	// RVA: 0x1995E20 Offset: 0x1995220 VA: 0x181995E20
	public LTDescr setEaseInQuint() { }

	// RVA: 0x1996450 Offset: 0x1995850 VA: 0x181996450
	public LTDescr setEaseOutQuint() { }

	// RVA: 0x1995BE0 Offset: 0x1994FE0 VA: 0x181995BE0
	public LTDescr setEaseInOutQuint() { }

	// RVA: 0x1995EB0 Offset: 0x19952B0 VA: 0x181995EB0
	public LTDescr setEaseInSine() { }

	// RVA: 0x19964E0 Offset: 0x19958E0 VA: 0x1819964E0
	public LTDescr setEaseOutSine() { }

	// RVA: 0x1995C70 Offset: 0x1995070 VA: 0x181995C70
	public LTDescr setEaseInOutSine() { }

	// RVA: 0x19956D0 Offset: 0x1994AD0 VA: 0x1819956D0
	public LTDescr setEaseInExpo() { }

	// RVA: 0x19962A0 Offset: 0x19956A0 VA: 0x1819962A0
	public LTDescr setEaseOutExpo() { }

	// RVA: 0x1995A30 Offset: 0x1994E30 VA: 0x181995A30
	public LTDescr setEaseInOutExpo() { }

	// RVA: 0x1995520 Offset: 0x1994920 VA: 0x181995520
	public LTDescr setEaseInCirc() { }

	// RVA: 0x19960F0 Offset: 0x19954F0 VA: 0x1819960F0
	public LTDescr setEaseOutCirc() { }

	// RVA: 0x1995880 Offset: 0x1994C80 VA: 0x181995880
	public LTDescr setEaseInOutCirc() { }

	// RVA: 0x1995490 Offset: 0x1994890 VA: 0x181995490
	public LTDescr setEaseInBounce() { }

	// RVA: 0x1996060 Offset: 0x1995460 VA: 0x181996060
	public LTDescr setEaseOutBounce() { }

	// RVA: 0x19957F0 Offset: 0x1994BF0 VA: 0x1819957F0
	public LTDescr setEaseInOutBounce() { }

	// RVA: 0x1995400 Offset: 0x1994800 VA: 0x181995400
	public LTDescr setEaseInBack() { }

	// RVA: 0x1995FD0 Offset: 0x19953D0 VA: 0x181995FD0
	public LTDescr setEaseOutBack() { }

	// RVA: 0x1995760 Offset: 0x1994B60 VA: 0x181995760
	public LTDescr setEaseInOutBack() { }

	// RVA: 0x1995640 Offset: 0x1994A40 VA: 0x181995640
	public LTDescr setEaseInElastic() { }

	// RVA: 0x1996210 Offset: 0x1995610 VA: 0x181996210
	public LTDescr setEaseOutElastic() { }

	// RVA: 0x19959A0 Offset: 0x1994DA0 VA: 0x1819959A0
	public LTDescr setEaseInOutElastic() { }

	// RVA: 0x1996570 Offset: 0x1995970 VA: 0x181996570
	public LTDescr setEasePunch() { }

	// RVA: 0x1996650 Offset: 0x1995A50 VA: 0x181996650
	public LTDescr setEaseShake() { }

	// RVA: 0x199A550 Offset: 0x1999950 VA: 0x18199A550
	private Vector3 tweenOnCurve() { }

	// RVA: 0x1992020 Offset: 0x1991420 VA: 0x181992020
	private Vector3 easeInOutQuad() { }

	// RVA: 0x1992620 Offset: 0x1991A20 VA: 0x181992620
	private Vector3 easeInQuad() { }

	// RVA: 0x19934C0 Offset: 0x19928C0 VA: 0x1819934C0
	private Vector3 easeOutQuad() { }

	// RVA: 0x1992AC0 Offset: 0x1991EC0 VA: 0x181992AC0
	private Vector3 easeLinear() { }

	// RVA: 0x19939B0 Offset: 0x1992DB0 VA: 0x1819939B0
	private Vector3 easeSpring() { }

	// RVA: 0x1991020 Offset: 0x1990420 VA: 0x181991020
	private Vector3 easeInCubic() { }

	// RVA: 0x19930E0 Offset: 0x19924E0 VA: 0x1819930E0
	private Vector3 easeOutCubic() { }

	// RVA: 0x1991AF0 Offset: 0x1990EF0 VA: 0x181991AF0
	private Vector3 easeInOutCubic() { }

	// RVA: 0x1992720 Offset: 0x1991B20 VA: 0x181992720
	private Vector3 easeInQuart() { }

	// RVA: 0x19935F0 Offset: 0x19929F0 VA: 0x1819935F0
	private Vector3 easeOutQuart() { }

	// RVA: 0x1992150 Offset: 0x1991550 VA: 0x181992150
	private Vector3 easeInOutQuart() { }

	// RVA: 0x1992840 Offset: 0x1991C40 VA: 0x181992840
	private Vector3 easeInQuint() { }

	// RVA: 0x1993720 Offset: 0x1992B20 VA: 0x181993720
	private Vector3 easeOutQuint() { }

	// RVA: 0x1992380 Offset: 0x1991780 VA: 0x181992380
	private Vector3 easeInOutQuint() { }

	// RVA: 0x1992950 Offset: 0x1991D50 VA: 0x181992950
	private Vector3 easeInSine() { }

	// RVA: 0x1993850 Offset: 0x1992C50 VA: 0x181993850
	private Vector3 easeOutSine() { }

	// RVA: 0x19924E0 Offset: 0x19918E0 VA: 0x1819924E0
	private Vector3 easeInOutSine() { }

	// RVA: 0x19912A0 Offset: 0x19906A0 VA: 0x1819912A0
	private Vector3 easeInExpo() { }

	// RVA: 0x1993380 Offset: 0x1992780 VA: 0x181993380
	private Vector3 easeOutExpo() { }

	// RVA: 0x1991DC0 Offset: 0x19911C0 VA: 0x181991DC0
	private Vector3 easeInOutExpo() { }

	// RVA: 0x1990EE0 Offset: 0x19902E0 VA: 0x181990EE0
	private Vector3 easeInCirc() { }

	// RVA: 0x1992F90 Offset: 0x1992390 VA: 0x181992F90
	private Vector3 easeOutCirc() { }

	// RVA: 0x1991930 Offset: 0x1990D30 VA: 0x181991930
	private Vector3 easeInOutCirc() { }

	// RVA: 0x1990D20 Offset: 0x1990120 VA: 0x181990D20
	private Vector3 easeInBounce() { }

	// RVA: 0x1992D00 Offset: 0x1992100 VA: 0x181992D00
	private Vector3 easeOutBounce() { }

	// RVA: 0x1991640 Offset: 0x1990A40 VA: 0x181991640
	private Vector3 easeInOutBounce() { }

	// RVA: 0x1990B70 Offset: 0x198FF70 VA: 0x181990B70
	private Vector3 easeInBack() { }

	// RVA: 0x1992BA0 Offset: 0x1991FA0 VA: 0x181992BA0
	private Vector3 easeOutBack() { }

	// RVA: 0x19913E0 Offset: 0x19907E0 VA: 0x1819913E0
	private Vector3 easeInOutBack() { }

	// RVA: 0x1991120 Offset: 0x1990520 VA: 0x181991120
	private Vector3 easeInElastic() { }

	// RVA: 0x1993200 Offset: 0x1992600 VA: 0x181993200
	private Vector3 easeOutElastic() { }

	// RVA: 0x1991C40 Offset: 0x1991040 VA: 0x181991C40
	private Vector3 easeInOutElastic() { }

	// RVA: 0x1998C90 Offset: 0x1998090 VA: 0x181998C90
	public LTDescr setOvershoot(float overshoot) { }

	// RVA: 0x1998CE0 Offset: 0x19980E0 VA: 0x181998CE0
	public LTDescr setPeriod(float period) { }

	// RVA: 0x1999690 Offset: 0x1998A90 VA: 0x181999690
	public LTDescr setScale(float scale) { }

	// RVA: 0x19967C0 Offset: 0x1995BC0 VA: 0x1819967C0
	public LTDescr setEase(AnimationCurve easeCurve) { }

	// RVA: 0x1999990 Offset: 0x1998D90 VA: 0x181999990
	public LTDescr setTo(Vector3 to) { }

	// RVA: 0x1999A70 Offset: 0x1998E70 VA: 0x181999A70
	public LTDescr setTo(Transform to) { }

	// RVA: 0x19972F0 Offset: 0x19966F0 VA: 0x1819972F0
	public LTDescr setFrom(Vector3 from) { }

	// RVA: 0x1997440 Offset: 0x1996840 VA: 0x181997440
	public LTDescr setFrom(float from) { }

	// RVA: 0x1995220 Offset: 0x1994620 VA: 0x181995220
	public LTDescr setDiff(Vector3 diff) { }

	// RVA: 0x19979C0 Offset: 0x1996DC0 VA: 0x1819979C0
	public LTDescr setHasInitialized(bool has) { }

	// RVA: 0x19979D0 Offset: 0x1996DD0 VA: 0x1819979D0
	public LTDescr setId(uint id, uint global_counter) { }

	// RVA: 0x1998CA0 Offset: 0x19980A0 VA: 0x181998CA0
	public LTDescr setPassed(float passed) { }

	// RVA: 0x1999970 Offset: 0x1998D70 VA: 0x181999970
	public LTDescr setTime(float time) { }

	// RVA: 0x1999770 Offset: 0x1998B70 VA: 0x181999770
	public LTDescr setSpeed(float speed) { }

	// RVA: 0x1998E30 Offset: 0x1998230 VA: 0x181998E30
	public LTDescr setRepeat(int repeat) { }

	// RVA: 0x1997A80 Offset: 0x1996E80 VA: 0x181997A80
	public LTDescr setLoopType(LeanTweenType loopType) { }

	// RVA: 0x19979E0 Offset: 0x1996DE0 VA: 0x1819979E0
	public LTDescr setUseEstimatedTime(bool useEstimatedTime) { }

	// RVA: 0x19979E0 Offset: 0x1996DE0 VA: 0x1819979E0
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime) { }

	// RVA: 0x1999AA0 Offset: 0x1998EA0 VA: 0x181999AA0
	public LTDescr setUseFrames(bool useFrames) { }

	// RVA: 0x1999AB0 Offset: 0x1998EB0 VA: 0x181999AB0
	public LTDescr setUseManualTime(bool useManualTime) { }

	// RVA: 0x1997A10 Offset: 0x1996E10 VA: 0x181997A10
	public LTDescr setLoopCount(int loopCount) { }

	// RVA: 0x1997A30 Offset: 0x1996E30 VA: 0x181997A30
	public LTDescr setLoopOnce() { }

	// RVA: 0x19979F0 Offset: 0x1996DF0 VA: 0x1819979F0
	public LTDescr setLoopClamp() { }

	// RVA: 0xE85B70 Offset: 0xE84F70 VA: 0x180E85B70
	public LTDescr setLoopClamp(int loops) { }

	// RVA: 0x1997A40 Offset: 0x1996E40 VA: 0x181997A40
	public LTDescr setLoopPingPong() { }

	// RVA: 0x1997A60 Offset: 0x1996E60 VA: 0x181997A60
	public LTDescr setLoopPingPong(int loops) { }

	// RVA: 0x19985F0 Offset: 0x19979F0 VA: 0x1819985F0
	public LTDescr setOnComplete(Action onComplete) { }

	// RVA: 0x1998630 Offset: 0x1997A30 VA: 0x181998630
	public LTDescr setOnComplete(Action<object> onComplete) { }

	// RVA: 0x1998580 Offset: 0x1997980 VA: 0x181998580
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam) { }

	// RVA: 0x1998540 Offset: 0x1997940 VA: 0x181998540
	public LTDescr setOnCompleteParam(object onCompleteParam) { }

	// RVA: 0x19988E0 Offset: 0x1997CE0 VA: 0x1819988E0
	public LTDescr setOnUpdate(Action<float> onUpdate) { }

	// RVA: 0x19987B0 Offset: 0x1997BB0 VA: 0x1819987B0
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate) { }

	// RVA: 0x1998730 Offset: 0x1997B30 VA: 0x181998730
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate) { }

	// RVA: 0x19987F0 Offset: 0x1997BF0 VA: 0x1819987F0
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate) { }

	// RVA: 0x1998830 Offset: 0x1997C30 VA: 0x181998830
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate) { }

	// RVA: 0x19986B0 Offset: 0x1997AB0 VA: 0x1819986B0
	public LTDescr setOnUpdateColor(Action<Color> onUpdate) { }

	// RVA: 0x19986F0 Offset: 0x1997AF0 VA: 0x1819986F0
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate) { }

	// RVA: 0x19986B0 Offset: 0x1997AB0 VA: 0x1819986B0
	public LTDescr setOnUpdate(Action<Color> onUpdate) { }

	// RVA: 0x19986F0 Offset: 0x1997AF0 VA: 0x1819986F0
	public LTDescr setOnUpdate(Action<Color, object> onUpdate) { }

	// RVA: 0x1998920 Offset: 0x1997D20 VA: 0x181998920
	public LTDescr setOnUpdate(Action<float, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x1998870 Offset: 0x1997C70 VA: 0x181998870
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x1998990 Offset: 0x1997D90 VA: 0x181998990
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, object onUpdateParam) { }

	// RVA: 0x1998A00 Offset: 0x1997E00 VA: 0x181998A00
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, object onUpdateParam) { }

	// RVA: 0x1998770 Offset: 0x1997B70 VA: 0x181998770
	public LTDescr setOnUpdateParam(object onUpdateParam) { }

	// RVA: 0x1998BA0 Offset: 0x1997FA0 VA: 0x181998BA0
	public LTDescr setOrientToPath(bool doesOrient) { }

	// RVA: 0x1998A70 Offset: 0x1997E70 VA: 0x181998A70
	public LTDescr setOrientToPath2d(bool doesOrient2d) { }

	// RVA: 0x1998D20 Offset: 0x1998120 VA: 0x181998D20
	public LTDescr setRect(LTRect rect) { }

	// RVA: 0x1998D80 Offset: 0x1998180 VA: 0x181998D80
	public LTDescr setRect(Rect rect) { }

	// RVA: 0x1998CB0 Offset: 0x19980B0 VA: 0x181998CB0
	public LTDescr setPath(LTBezierPath path) { }

	// RVA: 0x1998CF0 Offset: 0x19980F0 VA: 0x181998CF0
	public LTDescr setPoint(Vector3 point) { }

	// RVA: 0x1995210 Offset: 0x1994610 VA: 0x181995210
	public LTDescr setDestroyOnComplete(bool doesDestroy) { }

	// RVA: 0x1994410 Offset: 0x1993810 VA: 0x181994410
	public LTDescr setAudio(object audio) { }

	// RVA: 0x1998520 Offset: 0x1997920 VA: 0x181998520
	public LTDescr setOnCompleteOnRepeat(bool isOn) { }

	// RVA: 0x1998530 Offset: 0x1997930 VA: 0x181998530
	public LTDescr setOnCompleteOnStart(bool isOn) { }

	// RVA: 0x1998D50 Offset: 0x1998150 VA: 0x181998D50
	public LTDescr setRect(RectTransform rect) { }

	// RVA: 0x19997A0 Offset: 0x1998BA0 VA: 0x1819997A0
	public LTDescr setSprites(Sprite[] sprites) { }

	// RVA: 0x19971D0 Offset: 0x19965D0 VA: 0x1819971D0
	public LTDescr setFrameRate(float frameRate) { }

	// RVA: 0x1998670 Offset: 0x1997A70 VA: 0x181998670
	public LTDescr setOnStart(Action onStart) { }

	// RVA: 0x1995240 Offset: 0x1994640 VA: 0x181995240
	public LTDescr setDirection(float direction) { }

	// RVA: 0x1998E20 Offset: 0x1998220 VA: 0x181998E20
	public LTDescr setRecursive(bool useRecursion) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198DB80 Offset: 0x198CF80 VA: 0x18198DB80
	private void <setMoveX>b__71_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198DBB0 Offset: 0x198CFB0 VA: 0x18198DBB0
	private void <setMoveX>b__71_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198DCA0 Offset: 0x198D0A0 VA: 0x18198DCA0
	private void <setMoveY>b__72_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198DCE0 Offset: 0x198D0E0 VA: 0x18198DCE0
	private void <setMoveY>b__72_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198DDE0 Offset: 0x198D1E0 VA: 0x18198DDE0
	private void <setMoveZ>b__73_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198DE20 Offset: 0x198D220 VA: 0x18198DE20
	private void <setMoveZ>b__73_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D360 Offset: 0x198C760 VA: 0x18198D360
	private void <setMoveLocalX>b__74_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D390 Offset: 0x198C790 VA: 0x18198D390
	private void <setMoveLocalX>b__74_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D480 Offset: 0x198C880 VA: 0x18198D480
	private void <setMoveLocalY>b__75_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D4C0 Offset: 0x198C8C0 VA: 0x18198D4C0
	private void <setMoveLocalY>b__75_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D5C0 Offset: 0x198C9C0 VA: 0x18198D5C0
	private void <setMoveLocalZ>b__76_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D600 Offset: 0x198CA00 VA: 0x18198D600
	private void <setMoveLocalZ>b__76_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198CEF0 Offset: 0x198C2F0 VA: 0x18198CEF0
	private void <setMoveCurved>b__78_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198CAC0 Offset: 0x198BEC0 VA: 0x18198CAC0
	private void <setMoveCurvedLocal>b__79_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D7E0 Offset: 0x198CBE0 VA: 0x18198D7E0
	private void <setMoveSpline>b__80_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D6E0 Offset: 0x198CAE0 VA: 0x18198D6E0
	private void <setMoveSplineLocal>b__81_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198EFB0 Offset: 0x198E3B0 VA: 0x18198EFB0
	private void <setScaleX>b__82_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198EFE0 Offset: 0x198E3E0 VA: 0x18198EFE0
	private void <setScaleX>b__82_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198F0D0 Offset: 0x198E4D0 VA: 0x18198F0D0
	private void <setScaleY>b__83_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198F110 Offset: 0x198E510 VA: 0x18198F110
	private void <setScaleY>b__83_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198F210 Offset: 0x198E610 VA: 0x18198F210
	private void <setScaleZ>b__84_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198F250 Offset: 0x198E650 VA: 0x18198F250
	private void <setScaleZ>b__84_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198EA10 Offset: 0x198DE10 VA: 0x18198EA10
	private void <setRotateX>b__85_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198EAB0 Offset: 0x198DEB0 VA: 0x18198EAB0
	private void <setRotateX>b__85_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198EBA0 Offset: 0x198DFA0 VA: 0x18198EBA0
	private void <setRotateY>b__86_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198EC40 Offset: 0x198E040 VA: 0x18198EC40
	private void <setRotateY>b__86_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198ED40 Offset: 0x198E140 VA: 0x18198ED40
	private void <setRotateZ>b__87_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198EDF0 Offset: 0x198E1F0 VA: 0x18198EDF0
	private void <setRotateZ>b__87_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198E2F0 Offset: 0x198D6F0 VA: 0x18198E2F0
	private void <setRotateAround>b__88_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198E340 Offset: 0x198D740 VA: 0x18198E340
	private void <setRotateAround>b__88_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198DF00 Offset: 0x198D300 VA: 0x18198DF00
	private void <setRotateAroundLocal>b__89_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198DF50 Offset: 0x198D350 VA: 0x18198DF50
	private void <setRotateAroundLocal>b__89_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1989A50 Offset: 0x1988E50 VA: 0x181989A50
	private void <setAlpha>b__90_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198A150 Offset: 0x1989550 VA: 0x18198A150
	private void <setAlpha>b__90_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1989F60 Offset: 0x1989360 VA: 0x181989F60
	private void <setAlpha>b__90_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198F330 Offset: 0x198E730 VA: 0x18198F330
	private void <setTextAlpha>b__91_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198F420 Offset: 0x198E820 VA: 0x18198F420
	private void <setTextAlpha>b__91_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198A320 Offset: 0x1989720 VA: 0x18198A320
	private void <setAlphaVertex>b__92_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198A3B0 Offset: 0x19897B0 VA: 0x18198A3B0
	private void <setAlphaVertex>b__92_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198BDB0 Offset: 0x198B1B0 VA: 0x18198BDB0
	private void <setColor>b__93_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C290 Offset: 0x198B690 VA: 0x18198C290
	private void <setColor>b__93_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198A630 Offset: 0x1989A30 VA: 0x18198A630
	private void <setCallbackColor>b__94_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198A680 Offset: 0x1989A80 VA: 0x18198A680
	private void <setCallbackColor>b__94_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198F470 Offset: 0x198E870 VA: 0x18198F470
	private void <setTextColor>b__95_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198F570 Offset: 0x198E970 VA: 0x18198F570
	private void <setTextColor>b__95_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198A850 Offset: 0x1989C50 VA: 0x18198A850
	private void <setCanvasAlpha>b__96_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198A9B0 Offset: 0x1989DB0 VA: 0x18198A9B0
	private void <setCanvasAlpha>b__96_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198AF20 Offset: 0x198A320 VA: 0x18198AF20
	private void <setCanvasGroupAlpha>b__97_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198AF80 Offset: 0x198A380 VA: 0x18198AF80
	private void <setCanvasGroupAlpha>b__97_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198ABC0 Offset: 0x1989FC0 VA: 0x18198ABC0
	private void <setCanvasColor>b__98_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198AD60 Offset: 0x198A160 VA: 0x18198AD60
	private void <setCanvasColor>b__98_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B0A0 Offset: 0x198A4A0 VA: 0x18198B0A0
	private void <setCanvasMoveX>b__99_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B0E0 Offset: 0x198A4E0 VA: 0x18198B0E0
	private void <setCanvasMoveX>b__99_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B1A0 Offset: 0x198A5A0 VA: 0x18198B1A0
	private void <setCanvasMoveY>b__100_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B1E0 Offset: 0x198A5E0 VA: 0x18198B1E0
	private void <setCanvasMoveY>b__100_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B2A0 Offset: 0x198A6A0 VA: 0x18198B2A0
	private void <setCanvasMoveZ>b__101_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B2E0 Offset: 0x198A6E0 VA: 0x18198B2E0
	private void <setCanvasMoveZ>b__101_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B8D0 Offset: 0x198ACD0 VA: 0x18198B8D0
	private void <setCanvasRotateAround>b__103_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B5A0 Offset: 0x198A9A0 VA: 0x18198B5A0
	private void <setCanvasRotateAroundLocal>b__104_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B3B0 Offset: 0x198A7B0 VA: 0x18198B3B0
	private void <setCanvasPlaySprite>b__105_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B410 Offset: 0x198A810 VA: 0x18198B410
	private void <setCanvasPlaySprite>b__105_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B000 Offset: 0x198A400 VA: 0x18198B000
	private void <setCanvasMove>b__106_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198B040 Offset: 0x198A440 VA: 0x18198B040
	private void <setCanvasMove>b__106_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198BBC0 Offset: 0x198AFC0 VA: 0x18198BBC0
	private void <setCanvasScale>b__107_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198BC00 Offset: 0x198B000 VA: 0x18198BC00
	private void <setCanvasScale>b__107_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198BC60 Offset: 0x198B060 VA: 0x18198BC60
	private void <setCanvasSizeDelta>b__108_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198BD00 Offset: 0x198B100 VA: 0x18198BD00
	private void <setCanvasSizeDelta>b__108_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D8E0 Offset: 0x198CCE0 VA: 0x18198D8E0
	private void <setMove>b__112_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198DAE0 Offset: 0x198CEE0 VA: 0x18198DAE0
	private void <setMove>b__112_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D280 Offset: 0x198C680 VA: 0x18198D280
	private void <setMoveLocal>b__113_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D2C0 Offset: 0x198C6C0 VA: 0x18198D2C0
	private void <setMoveLocal>b__113_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D8E0 Offset: 0x198CCE0 VA: 0x18198D8E0
	private void <setMoveToTransform>b__114_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198D920 Offset: 0x198CD20 VA: 0x18198D920
	private void <setMoveToTransform>b__114_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198E840 Offset: 0x198DC40 VA: 0x18198E840
	private void <setRotate>b__115_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198E970 Offset: 0x198DD70 VA: 0x18198E970
	private void <setRotate>b__115_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198E670 Offset: 0x198DA70 VA: 0x18198E670
	private void <setRotateLocal>b__116_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198E7A0 Offset: 0x198DBA0 VA: 0x18198E7A0
	private void <setRotateLocal>b__116_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198EED0 Offset: 0x198E2D0 VA: 0x18198EED0
	private void <setScale>b__117_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198EF10 Offset: 0x198E310 VA: 0x18198EF10
	private void <setScale>b__117_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C630 Offset: 0x198BA30 VA: 0x18198C630
	private void <setGUIMove>b__118_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C700 Offset: 0x198BB00 VA: 0x18198C700
	private void <setGUIMove>b__118_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C4F0 Offset: 0x198B8F0 VA: 0x18198C4F0
	private void <setGUIMoveMargin>b__119_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C5A0 Offset: 0x198B9A0 VA: 0x18198C5A0
	private void <setGUIMoveMargin>b__119_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C8E0 Offset: 0x198BCE0 VA: 0x18198C8E0
	private void <setGUIScale>b__120_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C9B0 Offset: 0x198BDB0 VA: 0x18198C9B0
	private void <setGUIScale>b__120_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C470 Offset: 0x198B870 VA: 0x18198C470
	private void <setGUIAlpha>b__121_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C4A0 Offset: 0x198B8A0 VA: 0x18198C4A0
	private void <setGUIAlpha>b__121_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C820 Offset: 0x198BC20 VA: 0x18198C820
	private void <setGUIRotate>b__122_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C890 Offset: 0x198BC90 VA: 0x18198C890
	private void <setGUIRotate>b__122_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x198C460 Offset: 0x198B860 VA: 0x18198C460
	private void <setDelayedSound>b__123_0() { }

}

public sealed class LTDescr.EaseTypeDelegate : MulticastDelegate // TypeDefIndex: 5570
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19855E0 Offset: 0x19849E0 VA: 0x1819855E0 Slot: 12
	public virtual Vector3 Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x19855A0 Offset: 0x19849A0 VA: 0x1819855A0 Slot: 14
	public virtual Vector3 EndInvoke(IAsyncResult result) { }

}

public sealed class LTDescr.ActionMethodDelegate : MulticastDelegate // TypeDefIndex: 5571
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x145EF20 Offset: 0x145E320 VA: 0x18145EF20 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class LTDescr.<>c // TypeDefIndex: 5572
{	// Fields
	public static readonly LTDescr.<>c <>9; // 0x0
	public static LTDescr.ActionMethodDelegate <>9__110_0; // 0x8
	public static LTDescr.ActionMethodDelegate <>9__111_0; // 0x10

	// Methods

	// RVA: 0x199F9D0 Offset: 0x199EDD0 VA: 0x18199F9D0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <setCallback>b__110_0() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void <setValue3>b__111_0() { }

}

