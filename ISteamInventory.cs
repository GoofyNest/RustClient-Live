internal class ISteamInventory : SteamInterface // TypeDefIndex: 5118
{	// Methods

	// RVA: 0x1280910 Offset: 0x127FD10 VA: 0x181280910
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1282BE0 Offset: 0x1281FE0 VA: 0x181282BE0
	internal static extern IntPtr SteamAPI_SteamInventory_v003() { }

	// RVA: 0x1282BE0 Offset: 0x1281FE0 VA: 0x181282BE0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1282B70 Offset: 0x1281F70 VA: 0x181282B70
	internal static extern IntPtr SteamAPI_SteamGameServerInventory_v003() { }

	// RVA: 0x1282B70 Offset: 0x1281F70 VA: 0x181282B70 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0x1283A00 Offset: 0x1282E00 VA: 0x181283A00
	private static extern Result _GetResultStatus(IntPtr self, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1282AE0 Offset: 0x1281EE0 VA: 0x181282AE0
	internal Result GetResultStatus(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1283950 Offset: 0x1282D50 VA: 0x181283950
	private static extern bool _GetResultItems(IntPtr self, SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x1282A30 Offset: 0x1281E30 VA: 0x181282A30
	internal bool GetResultItems(SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x1283870 Offset: 0x1282C70 VA: 0x181283870
	private static extern bool _GetResultItemProperty(IntPtr self, SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1282800 Offset: 0x1281C00 VA: 0x181282800
	internal bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1283160 Offset: 0x1282560 VA: 0x181283160
	private static extern bool _CheckResultSteamID(IntPtr self, SteamInventoryResult_t resultHandle, SteamId steamIDExpected) { }

	// RVA: 0x1281F80 Offset: 0x1281380 VA: 0x181281F80
	internal bool CheckResultSteamID(SteamInventoryResult_t resultHandle, SteamId steamIDExpected) { }

	// RVA: 0x12832B0 Offset: 0x12826B0 VA: 0x1812832B0
	private static extern void _DestroyResult(IntPtr self, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x12820D0 Offset: 0x12814D0 VA: 0x1812820D0
	internal void DestroyResult(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1283450 Offset: 0x1282850 VA: 0x181283450
	private static extern bool _GetAllItems(IntPtr self, ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1282270 Offset: 0x1281670 VA: 0x181282270
	internal bool GetAllItems(ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1283C20 Offset: 0x1283020 VA: 0x181283C20
	private static extern bool _SerializeResult(IntPtr self, SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize) { }

	// RVA: 0x1282E40 Offset: 0x1282240 VA: 0x181282E40
	internal bool SerializeResult(SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize) { }

	// RVA: 0x1283A90 Offset: 0x1282E90 VA: 0x181283A90
	private static extern bool _GrantPromoItems(IntPtr self, ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1282C50 Offset: 0x1282050 VA: 0x181282C50
	internal bool GrantPromoItems(ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1283200 Offset: 0x1282600 VA: 0x181283200
	private static extern bool _ConsumeItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity) { }

	// RVA: 0x1282020 Offset: 0x1281420 VA: 0x181282020
	internal bool ConsumeItem(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity) { }

	// RVA: 0x1283340 Offset: 0x1282740 VA: 0x181283340
	private static extern bool _ExchangeItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In] [Out] InventoryDefId[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] InventoryItemId[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x1282160 Offset: 0x1281560 VA: 0x181282160
	internal bool ExchangeItems(ref SteamInventoryResult_t pResultHandle, [In] [Out] InventoryDefId[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] InventoryItemId[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x1283D90 Offset: 0x1283190 VA: 0x181283D90
	private static extern bool _TransferItemQuantity(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest) { }

	// RVA: 0x1283000 Offset: 0x1282400 VA: 0x181283000
	internal bool TransferItemQuantity(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest) { }

	// RVA: 0x1283E50 Offset: 0x1283250 VA: 0x181283E50
	private static extern bool _TriggerItemDrop(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition) { }

	// RVA: 0x12830C0 Offset: 0x12824C0 VA: 0x1812830C0
	internal bool TriggerItemDrop(ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition) { }

	// RVA: 0x1283B20 Offset: 0x1282F20 VA: 0x181283B20
	private static extern bool _LoadItemDefinitions(IntPtr self) { }

	// RVA: 0x1282CE0 Offset: 0x12820E0 VA: 0x181282CE0
	internal bool LoadItemDefinitions() { }

	// RVA: 0x12834E0 Offset: 0x12828E0 VA: 0x1812834E0
	private static extern bool _GetItemDefinitionIDs(IntPtr self, [In] [Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x1282300 Offset: 0x1281700 VA: 0x181282300
	internal bool GetItemDefinitionIDs([In] [Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x1283590 Offset: 0x1282990 VA: 0x181283590
	private static extern bool _GetItemDefinitionProperty(IntPtr self, InventoryDefId iDefinition, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x12823B0 Offset: 0x12817B0 VA: 0x1812823B0
	internal bool GetItemDefinitionProperty(InventoryDefId iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1283CD0 Offset: 0x12830D0 VA: 0x181283CD0
	private static extern SteamAPICall_t _StartPurchase(IntPtr self, [In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x1282EF0 Offset: 0x12822F0 VA: 0x181282EF0
	internal CallResult<SteamInventoryStartPurchaseResult_t> StartPurchase([In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x1283BA0 Offset: 0x1282FA0 VA: 0x181283BA0
	private static extern SteamAPICall_t _RequestPrices(IntPtr self) { }

	// RVA: 0x1282D60 Offset: 0x1282160 VA: 0x181282D60
	internal CallResult<SteamInventoryRequestPricesResult_t> RequestPrices() { }

	// RVA: 0x12837F0 Offset: 0x1282BF0 VA: 0x1812837F0
	private static extern uint _GetNumItemsWithPrices(IntPtr self) { }

	// RVA: 0x1282780 Offset: 0x1281B80 VA: 0x181282780
	internal uint GetNumItemsWithPrices() { }

	// RVA: 0x1283710 Offset: 0x1282B10 VA: 0x181283710
	private static extern bool _GetItemsWithPrices(IntPtr self, [In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x12826A0 Offset: 0x1281AA0 VA: 0x1812826A0
	internal bool GetItemsWithPrices([In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x1283660 Offset: 0x1282A60 VA: 0x181283660
	private static extern bool _GetItemPrice(IntPtr self, InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice) { }

	// RVA: 0x12825F0 Offset: 0x12819F0 VA: 0x1812825F0
	internal bool GetItemPrice(InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice) { }

}

