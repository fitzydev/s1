using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Property
{
	// Token: 0x020008BE RID: 2238
	[Token(Token = "0x20008BE")]
	public class RV : Property
	{
		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06003D9B RID: 15771 RVA: 0x00010950 File Offset: 0x0000EB50
		// (set) Token: 0x06003D9C RID: 15772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008BC")]
		public bool _isExploded
		{
			[Token(Token = "0x6003D9B")]
			[Address(RVA = "0x84B300", Offset = "0x849D00", VA = "0x18084B300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003D9C")]
			[Address(RVA = "0x84B310", Offset = "0x849D10", VA = "0x18084B310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9D")]
		[Address(RVA = "0x84AA90", Offset = "0x849490", VA = "0x18084AA90", Slot = "44")]
		protected override void Start()
		{
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9E")]
		[Address(RVA = "0x84A3D0", Offset = "0x848DD0", VA = "0x18084A3D0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9F")]
		[Address(RVA = "0x84AC20", Offset = "0x849620", VA = "0x18084AC20")]
		private void UpdateVariables()
		{
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA0")]
		[Address(RVA = "0x84A540", Offset = "0x848F40", VA = "0x18084A540")]
		public void Ransack()
		{
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00010968 File Offset: 0x0000EB68
		[Token(Token = "0x6003DA1")]
		[Address(RVA = "0x84AA30", Offset = "0x849430", VA = "0x18084AA30", Slot = "49")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA2")]
		[Address(RVA = "0x84A900", Offset = "0x849300", VA = "0x18084A900")]
		[TargetRpc]
		public void SetExploded(NetworkConnection conn)
		{
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA3")]
		[Address(RVA = "0x84A890", Offset = "0x849290", VA = "0x18084A890")]
		public void SetExploded()
		{
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA4")]
		[Address(RVA = "0x84A340", Offset = "0x848D40", VA = "0x18084A340")]
		private void OnSleep()
		{
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA5")]
		[Address(RVA = "0x84B2B0", Offset = "0x849CB0", VA = "0x18084B2B0")]
		public RV()
		{
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA6")]
		[Address(RVA = "0x84A2A0", Offset = "0x848CA0", VA = "0x18084A2A0", Slot = "56")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA7")]
		[Address(RVA = "0x84A270", Offset = "0x848C70", VA = "0x18084A270", Slot = "57")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA8")]
		[Address(RVA = "0x825A80", Offset = "0x824480", VA = "0x180825A80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA9")]
		[Address(RVA = "0x84A900", Offset = "0x849300", VA = "0x18084A900")]
		private void RpcWriter___Target_SetExploded_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAA")]
		[Address(RVA = "0x84A890", Offset = "0x849290", VA = "0x18084A890")]
		public void RpcLogic___SetExploded_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAB")]
		[Address(RVA = "0x84A8B0", Offset = "0x8492B0", VA = "0x18084A8B0")]
		private void RpcReader___Target_SetExploded_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAC")]
		[Address(RVA = "0x841310", Offset = "0x83FD10", VA = "0x180841310", Slot = "42")]
		public override void Awake()
		{
		}

		// Token: 0x04002B6F RID: 11119
		[Token(Token = "0x4002B6F")]
		[FieldOffset(Offset = "0x240")]
		public Transform ModelContainer;

		// Token: 0x04002B70 RID: 11120
		[Token(Token = "0x4002B70")]
		[FieldOffset(Offset = "0x248")]
		public Transform FXContainer;

		// Token: 0x04002B71 RID: 11121
		[Token(Token = "0x4002B71")]
		[FieldOffset(Offset = "0x250")]
		public UnityEvent onSetExploded;

		// Token: 0x04002B73 RID: 11123
		[Token(Token = "0x4002B73")]
		[FieldOffset(Offset = "0x259")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.RVAssembly-CSharp.dll_Excuted;

		// Token: 0x04002B74 RID: 11124
		[Token(Token = "0x4002B74")]
		[FieldOffset(Offset = "0x25A")]
		private bool NetworkInitialize__LateScheduleOne.Property.RVAssembly-CSharp.dll_Excuted;
	}
}
