using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using EPOOutline;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Map;
using ScheduleOne.Property;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Delivery
{
	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x200078E")]
	public class LoadingDock : MonoBehaviour, IGUIDRegisterable, ITransitEntity
	{
		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600341C RID: 13340 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600341D RID: 13341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000795")]
		public LandVehicle DynamicOccupant
		{
			[Token(Token = "0x600341C")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600341D")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600341E RID: 13342 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600341F RID: 13343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000796")]
		public LandVehicle StaticOccupant
		{
			[Token(Token = "0x600341E")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600341F")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06003420 RID: 13344 RVA: 0x0000E508 File Offset: 0x0000C708
		[Token(Token = "0x17000797")]
		public bool IsInUse
		{
			[Token(Token = "0x6003420")]
			[Address(RVA = "0x7A4750", Offset = "0x7A3150", VA = "0x1807A4750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06003421 RID: 13345 RVA: 0x0000E520 File Offset: 0x0000C720
		// (set) Token: 0x06003422 RID: 13346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000798")]
		public Guid GUID
		{
			[Token(Token = "0x6003421")]
			[Address(RVA = "0x6FD0D0", Offset = "0x6FBAD0", VA = "0x1806FD0D0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6003422")]
			[Address(RVA = "0x6FD170", Offset = "0x6FBB70", VA = "0x1806FD170")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003423")]
		[Address(RVA = "0x6FCBF0", Offset = "0x6FB5F0", VA = "0x1806FCBF0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06003424 RID: 13348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000799")]
		public string Name
		{
			[Token(Token = "0x6003424")]
			[Address(RVA = "0x7A47E0", Offset = "0x7A31E0", VA = "0x1807A47E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06003425 RID: 13349 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003426 RID: 13350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700079A")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6003425")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003426")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06003427 RID: 13351 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003428 RID: 13352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700079B")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6003427")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003428")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079C")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6003429")]
			[Address(RVA = "0x4F2140", Offset = "0x4F0B40", VA = "0x1804F2140", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x0600342A RID: 13354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079D")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x600342A")]
			[Address(RVA = "0x506BA0", Offset = "0x5055A0", VA = "0x180506BA0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x1700079E")]
		public bool Selectable
		{
			[Token(Token = "0x600342B")]
			[Address(RVA = "0x4FA970", Offset = "0x4F9370", VA = "0x1804FA970", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x0000E550 File Offset: 0x0000C750
		// (set) Token: 0x0600342D RID: 13357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700079F")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x600342C")]
			[Address(RVA = "0x7A4730", Offset = "0x7A3130", VA = "0x1807A4730", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600342D")]
			[Address(RVA = "0x7A4860", Offset = "0x7A3260", VA = "0x1807A4860")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x0000E568 File Offset: 0x0000C768
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A0")]
		public bool IsDestroyed
		{
			[Token(Token = "0x600342E")]
			[Address(RVA = "0x7A4740", Offset = "0x7A3140", VA = "0x1807A4740", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600342F")]
			[Address(RVA = "0x7A4870", Offset = "0x7A3270", VA = "0x1807A4870")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003430")]
		[Address(RVA = "0x7A3960", Offset = "0x7A2360", VA = "0x1807A3960")]
		private void Awake()
		{
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003431")]
		[Address(RVA = "0x7A45E0", Offset = "0x7A2FE0", VA = "0x1807A45E0")]
		private void Start()
		{
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003432")]
		[Address(RVA = "0x7A3EB0", Offset = "0x7A28B0", VA = "0x1807A3EB0", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003433")]
		[Address(RVA = "0x7A3A50", Offset = "0x7A2450", VA = "0x1807A3A50")]
		private void RefreshOccupant()
		{
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003434")]
		[Address(RVA = "0x7A3F10", Offset = "0x7A2910", VA = "0x1807A3F10")]
		private void SetOccupant(LandVehicle occupant)
		{
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003435")]
		[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
		public void SetStaticOccupant(LandVehicle vehicle)
		{
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003436")]
		[Address(RVA = "0x7A41D0", Offset = "0x7A2BD0", VA = "0x1807A41D0", Slot = "29")]
		public virtual void ShowOutline(Color color)
		{
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003437")]
		[Address(RVA = "0x7A39D0", Offset = "0x7A23D0", VA = "0x1807A39D0", Slot = "30")]
		public virtual void HideOutline()
		{
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003438")]
		[Address(RVA = "0x7A4650", Offset = "0x7A3050", VA = "0x1807A4650")]
		public LoadingDock()
		{
		}

		// Token: 0x04002444 RID: 9284
		[Token(Token = "0x4002444")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x0400244A RID: 9290
		[Token(Token = "0x400244A")]
		[FieldOffset(Offset = "0x60")]
		public Property ParentProperty;

		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		[FieldOffset(Offset = "0x68")]
		public VehicleDetector VehicleDetector;

		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		[FieldOffset(Offset = "0x70")]
		public ParkingLot Parking;

		// Token: 0x0400244D RID: 9293
		[Token(Token = "0x400244D")]
		[FieldOffset(Offset = "0x78")]
		public Transform uiPoint;

		// Token: 0x0400244E RID: 9294
		[Token(Token = "0x400244E")]
		[FieldOffset(Offset = "0x80")]
		public Transform[] accessPoints;

		// Token: 0x0400244F RID: 9295
		[Token(Token = "0x400244F")]
		[FieldOffset(Offset = "0x88")]
		public GameObject[] OutlineRenderers;

		// Token: 0x04002450 RID: 9296
		[Token(Token = "0x4002450")]
		[FieldOffset(Offset = "0x90")]
		private Outlinable OutlineEffect;
	}
}
