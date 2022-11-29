public class Component : MarshalByRefObject, IComponent, IDisposable // TypeDefIndex: 2677
{
	private static readonly object EventDisposed; 
	private ISite site; 
	private EventHandlerList events; 

	protected virtual bool CanRaiseEvents { get; }
	internal bool CanRaiseEventsInternal { get; }
	protected EventHandlerList Events { get; }
	[DesignerSerializationVisibilityAttribute] 
	[BrowsableAttribute] 
	public virtual ISite Site { get; }
	[DesignerSerializationVisibilityAttribute] 
	[BrowsableAttribute] 
	protected bool DesignMode { get; }


	protected override void Finalize() { }

	protected virtual bool get_CanRaiseEvents() { }

	internal bool get_CanRaiseEventsInternal() { }

	protected EventHandlerList get_Events() { }

	public virtual ISite get_Site() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual object GetService(Type service) { }

	protected bool get_DesignMode() { }

	public override string ToString() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Component : Object // TypeDefIndex: 3511
{
	public Transform transform { get; }
	public GameObject gameObject { get; }


	[FreeFunctionAttribute] 
	public Transform get_transform() { }

	[FreeFunctionAttribute] 
	public GameObject get_gameObject() { }

	[TypeInferenceRuleAttribute] 
	public Component GetComponent(Type type) { }

	[FreeFunctionAttribute] 
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-Component.GetComponent<AIInformationZone>
	|-Component.GetComponent<AddNewEventUIButton>
	|-Component.GetComponent<AddNewStateUIButton>
	|-Component.GetComponent<AdvancedChristmasLights>
	|-Component.GetComponent<AmbienceZone>
	|-Component.GetComponent<AmbientLightLOD>
	|-Component.GetComponent<AnimalSkin>
	|-Component.GetComponent<AnimationEvents>
	|-Component.GetComponent<ArcadeEntity>
	|-Component.GetComponent<ArticulatedOccludee>
	|-Component.GetComponent<BaseCollision>
	|-Component.GetComponent<BaseCombatEntity>
	|-Component.GetComponent<BaseEntity>
	|-Component.GetComponent<BaseEventUI>
	|-Component.GetComponent<BaseMelee>
	|-Component.GetComponent<BaseMeshPaintable>
	|-Component.GetComponent<BasePlayer>
	|-Component.GetComponent<BaseProjectile>
	|-Component.GetComponent<BaseStateUI>
	|-Component.GetComponent<BowWeapon>
	|-Component.GetComponent<BuildingBlock>
	|-Component.GetComponent<CardReader>
	|-Component.GetComponent<CargoShip>
	|-Component.GetComponent<ChippyArcadeGame>
	|-Component.GetComponent<ChippyBoss>
	|-Component.GetComponent<CollectableEasterEgg>
	|-Component.GetComponent<ColliderInfo>
	|-Component.GetComponent<CommandBufferManager>
	|-Component.GetComponent<CommunityEntity.FadeOut>
	|-Component.GetComponent<ComputerStation>
	|-Component.GetComponent<ContainerSourceLoot>
	|-Component.GetComponent<CoverageQueryFlare>
	|-Component.GetComponent<DamageRenderer>
	|-Component.GetComponent<DecorComponent>
	|-Component.GetComponent<DeferredDecal>
	|-Component.GetComponent<Deployable>
	|-Component.GetComponent<DistanceFlareLOD>
	|-Component.GetComponent<Door>
	|-Component.GetComponent<DudTimedExplosive>
	|-Component.GetComponent<DungeonBaseLink>
	|-Component.GetComponent<ERSurfaceScript>
	|-Component.GetComponent<ERModularBase>
	|-Component.GetComponent<ERModularRoad>
	|-Component.GetComponent<ERPrefabInstance>
	|-Component.GetComponent<ERRoundabouts>
	|-Component.GetComponent<ERSideObjectInstance>
	|-Component.GetComponent<EggSwap>
	|-Component.GetComponent<ElectricBattery>
	|-Component.GetComponent<EnumListItemUI>
	|-Component.GetComponent<FPSGraph>
	|-Component.GetComponent<Skeleton>
	|-Component.GetComponent<FishingBobber>
	|-Component.GetComponent<FishingRodViewmodel>
	|-Component.GetComponent<FootstepEffects>
	|-Component.GetComponent<IProvider>
	|-Component.GetComponent<Gib>
	|-Component.GetComponent<GlassPane>
	|-Component.GetComponent<GrenadeWeapon>
	|-Component.GetComponent<GrowableEntity>
	|-Component.GetComponent<Hammer>
	|-Component.GetComponent<HeldEntity>
	|-Component.GetComponent<HideIfOwnerFirstPerson>
	|-Component.GetComponent<HitboxSystem>
	|-Component.GetComponent<HorseCorpse>
	|-Component.GetComponent<IAIDesign>
	|-Component.GetComponent<IAudioConnectionSource>
	|-Component.GetComponent<IBatchingHandler>
	|-Component.GetComponent<IDraggable>
	|-Component.GetComponent<IOEntity>
	|-Component.GetComponent<IRFObject>
	|-Component.GetComponent<IRemoteControllable>
	|-Component.GetComponent<ImageEffectComposite>
	|-Component.GetComponent<Impostor>
	|-Component.GetComponent<InstrumentKeyController>
	|-Component.GetComponent<InstrumentViewmodel>
	|-Component.GetComponent<InvisibleVendingMachine>
	|-Component.GetComponent<IronSights>
	|-Component.GetComponent<ItemBlueprint>
	|-Component.GetComponent<ItemCrafter>
	|-Component.GetComponent<ItemDefinition>
	|-Component.GetComponent<ItemFootstepSounds>
	|-Component.GetComponent<ItemIcon>
	|-Component.GetComponent<ItemModAnimalEquipment>
	|-Component.GetComponent<ItemModAssociatedEntityMobile>
	|-Component.GetComponent<ItemModBurnable>
	|-Component.GetComponent<ItemModChildIO>
	|-Component.GetComponent<ItemModConsumable>
	|-Component.GetComponent<ItemModConsume>
	|-Component.GetComponent<ItemModContainer>
	|-Component.GetComponent<ItemModCookable>
	|-Component.GetComponent<ItemModDeployable>
	|-Component.GetComponent<ItemModEntity>
	|-Component.GetComponent<ItemModKeycard>
	|-Component.GetComponent<ItemModPetStats>
	|-Component.GetComponent<ItemModProjectile>
	|-Component.GetComponent<ItemModRFListener>
	|-Component.GetComponent<ItemModSign>
	|-Component.GetComponent<ItemModWearable>
	|-Component.GetComponent<LODComponent>
	|-Component.GetComponent<LODComponentParticleSystem>
	|-Component.GetComponent<LightEx>
	|-Component.GetComponent<LightLOD>
	|-Component.GetComponent<LightOccludee>
	|-Component.GetComponent<LiquidContainer>
	|-Component.GetComponent<LiquidWeaponEffects>
	|-Component.GetComponent<LootPanel>
	|-Component.GetComponent<MagnetLiftable>
	|-Component.GetComponent<MaterialColorLerp>
	|-Component.GetComponent<MeshLOD>
	|-Component.GetComponent<Model>
	|-Component.GetComponent<MorphCache>
	|-Component.GetComponent<NeedsCursor>
	|-Component.GetComponent<NeedsKeyboard>
	|-Component.GetComponent<OnePoleLowpassFilter>
	|-Component.GetComponent<OvenItemIcon>
	|-Component.GetComponent<PagerEntity>
	|-Component.GetComponent<PaintableItem>
	|-Component.GetComponent<Planner>
	|-Component.GetComponent<PlanterBox>
	|-Component.GetComponent<PlayerBlueprints>
	|-Component.GetComponent<PlayerEyes>
	|-Component.GetComponent<PlayerInput>
	|-Component.GetComponent<PlayerInventory>
	|-Component.GetComponent<PlayerLoot>
	|-Component.GetComponent<PlayerMetabolism>
	|-Component.GetComponent<PlayerModel>
	|-Component.GetComponent<PlayerModelHair>
	|-Component.GetComponent<PlayerModelHairCap>
	|-Component.GetComponent<PlayerModifiers>
	|-Component.GetComponent<PlayerVoiceRecorder>
	|-Component.GetComponent<PlayerVoiceSpeaker>
	|-Component.GetComponent<PlayingCardsViewmodel>
	|-Component.GetComponent<PostOpaqueDepth>
	|-Component.GetComponent<PowerLineWireConnectionHelper>
	|-Component.GetComponent<Projectile>
	|-Component.GetComponent<RealmedRemove>
	|-Component.GetComponent<RendererBatch>
	|-Component.GetComponent<CoverPointVolume>
	|-Component.GetComponent<IEntity>
	|-Component.GetComponent<ItemModEngineItem>
	|-Component.GetComponent<ItemModVehicleModule>
	|-Component.GetComponent<RustButton>
	|-Component.GetComponent<RustImageButton>
	|-Component.GetComponent<RustInput>
	|-Component.GetComponent<RustLayout>
	|-Component.GetComponent<RustText>
	|-Component.GetComponent<SteamInventoryItem>
	|-Component.GetComponent<WorkshopPlayerPreview>
	|-Component.GetComponent<SedanWheelSmoke>
	|-Component.GetComponent<ServerHistoryItem>
	|-Component.GetComponent<SkinnedMultiMesh>
	|-Component.GetComponent<Sound>
	|-Component.GetComponent<SoundFadeHQAudioFilter>
	|-Component.GetComponent<SpriteArcadeEntity>
	|-Component.GetComponent<SteamInventory>
	|-Component.GetComponent<SwapArrows>
	|-Component.GetComponent<SwapKeycard>
	|-Component.GetComponent<SwapRPG>
	|-Component.GetComponent<TMP_InputField>
	|-Component.GetComponent<TMP_Text>
	|-Component.GetComponent<TextMeshPro>
	|-Component.GetComponent<TextMeshProUGUI>
	|-Component.GetComponent<TOD_Animation>
	|-Component.GetComponent<TOD_Components>
	|-Component.GetComponent<TOD_Resources>
	|-Component.GetComponent<TOD_Scattering>
	|-Component.GetComponent<TOD_Sky>
	|-Component.GetComponent<TOD_Time>
	|-Component.GetComponent<TechTreeDialog>
	|-Component.GetComponent<TechTreeEntry>
	|-Component.GetComponent<TerrainAlphaMap>
	|-Component.GetComponent<TerrainBiomeMap>
	|-Component.GetComponent<TerrainBlendMap>
	|-Component.GetComponent<TerrainCollision>
	|-Component.GetComponent<TerrainCollisionProxy>
	|-Component.GetComponent<TerrainColors>
	|-Component.GetComponent<TerrainDistanceMap>
	|-Component.GetComponent<TerrainHeightMap>
	|-Component.GetComponent<TerrainMeta>
	|-Component.GetComponent<TerrainPath>
	|-Component.GetComponent<TerrainPhysics>
	|-Component.GetComponent<TerrainPlacementMap>
	|-Component.GetComponent<TerrainQuality>
	|-Component.GetComponent<TerrainSplatMap>
	|-Component.GetComponent<TerrainTexturing>
	|-Component.GetComponent<TerrainTopologyMap>
	|-Component.GetComponent<TerrainWaterMap>
	|-Component.GetComponent<Tooltip>
	|-Component.GetComponent<TreadAnimator>
	|-Component.GetComponent<TriggerLadder>
	|-Component.GetComponent<UIEscapeCapture>
	|-Component.GetComponent<Animation>
	|-Component.GetComponent<Animator>
	|-Component.GetComponent<AudioSource>
	|-Component.GetComponent<BoxCollider>
	|-Component.GetComponent<Camera>
	|-Component.GetComponent<Canvas>
	|-Component.GetComponent<CanvasGroup>
	|-Component.GetComponent<CanvasRenderer>
	|-Component.GetComponent<CapsuleCollider>
	|-Component.GetComponent<Collider>
	|-Component.GetComponent<EventSystem>
	|-Component.GetComponent<LODGroup>
	|-Component.GetComponent<Light>
	|-Component.GetComponent<LineRenderer>
	|-Component.GetComponent<MeshCollider>
	|-Component.GetComponent<MeshFilter>
	|-Component.GetComponent<MeshRenderer>
	|-Component.GetComponent<ParticleSystem>
	|-Component.GetComponent<ParticleSystemRenderer>
	|-Component.GetComponent<PlayableDirector>
	|-Component.GetComponent<Projector>
	|-Component.GetComponent<RectTransform>
	|-Component.GetComponent<ReflectionProbe>
	|-Component.GetComponent<Renderer>
	|-Component.GetComponent<PostProcessLayer>
	|-Component.GetComponent<PostProcessVolume>
	|-Component.GetComponent<Rigidbody>
	|-Component.GetComponent<SkinnedMeshRenderer>
	|-Component.GetComponent<SphereCollider>
	|-Component.GetComponent<SpriteRenderer>
	|-Component.GetComponent<Terrain>
	|-Component.GetComponent<TerrainCollider>
	|-Component.GetComponent<TrailRenderer>
	|-Component.GetComponent<Transform>
	|-Component.GetComponent<Button>
	|-Component.GetComponent<CanvasScaler>
	|-Component.GetComponent<Graphic>
	|-Component.GetComponent<GraphicRaycaster>
	|-Component.GetComponent<GridLayoutGroup>
	|-Component.GetComponent<ILayoutController>
	|-Component.GetComponent<Image>
	|-Component.GetComponent<InputField>
	|-Component.GetComponent<LayoutElement>
	|-Component.GetComponent<Mask>
	|-Component.GetComponent<RawImage>
	|-Component.GetComponent<ScrollRect>
	|-Component.GetComponent<Slider>
	|-Component.GetComponent<Text>
	|-Component.GetComponent<Toggle>
	|-Component.GetComponent<ToggleGroup>
	|-Component.GetComponent<VerticalLayoutGroup>
	|-Component.GetComponent<VideoPlayer>
	|-Component.GetComponent<WindZone>
	|-Component.GetComponent<TriggerZone>
	|-Component.GetComponent<VolumetricLightBeam>
	|-Component.GetComponent<VehicleModuleEngine>
	|-Component.GetComponent<VehicleModuleInformationPanel.IVehicleModuleInfo>
	|-Component.GetComponent<VehicleSpawner>
	|-Component.GetComponent<VertexColorStream>
	|-Component.GetComponent<ViewModel>
	|-Component.GetComponent<ViewmodelAspectOffset>
	|-Component.GetComponent<ViewmodelAttachment>
	|-Component.GetComponent<ViewmodelBob>
	|-Component.GetComponent<ViewmodelLower>
	|-Component.GetComponent<ViewmodelMountedAnchor>
	|-Component.GetComponent<ViewmodelPunch>
	|-Component.GetComponent<ViewmodelSway>
	|-Component.GetComponent<WaterCollision>
	|-Component.GetComponent<WaterDynamics>
	|-Component.GetComponent<WearableHairCap>
	|-Component.GetComponent<WearableReplacementByRace>
	|-Component.GetComponent<WearableShadowLod>
	|-Component.GetComponent<WireTool>
	|-Component.GetComponent<flamethrowerFire>
	|-Component.GetComponent<v_chainsaw>
	|-Component.GetComponent<object>
	*/

	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-Component.TryGetComponent<BeltBarIcon>
	|-Component.TryGetComponent<BoneRetarget>
	|-Component.TryGetComponent<ColliderInfo>
	|-Component.TryGetComponent<ConnectedSpeaker>
	|-Component.TryGetComponent<DragMeCustomParent>
	|-Component.TryGetComponent<DungeonGridInfo>
	|-Component.TryGetComponent<IFlexNode>
	|-Component.TryGetComponent<HitboxSystem>
	|-Component.TryGetComponent<IAnimationEventReceiver>
	|-Component.TryGetComponent<IAudioConnectionSource>
	|-Component.TryGetComponent<IAutoLayout>
	|-Component.TryGetComponent<IContainerSounds>
	|-Component.TryGetComponent<IPropRenderNotify>
	|-Component.TryGetComponent<InstrumentKeyController>
	|-Component.TryGetComponent<ItemModCassette>
	|-Component.TryGetComponent<ItemModCompostable>
	|-Component.TryGetComponent<ItemModDeployable>
	|-Component.TryGetComponent<ItemModEntity>
	|-Component.TryGetComponent<ItemModProjectile>
	|-Component.TryGetComponent<LootContainer>
	|-Component.TryGetComponent<NewsParagraph>
	|-Component.TryGetComponent<PreventBuildingMonumentTag>
	|-Component.TryGetComponent<RendererLOD>
	|-Component.TryGetComponent<SpawnableBoundsBlocker>
	|-Component.TryGetComponent<SprayCanViewmodel>
	|-Component.TryGetComponent<SwapKeycard>
	|-Component.TryGetComponent<object>
	|-Component.TryGetComponent<MeshFilter>
	|-Component.TryGetComponent<ParticleSystem>
	|-Component.TryGetComponent<Renderer>
	|-Component.TryGetComponent<Shadow>
	|-Component.TryGetComponent<ViewModel>
	|-Component.TryGetComponent<WaterBody>
	|-Component.TryGetComponent<WearableEyeViewAdjustment>
	|-Component.TryGetComponent<v_chainsaw>
	*/

	[TypeInferenceRuleAttribute] 
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentInChildren<VirtualScroll>
	|-Component.GetComponentInChildren<Publisher>
	|-Component.GetComponentInChildren<WorkshopView>
	|-Component.GetComponentInChildren<MeshRenderer>
	|-Component.GetComponentInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentInChildren<object>
	*/

	[ExcludeFromDocsAttribute] 
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentInChildren<AnimationEvents>
	|-Component.GetComponentInChildren<BlendedLoopEngineSound>
	|-Component.GetComponentInChildren<ConstructionPlaceholder>
	|-Component.GetComponentInChildren<DungeonBaseLink>
	|-Component.GetComponentInChildren<DungeonGridInfo>
	|-Component.GetComponentInChildren<DungeonGridLink>
	|-Component.GetComponentInChildren<DungeonVolume>
	|-Component.GetComponentInChildren<IAirSupply>
	|-Component.GetComponentInChildren<Impostor>
	|-Component.GetComponentInChildren<LODComponent>
	|-Component.GetComponentInChildren<MeshPaintController>
	|-Component.GetComponentInChildren<MeshPaintableSource>
	|-Component.GetComponentInChildren<NeedsCursor>
	|-Component.GetComponentInChildren<NeedsMouseButtons>
	|-Component.GetComponentInChildren<NeedsMouseWheel>
	|-Component.GetComponentInChildren<OutlineObject>
	|-Component.GetComponentInChildren<OvenLootPanel>
	|-Component.GetComponentInChildren<RustButton>
	|-Component.GetComponentInChildren<SteamInventoryItem>
	|-Component.GetComponentInChildren<TextMeshProUGUI>
	|-Component.GetComponentInChildren<TreeLOD>
	|-Component.GetComponentInChildren<Animator>
	|-Component.GetComponentInChildren<CanvasGroup>
	|-Component.GetComponentInChildren<Collider>
	|-Component.GetComponentInChildren<EventSystem>
	|-Component.GetComponentInChildren<PostProcessVolume>
	|-Component.GetComponentInChildren<TrailRenderer>
	|-Component.GetComponentInChildren<ScrollRect>
	|-Component.GetComponentInChildren<Text>
	|-Component.GetComponentInChildren<Toggle>
	|-Component.GetComponentInChildren<WaterBody>
	|-Component.GetComponentInChildren<object>
	*/

	[ExcludeFromDocsAttribute] 
	public Component[] GetComponentsInChildren(Type t) { }

	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentsInChildren<AchievementTodo>
	|-Component.GetComponentsInChildren<BaseScreenShake>
	|-Component.GetComponentsInChildren<BaseViewModel>
	|-Component.GetComponentsInChildren<BuildingProximity>
	|-Component.GetComponentsInChildren<EntityComponentBase>
	|-Component.GetComponentsInChildren<IOnPostNetworkUpdate>
	|-Component.GetComponentsInChildren<IVitalNotice>
	|-Component.GetComponentsInChildren<ItemInformationPanel>
	|-Component.GetComponentsInChildren<ItemMod>
	|-Component.GetComponentsInChildren<MissionsHUDToDo>
	|-Component.GetComponentsInChildren<ModelConditionTest>
	|-Component.GetComponentsInChildren<ProceduralComponent>
	|-Component.GetComponentsInChildren<ProtectionValue>
	|-Component.GetComponentsInChildren<RendererBatch>
	|-Component.GetComponentsInChildren<NetGraphRow>
	|-Component.GetComponentsInChildren<MaterialRow>
	|-Component.GetComponentsInChildren<ServerBrowserList>
	|-Component.GetComponentsInChildren<ServerBrowserTag>
	|-Component.GetComponentsInChildren<ServerBrowserTagGroup>
	|-Component.GetComponentsInChildren<SingletonComponent>
	|-Component.GetComponentsInChildren<SocketHandle>
	|-Component.GetComponentsInChildren<SocketMod>
	|-Component.GetComponentsInChildren<Socket_Base>
	|-Component.GetComponentsInChildren<SoundPlayer>
	|-Component.GetComponentsInChildren<TerrainPathConnect>
	|-Component.GetComponentsInChildren<AudioSource>
	|-Component.GetComponentsInChildren<Canvas>
	|-Component.GetComponentsInChildren<LODGroup>
	|-Component.GetComponentsInChildren<Light>
	|-Component.GetComponentsInChildren<MeshCollider>
	|-Component.GetComponentsInChildren<MeshFilter>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<ParticleSystemRenderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<GraphicRaycaster>
	|-Component.GetComponentsInChildren<Toggle>
	|-Component.GetComponentsInChildren<ViewmodelIgniteToggle>
	|-Component.GetComponentsInChildren<object>
	*/

	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentsInChildren<BaseVehicleModule>
	|-Component.GetComponentsInChildren<BoneRetarget>
	|-Component.GetComponentsInChildren<ComponentInfo>
	|-Component.GetComponentsInChildren<DungeonBaseSocket>
	|-Component.GetComponentsInChildren<DungeonVolume>
	|-Component.GetComponentsInChildren<EnvironmentVolume>
	|-Component.GetComponentsInChildren<SkeletonSkin>
	|-Component.GetComponentsInChildren<FruitScale>
	|-Component.GetComponentsInChildren<IRagdollInhert>
	|-Component.GetComponentsInChildren<LODComponent>
	|-Component.GetComponentsInChildren<LifeScale>
	|-Component.GetComponentsInChildren<LightOccludee>
	|-Component.GetComponentsInChildren<PlayerModelSkin>
	|-Component.GetComponentsInChildren<RustButton>
	|-Component.GetComponentsInChildren<object>
	|-Component.GetComponentsInChildren<CharacterJoint>
	|-Component.GetComponentsInChildren<ConfigurableJoint>
	|-Component.GetComponentsInChildren<Joint>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<Wearable>
	*/

	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentsInChildren<AIMovePoint>
	|-Component.GetComponentsInChildren<ArcadeEntity>
	|-Component.GetComponentsInChildren<BasePathNode>
	|-Component.GetComponentsInChildren<BlueprintCraftGridRow>
	|-Component.GetComponentsInChildren<ContactsEntry>
	|-Component.GetComponentsInChildren<DevControlsTab>
	|-Component.GetComponentsInChildren<HideIfScoped>
	|-Component.GetComponentsInChildren<HitNumber>
	|-Component.GetComponentsInChildren<ItemIcon>
	|-Component.GetComponentsInChildren<ItemTextValue>
	|-Component.GetComponentsInChildren<PathInterestNode>
	|-Component.GetComponentsInChildren<PathSpeedZone>
	|-Component.GetComponentsInChildren<NetGraphItem>
	|-Component.GetComponentsInChildren<RustText>
	|-Component.GetComponentsInChildren<TimelineMarker>
	|-Component.GetComponentsInChildren<Sound>
	|-Component.GetComponentsInChildren<SpawnGroup>
	|-Component.GetComponentsInChildren<TMP_SubMesh>
	|-Component.GetComponentsInChildren<TMP_SubMeshUI>
	|-Component.GetComponentsInChildren<NavMeshModifier>
	|-Component.GetComponentsInChildren<NavMeshModifierVolume>
	|-Component.GetComponentsInChildren<Collider>
	|-Component.GetComponentsInChildren<Light>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<TrailRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<Button>
	|-Component.GetComponentsInChildren<LayoutGroup>
	|-Component.GetComponentsInChildren<Toggle>
	|-Component.GetComponentsInChildren<VehicleLight>
	|-Component.GetComponentsInChildren<object>
	*/

	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentsInChildren<BurstClothCollider>
	|-Component.GetComponentsInChildren<HitboxDefinition>
	|-Component.GetComponentsInChildren<ServerAdminUGCEntry>
	|-Component.GetComponentsInChildren<ServerAdminUGCEntryPattern>
	|-Component.GetComponentsInChildren<object>
	|-Component.GetComponentsInChildren<AudioSource>
	|-Component.GetComponentsInChildren<Component>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<TrailRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<VolumetricLightBeam>
	*/

	[TypeInferenceRuleAttribute] 
	public Component GetComponentInParent(Type t) { }

	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentInParent<BaseEntity>
	|-Component.GetComponentInParent<BaseEventUI>
	|-Component.GetComponentInParent<BaseMountable>
	|-Component.GetComponentInParent<BaseNetworkable>
	|-Component.GetComponentInParent<BaseVehicleModule>
	|-Component.GetComponentInParent<BaseViewModel>
	|-Component.GetComponentInParent<ChangeSignText>
	|-Component.GetComponentInParent<DeployableBoomBox>
	|-Component.GetComponentInParent<Skeleton>
	|-Component.GetComponentInParent<HitboxSystem>
	|-Component.GetComponentInParent<IronSights>
	|-Component.GetComponentInParent<LifeInfographic>
	|-Component.GetComponentInParent<MLRS>
	|-Component.GetComponentInParent<MapView>
	|-Component.GetComponentInParent<MonumentInfo>
	|-Component.GetComponentInParent<Ragdoll>
	|-Component.GetComponentInParent<WorkshopInterface>
	|-Component.GetComponentInParent<WorkshopItemEditor>
	|-Component.GetComponentInParent<Canvas>
	|-Component.GetComponentInParent<CanvasGroup>
	|-Component.GetComponentInParent<CanvasScaler>
	|-Component.GetComponentInParent<Dropdown>
	|-Component.GetComponentInParent<ILayoutGroup>
	|-Component.GetComponentInParent<object>
	*/

	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentsInParent<object>
	*/

	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentsInParent<object>
	|-Component.GetComponentsInParent<Canvas>
	|-Component.GetComponentsInParent<RectMask2D>
	*/

	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-Component.GetComponentsInParent<BaseRaycaster>
	|-Component.GetComponentsInParent<object>
	*/

	public Component[] GetComponents(Type type) { }

	[FreeFunctionAttribute] 
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	public void GetComponents(Type type, List<Component> results) { }

	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-Component.GetComponents<object>
	|-Component.GetComponents<CanvasGroup>
	|-Component.GetComponents<Component>
	|-Component.GetComponents<BaseInputModule>
	|-Component.GetComponents<IMaterialModifier>
	|-Component.GetComponents<Mask>
	*/

	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-Component.GetComponents<EZSoftBone>
	|-Component.GetComponents<IImageEffect>
	|-Component.GetComponents<ItemMod>
	|-Component.GetComponents<LODComponentParticleSystem>
	|-Component.GetComponents<TerrainExtension>
	|-Component.GetComponents<Component>
	|-Component.GetComponents<BaseInput>
	|-Component.GetComponents<BaseRaycaster>
	|-Component.GetComponents<object>
	*/

	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] 
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	public void SendMessage(string methodName, object value) { }

	public void SendMessage(string methodName) { }

	[FreeFunctionAttribute] 
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	public void SendMessage(string methodName, SendMessageOptions options) { }

	[FreeFunctionAttribute] 
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] 
	public void BroadcastMessage(string methodName) { }

	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	public void .ctor() { }

}

