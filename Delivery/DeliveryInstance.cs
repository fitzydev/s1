using System;
using System.Runtime.CompilerServices;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using UnityEngine.Events;

namespace ScheduleOne.Delivery
{
	// Token: 0x02000787 RID: 1927
	[Token(Token = "0x2000787")]
	[Serializable]
	public class DeliveryInstance
	{
		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060033DA RID: 13274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000788")]
		[CodegenExclude]
		public DeliveryVehicle ActiveVehicle
		{
			[Token(Token = "0x60033D9")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033DA")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000789")]
		[CodegenExclude]
		public Property Destination
		{
			[Token(Token = "0x60033DB")]
			[Address(RVA = "0x79F9C0", Offset = "0x79E3C0", VA = "0x18079F9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060033DC RID: 13276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078A")]
		[CodegenExclude]
		public LoadingDock LoadingDock
		{
			[Token(Token = "0x60033DC")]
			[Address(RVA = "0x79FA50", Offset = "0x79E450", VA = "0x18079FA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033DD")]
		[Address(RVA = "0x79F920", Offset = "0x79E320", VA = "0x18079F920")]
		public DeliveryInstance(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, StringIntPair[] items, EDeliveryStatus status, int timeUntilArrival)
		{
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033DE")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public DeliveryInstance()
		{
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0000E430 File Offset: 0x0000C630
		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x79F630", Offset = "0x79E030", VA = "0x18079F630")]
		public int GetTimeStatus()
		{
			return 0;
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x79F660", Offset = "0x79E060", VA = "0x18079F660")]
		public void SetStatus(EDeliveryStatus status)
		{
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E1")]
		[Address(RVA = "0x79F460", Offset = "0x79DE60", VA = "0x18079F460")]
		public void AddItemsToDeliveryVehicle()
		{
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E2")]
		[Address(RVA = "0x79F650", Offset = "0x79E050", VA = "0x18079F650")]
		public void OnMinPass()
		{
		}

		// Token: 0x04002425 RID: 9253
		[Token(Token = "0x4002425")]
		[FieldOffset(Offset = "0x10")]
		public string DeliveryID;

		// Token: 0x04002426 RID: 9254
		[Token(Token = "0x4002426")]
		[FieldOffset(Offset = "0x18")]
		public string StoreName;

		// Token: 0x04002427 RID: 9255
		[Token(Token = "0x4002427")]
		[FieldOffset(Offset = "0x20")]
		public string DestinationCode;

		// Token: 0x04002428 RID: 9256
		[Token(Token = "0x4002428")]
		[FieldOffset(Offset = "0x28")]
		public int LoadingDockIndex;

		// Token: 0x04002429 RID: 9257
		[Token(Token = "0x4002429")]
		[FieldOffset(Offset = "0x30")]
		public StringIntPair[] Items;

		// Token: 0x0400242A RID: 9258
		[Token(Token = "0x400242A")]
		[FieldOffset(Offset = "0x38")]
		public EDeliveryStatus Status;

		// Token: 0x0400242B RID: 9259
		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x3C")]
		public int TimeUntilArrival;

		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x48")]
		[CodegenExclude]
		[NonSerialized]
		public UnityEvent onDeliveryCompleted;
	}
}
