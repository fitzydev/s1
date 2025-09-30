using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x02000372 RID: 882
	[Token(Token = "0x2000372")]
	public class EntityVisibility : NetworkBehaviour
	{
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x000081A8 File Offset: 0x000063A8
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B7")]
		public float CurrentVisibility
		{
			[Token(Token = "0x60013A7")]
			[Address(RVA = "0x5ADF00", Offset = "0x5AC900", VA = "0x1805ADF00")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60013A8")]
			[Address(RVA = "0x5ADF20", Offset = "0x5AC920", VA = "0x1805ADF20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x000081C0 File Offset: 0x000063C0
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B8")]
		public float Suspiciousness
		{
			[Token(Token = "0x60013A9")]
			[Address(RVA = "0x5ADF10", Offset = "0x5AC910", VA = "0x1805ADF10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60013AA")]
			[Address(RVA = "0x5ADF30", Offset = "0x5AC930", VA = "0x1805ADF30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B9")]
		public List<EntityVisualState> VisualStates
		{
			[Token(Token = "0x60013AB")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013AC")]
			[Address(RVA = "0x5ADF40", Offset = "0x5AC940", VA = "0x1805ADF40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x000081D8 File Offset: 0x000063D8
		[Token(Token = "0x170003BA")]
		public Vector3 CenterPoint
		{
			[Token(Token = "0x60013AD")]
			[Address(RVA = "0x5ADDE0", Offset = "0x5AC7E0", VA = "0x1805ADDE0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x5AB8F0", Offset = "0x5AA2F0", VA = "0x1805AB8F0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x5AD0D0", Offset = "0x5ABAD0", VA = "0x1805AD0D0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x5ACD60", Offset = "0x5AB760", VA = "0x1805ACD60", Slot = "20")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x000081F0 File Offset: 0x000063F0
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x5AC890", Offset = "0x5AB290", VA = "0x1805AC890")]
		private float CalculateVisibility()
		{
			return 0f;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x5ACE20", Offset = "0x5AB820", VA = "0x1805ACE20")]
		public VisibilityAttribute GetAttribute(string name)
		{
			return null;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x5ADB90", Offset = "0x5AC590", VA = "0x1805ADB90")]
		private void UpdateEnvironmentalVisibilityAttribute()
		{
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x5AB930", Offset = "0x5AA330", VA = "0x1805AB930")]
		public float CalculateExposureToPoint(Vector3 point, float checkRange = 50f, [Optional] NPC checkingNPC)
		{
			return 0f;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x5AB890", Offset = "0x5AA290", VA = "0x1805AB890")]
		[ServerRpc(RunLocally = true)]
		public void ApplyState(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x5AD180", Offset = "0x5ABB80", VA = "0x1805AD180")]
		[ServerRpc(RunLocally = true)]
		public void RemoveState(string label, float delay = 0f)
		{
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x5ACF00", Offset = "0x5AB900", VA = "0x1805ACF00")]
		public EntityVisualState GetState(string label)
		{
			return null;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x5ACC50", Offset = "0x5AB650", VA = "0x1805ACC50")]
		public void ClearStates()
		{
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x5ADC30", Offset = "0x5AC630", VA = "0x1805ADC30")]
		public EntityVisibility()
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x5AD000", Offset = "0x5ABA00", VA = "0x1805AD000", Slot = "21")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x5ACFE0", Offset = "0x5AB9E0", VA = "0x1805ACFE0", Slot = "22")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x5AB8F0", Offset = "0x5AA2F0", VA = "0x1805AB8F0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x5AD7D0", Offset = "0x5AC1D0", VA = "0x1805AD7D0")]
		private void RpcWriter___Server_ApplyState_2910447583(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x5AD1C0", Offset = "0x5ABBC0", VA = "0x1805AD1C0")]
		public void RpcLogic___ApplyState_2910447583(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x5AD660", Offset = "0x5AC060", VA = "0x1805AD660")]
		private void RpcReader___Server_ApplyState_2910447583(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x5AD9A0", Offset = "0x5AC3A0", VA = "0x1805AD9A0")]
		private void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0f)
		{
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x5AD410", Offset = "0x5ABE10", VA = "0x1805AD410")]
		public void RpcLogic___RemoveState_606697822(string label, float delay = 0f)
		{
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x5AD730", Offset = "0x5AC130", VA = "0x1805AD730")]
		private void RpcReader___Server_RemoveState_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "23")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vision.EntityVisibility_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001294 RID: 4756
		[Token(Token = "0x4001294")]
		public const float MAX_VISIBLITY = 100f;

		// Token: 0x04001297 RID: 4759
		[Token(Token = "0x4001297")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public List<VisibilityAttribute> ActiveAttributes;

		// Token: 0x04001299 RID: 4761
		[Token(Token = "0x4001299")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Header("Settings")]
		public LayerMask VisibilityCheckMask;

		// Token: 0x0400129A RID: 4762
		[Token(Token = "0x400129A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Header("References")]
		public Transform CentralVisibilityPoint;

		// Token: 0x0400129B RID: 4763
		[Token(Token = "0x400129B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public List<Transform> VisibilityPoints;

		// Token: 0x0400129C RID: 4764
		[Token(Token = "0x400129C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private VisibilityAttribute environmentalVisibility;

		// Token: 0x0400129D RID: 4765
		[Token(Token = "0x400129D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Dictionary<string, Coroutine> removalRoutinesDict;

		// Token: 0x0400129E RID: 4766
		[Token(Token = "0x400129E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Dictionary<string, float> maxPointsChangesByUniquenessCode;

		// Token: 0x0400129F RID: 4767
		[Token(Token = "0x400129F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<RaycastHit> hits;

		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Vision.EntityVisibilityAssembly-CSharp.dll_Excuted;

		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Vision.EntityVisibilityAssembly-CSharp.dll_Excuted;
	}
}
