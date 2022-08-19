public sealed class GameObject : Object // TypeDefIndex: 3515
{
// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0xBBD50 Offset: 0xBB150 VA: 0x1800BBD50
[ExcludeFromPresetAttribute] // RVA: 0xBBD50 Offset: 0xBB150 VA: 0x1800BBD50
[NativeHeaderAttribute] // RVA: 0xBBD50 Offset: 0xBB150 VA: 0x1800BBD50
public sealed class GameObject : Object // TypeDefIndex: 3515
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public bool isStatic { get; set; }
	public string tag { get; set; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xBC0B0 Offset: 0xBB4B0 VA: 0x1800BC0B0
	// RVA: 0x1825C00 Offset: 0x1825000 VA: 0x181825C00
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A9810 Offset: 0x14A8C10 VA: 0x1814A9810
	|-GameObject.GetComponent<AdminExistingSellOrder>
	|-GameObject.GetComponent<AmbienceEmitter>
	|-GameObject.GetComponent<AttackEntity>
	|-GameObject.GetComponent<BaseBulb>
	|-GameObject.GetComponent<BaseCollision>
	|-GameObject.GetComponent<BaseEntity>
	|-GameObject.GetComponent<BaseMelee>
	|-GameObject.GetComponent<BaseMeshPaintable>
	|-GameObject.GetComponent<BaseMovement>
	|-GameObject.GetComponent<BaseProjectile>
	|-GameObject.GetComponent<BaseViewModel>
	|-GameObject.GetComponent<BlueprintButton>
	|-GameObject.GetComponent<BobberPreview>
	|-GameObject.GetComponent<BranchConfig>
	|-GameObject.GetComponent<BuildingPrivlidge>
	|-GameObject.GetComponent<CardTableUI>
	|-GameObject.GetComponent<ChangeSignText>
	|-GameObject.GetComponent<ChatEntry>
	|-GameObject.GetComponent<ClientIOLine>
	|-GameObject.GetComponent<ColliderInfo>
	|-GameObject.GetComponent<CommunityEntity.FadeOut>
	|-GameObject.GetComponent<ComputerMenu>
	|-GameObject.GetComponent<ConditionalGibbable>
	|-GameObject.GetComponent<ConstructionSkin>
	|-GameObject.GetComponent<CounterConfig>
	|-GameObject.GetComponent<CraftingQueueIcon>
	|-GameObject.GetComponent<CullingVolume>
	|-GameObject.GetComponent<DemoItem>
	|-GameObject.GetComponent<DemoShotEntry>
	|-GameObject.GetComponent<DemoShotListFolderWidget>
	|-GameObject.GetComponent<DropMe>
	|-GameObject.GetComponent<ERSurfaceScript>
	|-GameObject.GetComponent<ERCrossingPrefabs>
	|-GameObject.GetComponent<ERCrossings>
	|-GameObject.GetComponent<ERIConnector>
	|-GameObject.GetComponent<ERModularBase>
	|-GameObject.GetComponent<ERModularRoad>
	|-GameObject.GetComponent<ERRoundabouts>
	|-GameObject.GetComponent<ERSideObjectInstance>
	|-GameObject.GetComponent<ERSideObjectLog>
	|-GameObject.GetComponent<ERTerrain>
	|-GameObject.GetComponent<EffectParentToWeaponBone>
	|-GameObject.GetComponent<EntityDebug>
	|-GameObject.GetComponent<EnvironmentFish>
	|-GameObject.GetComponent<EnvironmentVolume>
	|-GameObject.GetComponent<SkeletonSkin>
	|-GameObject.GetComponent<VirtualScroll.IDataSource>
	|-GameObject.GetComponent<FavouriteRadioStation>
	|-GameObject.GetComponent<FireworkShell>
	|-GameObject.GetComponent<FoliageGridBatch>
	|-GameObject.GetComponent<FootstepSound>
	|-GameObject.GetComponent<FrequencyConfig>
	|-GameObject.GetComponent<Gib>
	|-GameObject.GetComponent<Gibbable>
	|-GameObject.GetComponent<GrowableEntity>
	|-GameObject.GetComponent<HeldEntity>
	|-GameObject.GetComponent<IEffectRecycle>
	|-GameObject.GetComponent<INotifyLOD>
	|-GameObject.GetComponent<IOEntity>
	|-GameObject.GetComponent<IconSkin>
	|-GameObject.GetComponent<IdentifierConfig>
	|-GameObject.GetComponent<ImageEffectComposite>
	|-GameObject.GetComponent<ImageRenderController>
	|-GameObject.GetComponent<ImpostorShadows>
	|-GameObject.GetComponent<IronSightOverride>
	|-GameObject.GetComponent<ItemBlueprint>
	|-GameObject.GetComponent<ItemDefinition>
	|-GameObject.GetComponent<ItemOptionButton>
	|-GameObject.GetComponent<ItemPickupNotice>
	|-GameObject.GetComponent<ItemStoreCartItem>
	|-GameObject.GetComponent<ItemStoreItem>
	|-GameObject.GetComponent<KeyCodeEntry>
	|-GameObject.GetComponent<KeyframeWidget>
	|-GameObject.GetComponent<LifeInfographicStatDynamicRow>
	|-GameObject.GetComponent<LifeInfographicStatWeapon>
	|-GameObject.GetComponent<MainCamera>
	|-GameObject.GetComponent<MapLayerRenderer>
	|-GameObject.GetComponent<MaterialSwap>
	|-GameObject.GetComponent<MaxSpawnDistance>
	|-GameObject.GetComponent<MedicalTool>
	|-GameObject.GetComponent<MeshRendererBatch>
	|-GameObject.GetComponent<MissionMapMarker>
	|-GameObject.GetComponent<Model>
	|-GameObject.GetComponent<MonumentMarker>
	|-GameObject.GetComponent<NeedsCursor>
	|-GameObject.GetComponent<NeedsKeyboard>
	|-GameObject.GetComponent<ObjectMotionVectorFix>
	|-GameObject.GetComponent<PhoneDialler>
	|-GameObject.GetComponent<PhoneDirectoryEntry>
	|-GameObject.GetComponent<PhysicsEffects>
	|-GameObject.GetComponent<PickAFriend>
	|-GameObject.GetComponent<PieOption>
	|-GameObject.GetComponent<PlantSkin>
	|-GameObject.GetComponent<PlayerModel>
	|-GameObject.GetComponent<PlayerWalkMovement>
	|-GameObject.GetComponent<PointOfInterestMapMarker>
	|-GameObject.GetComponent<Poolable>
	|-GameObject.GetComponent<PowerLineWireConnectionHelper>
	|-GameObject.GetComponent<PrefabParameters>
	|-GameObject.GetComponent<Projectile>
	|-GameObject.GetComponent<ProjectileWeaponMod>
	|-GameObject.GetComponent<QuickCraftButton>
	|-GameObject.GetComponent<RCBookmarkEntry>
	|-GameObject.GetComponent<RadioDialog>
	|-GameObject.GetComponent<Ragdoll>
	|-GameObject.GetComponent<RecordingBars>
	|-GameObject.GetComponent<RenameSleepingBag>
	|-GameObject.GetComponent<ReskinEffect>
	|-GameObject.GetComponent<RidableHorse>
	|-GameObject.GetComponent<IEntity>
	|-GameObject.GetComponent<PropRenderer>
	|-GameObject.GetComponent<FileDialog>
	|-GameObject.GetComponent<FileListElement>
	|-GameObject.GetComponent<RustButton>
	|-GameObject.GetComponent<RustText>
	|-GameObject.GetComponent<ServerAdminServerInfo>
	|-GameObject.GetComponent<SteamInventoryItem>
	|-GameObject.GetComponent<WorkshopItemButton>
	|-GameObject.GetComponent<WorkshopSkin>
	|-GameObject.GetComponent<SellOrderEntry>
	|-GameObject.GetComponent<ServerBrowserItem>
	|-GameObject.GetComponent<ServerHistoryItem>
	|-GameObject.GetComponent<ServerProjectile>
	|-GameObject.GetComponent<SetupAppNotification>
	|-GameObject.GetComponent<SlotMachinePayoutWidget>
	|-GameObject.GetComponent<Sound>
	|-GameObject.GetComponent<SoundLightDialog>
	|-GameObject.GetComponent<SoundPlayer>
	|-GameObject.GetComponent<SoundSource>
	|-GameObject.GetComponent<SprayCanSkinSelect>
	|-GameObject.GetComponent<SteamUserButton>
	|-GameObject.GetComponent<TMP_InputField>
	|-GameObject.GetComponent<TMP_SubMesh>
	|-GameObject.GetComponent<TMP_Text>
	|-GameObject.GetComponent<TerrainGenerator>
	|-GameObject.GetComponent<TerrainMeta>
	|-GameObject.GetComponent<ThrownWeapon>
	|-GameObject.GetComponent<TimedExplosive>
	|-GameObject.GetComponent<TimerConfig>
	|-GameObject.GetComponent<ToggleHUDLayer>
	|-GameObject.GetComponent<UIChatPopup>
	|-GameObject.GetComponent<UIEscapeCapture>
	|-GameObject.GetComponent<UIFireworkDesigner>
	|-GameObject.GetComponent<UIFireworkStar>
	|-GameObject.GetComponent<UIMapGenericRadius>
	|-GameObject.GetComponent<UIMapVendingMachineMarker>
	|-GameObject.GetComponent<UIMapVendingMachineMarkerCluster>
	|-GameObject.GetComponent<UIMarketSearchStore>
	|-GameObject.GetComponent<UIMixingTableItem>
	|-GameObject.GetComponent<UIPaintableImage>
	|-GameObject.GetComponent<UnderwearIcon>
	|-GameObject.GetComponent<NavMeshAgent>
	|-GameObject.GetComponent<NavMeshObstacle>
	|-GameObject.GetComponent<AudioSource>
	|-GameObject.GetComponent<BoxCollider>
	|-GameObject.GetComponent<Camera>
	|-GameObject.GetComponent<Canvas>
	|-GameObject.GetComponent<CanvasGroup>
	|-GameObject.GetComponent<CanvasRenderer>
	|-GameObject.GetComponent<Collider>
	|-GameObject.GetComponent<LODGroup>
	|-GameObject.GetComponent<Light>
	|-GameObject.GetComponent<MeshCollider>
	|-GameObject.GetComponent<MeshFilter>
	|-GameObject.GetComponent<MeshRenderer>
	|-GameObject.GetComponent<ParticleSystem>
	|-GameObject.GetComponent<RectTransform>
	|-GameObject.GetComponent<ReflectionProbe>
	|-GameObject.GetComponent<Renderer>
	|-GameObject.GetComponent<Rigidbody>
	|-GameObject.GetComponent<SpriteRenderer>
	|-GameObject.GetComponent<Terrain>
	|-GameObject.GetComponent<TerrainCollider>
	|-GameObject.GetComponent<Transform>
	|-GameObject.GetComponent<Button>
	|-GameObject.GetComponent<Dropdown>
	|-GameObject.GetComponent<Image>
	|-GameObject.GetComponent<InputField>
	|-GameObject.GetComponent<Mask>
	|-GameObject.GetComponent<ScrollRect>
	|-GameObject.GetComponent<Scrollbar>
	|-GameObject.GetComponent<Slider>
	|-GameObject.GetComponent<Text>
	|-GameObject.GetComponent<Toggle>
	|-GameObject.GetComponent<ToggleGroup>
	|-GameObject.GetComponent<VendingPanelAdmin>
	|-GameObject.GetComponent<ViewmodelClothing>
	|-GameObject.GetComponent<VoicemailEntry>
	|-GameObject.GetComponent<Wearable>
	|-GameObject.GetComponent<WearableHolsterOffset>
	|-GameObject.GetComponent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBC180 Offset: 0xBB580 VA: 0x1800BC180
	[TypeInferenceRuleAttribute] // RVA: 0xBC180 Offset: 0xBB580 VA: 0x1800BC180
	// RVA: 0x1825D90 Offset: 0x1825190 VA: 0x181825D90
	public Component GetComponent(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xBC370 Offset: 0xBB770 VA: 0x1800BC370
	[NativeWritableSelfAttribute] // RVA: 0xBC370 Offset: 0xBB770 VA: 0x1800BC370
	// RVA: 0x1825C80 Offset: 0x1825080 VA: 0x181825C80
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunctionAttribute] // RVA: 0xBD9F0 Offset: 0xBCDF0 VA: 0x1800BD9F0
	[TypeInferenceRuleAttribute] // RVA: 0xBD9F0 Offset: 0xBCDF0 VA: 0x1800BD9F0
	// RVA: 0x1825CE0 Offset: 0x18250E0 VA: 0x181825CE0
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A9630 Offset: 0x14A8A30 VA: 0x1814A9630
	|-GameObject.GetComponentInChildren<AnimationEvents>
	|-GameObject.GetComponentInChildren<DungeonGridLink>
	|-GameObject.GetComponentInChildren<DungeonVolume>
	|-GameObject.GetComponentInChildren<ERSurfaceScript>
	|-GameObject.GetComponentInChildren<OQQCCQCDQQ>
	|-GameObject.GetComponentInChildren<ItemButtonTools>
	|-GameObject.GetComponentInChildren<LadderMinMountHeight>
	|-GameObject.GetComponentInChildren<PaintableItem>
	|-GameObject.GetComponentInChildren<ProceduralObject>
	|-GameObject.GetComponentInChildren<HttpImage>
	|-GameObject.GetComponentInChildren<TextMeshProUGUI>
	|-GameObject.GetComponentInChildren<TooltipContainer>
	|-GameObject.GetComponentInChildren<LODGroup>
	|-GameObject.GetComponentInChildren<LineRenderer>
	|-GameObject.GetComponentInChildren<Rigidbody>
	|-GameObject.GetComponentInChildren<Button>
	|-GameObject.GetComponentInChildren<Dropdown.DropdownItem>
	|-GameObject.GetComponentInChildren<Text>
	|-GameObject.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A9660 Offset: 0x14A8A60 VA: 0x1814A9660
	|-GameObject.GetComponentInChildren<Text>
	|-GameObject.GetComponentInChildren<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBDCB0 Offset: 0xBD0B0 VA: 0x1800BDCB0
	[TypeInferenceRuleAttribute] // RVA: 0xBDCB0 Offset: 0xBD0B0 VA: 0x1800BDCB0
	// RVA: 0x1825D40 Offset: 0x1825140 VA: 0x181825D40
	public Component GetComponentInParent(Type type) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A9740 Offset: 0x14A8B40 VA: 0x1814A9740
	|-GameObject.GetComponentInParent<BaseEntity>
	|-GameObject.GetComponentInParent<BaseViewModel>
	|-GameObject.GetComponentInParent<DropMe>
	|-GameObject.GetComponentInParent<IProvider>
	|-GameObject.GetComponentInParent<Model>
	|-GameObject.GetComponentInParent<Poolable>
	|-GameObject.GetComponentInParent<Ragdoll>
	|-GameObject.GetComponentInParent<RustControl>
	|-GameObject.GetComponentInParent<SoundSource>
	|-GameObject.GetComponentInParent<IPointerDownHandler>
	|-GameObject.GetComponentInParent<ISubmitHandler>
	|-GameObject.GetComponentInParent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBDDF0 Offset: 0xBD1F0 VA: 0x1800BDDF0
	// RVA: 0x1825EB0 Offset: 0x18252B0 VA: 0x181825EB0
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x1825F30 Offset: 0x1825330 VA: 0x181825F30
	public Component[] GetComponents(Type type) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA0310 Offset: 0x1A9F710 VA: 0x181AA0310
	|-GameObject.GetComponents<ConstructionGrade>
	|-GameObject.GetComponents<Component>
	|-GameObject.GetComponents<Graphic>
	|-GameObject.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E7B20 Offset: 0x5E6F20 VA: 0x1805E7B20
	|-GameObject.GetComponents<DecalRecycle>
	|-GameObject.GetComponents<IOnParentDestroying>
	|-GameObject.GetComponents<IOnParentSpawning>
	|-GameObject.GetComponents<IOnPostNetworkUpdate>
	|-GameObject.GetComponents<IOnSendNetworkUpdate>
	|-GameObject.GetComponents<RendererBatch>
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<Component>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1825DE0 Offset: 0x18251E0 VA: 0x181825DE0
	public Component[] GetComponentsInChildren(Type type) { }

	// RVA: 0x1825DF0 Offset: 0x18251F0 VA: 0x181825DF0
	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA0110 Offset: 0x1A9F510 VA: 0x181AA0110
	|-GameObject.GetComponentsInChildren<BlueprintCategoryButton>
	|-GameObject.GetComponentsInChildren<CraftingQueueIcon>
	|-GameObject.GetComponentsInChildren<SingletonComponent>
	|-GameObject.GetComponentsInChildren<TerrainPathConnect>
	|-GameObject.GetComponentsInChildren<Collider>
	|-GameObject.GetComponentsInChildren<Component>
	|-GameObject.GetComponentsInChildren<LODGroup>
	|-GameObject.GetComponentsInChildren<MonoBehaviour>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<Rigidbody>
	|-GameObject.GetComponentsInChildren<Image>
	|-GameObject.GetComponentsInChildren<Text>
	|-GameObject.GetComponentsInChildren<Toggle>
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E79A0 Offset: 0x5E6DA0 VA: 0x1805E79A0
	|-GameObject.GetComponentsInChildren<IEffect>
	|-GameObject.GetComponentsInChildren<IItemSetup>
	|-GameObject.GetComponentsInChildren<IItemUpdate>
	|-GameObject.GetComponentsInChildren<MaterialReplacement>
	|-GameObject.GetComponentsInChildren<MorphCache>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<MeshRenderer>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<SkinnedMeshRenderer>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A9630 Offset: 0x14A8A30 VA: 0x1814A9630
	|-GameObject.GetComponentsInChildren<ConditionalGibbable>
	|-GameObject.GetComponentsInChildren<ERSurfaceScript>
	|-GameObject.GetComponentsInChildren<ERConnectionParent>
	|-GameObject.GetComponentsInChildren<ERCrossingPrefabs>
	|-GameObject.GetComponentsInChildren<ERCrossings>
	|-GameObject.GetComponentsInChildren<ERModularRoad>
	|-GameObject.GetComponentsInChildren<ERPrefabInstance>
	|-GameObject.GetComponentsInChildren<ERRoadNetworkObject>
	|-GameObject.GetComponentsInChildren<ERRoundabouts>
	|-GameObject.GetComponentsInChildren<ERSideObjectInstance>
	|-GameObject.GetComponentsInChildren<ERSideObjectSection>
	|-GameObject.GetComponentsInChildren<EffectRecycle>
	|-GameObject.GetComponentsInChildren<MeshFilter>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<Toggle>
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4DB0 Offset: 0x5E41B0 VA: 0x1805E4DB0
	|-GameObject.GetComponentsInChildren<DecalRecycle>
	|-GameObject.GetComponentsInChildren<EffectRecycle>
	|-GameObject.GetComponentsInChildren<IOnParentDestroying>
	|-GameObject.GetComponentsInChildren<IOnParentSpawning>
	|-GameObject.GetComponentsInChildren<IOnPostNetworkUpdate>
	|-GameObject.GetComponentsInChildren<IOnSendNetworkUpdate>
	|-GameObject.GetComponentsInChildren<LODComponent>
	|-GameObject.GetComponentsInChildren<RendererBatch>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<LODGroup>
	|-GameObject.GetComponentsInChildren<MeshRenderer>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E7A60 Offset: 0x5E6E60 VA: 0x1805E7A60
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<Canvas>
	|-GameObject.GetComponentsInParent<RectMask2D>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA0210 Offset: 0x1A9F610 VA: 0x181AA0210
	|-GameObject.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEDD30 Offset: 0xBED130 VA: 0x180BEDD30
	|-GameObject.TryGetComponent<ICustomMaterialReplacer>
	|-GameObject.TryGetComponent<INotifyEntityTrigger>
	|-GameObject.TryGetComponent<INotifyTrigger>
	|-GameObject.TryGetComponent<PatternFireworkStar>
	|-GameObject.TryGetComponent<Ragdoll>
	|-GameObject.TryGetComponent<RendererInfo>
	|-GameObject.TryGetComponent<ServerAdminUGCEntryStub>
	|-GameObject.TryGetComponent<SteamUserButton>
	|-GameObject.TryGetComponent<object>
	|-GameObject.TryGetComponent<ThrownWeapon>
	|-GameObject.TryGetComponent<MeshCollider>
	|-GameObject.TryGetComponent<MeshFilter>
	|-GameObject.TryGetComponent<SkinnedMeshRenderer>
	|-GameObject.TryGetComponent<Button>
	|-GameObject.TryGetComponent<GridLayoutGroup>
	|-GameObject.TryGetComponent<Image>
	|-GameObject.TryGetComponent<Wearable>
	*/

	[FreeFunctionAttribute] // RVA: 0xBE160 Offset: 0xBD560 VA: 0x1800BE160
	[NativeWritableSelfAttribute] // RVA: 0xBE160 Offset: 0xBD560 VA: 0x1800BE160
	// RVA: 0x1826200 Offset: 0x1825600 VA: 0x181826200
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x1826030 Offset: 0x1825430 VA: 0x181826030
	public void SendMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x1825AE0 Offset: 0x1824EE0 VA: 0x181825AE0
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunctionAttribute] // RVA: 0xBE1E0 Offset: 0xBD5E0 VA: 0x1800BE1E0
	// RVA: 0x1825A30 Offset: 0x1824E30 VA: 0x181825A30
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9A30 Offset: 0xB8E30 VA: 0x1800B9A30
	// RVA: 0x1825A30 Offset: 0x1824E30 VA: 0x181825A30
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A9530 Offset: 0x14A8930 VA: 0x1814A9530
	|-GameObject.AddComponent<AICoverPoint>
	|-GameObject.AddComponent<AddToHeightMap>
	|-GameObject.AddComponent<AddToWaterMap>
	|-GameObject.AddComponent<AudioInterceptComponent>
	|-GameObject.AddComponent<BaseEntityChild>
	|-GameObject.AddComponent<ColliderInfo>
	|-GameObject.AddComponent<CommunityEntity.Countdown>
	|-GameObject.AddComponent<CommunityEntity.FadeOut>
	|-GameObject.AddComponent<ConversationManager.Conversation>
	|-GameObject.AddComponent<DemoShotPlayback>
	|-GameObject.AddComponent<DemoShotRecorder>
	|-GameObject.AddComponent<DeployGuide>
	|-GameObject.AddComponent<DetachMonumentChildren>
	|-GameObject.AddComponent<ERSurfaceScript>
	|-GameObject.AddComponent<ERCrossingPrefabs>
	|-GameObject.AddComponent<ERCrossings>
	|-GameObject.AddComponent<ERIConnector>
	|-GameObject.AddComponent<ERPrefabInstance>
	|-GameObject.AddComponent<ERSideObjectInstance>
	|-GameObject.AddComponent<ERSideObjectSection>
	|-GameObject.AddComponent<ERSideWalkInstanceScript>
	|-GameObject.AddComponent<ERTerrain>
	|-GameObject.AddComponent<OQQCCQCDQQ>
	|-GameObject.AddComponent<EntityDebug>
	|-GameObject.AddComponent<EnvironmentVolume>
	|-GameObject.AddComponent<ExplosionDemoReactivator>
	|-GameObject.AddComponent<ApplicationControllerMonobehaviour>
	|-GameObject.AddComponent<BurstClothManager>
	|-GameObject.AddComponent<Skeleton>
	|-GameObject.AddComponent<TickComponent>
	|-GameObject.AddComponent<Gib>
	|-GameObject.AddComponent<HudMenuInput>
	|-GameObject.AddComponent<InvokeHandler>
	|-GameObject.AddComponent<InvokeHandlerFixedTime>
	|-GameObject.AddComponent<LightLOD>
	|-GameObject.AddComponent<LoadBalancer>
	|-GameObject.AddComponent<MeshLOD>
	|-GameObject.AddComponent<MeshPaintable3D>
	|-GameObject.AddComponent<MeshPaintable>
	|-GameObject.AddComponent<MidiConvar>
	|-GameObject.AddComponent<NeedsCursor>
	|-GameObject.AddComponent<NeedsKeyboard>
	|-GameObject.AddComponent<NeedsKeyboardInputField>
	|-GameObject.AddComponent<ObjectMotionVectorFix>
	|-GameObject.AddComponent<PlayerLoot>
	|-GameObject.AddComponent<PowerLineWire>
	|-GameObject.AddComponent<PowerLineWireSpan>
	|-GameObject.AddComponent<QueryVis>
	|-GameObject.AddComponent<ReflectionProbeEx>
	|-GameObject.AddComponent<RendererInfo>
	|-GameObject.AddComponent<RiverInfo>
	|-GameObject.AddComponent<DepthOfFieldFocusPoint>
	|-GameObject.AddComponent<LightingOverride>
	|-GameObject.AddComponent<NullMonoBehaviour>
	|-GameObject.AddComponent<IconOutline>
	|-GameObject.AddComponent<PropRenderer>
	|-GameObject.AddComponent<WorkshopSkin>
	|-GameObject.AddComponent<TMP_InputField>
	|-GameObject.AddComponent<TMP_SelectionCaret>
	|-GameObject.AddComponent<TMP_SubMeshUI>
	|-GameObject.AddComponent<TextMeshProUGUI>
	|-GameObject.AddComponent<TerrainAlphaMap>
	|-GameObject.AddComponent<TerrainBiomeMap>
	|-GameObject.AddComponent<TerrainCollision>
	|-GameObject.AddComponent<TerrainColors>
	|-GameObject.AddComponent<TerrainHeightMap>
	|-GameObject.AddComponent<TerrainMeta>
	|-GameObject.AddComponent<TerrainPath>
	|-GameObject.AddComponent<TerrainPhysics>
	|-GameObject.AddComponent<TerrainPlacementMap>
	|-GameObject.AddComponent<TerrainQuality>
	|-GameObject.AddComponent<TerrainSplatMap>
	|-GameObject.AddComponent<TerrainTexturing>
	|-GameObject.AddComponent<TerrainTopologyMap>
	|-GameObject.AddComponent<TerrainWaterMap>
	|-GameObject.AddComponent<TrainTrackSpline>
	|-GameObject.AddComponent<UIEscapeCapture>
	|-GameObject.AddComponent<AudioReverbZone>
	|-GameObject.AddComponent<AudioSource>
	|-GameObject.AddComponent<BoxCollider>
	|-GameObject.AddComponent<Camera>
	|-GameObject.AddComponent<Canvas>
	|-GameObject.AddComponent<CanvasGroup>
	|-GameObject.AddComponent<CanvasRenderer>
	|-GameObject.AddComponent<BaseInput>
	|-GameObject.AddComponent<LODGroup>
	|-GameObject.AddComponent<Light>
	|-GameObject.AddComponent<MeshCollider>
	|-GameObject.AddComponent<MeshFilter>
	|-GameObject.AddComponent<MeshRenderer>
	|-GameObject.AddComponent<RectTransform>
	|-GameObject.AddComponent<ReflectionProbe>
	|-GameObject.AddComponent<Renderer>
	|-GameObject.AddComponent<PostProcessVolume>
	|-GameObject.AddComponent<Rigidbody>
	|-GameObject.AddComponent<SkinnedMeshRenderer>
	|-GameObject.AddComponent<SpringJoint>
	|-GameObject.AddComponent<StreamingController>
	|-GameObject.AddComponent<Button>
	|-GameObject.AddComponent<Dropdown.DropdownItem>
	|-GameObject.AddComponent<Image>
	|-GameObject.AddComponent<InputField>
	|-GameObject.AddComponent<LayoutElement>
	|-GameObject.AddComponent<Outline>
	|-GameObject.AddComponent<RawImage>
	|-GameObject.AddComponent<RectMask2D>
	|-GameObject.AddComponent<Scrollbar>
	|-GameObject.AddComponent<Text>
	|-GameObject.AddComponent<UpdateHandler>
	|-GameObject.AddComponent<ViewModelRenderer>
	|-GameObject.AddComponent<WaterBody>
	|-GameObject.AddComponent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBE330 Offset: 0xBD730 VA: 0x1800BE330
	// RVA: 0x18265B0 Offset: 0x18259B0 VA: 0x1818265B0
	public Transform get_transform() { }

	// RVA: 0x1826530 Offset: 0x1825930 VA: 0x181826530
	public int get_layer() { }

	// RVA: 0x1826640 Offset: 0x1825A40 VA: 0x181826640
	public void set_layer(int value) { }

	[NativeMethodAttribute] // RVA: 0xBE450 Offset: 0xBD850 VA: 0x1800BE450
	// RVA: 0x18261B0 Offset: 0x18255B0 VA: 0x1818261B0
	public void SetActive(bool value) { }

	[NativeMethodAttribute] // RVA: 0xBE550 Offset: 0xBD950 VA: 0x1800BE550
	// RVA: 0x18264B0 Offset: 0x18258B0 VA: 0x1818264B0
	public bool get_activeSelf() { }

	[NativeMethodAttribute] // RVA: 0xBE6D0 Offset: 0xBDAD0 VA: 0x1800BE6D0
	// RVA: 0x1826470 Offset: 0x1825870 VA: 0x181826470
	public bool get_activeInHierarchy() { }

	[NativeMethodAttribute] // RVA: 0xBE810 Offset: 0xBDC10 VA: 0x1800BE810
	// RVA: 0x18264F0 Offset: 0x18258F0 VA: 0x1818264F0
	public bool get_isStatic() { }

	[NativeMethodAttribute] // RVA: 0xBE960 Offset: 0xBDD60 VA: 0x1800BE960
	// RVA: 0x18265F0 Offset: 0x18259F0 VA: 0x1818265F0
	public void set_isStatic(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xBE9E0 Offset: 0xBDDE0 VA: 0x1800BE9E0
	// RVA: 0x1826570 Offset: 0x1825970 VA: 0x181826570
	public string get_tag() { }

	[FreeFunctionAttribute] // RVA: 0xBEAE0 Offset: 0xBDEE0 VA: 0x1800BEAE0
	// RVA: 0x1826680 Offset: 0x1825A80 VA: 0x181826680
	public void set_tag(string value) { }

	[FreeFunctionAttribute] // RVA: 0xBEB90 Offset: 0xBDF90 VA: 0x1800BEB90
	// RVA: 0x1825BB0 Offset: 0x1824FB0 VA: 0x181825BB0
	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xBECF0 Offset: 0xBE0F0 VA: 0x1800BECF0
	// RVA: 0x1826140 Offset: 0x1825540 VA: 0x181826140
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18260E0 Offset: 0x18254E0 VA: 0x1818260E0
	public void SendMessage(string methodName, object value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1826090 Offset: 0x1825490 VA: 0x181826090
	public void SendMessage(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xBEF60 Offset: 0xBE360 VA: 0x1800BEF60
	// RVA: 0x1825B40 Offset: 0x1824F40 VA: 0x181825B40
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1825A80 Offset: 0x1824E80 VA: 0x181825A80
	public void BroadcastMessage(string methodName, object parameter) { }

	// RVA: 0x18263E0 Offset: 0x18257E0 VA: 0x1818263E0
	public void .ctor(string name) { }

	// RVA: 0x1826360 Offset: 0x1825760 VA: 0x181826360
	public void .ctor() { }

	// RVA: 0x1826260 Offset: 0x1825660 VA: 0x181826260
	public void .ctor(string name, Type[] components) { }

	[FreeFunctionAttribute] // RVA: 0xC04E0 Offset: 0xBF8E0 VA: 0x1800C04E0
	// RVA: 0x1825FE0 Offset: 0x18253E0 VA: 0x181825FE0
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunctionAttribute] // RVA: 0xC0640 Offset: 0xBFA40 VA: 0x1800C0640
	// RVA: 0x1825C40 Offset: 0x1825040 VA: 0x181825C40
	public static GameObject Find(string name) { }

	// RVA: 0xED4D30 Offset: 0xED4130 VA: 0x180ED4D30
	public GameObject get_gameObject() { }

}

