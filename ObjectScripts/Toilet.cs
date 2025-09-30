using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C72 RID: 3186
	[Token(Token = "0x2000C72")]
	public class Toilet : GridItem
	{
		// Token: 0x06005610 RID: 22032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005610")]
		[Address(RVA = "0x9DA790", Offset = "0x9D9190", VA = "0x1809DA790")]
		public void Hovered()
		{
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005611")]
		[Address(RVA = "0x9DA810", Offset = "0x9D9210", VA = "0x1809DA810")]
		public void Interacted()
		{
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005612")]
		[Address(RVA = "0x9DAC90", Offset = "0x9D9690", VA = "0x1809DAC90")]
		[ServerRpc(RequireOwnership = false)]
		private void SendFlush()
		{
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005613")]
		[Address(RVA = "0x9DA670", Offset = "0x9D9070", VA = "0x1809DA670")]
		[ObserversRpc]
		private void Flush()
		{
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005614")]
		[Address(RVA = "0x9DAE10", Offset = "0x9D9810", VA = "0x1809DAE10")]
		public Toilet()
		{
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005615")]
		[Address(RVA = "0x9DADA0", Offset = "0x9D97A0", VA = "0x1809DADA0")]
		[CompilerGenerated]
		private IEnumerator <Flush>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005616")]
		[Address(RVA = "0x9DA940", Offset = "0x9D9340", VA = "0x1809DA940", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005617")]
		[Address(RVA = "0x9DA920", Offset = "0x9D9320", VA = "0x1809DA920", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005618")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005619")]
		[Address(RVA = "0x9DAC90", Offset = "0x9D9690", VA = "0x1809DAC90")]
		private void RpcWriter___Server_SendFlush_2166136261()
		{
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561A")]
		[Address(RVA = "0x9DA670", Offset = "0x9D9070", VA = "0x1809DA670")]
		private void RpcLogic___SendFlush_2166136261()
		{
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561B")]
		[Address(RVA = "0x9DAB60", Offset = "0x9D9560", VA = "0x1809DAB60")]
		private void RpcReader___Server_SendFlush_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561C")]
		[Address(RVA = "0x9DA670", Offset = "0x9D9070", VA = "0x1809DA670")]
		private void RpcWriter___Observers_Flush_2166136261()
		{
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561D")]
		[Address(RVA = "0x9DAA30", Offset = "0x9D9430", VA = "0x1809DAA30")]
		private void RpcLogic___Flush_2166136261()
		{
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561E")]
		[Address(RVA = "0x9DAAC0", Offset = "0x9D94C0", VA = "0x1809DAAC0")]
		private void RpcReader___Observers_Flush_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561F")]
		[Address(RVA = "0x9C4910", Offset = "0x9C3310", VA = "0x1809C4910", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04003FCC RID: 16332
		[Token(Token = "0x4003FCC")]
		[FieldOffset(Offset = "0x218")]
		public float InitialDelay;

		// Token: 0x04003FCD RID: 16333
		[Token(Token = "0x4003FCD")]
		[FieldOffset(Offset = "0x21C")]
		public float FlushTime;

		// Token: 0x04003FCE RID: 16334
		[Token(Token = "0x4003FCE")]
		[FieldOffset(Offset = "0x220")]
		public InteractableObject IntObj;

		// Token: 0x04003FCF RID: 16335
		[Token(Token = "0x4003FCF")]
		[FieldOffset(Offset = "0x228")]
		public LayerMask ItemLayerMask;

		// Token: 0x04003FD0 RID: 16336
		[Token(Token = "0x4003FD0")]
		[FieldOffset(Offset = "0x230")]
		public SphereCollider ItemDetectionCollider;

		// Token: 0x04003FD1 RID: 16337
		[Token(Token = "0x4003FD1")]
		[FieldOffset(Offset = "0x238")]
		public UnityEvent OnFlush;

		// Token: 0x04003FD2 RID: 16338
		[Token(Token = "0x4003FD2")]
		[FieldOffset(Offset = "0x240")]
		private Coroutine _flushCoroutine;

		// Token: 0x04003FD3 RID: 16339
		[Token(Token = "0x4003FD3")]
		[FieldOffset(Offset = "0x248")]
		private bool isFlushing;

		// Token: 0x04003FD4 RID: 16340
		[Token(Token = "0x4003FD4")]
		[FieldOffset(Offset = "0x249")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted;

		// Token: 0x04003FD5 RID: 16341
		[Token(Token = "0x4003FD5")]
		[FieldOffset(Offset = "0x24A")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted;
	}
}
