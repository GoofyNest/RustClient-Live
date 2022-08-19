internal static class ThrowHelper // TypeDefIndex: 124
{	// Methods

	// RVA: 0x1609510 Offset: 0x1608910 VA: 0x181609510
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x1608D00 Offset: 0x1608100 VA: 0x181608D00
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x16096A0 Offset: 0x1608AA0 VA: 0x1816096A0
	internal static void ThrowArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x1608E40 Offset: 0x1608240 VA: 0x181608E40
	private static Exception CreateArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x1609460 Offset: 0x1608860 VA: 0x181609460
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x1608C90 Offset: 0x1608090 VA: 0x181608C90
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x16096E0 Offset: 0x1608AE0 VA: 0x1816096E0
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x1608EB0 Offset: 0x16082B0 VA: 0x181608EB0
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x1609640 Offset: 0x1608A40 VA: 0x181609640
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1608DA0 Offset: 0x16081A0 VA: 0x181608DA0
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x1609680 Offset: 0x1608A80 VA: 0x181609680
	internal static void ThrowArgumentOutOfRangeException() { }

	// RVA: 0x1609850 Offset: 0x1608C50 VA: 0x181609850
	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

	// RVA: 0x1609790 Offset: 0x1608B90 VA: 0x181609790
	internal static void ThrowKeyNotFoundException() { }

	// RVA: 0x16094A0 Offset: 0x16088A0 VA: 0x1816094A0
	internal static void ThrowArgumentException(ExceptionResource resource) { }

	// RVA: 0x1609550 Offset: 0x1608950 VA: 0x181609550
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	// RVA: 0x1609720 Offset: 0x1608B20 VA: 0x181609720
	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	// RVA: 0x16097E0 Offset: 0x1608BE0 VA: 0x1816097E0
	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	// RVA: -1 Offset: -1
	internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDCB0 Offset: 0x5ED0B0 VA: 0x1805EDCB0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AdvancedChristmasLights.pointEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AlignedLineDrawer.LinePoint>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AtmosphereVolumeRenderer.CurrentVolumeEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BaseEntity.ServerFileRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CardTableUI.KeycodeWithAction>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Cassette.LoadRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Admin.PlayerInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Admin.ServerConvarInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Admin.ServerUGCInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Chat.MuteEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DamageRenderer.DamageShowingRenderer>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DeferredExtensionMesh.MaterialLink>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DeferredMeshDecal.MaterialLink>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Demos.DemoInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CRedge>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CombineClass>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERCell>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERChildsSO>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERConnectionGUIStatus>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERLane>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERMeshCombineUtility.MeshInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERSOSection>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERSplatmap>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERTerrainChange>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERVSData>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NormalPairs>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EngineDamageOverTime.RecentDamage>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EntityRef<object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ExpandedLifeStats.GenericStatDisplay>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BurstCloth.Chain>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CapsuleParams>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BoneData>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TabbedPanel.Tab>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Output.Entry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RCon.BannedAddresses>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SkeletonDefinition.Bone>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Tick.Entry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderInfo.RendererInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WeightedStringList.Container>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<FoliageGridMeshData.FoliageVertex>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Option>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GameStat.Stat>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Gibbable.OverrideMesh>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<IconSkinPicker.SkinButtonSetup>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ImageStorageEntity.ImageRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InvokeAction>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ItemSkinDirectory.Skin>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyframeView.UIKeyframeValue>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<LocalClock.TimedEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MagnetCrane.MagnetCraneSnapshot>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapView.MapMarkerCluster>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapView.SleepingBagCluster>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SevenBitNumber>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshColliderInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshColliderLookup.LookupEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshRendererInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshRendererLookup.LookupEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MidiConvar.KnobBinding>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MidiConvar.NoteBinding>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SqliteKeyReader.KeyInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<JsonPosition>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ParticleSystemContainer.ParticleSystemGroup>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PathFinder.Point>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PetCommandList.PetCommandDesc>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonuments.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonumentsOffshore.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonumentsRailside.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonumentsRoadside.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerItemRecipe.Ingredient>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerItemRecipe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ProjectileWeaponMod.Modifier>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotFloatKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotParentKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotQuaternionKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotVectorKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<VectorData>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ReflectionProbeEx.CubemapSkyboxVertex>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ReflectionProbeEx.RenderListEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WaypointSet.Waypoint>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TransformSnapshot>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimelineEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Option>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TickRenderer.Tick>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ServerInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SkinnedMultiMesh.Part>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubmarineSonar.SonarBlip>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SpawnIndividual>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SpecialPurposeCamera.RenderEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SteamNewsSource.Story>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Achievement>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryDefId>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MatchMakingKeyValuePair>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ServerInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Dispatch.Callback>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Friend>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryItem.Amount>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryItem>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryRecipe.Ingredient>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryRecipe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubsurfaceProfileTexture.SubsurfaceProfileEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SynchronizedClock.TimedEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<bool>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<byte>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<char>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DictionaryEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<DateTime, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<int, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<Int32Enum, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, float>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, Color>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<uint, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<ulong, Dispatch.ResultCallback>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTime>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTimeOffset>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Decimal>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EventProvider.SessionInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<double>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Guid>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<short>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<int>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Int32Enum>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<long>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<sbyte>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<float>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimeSpan>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ushort>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<uint>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ulong>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RangePositionInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TickInterpolator.Segment>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TraceInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TrainCar.TrainCarSnapshot>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NavMeshBuildMarkup>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NavMeshBuildSource>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BeforeRenderHelper.OrderBlock>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color32>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastResult>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastHit2D>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastHit>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Rect>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderTargetIdentifier>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Resolution>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GlyphRect>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TreeInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UICharInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<FocusController.FocusedElement>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UILineInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIVertex>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UnitySynchronizationContext.WorkRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector3>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector4>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2i>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ViewModelDrawEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WindZoneExManager.CurrentZoneEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WorldSplineData.LUTEntry.LUTPoint>
	|
	|-RVA: 0x488BC0 Offset: 0x487FC0 VA: 0x180488BC0
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<object>
	*/

	// RVA: 0x1608F00 Offset: 0x1608300 VA: 0x181608F00
	internal static string GetArgumentName(ExceptionArgument argument) { }

	// RVA: 0x16090F0 Offset: 0x16084F0 VA: 0x1816090F0
	internal static string GetResourceName(ExceptionResource resource) { }

}

