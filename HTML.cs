internal struct HTML_BrowserReady_t : ICallbackData // TypeDefIndex: 5451
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9640 Offset: 0x1E8A40 VA: 0x1801E9640 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9630 Offset: 0x1E8A30 VA: 0x1801E9630 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C5C0 Offset: 0x136B9C0 VA: 0x18136C5C0
	private static void .cctor() { }

}

internal struct HTML_NeedsPaint_t : ICallbackData // TypeDefIndex: 5452
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PBGRA; // 0x8
	internal uint UnWide; // 0x10
	internal uint UnTall; // 0x14
	internal uint UnUpdateX; // 0x18
	internal uint UnUpdateY; // 0x1C
	internal uint UnUpdateWide; // 0x20
	internal uint UnUpdateTall; // 0x24
	internal uint UnScrollX; // 0x28
	internal uint UnScrollY; // 0x2C
	internal float FlPageScale; // 0x30
	internal uint UnPageSerial; // 0x34
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9D10 Offset: 0x1E9110 VA: 0x1801E9D10 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9D00 Offset: 0x1E9100 VA: 0x1801E9D00 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CD40 Offset: 0x136C140 VA: 0x18136CD40
	private static void .cctor() { }

}

internal struct HTML_StartRequest_t : ICallbackData // TypeDefIndex: 5453
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal string PchTarget; // 0x10
	internal string PchPostData; // 0x18
	internal bool BIsRedirect; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA150 Offset: 0x1E9550 VA: 0x1801EA150 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA140 Offset: 0x1E9540 VA: 0x1801EA140 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D100 Offset: 0x136C500 VA: 0x18136D100
	private static void .cctor() { }

}

internal struct HTML_CloseBrowser_t : ICallbackData // TypeDefIndex: 5454
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9850 Offset: 0x1E8C50 VA: 0x1801E9850 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9840 Offset: 0x1E8C40 VA: 0x1801E9840 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C840 Offset: 0x136BC40 VA: 0x18136C840
	private static void .cctor() { }

}

internal struct HTML_URLChanged_t : ICallbackData // TypeDefIndex: 5455
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal string PchPostData; // 0x10
	internal bool BIsRedirect; // 0x18
	internal string PchPageTitle; // 0x20
	internal bool BNewNavigation; // 0x28
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA350 Offset: 0x1E9750 VA: 0x1801EA350 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA340 Offset: 0x1E9740 VA: 0x1801EA340 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D240 Offset: 0x136C640 VA: 0x18136D240
	private static void .cctor() { }

}

internal struct HTML_FinishedRequest_t : ICallbackData // TypeDefIndex: 5456
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal string PchPageTitle; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E99C0 Offset: 0x1E8DC0 VA: 0x1801E99C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E99B0 Offset: 0x1E8DB0 VA: 0x1801E99B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C980 Offset: 0x136BD80 VA: 0x18136C980
	private static void .cctor() { }

}

internal struct HTML_OpenLinkInNewTab_t : ICallbackData // TypeDefIndex: 5457
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9F90 Offset: 0x1E9390 VA: 0x1801E9F90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9F80 Offset: 0x1E9380 VA: 0x1801E9F80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CE80 Offset: 0x136C280 VA: 0x18136CE80
	private static void .cctor() { }

}

internal struct HTML_ChangedTitle_t : ICallbackData // TypeDefIndex: 5458
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchTitle; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9790 Offset: 0x1E8B90 VA: 0x1801E9790 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9780 Offset: 0x1E8B80 VA: 0x1801E9780 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C7A0 Offset: 0x136BBA0 VA: 0x18136C7A0
	private static void .cctor() { }

}

internal struct HTML_SearchResults_t : ICallbackData // TypeDefIndex: 5459
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnResults; // 0x4
	internal uint UnCurrentMatch; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA000 Offset: 0x1E9400 VA: 0x1801EA000 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9FF0 Offset: 0x1E93F0 VA: 0x1801E9FF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CF20 Offset: 0x136C320 VA: 0x18136CF20
	private static void .cctor() { }

}

internal struct HTML_CanGoBackAndForward_t : ICallbackData // TypeDefIndex: 5460
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal bool BCanGoBack; // 0x4
	internal bool BCanGoForward; // 0x5
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9720 Offset: 0x1E8B20 VA: 0x1801E9720 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9710 Offset: 0x1E8B10 VA: 0x1801E9710 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C700 Offset: 0x136BB00 VA: 0x18136C700
	private static void .cctor() { }

}

internal struct HTML_HorizontalScroll_t : ICallbackData // TypeDefIndex: 5461
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnScrollMax; // 0x4
	internal uint UnScrollCurrent; // 0x8
	internal float FlPageScale; // 0xC
	internal bool BVisible; // 0x10
	internal uint UnPageSize; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9AA0 Offset: 0x1E8EA0 VA: 0x1801E9AA0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9A90 Offset: 0x1E8E90 VA: 0x1801E9A90 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CAC0 Offset: 0x136BEC0 VA: 0x18136CAC0
	private static void .cctor() { }

}

