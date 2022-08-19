public class Time // TypeDefIndex: 3558
{	// Properties
	[NativePropertyAttribute] // RVA: 0xCD7D0 Offset: 0xCCBD0 VA: 0x1800CD7D0
	public static float time { get; }
	public static float deltaTime { get; }
	public static float fixedTime { get; }
	public static float unscaledTime { get; }
	public static float unscaledDeltaTime { get; }
	public static float fixedDeltaTime { get; set; }
	public static float maximumDeltaTime { get; set; }
	public static float smoothDeltaTime { get; }
	public static float timeScale { get; set; }
	public static int frameCount { get; }
	[NativePropertyAttribute] // RVA: 0xCD8C0 Offset: 0xCCCC0 VA: 0x1800CD8C0
	public static int renderedFrameCount { get; }
	[NativePropertyAttribute] // RVA: 0xCD9A0 Offset: 0xCCDA0 VA: 0x1800CD9A0
	public static float realtimeSinceStartup { get; }

	// Methods

	// RVA: 0x21776C0 Offset: 0x2176AC0 VA: 0x1821776C0
	public static float get_time() { }

	// RVA: 0x2177510 Offset: 0x2176910 VA: 0x182177510
	public static float get_deltaTime() { }

	// RVA: 0x2177570 Offset: 0x2176970 VA: 0x182177570
	public static float get_fixedTime() { }

	// RVA: 0x2177720 Offset: 0x2176B20 VA: 0x182177720
	public static float get_unscaledTime() { }

	// RVA: 0x21776F0 Offset: 0x2176AF0 VA: 0x1821776F0
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x2177540 Offset: 0x2176940 VA: 0x182177540
	public static float get_fixedDeltaTime() { }

	// RVA: 0x2177750 Offset: 0x2176B50 VA: 0x182177750
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x21775D0 Offset: 0x21769D0 VA: 0x1821775D0
	public static float get_maximumDeltaTime() { }

	// RVA: 0x2177790 Offset: 0x2176B90 VA: 0x182177790
	public static void set_maximumDeltaTime(float value) { }

	// RVA: 0x2177660 Offset: 0x2176A60 VA: 0x182177660
	public static float get_smoothDeltaTime() { }

	// RVA: 0x2177690 Offset: 0x2176A90 VA: 0x182177690
	public static float get_timeScale() { }

	// RVA: 0x21777D0 Offset: 0x2176BD0 VA: 0x1821777D0
	public static void set_timeScale(float value) { }

	// RVA: 0x21775A0 Offset: 0x21769A0 VA: 0x1821775A0
	public static int get_frameCount() { }

	// RVA: 0x2177630 Offset: 0x2176A30 VA: 0x182177630
	public static int get_renderedFrameCount() { }

	// RVA: 0x2177600 Offset: 0x2176A00 VA: 0x182177600
	public static float get_realtimeSinceStartup() { }

}

public class Time : ConsoleSystem // TypeDefIndex: 11965
{	// Methods

	// RVA: 0x36AAB0 Offset: 0x369EB0 VA: 0x18036AAB0
	public void .ctor() { }

}

