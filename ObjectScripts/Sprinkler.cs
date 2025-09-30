using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CC5 RID: 3269
	[Token(Token = "0x2000CC5")]
	public class Sprinkler : GridItem
	{
		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06005C82 RID: 23682 RVA: 0x00016620 File Offset: 0x00014820
		// (set) Token: 0x06005C83 RID: 23683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CF6")]
		public bool IsSprinkling
		{
			[Token(Token = "0x6005C82")]
			[Address(RVA = "0x69DDB0", Offset = "0x69C7B0", VA = "0x18069DDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C83")]
			[Address(RVA = "0x69DDC0", Offset = "0x69C7C0", VA = "0x18069DDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0xA51100", Offset = "0xA4FB00", VA = "0x180A51100")]
		public void Hovered()
		{
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C85")]
		[Address(RVA = "0xA51190", Offset = "0xA4FB90", VA = "0x180A51190")]
		public void Interacted()
		{
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x00016638 File Offset: 0x00014838
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0xA50CD0", Offset = "0xA4F6D0", VA = "0x180A50CD0")]
		private bool CanWater()
		{
			return default(bool);
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C87")]
		[Address(RVA = "0xA51860", Offset = "0xA50260", VA = "0x180A51860")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendWater()
		{
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0xA513D0", Offset = "0xA4FDD0", VA = "0x180A513D0")]
		[ObserversRpc(RunLocally = true)]
		private void Water()
		{
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0xA50BF0", Offset = "0xA4F5F0", VA = "0x180A50BF0")]
		public void ApplyWater(float normalizedAmount)
		{
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0xA50CE0", Offset = "0xA4F6E0", VA = "0x180A50CE0", Slot = "71")]
		protected virtual List<Pot> GetPots()
		{
			return null;
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0xA519E0", Offset = "0xA503E0", VA = "0x180A519E0")]
		public Sprinkler()
		{
		}

		// Token: 0x06005C8C RID: 23692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0xA51970", Offset = "0xA50370", VA = "0x180A51970")]
		[CompilerGenerated]
		private IEnumerator <Water>g__Routine|15_0()
		{
			return null;
		}

		// Token: 0x06005C8D RID: 23693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0xA512E0", Offset = "0xA4FCE0", VA = "0x180A512E0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0xA512C0", Offset = "0xA4FCC0", VA = "0x180A512C0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C90")]
		[Address(RVA = "0xA51750", Offset = "0xA50150", VA = "0x180A51750")]
		private void RpcWriter___Server_SendWater_2166136261()
		{
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C91")]
		[Address(RVA = "0xA513D0", Offset = "0xA4FDD0", VA = "0x180A513D0")]
		private void RpcLogic___SendWater_2166136261()
		{
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0xA515E0", Offset = "0xA4FFE0", VA = "0x180A515E0")]
		private void RpcReader___Server_SendWater_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C93")]
		[Address(RVA = "0xA51630", Offset = "0xA50030", VA = "0x180A51630")]
		private void RpcWriter___Observers_Water_2166136261()
		{
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C94")]
		[Address(RVA = "0xA514F0", Offset = "0xA4FEF0", VA = "0x180A514F0")]
		private void RpcLogic___Water_2166136261()
		{
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C95")]
		[Address(RVA = "0xA515A0", Offset = "0xA4FFA0", VA = "0x180A515A0")]
		private void RpcReader___Observers_Water_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C96")]
		[Address(RVA = "0x9C4910", Offset = "0x9C3310", VA = "0x1809C4910", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04004337 RID: 17207
		[Token(Token = "0x4004337")]
		[FieldOffset(Offset = "0x220")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04004338 RID: 17208
		[Token(Token = "0x4004338")]
		[FieldOffset(Offset = "0x228")]
		public ParticleSystem[] WaterParticles;

		// Token: 0x04004339 RID: 17209
		[Token(Token = "0x4004339")]
		[FieldOffset(Offset = "0x230")]
		public AudioSourceController ClickSound;

		// Token: 0x0400433A RID: 17210
		[Token(Token = "0x400433A")]
		[FieldOffset(Offset = "0x238")]
		public AudioSourceController WaterSound;

		// Token: 0x0400433B RID: 17211
		[Token(Token = "0x400433B")]
		[FieldOffset(Offset = "0x240")]
		[Header("Settings")]
		public float ApplyWaterDelay;

		// Token: 0x0400433C RID: 17212
		[Token(Token = "0x400433C")]
		[FieldOffset(Offset = "0x244")]
		public float ParticleStopDelay;

		// Token: 0x0400433D RID: 17213
		[Token(Token = "0x400433D")]
		[FieldOffset(Offset = "0x248")]
		public UnityEvent onSprinklerStart;

		// Token: 0x0400433E RID: 17214
		[Token(Token = "0x400433E")]
		[FieldOffset(Offset = "0x250")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400433F RID: 17215
		[Token(Token = "0x400433F")]
		[FieldOffset(Offset = "0x251")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted;
	}
}
