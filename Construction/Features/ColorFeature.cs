using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x02000796 RID: 1942
	[Token(Token = "0x2000796")]
	public class ColorFeature : Feature
	{
		// Token: 0x06003462 RID: 13410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003462")]
		[Address(RVA = "0x790040", Offset = "0x78EA40", VA = "0x180790040", Slot = "20")]
		public override FI_Base CreateInterface(Transform parent)
		{
			return null;
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003463")]
		[Address(RVA = "0x790220", Offset = "0x78EC20", VA = "0x180790220", Slot = "21")]
		public override void Default()
		{
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003464")]
		[Address(RVA = "0x78FCC0", Offset = "0x78E6C0", VA = "0x18078FCC0")]
		private void ApplyColor(ColorFeature.NamedColor color)
		{
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[Token(Token = "0x6003465")]
		[Address(RVA = "0x7902D0", Offset = "0x78ECD0", VA = "0x1807902D0")]
		public static Color ModifyColor(Color original, float sChange, float vChange)
		{
			return default(Color);
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003466")]
		[Address(RVA = "0x790A30", Offset = "0x78F430", VA = "0x180790A30", Slot = "25")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(int colorIndex)
		{
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003467")]
		[Address(RVA = "0x790720", Offset = "0x78F120", VA = "0x180790720")]
		private void ReceiveData()
		{
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003468")]
		[Address(RVA = "0x78FFD0", Offset = "0x78E9D0", VA = "0x18078FFD0")]
		private void BuyColor(ColorFeature.NamedColor color)
		{
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003469")]
		[Address(RVA = "0x790B70", Offset = "0x78F570", VA = "0x180790B70")]
		public ColorFeature()
		{
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346A")]
		[Address(RVA = "0x790440", Offset = "0x78EE40", VA = "0x180790440", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346B")]
		[Address(RVA = "0x7903E0", Offset = "0x78EDE0", VA = "0x1807903E0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346C")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346D")]
		[Address(RVA = "0x7908F0", Offset = "0x78F2F0", VA = "0x1807908F0")]
		private void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346E")]
		[Address(RVA = "0x790780", Offset = "0x78F180", VA = "0x180790780", Slot = "26")]
		protected virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346F")]
		[Address(RVA = "0x790870", Offset = "0x78F270", VA = "0x180790870")]
		private void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x0000E610 File Offset: 0x0000C810
		// (set) Token: 0x06003471 RID: 13425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A5")]
		public int SyncAccessor_ownedColorIndex
		{
			[Token(Token = "0x6003470")]
			[Address(RVA = "0x790CD0", Offset = "0x78F6D0", VA = "0x180790CD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003471")]
			[Address(RVA = "0x790CE0", Offset = "0x78F6E0", VA = "0x180790CE0")]
			set
			{
			}
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x0000E628 File Offset: 0x0000C828
		[Token(Token = "0x6003472")]
		[Address(RVA = "0x7905F0", Offset = "0x78EFF0", VA = "0x1807905F0", Slot = "27")]
		public virtual bool ReadSyncVar___ScheduleOne.Construction.Features.ColorFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003473")]
		[Address(RVA = "0x78FF60", Offset = "0x78E960", VA = "0x18078FF60", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400246E RID: 9326
		[Token(Token = "0x400246E")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Header("References")]
		protected List<MeshRenderer> colorTargets;

		// Token: 0x0400246F RID: 9327
		[Token(Token = "0x400246F")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected List<ColorFeature.SecondaryPaintTarget> secondaryTargets;

		// Token: 0x04002470 RID: 9328
		[Token(Token = "0x4002470")]
		[FieldOffset(Offset = "0x150")]
		[Header("Color settings")]
		public List<ColorFeature.NamedColor> colors;

		// Token: 0x04002471 RID: 9329
		[Token(Token = "0x4002471")]
		[FieldOffset(Offset = "0x158")]
		public int defaultColorIndex;

		// Token: 0x04002472 RID: 9330
		[Token(Token = "0x4002472")]
		[FieldOffset(Offset = "0x15C")]
		[SyncVar]
		public int ownedColorIndex;

		// Token: 0x04002473 RID: 9331
		[Token(Token = "0x4002473")]
		[FieldOffset(Offset = "0x160")]
		public SyncVar<int> syncVar___ownedColorIndex;

		// Token: 0x04002474 RID: 9332
		[Token(Token = "0x4002474")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted;

		// Token: 0x04002475 RID: 9333
		[Token(Token = "0x4002475")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted;

		// Token: 0x02000797 RID: 1943
		[Token(Token = "0x2000797")]
		[Serializable]
		public class NamedColor
		{
			// Token: 0x06003474 RID: 13428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003474")]
			[Address(RVA = "0x7A4DF0", Offset = "0x7A37F0", VA = "0x1807A4DF0")]
			public NamedColor()
			{
			}

			// Token: 0x04002476 RID: 9334
			[Token(Token = "0x4002476")]
			[FieldOffset(Offset = "0x10")]
			public string colorName;

			// Token: 0x04002477 RID: 9335
			[Token(Token = "0x4002477")]
			[FieldOffset(Offset = "0x18")]
			public Color color;

			// Token: 0x04002478 RID: 9336
			[Token(Token = "0x4002478")]
			[FieldOffset(Offset = "0x28")]
			public float price;
		}

		// Token: 0x02000798 RID: 1944
		[Token(Token = "0x2000798")]
		[Serializable]
		public class SecondaryPaintTarget
		{
			// Token: 0x06003475 RID: 13429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003475")]
			[Address(RVA = "0x7A7400", Offset = "0x7A5E00", VA = "0x1807A7400")]
			public SecondaryPaintTarget()
			{
			}

			// Token: 0x04002479 RID: 9337
			[Token(Token = "0x4002479")]
			[FieldOffset(Offset = "0x10")]
			public List<MeshRenderer> colorTargets;

			// Token: 0x0400247A RID: 9338
			[Token(Token = "0x400247A")]
			[FieldOffset(Offset = "0x18")]
			public float sChange;

			// Token: 0x0400247B RID: 9339
			[Token(Token = "0x400247B")]
			[FieldOffset(Offset = "0x1C")]
			public float vChange;
		}
	}
}