internal static class ThrowHelper // TypeDefIndex: 6726
{
// Namespace: System
internal static class ThrowHelper // TypeDefIndex: 6726
	// Methods

	// RVA: 0x2316530 Offset: 0x2315930 VA: 0x182316530
	internal static void ThrowArrayTypeMismatchException() { }

	// RVA: 0x23163D0 Offset: 0x23157D0 VA: 0x1823163D0
	private static Exception CreateArrayTypeMismatchException() { }

	// RVA: 0x23164B0 Offset: 0x23158B0 VA: 0x1823164B0
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x2316120 Offset: 0x2315520 VA: 0x182316120
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x2316470 Offset: 0x2315870 VA: 0x182316470
	internal static void ThrowArgumentException_DestinationTooShort() { }

	// RVA: 0x2316050 Offset: 0x2315450 VA: 0x182316050
	private static Exception CreateArgumentException_DestinationTooShort() { }

	// RVA: 0x2316570 Offset: 0x2315970 VA: 0x182316570
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x2316420 Offset: 0x2315820 VA: 0x182316420
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x23164F0 Offset: 0x23158F0 VA: 0x1823164F0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x2316330 Offset: 0x2315730 VA: 0x182316330
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

}

internal static class ThrowHelper // TypeDefIndex: 7083
{	// Methods

	// RVA: 0x230DD10 Offset: 0x230D110 VA: 0x18230DD10
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x230DD50 Offset: 0x230D150 VA: 0x18230DD50
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x230DC50 Offset: 0x230D050 VA: 0x18230DC50
	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x230DCB0 Offset: 0x230D0B0 VA: 0x18230DCB0
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x230DBD0 Offset: 0x230CFD0 VA: 0x18230DBD0
	private static string GetArgumentName(ExceptionArgument argument) { }

}

