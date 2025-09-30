using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.WorldspacePopup;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Vision
{
	// Token: 0x0200037D RID: 893
	[Token(Token = "0x200037D")]
	public class VisionCone : NetworkBehaviour
	{
		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x170003C0")]
		protected float effectiveRange
		{
			[Token(Token = "0x60013E1")]
			[Address(RVA = "0x5C4F10", Offset = "0x5C3910", VA = "0x1805C4F10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x5BFAA0", Offset = "0x5BE4A0", VA = "0x1805BFAA0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x5C2470", Offset = "0x5C0E70", VA = "0x1805C2470")]
		private void PlayerSpawned(Player plr)
		{
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x5C2410", Offset = "0x5C0E10", VA = "0x1805C2410")]
		private void OnDisable()
		{
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x5C4BB0", Offset = "0x5C35B0", VA = "0x1805C4BB0", Slot = "20")]
		protected virtual void Update()
		{
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x5C0060", Offset = "0x5BEA60", VA = "0x1805C0060", Slot = "21")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x5C4BD0", Offset = "0x5C35D0", VA = "0x1805C4BD0", Slot = "22")]
		protected virtual void VisionUpdate()
		{
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x5C3620", Offset = "0x5C2020", VA = "0x1805C3620", Slot = "23")]
		protected virtual void UpdateEvents(float tickTime)
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x5C40D0", Offset = "0x5C2AD0", VA = "0x1805C40D0", Slot = "24")]
		protected virtual void UpdateVision(float tickTime)
		{
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x5BFF60", Offset = "0x5BE960", VA = "0x1805BFF60", Slot = "25")]
		public virtual void EventReachedZero(VisionEvent _event)
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x5BFE90", Offset = "0x5BE890", VA = "0x1805BFE90", Slot = "26")]
		public virtual void EventHalfNoticed(VisionEvent _event)
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x5BFCA0", Offset = "0x5BE6A0", VA = "0x1805BFCA0", Slot = "27")]
		public virtual void EventFullyNoticed(VisionEvent _event)
		{
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x5C3290", Offset = "0x5C1C90", VA = "0x1805C3290")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x5C2BE0", Offset = "0x5C15E0", VA = "0x1805C2BE0", Slot = "28")]
		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public virtual void ReceiveEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x5BF650", Offset = "0x5BE050", VA = "0x1805BF650")]
		public void AddSightableOfInterest(ISightable s)
		{
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x5C2D40", Offset = "0x5C1740", VA = "0x1805C2D40")]
		public void RemoveSightableOfInterest(ISightable s)
		{
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x5C34C0", Offset = "0x5C1EC0", VA = "0x1805C34C0")]
		public void SetSightableStateEnabled(ISightable sightable, EVisualState state, bool enabled)
		{
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x5C26D0", Offset = "0x5C10D0", VA = "0x1805C26D0")]
		[Button]
		public void PrintSightableStates()
		{
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x5C1970", Offset = "0x5C0370", VA = "0x1805C1970", Slot = "29")]
		public virtual bool IsPointWithinSight(Vector3 point, bool ignoreLoS = false, [Optional] LandVehicle vehicleToIgnore)
		{
			return default(bool);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x5C0170", Offset = "0x5BEB70", VA = "0x1805C0170")]
		public VisionEvent GetEvent(ISightable target, EntityVisualState state)
		{
			return null;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x5C17F0", Offset = "0x5C01F0", VA = "0x1805C17F0")]
		public bool IsPlayerVisible(Player player)
		{
			return default(bool);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x5C17F0", Offset = "0x5C01F0", VA = "0x1805C17F0")]
		public bool WasSightableVisibleThisFrame(ISightable sightable)
		{
			return default(bool);
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x5C2120", Offset = "0x5C0B20", VA = "0x1805C2120")]
		public bool IsTargetVisible(ISightable target)
		{
			return default(bool);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x5C1700", Offset = "0x5C0100", VA = "0x1805C1700")]
		public float GetPlayerVisibility(Player player)
		{
			return 0f;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x5C18A0", Offset = "0x5C02A0", VA = "0x1805C18A0")]
		public bool IsPlayerVisible(Player player, out VisionCone.SightableData data)
		{
			return default(bool);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x5C33F0", Offset = "0x5C1DF0", VA = "0x1805C33F0", Slot = "30")]
		public virtual void SetNoticePlayerCrimes(Player player, bool active)
		{
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x5C2400", Offset = "0x5C0E00", VA = "0x1805C2400")]
		private void OnDie()
		{
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x5BFAF0", Offset = "0x5BE4F0", VA = "0x1805BFAF0")]
		public void ClearEvents()
		{
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x5C0E70", Offset = "0x5BF870", VA = "0x1805C0E70")]
		private Vector3[] GetFrustumVertices()
		{
			return null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x5C0270", Offset = "0x5BEC70", VA = "0x1805C0270")]
		private Plane[] GetFrustumPlanes()
		{
			return null;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x5C4C90", Offset = "0x5C3690", VA = "0x1805C4C90")]
		public VisionCone()
		{
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001401")]
		[Address(RVA = "0x5C2320", Offset = "0x5C0D20", VA = "0x1805C2320", Slot = "31")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001402")]
		[Address(RVA = "0x5C2300", Offset = "0x5C0D00", VA = "0x1805C2300", Slot = "32")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001403")]
		[Address(RVA = "0x5C22C0", Offset = "0x5C0CC0", VA = "0x1805C22C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x5C3130", Offset = "0x5C1B30", VA = "0x1805C3130")]
		private void RpcWriter___Server_SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x5C2EA0", Offset = "0x5C18A0", VA = "0x1805C2EA0")]
		public void RpcLogic___SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x5C2F30", Offset = "0x5C1930", VA = "0x1805C2F30")]
		private void RpcReader___Server_SendEventReceipt_3486014028(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x5C2FC0", Offset = "0x5C19C0", VA = "0x1805C2FC0")]
		private void RpcWriter___Observers_ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x5C2E00", Offset = "0x5C1800", VA = "0x1805C2E00", Slot = "33")]
		public virtual void RpcLogic___ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001409")]
		[Address(RVA = "0x5C2EC0", Offset = "0x5C18C0", VA = "0x1805C2EC0")]
		private void RpcReader___Observers_ReceiveEventReceipt_3486014028(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x5BF6E0", Offset = "0x5BE0E0", VA = "0x1805BF6E0", Slot = "34")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vision.VisionCone_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040012C4 RID: 4804
		[Token(Token = "0x40012C4")]
		public const float VISION_UPDATE_INTERVAL = 0.1f;

		// Token: 0x040012C5 RID: 4805
		[Token(Token = "0x40012C5")]
		public const float MinVisionDelta = 0.075f;

		// Token: 0x040012C6 RID: 4806
		[Token(Token = "0x40012C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float UniversalAttentivenessScale;

		// Token: 0x040012C7 RID: 4807
		[Token(Token = "0x40012C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float UniversalMemoryScale;

		// Token: 0x040012C8 RID: 4808
		[Token(Token = "0x40012C8")]
		public const float HorizontalFOV = 135f;

		// Token: 0x040012C9 RID: 4809
		[Token(Token = "0x40012C9")]
		public const float VerticalFOV = 100f;

		// Token: 0x040012CA RID: 4810
		[Token(Token = "0x40012CA")]
		public const float Range = 25f;

		// Token: 0x040012CB RID: 4811
		[Token(Token = "0x40012CB")]
		public const float MinorWidth = 3f;

		// Token: 0x040012CC RID: 4812
		[Token(Token = "0x40012CC")]
		public const float MinorHeight = 1.5f;

		// Token: 0x040012CD RID: 4813
		[Token(Token = "0x40012CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x040012CE RID: 4814
		[Token(Token = "0x40012CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		public bool DisableSightUpdates;

		// Token: 0x040012CF RID: 4815
		[Token(Token = "0x40012CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Transform VisionOrigin;

		// Token: 0x040012D0 RID: 4816
		[Token(Token = "0x40012D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool DEBUG_FRUSTRUM;

		// Token: 0x040012D1 RID: 4817
		[Token(Token = "0x40012D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		[Header("Vision Settings")]
		public bool VisionEnabled;

		// Token: 0x040012D2 RID: 4818
		[Token(Token = "0x40012D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AnimationCurve VisionFalloff;

		// Token: 0x040012D3 RID: 4819
		[Token(Token = "0x40012D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public LayerMask VisibilityBlockingLayers;

		// Token: 0x040012D4 RID: 4820
		[Token(Token = "0x40012D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[Range(0f, 2f)]
		public float RangeMultiplier;

		// Token: 0x040012D5 RID: 4821
		[Token(Token = "0x40012D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[FormerlySerializedAs("StatesOfInterest")]
		[Header("Interest settings")]
		public List<VisionCone.StateContainer> DefaultStatesOfInterest;

		// Token: 0x040012D6 RID: 4822
		[Token(Token = "0x40012D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[Header("Notice Settings")]
		public float Attentiveness;

		// Token: 0x040012D7 RID: 4823
		[Token(Token = "0x40012D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float Memory;

		// Token: 0x040012D8 RID: 4824
		[Token(Token = "0x40012D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[Header("Worldspace Icons")]
		public bool WorldspaceIconsEnabled;

		// Token: 0x040012D9 RID: 4825
		[Token(Token = "0x40012D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public WorldspacePopup QuestionMarkPopup;

		// Token: 0x040012DA RID: 4826
		[Token(Token = "0x40012DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public WorldspacePopup ExclamationPointPopup;

		// Token: 0x040012DB RID: 4827
		[Token(Token = "0x40012DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioSourceController ExclamationSound;

		// Token: 0x040012DC RID: 4828
		[Token(Token = "0x40012DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public VisionCone.EventStateChange onVisionEventStarted;

		// Token: 0x040012DD RID: 4829
		[Token(Token = "0x40012DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public VisionCone.EventStateChange onVisionEventHalf;

		// Token: 0x040012DE RID: 4830
		[Token(Token = "0x40012DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public VisionCone.EventStateChange onVisionEventFull;

		// Token: 0x040012DF RID: 4831
		[Token(Token = "0x40012DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public VisionCone.EventStateChange onVisionEventExpired;

		// Token: 0x040012E0 RID: 4832
		[Token(Token = "0x40012E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected List<ISightable> sightablesOfInterest;

		// Token: 0x040012E1 RID: 4833
		[Token(Token = "0x40012E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		protected Dictionary<ISightable, VisionCone.SightableData> sightableDatas;

		// Token: 0x040012E2 RID: 4834
		[Token(Token = "0x40012E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		protected Dictionary<ISightable, Dictionary<EVisualState, VisionCone.StateContainer>> stateSettings;

		// Token: 0x040012E3 RID: 4835
		[Token(Token = "0x40012E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		protected List<VisionEvent> activeVisionEvents;

		// Token: 0x040012E4 RID: 4836
		[Token(Token = "0x40012E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		protected List<VisionEvent> cachedVisionEvents;

		// Token: 0x040012E5 RID: 4837
		[Token(Token = "0x40012E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected NPC npc;

		// Token: 0x040012E6 RID: 4838
		[Token(Token = "0x40012E6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		protected bool noticeGeneralCrime;

		// Token: 0x040012E7 RID: 4839
		[Token(Token = "0x40012E7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		protected List<ISightable> sightablesSeenThisFrame;

		// Token: 0x040012E8 RID: 4840
		[Token(Token = "0x40012E8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		protected List<ISightable> toRemove;

		// Token: 0x040012E9 RID: 4841
		[Token(Token = "0x40012E9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private bool NetworkInitialize___EarlyScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted;

		// Token: 0x040012EA RID: 4842
		[Token(Token = "0x40012EA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		private bool NetworkInitialize__LateScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted;

		// Token: 0x0200037E RID: 894
		[Token(Token = "0x200037E")]
		public enum EEventLevel
		{
			// Token: 0x040012EC RID: 4844
			[Token(Token = "0x40012EC")]
			Start,
			// Token: 0x040012ED RID: 4845
			[Token(Token = "0x40012ED")]
			Half,
			// Token: 0x040012EE RID: 4846
			[Token(Token = "0x40012EE")]
			Full,
			// Token: 0x040012EF RID: 4847
			[Token(Token = "0x40012EF")]
			Zero
		}

		// Token: 0x0200037F RID: 895
		[Token(Token = "0x200037F")]
		[Serializable]
		public class StateContainer
		{
			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x0600140B RID: 5131 RVA: 0x00008310 File Offset: 0x00006510
			[Token(Token = "0x170003C1")]
			public float RequiredNoticeTime
			{
				[Token(Token = "0x600140B")]
				[Address(RVA = "0x5B8E70", Offset = "0x5B7870", VA = "0x1805B8E70")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600140C RID: 5132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600140C")]
			[Address(RVA = "0x5B8DF0", Offset = "0x5B77F0", VA = "0x1805B8DF0")]
			public VisionCone.StateContainer GetCopy()
			{
				return null;
			}

			// Token: 0x0600140D RID: 5133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600140D")]
			[Address(RVA = "0x5B8E60", Offset = "0x5B7860", VA = "0x1805B8E60")]
			public StateContainer()
			{
			}

			// Token: 0x040012F0 RID: 4848
			[Token(Token = "0x40012F0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EVisualState state;

			// Token: 0x040012F1 RID: 4849
			[Token(Token = "0x40012F1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool Enabled;

			// Token: 0x040012F2 RID: 4850
			[Token(Token = "0x40012F2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0.5f, 4f)]
			public float NoticeTimeMultiplier;
		}

		// Token: 0x02000380 RID: 896
		[Token(Token = "0x2000380")]
		public class SightableData
		{
			// Token: 0x0600140E RID: 5134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600140E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SightableData()
			{
			}

			// Token: 0x040012F3 RID: 4851
			[Token(Token = "0x40012F3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ISightable Sightable;

			// Token: 0x040012F4 RID: 4852
			[Token(Token = "0x40012F4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VisionDelta;

			// Token: 0x040012F5 RID: 4853
			[Token(Token = "0x40012F5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float TimeVisible;
		}

		// Token: 0x02000381 RID: 897
		// (Invoke) Token: 0x06001410 RID: 5136
		[Token(Token = "0x2000381")]
		public delegate void EventStateChange(VisionEventReceipt _event);
	}
}
