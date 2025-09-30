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
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CC9 RID: 3273
	[Token(Token = "0x2000CC9")]
	public class SoilPourer : GridItem
	{
		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06005CB5 RID: 23733 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005CB6 RID: 23734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CFC")]
		public string SoilID
		{
			[Token(Token = "0x6005CB5")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CB6")]
			[Address(RVA = "0x6302A0", Offset = "0x62ECA0", VA = "0x1806302A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB7")]
		[Address(RVA = "0xA4F9E0", Offset = "0xA4E3E0", VA = "0x180A4F9E0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB8")]
		[Address(RVA = "0xA4F630", Offset = "0xA4E030", VA = "0x180A4F630")]
		public void HandleHovered()
		{
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB9")]
		[Address(RVA = "0xA4F6D0", Offset = "0xA4E0D0", VA = "0x180A4F6D0")]
		public void HandleInteracted()
		{
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBA")]
		[Address(RVA = "0xA50510", Offset = "0xA4EF10", VA = "0x180A50510")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendPourSoil()
		{
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBB")]
		[Address(RVA = "0xA4FAB0", Offset = "0xA4E4B0", VA = "0x180A4FAB0")]
		[ObserversRpc(RunLocally = true)]
		private void PourSoil()
		{
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0xA4EA20", Offset = "0xA4D420", VA = "0x180A4EA20")]
		private void ApplySoil(string ID)
		{
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBD")]
		[Address(RVA = "0xA4EBF0", Offset = "0xA4D5F0", VA = "0x180A4EBF0")]
		public void FillHovered()
		{
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBE")]
		[Address(RVA = "0xA4EDD0", Offset = "0xA4D7D0", VA = "0x180A4EDD0")]
		public void FillInteracted()
		{
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBF")]
		[Address(RVA = "0xA50620", Offset = "0xA4F020", VA = "0x180A50620")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendSoil(string ID)
		{
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC0")]
		[Address(RVA = "0xA508B0", Offset = "0xA4F2B0", VA = "0x180A508B0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		protected void SetSoil(NetworkConnection conn, string ID)
		{
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC1")]
		[Address(RVA = "0xA50750", Offset = "0xA4F150", VA = "0x180A50750")]
		public void SetSoilLevel(float level)
		{
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0xA4F210", Offset = "0xA4DC10", VA = "0x180A4F210", Slot = "71")]
		protected virtual List<Pot> GetPots()
		{
			return null;
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC3")]
		[Address(RVA = "0xA4F110", Offset = "0xA4DB10", VA = "0x180A4F110", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC4")]
		[Address(RVA = "0xA50B80", Offset = "0xA4F580", VA = "0x180A50B80")]
		public SoilPourer()
		{
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC5")]
		[Address(RVA = "0xA50B10", Offset = "0xA4F510", VA = "0x180A50B10")]
		[CompilerGenerated]
		private IEnumerator <PourSoil>g__PourRoutine|20_0()
		{
			return null;
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC6")]
		[Address(RVA = "0xA4F830", Offset = "0xA4E230", VA = "0x180A4F830", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC7")]
		[Address(RVA = "0xA4F810", Offset = "0xA4E210", VA = "0x180A4F810", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC8")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0xA50170", Offset = "0xA4EB70", VA = "0x180A50170")]
		private void RpcWriter___Server_SendPourSoil_2166136261()
		{
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0xA4FAB0", Offset = "0xA4E4B0", VA = "0x180A4FAB0")]
		private void RpcLogic___SendPourSoil_2166136261()
		{
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0xA4FDE0", Offset = "0xA4E7E0", VA = "0x180A4FDE0")]
		private void RpcReader___Server_SendPourSoil_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCC")]
		[Address(RVA = "0xA4FF10", Offset = "0xA4E910", VA = "0x180A4FF10")]
		private void RpcWriter___Observers_PourSoil_2166136261()
		{
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCD")]
		[Address(RVA = "0xA4FBD0", Offset = "0xA4E5D0", VA = "0x180A4FBD0")]
		private void RpcLogic___PourSoil_2166136261()
		{
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCE")]
		[Address(RVA = "0xA4FD40", Offset = "0xA4E740", VA = "0x180A4FD40")]
		private void RpcReader___Observers_PourSoil_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCF")]
		[Address(RVA = "0xA50280", Offset = "0xA4EC80", VA = "0x180A50280")]
		private void RpcWriter___Server_SendSoil_3615296227(string ID)
		{
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD0")]
		[Address(RVA = "0xA4FC60", Offset = "0xA4E660", VA = "0x180A4FC60")]
		public void RpcLogic___SendSoil_3615296227(string ID)
		{
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD1")]
		[Address(RVA = "0xA4FE30", Offset = "0xA4E830", VA = "0x180A4FE30")]
		private void RpcReader___Server_SendSoil_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD2")]
		[Address(RVA = "0xA50030", Offset = "0xA4EA30", VA = "0x180A50030")]
		private void RpcWriter___Observers_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD3")]
		[Address(RVA = "0xA4FC70", Offset = "0xA4E670", VA = "0x180A4FC70")]
		protected void RpcLogic___SetSoil_2971853958(NetworkConnection conn, string ID)
		{
		}

		// Token: 0x06005CD4 RID: 23764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD4")]
		[Address(RVA = "0xA4FD80", Offset = "0xA4E780", VA = "0x180A4FD80")]
		private void RpcReader___Observers_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD5")]
		[Address(RVA = "0xA503B0", Offset = "0xA4EDB0", VA = "0x180A503B0")]
		private void RpcWriter___Target_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD6")]
		[Address(RVA = "0xA4FEB0", Offset = "0xA4E8B0", VA = "0x180A4FEB0")]
		private void RpcReader___Target_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD7")]
		[Address(RVA = "0x9C4910", Offset = "0x9C3310", VA = "0x1809C4910", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04004355 RID: 17237
		[Token(Token = "0x4004355")]
		[FieldOffset(Offset = "0x220")]
		public float AnimationDuration;

		// Token: 0x04004356 RID: 17238
		[Token(Token = "0x4004356")]
		[FieldOffset(Offset = "0x228")]
		[Header("References")]
		public InteractableObject HandleIntObj;

		// Token: 0x04004357 RID: 17239
		[Token(Token = "0x4004357")]
		[FieldOffset(Offset = "0x230")]
		public InteractableObject FillIntObj;

		// Token: 0x04004358 RID: 17240
		[Token(Token = "0x4004358")]
		[FieldOffset(Offset = "0x238")]
		public MeshRenderer DirtPlane;

		// Token: 0x04004359 RID: 17241
		[Token(Token = "0x4004359")]
		[FieldOffset(Offset = "0x240")]
		public Transform Dirt_Min;

		// Token: 0x0400435A RID: 17242
		[Token(Token = "0x400435A")]
		[FieldOffset(Offset = "0x248")]
		public Transform Dirt_Max;

		// Token: 0x0400435B RID: 17243
		[Token(Token = "0x400435B")]
		[FieldOffset(Offset = "0x250")]
		public ParticleSystem PourParticles;

		// Token: 0x0400435C RID: 17244
		[Token(Token = "0x400435C")]
		[FieldOffset(Offset = "0x258")]
		public Animation PourAnimation;

		// Token: 0x0400435D RID: 17245
		[Token(Token = "0x400435D")]
		[FieldOffset(Offset = "0x260")]
		public AudioSourceController FillSound;

		// Token: 0x0400435E RID: 17246
		[Token(Token = "0x400435E")]
		[FieldOffset(Offset = "0x268")]
		public AudioSourceController ActivateSound;

		// Token: 0x0400435F RID: 17247
		[Token(Token = "0x400435F")]
		[FieldOffset(Offset = "0x270")]
		public AudioSourceController DirtPourSound;

		// Token: 0x04004360 RID: 17248
		[Token(Token = "0x4004360")]
		[FieldOffset(Offset = "0x278")]
		private bool isDispensing;

		// Token: 0x04004361 RID: 17249
		[Token(Token = "0x4004361")]
		[FieldOffset(Offset = "0x279")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted;

		// Token: 0x04004362 RID: 17250
		[Token(Token = "0x4004362")]
		[FieldOffset(Offset = "0x27A")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted;
	}
}
