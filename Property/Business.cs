using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x020008AB RID: 2219
	[Token(Token = "0x20008AB")]
	public class Business : Property, ISaveable
	{
		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x00010638 File Offset: 0x0000E838
		[Token(Token = "0x17000895")]
		public float currentLaunderTotal
		{
			[Token(Token = "0x6003CBB")]
			[Address(RVA = "0x828460", Offset = "0x826E60", VA = "0x180828460")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06003CBC RID: 15548 RVA: 0x00010650 File Offset: 0x0000E850
		[Token(Token = "0x17000896")]
		public float appliedLaunderLimit
		{
			[Token(Token = "0x6003CBC")]
			[Address(RVA = "0x828430", Offset = "0x826E30", VA = "0x180828430")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000897")]
		public new Loader Loader
		{
			[Token(Token = "0x6003CBD")]
			[Address(RVA = "0x62FBD0", Offset = "0x62E5D0", VA = "0x18062FBD0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBE")]
		[Address(RVA = "0x826540", Offset = "0x824F40", VA = "0x180826540", Slot = "42")]
		public override void Awake()
		{
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBF")]
		[Address(RVA = "0x827FE0", Offset = "0x8269E0", VA = "0x180827FE0", Slot = "44")]
		protected override void Start()
		{
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC0")]
		[Address(RVA = "0x8271B0", Offset = "0x825BB0", VA = "0x1808271B0", Slot = "46")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC1")]
		[Address(RVA = "0x8269B0", Offset = "0x8253B0", VA = "0x1808269B0", Slot = "47")]
		protected override void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x827280", Offset = "0x825C80", VA = "0x180827280", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x826F10", Offset = "0x825910", VA = "0x180826F10", Slot = "59")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0x826F30", Offset = "0x825930", VA = "0x180826F30", Slot = "60")]
		protected virtual void MinsPass(int mins)
		{
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x828200", Offset = "0x826C00", VA = "0x180828200")]
		private void TimeSkipped(int minsPassed)
		{
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC6")]
		[Address(RVA = "0x826A00", Offset = "0x825400", VA = "0x180826A00", Slot = "52")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC7")]
		[Address(RVA = "0x826E10", Offset = "0x825810", VA = "0x180826E10", Slot = "55")]
		public override void Load(PropertyData propertyData, string dataString)
		{
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC8")]
		[Address(RVA = "0x8275E0", Offset = "0x825FE0", VA = "0x1808275E0", Slot = "48")]
		protected override void RecieveOwned()
		{
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC9")]
		[Address(RVA = "0x827D00", Offset = "0x826700", VA = "0x180827D00")]
		[ServerRpc(RequireOwnership = false)]
		public void StartLaunderingOperation(float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCA")]
		[Address(RVA = "0x827390", Offset = "0x825D90", VA = "0x180827390")]
		[ObserversRpc]
		[TargetRpc]
		private void ReceiveLaunderingOperation(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCB")]
		[Address(RVA = "0x826590", Offset = "0x824F90", VA = "0x180826590")]
		protected void CompleteOperation(LaunderingOperation op)
		{
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCC")]
		[Address(RVA = "0x828340", Offset = "0x826D40", VA = "0x180828340")]
		public Business()
		{
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCE")]
		[Address(RVA = "0x827080", Offset = "0x825A80", VA = "0x180827080", Slot = "56")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCF")]
		[Address(RVA = "0x827060", Offset = "0x825A60", VA = "0x180827060", Slot = "57")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0x825A80", Offset = "0x824480", VA = "0x180825A80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0x827D00", Offset = "0x826700", VA = "0x180827D00")]
		private void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD2")]
		[Address(RVA = "0x8279B0", Offset = "0x8263B0", VA = "0x1808279B0")]
		public void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD3")]
		[Address(RVA = "0x827A60", Offset = "0x826460", VA = "0x180827A60")]
		private void RpcReader___Server_StartLaunderingOperation_1481775633(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD4")]
		[Address(RVA = "0x827E70", Offset = "0x826870", VA = "0x180827E70")]
		private void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0x8276F0", Offset = "0x8260F0", VA = "0x1808276F0")]
		private void RpcLogic___ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD6")]
		[Address(RVA = "0x827AF0", Offset = "0x8264F0", VA = "0x180827AF0")]
		private void RpcReader___Target_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD7")]
		[Address(RVA = "0x827B80", Offset = "0x826580", VA = "0x180827B80")]
		private void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD8")]
		[Address(RVA = "0x8279D0", Offset = "0x8263D0", VA = "0x1808279D0")]
		private void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD9")]
		[Address(RVA = "0x8263B0", Offset = "0x824DB0", VA = "0x1808263B0", Slot = "61")]
		protected virtual void Awake_UserLogic_ScheduleOne.Property.Business_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x0")]
		public static List<Business> Businesses;

		// Token: 0x04002B03 RID: 11011
		[Token(Token = "0x4002B03")]
		[FieldOffset(Offset = "0x8")]
		public static List<Business> UnownedBusinesses;

		// Token: 0x04002B04 RID: 11012
		[Token(Token = "0x4002B04")]
		[FieldOffset(Offset = "0x10")]
		public static List<Business> OwnedBusinesses;

		// Token: 0x04002B05 RID: 11013
		[Token(Token = "0x4002B05")]
		[FieldOffset(Offset = "0x240")]
		[Header("Settings")]
		public float LaunderCapacity;

		// Token: 0x04002B06 RID: 11014
		[Token(Token = "0x4002B06")]
		[FieldOffset(Offset = "0x248")]
		public List<LaunderingOperation> LaunderingOperations;

		// Token: 0x04002B07 RID: 11015
		[Token(Token = "0x4002B07")]
		[FieldOffset(Offset = "0x18")]
		public static Action<LaunderingOperation> onOperationStarted;

		// Token: 0x04002B08 RID: 11016
		[Token(Token = "0x4002B08")]
		[FieldOffset(Offset = "0x20")]
		public static Action<LaunderingOperation> onOperationFinished;

		// Token: 0x04002B09 RID: 11017
		[Token(Token = "0x4002B09")]
		[FieldOffset(Offset = "0x250")]
		private BusinessLoader loader;

		// Token: 0x04002B0A RID: 11018
		[Token(Token = "0x4002B0A")]
		[FieldOffset(Offset = "0x258")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted;

		// Token: 0x04002B0B RID: 11019
		[Token(Token = "0x4002B0B")]
		[FieldOffset(Offset = "0x259")]
		private bool NetworkInitialize__LateScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted;
	}
}