internal struct HTML_VerticalScroll_t : ICallbackData // TypeDefIndex: 5462
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnScrollMax; // 0x4
	internal uint UnScrollCurrent; // 0x8
	internal float FlPageScale; // 0xC
	internal bool BVisible; // 0x10
	internal uint UnPageSize; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA560 Offset: 0x1E9960 VA: 0x1801EA560 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA550 Offset: 0x1E9950 VA: 0x1801EA550 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D380 Offset: 0x136C780 VA: 0x18136D380
	private static void .cctor() { }

}

internal struct HTML_LinkAtPosition_t : ICallbackData // TypeDefIndex: 5463
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint X; // 0x4
	internal uint Y; // 0x8
	internal string PchURL; // 0x10
	internal bool BInput; // 0x18
	internal bool BLiveLink; // 0x19
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9BF0 Offset: 0x1E8FF0 VA: 0x1801E9BF0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9BE0 Offset: 0x1E8FE0 VA: 0x1801E9BE0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CCA0 Offset: 0x136C0A0 VA: 0x18136CCA0
	private static void .cctor() { }

}

internal struct HTML_JSAlert_t : ICallbackData // TypeDefIndex: 5464
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMessage; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9B10 Offset: 0x1E8F10 VA: 0x1801E9B10 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9B00 Offset: 0x1E8F00 VA: 0x1801E9B00 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CB60 Offset: 0x136BF60 VA: 0x18136CB60
	private static void .cctor() { }

}

internal struct HTML_JSConfirm_t : ICallbackData // TypeDefIndex: 5465
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMessage; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9B80 Offset: 0x1E8F80 VA: 0x1801E9B80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9B70 Offset: 0x1E8F70 VA: 0x1801E9B70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CC00 Offset: 0x136C000 VA: 0x18136CC00
	private static void .cctor() { }

}

internal struct HTML_FileOpenDialog_t : ICallbackData // TypeDefIndex: 5466
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchTitle; // 0x8
	internal string PchInitialFile; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E98C0 Offset: 0x1E8CC0 VA: 0x1801E98C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E98B0 Offset: 0x1E8CB0 VA: 0x1801E98B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C8E0 Offset: 0x136BCE0 VA: 0x18136C8E0
	private static void .cctor() { }

}

internal struct HTML_NewWindow_t : ICallbackData // TypeDefIndex: 5467
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal uint UnX; // 0x10
	internal uint UnY; // 0x14
	internal uint UnWide; // 0x18
	internal uint UnTall; // 0x1C
	internal uint UnNewWindow_BrowserHandle_IGNORE; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9E70 Offset: 0x1E9270 VA: 0x1801E9E70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9E60 Offset: 0x1E9260 VA: 0x1801E9E60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CDE0 Offset: 0x136C1E0 VA: 0x18136CDE0
	private static void .cctor() { }

}

internal struct HTML_SetCursor_t : ICallbackData // TypeDefIndex: 5468
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint EMouseCursor; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA070 Offset: 0x1E9470 VA: 0x1801EA070 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA060 Offset: 0x1E9460 VA: 0x1801EA060 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CFC0 Offset: 0x136C3C0 VA: 0x18136CFC0
	private static void .cctor() { }

}

internal struct HTML_StatusText_t : ICallbackData // TypeDefIndex: 5469
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA2E0 Offset: 0x1E96E0 VA: 0x1801EA2E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA2D0 Offset: 0x1E96D0 VA: 0x1801EA2D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D1A0 Offset: 0x136C5A0 VA: 0x18136D1A0
	private static void .cctor() { }

}

internal struct HTML_ShowToolTip_t : ICallbackData // TypeDefIndex: 5470
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA0E0 Offset: 0x1E94E0 VA: 0x1801EA0E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA0D0 Offset: 0x1E94D0 VA: 0x1801EA0D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D060 Offset: 0x136C460 VA: 0x18136D060
	private static void .cctor() { }

}

internal struct HTML_UpdateToolTip_t : ICallbackData // TypeDefIndex: 5471
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA4F0 Offset: 0x1E98F0 VA: 0x1801EA4F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA4E0 Offset: 0x1E98E0 VA: 0x1801EA4E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D2E0 Offset: 0x136C6E0 VA: 0x18136D2E0
	private static void .cctor() { }

}

internal struct HTML_HideToolTip_t : ICallbackData // TypeDefIndex: 5472
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9A30 Offset: 0x1E8E30 VA: 0x1801E9A30 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9A20 Offset: 0x1E8E20 VA: 0x1801E9A20 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136CA20 Offset: 0x136BE20 VA: 0x18136CA20
	private static void .cctor() { }

}

internal struct HTML_BrowserRestarted_t : ICallbackData // TypeDefIndex: 5473
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnOldBrowserHandle; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E96B0 Offset: 0x1E8AB0 VA: 0x1801E96B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E96A0 Offset: 0x1E8AA0 VA: 0x1801E96A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C660 Offset: 0x136BA60 VA: 0x18136C660
	private static void .cctor() { }

}

