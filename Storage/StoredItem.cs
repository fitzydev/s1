using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x0200095C RID: 2396
	[Token(Token = "0x200095C")]
	public class StoredItem : MonoBehaviour
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060041BE RID: 16830 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060041BF RID: 16831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000929")]
		public StorableItemInstance item
		{
			[Token(Token = "0x60041BE")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041BF")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060041C0 RID: 16832 RVA: 0x00011430 File Offset: 0x0000F630
		// (set) Token: 0x060041C1 RID: 16833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700092A")]
		public bool Destroyed
		{
			[Token(Token = "0x60041C0")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041C1")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060041C2 RID: 16834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700092B")]
		public FootprintTile OriginFootprint
		{
			[Token(Token = "0x60041C2")]
			[Address(RVA = "0x891BB0", Offset = "0x8905B0", VA = "0x180891BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x00011448 File Offset: 0x0000F648
		[Token(Token = "0x1700092C")]
		public int FootprintX
		{
			[Token(Token = "0x60041C3")]
			[Address(RVA = "0x8918D0", Offset = "0x8902D0", VA = "0x1808918D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x00011460 File Offset: 0x0000F660
		[Token(Token = "0x1700092D")]
		public int FootprintY
		{
			[Token(Token = "0x60041C4")]
			[Address(RVA = "0x891A40", Offset = "0x890440", VA = "0x180891A40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060041C6 RID: 16838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700092E")]
		public IStorageEntity parentStorageEntity
		{
			[Token(Token = "0x60041C5")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041C6")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060041C8 RID: 16840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700092F")]
		public StorageGrid parentGrid
		{
			[Token(Token = "0x60041C7")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041C8")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060041C9 RID: 16841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000930")]
		public List<CoordinatePair> CoordinatePairs
		{
			[Token(Token = "0x60041C9")]
			[Address(RVA = "0x4E9B20", Offset = "0x4E8520", VA = "0x1804E9B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060041CA RID: 16842 RVA: 0x00011478 File Offset: 0x0000F678
		[Token(Token = "0x17000931")]
		public float Rotation
		{
			[Token(Token = "0x60041CA")]
			[Address(RVA = "0x4F2910", Offset = "0x4F1310", VA = "0x1804F2910")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060041CB RID: 16843 RVA: 0x00011490 File Offset: 0x0000F690
		[Token(Token = "0x17000932")]
		public int totalArea
		{
			[Token(Token = "0x60041CB")]
			[Address(RVA = "0x891C10", Offset = "0x890610", VA = "0x180891C10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060041CC RID: 16844 RVA: 0x000114A8 File Offset: 0x0000F6A8
		// (set) Token: 0x060041CD RID: 16845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000933")]
		public bool canBePickedUp
		{
			[Token(Token = "0x60041CC")]
			[Address(RVA = "0x65E650", Offset = "0x65D050", VA = "0x18065E650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041CD")]
			[Address(RVA = "0x65E720", Offset = "0x65D120", VA = "0x18065E720")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060041CE RID: 16846 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060041CF RID: 16847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000934")]
		public string noPickupReason
		{
			[Token(Token = "0x60041CE")]
			[Address(RVA = "0x4F2140", Offset = "0x4F0B40", VA = "0x1804F2140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041CF")]
			[Address(RVA = "0x639E10", Offset = "0x638810", VA = "0x180639E10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D0")]
		[Address(RVA = "0x88F9A0", Offset = "0x88E3A0", VA = "0x18088F9A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D1")]
		[Address(RVA = "0x890DD0", Offset = "0x88F7D0", VA = "0x180890DD0", Slot = "5")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D2")]
		[Address(RVA = "0x890830", Offset = "0x88F230", VA = "0x180890830", Slot = "6")]
		public virtual void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D3")]
		[Address(RVA = "0x890F00", Offset = "0x88F900", VA = "0x180890F00")]
		private void RefreshTransform()
		{
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D4")]
		[Address(RVA = "0x8906B0", Offset = "0x88F0B0", VA = "0x1808906B0", Slot = "7")]
		protected virtual void InitializeIntObj()
		{
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D5")]
		[Address(RVA = "0x88FDD0", Offset = "0x88E7D0", VA = "0x18088FDD0", Slot = "8")]
		public virtual void Destroy_Internal()
		{
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D6")]
		[Address(RVA = "0x88FD00", Offset = "0x88E700", VA = "0x18088FD00")]
		public void DestroyStoredItem()
		{
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D7")]
		[Address(RVA = "0x88FB20", Offset = "0x88E520", VA = "0x18088FB20")]
		public void ClearFootprintOccupancy()
		{
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D8")]
		[Address(RVA = "0x8915E0", Offset = "0x88FFE0", VA = "0x1808915E0")]
		public void SetCanBePickedUp(bool _canBePickedUp, string _noPickupReason = "")
		{
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D9")]
		[Address(RVA = "0x8916C0", Offset = "0x8900C0", VA = "0x1808916C0")]
		public static void SetLayerRecursively(GameObject go, int layerNumber)
		{
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DA")]
		[Address(RVA = "0x8914F0", Offset = "0x88FEF0", VA = "0x1808914F0")]
		public static List<StoredItem> RemoveReservedItems(List<StoredItem> itemList, Employee allowedReservant)
		{
			return null;
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DB")]
		[Address(RVA = "0x88FC80", Offset = "0x88E680", VA = "0x18088FC80", Slot = "9")]
		public virtual GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			return null;
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x891600", Offset = "0x890000", VA = "0x180891600")]
		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x88FA70", Offset = "0x88E470", VA = "0x18088FA70")]
		public void CalculateFootprintTileIntersections()
		{
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DE")]
		[Address(RVA = "0x8902E0", Offset = "0x88ECE0", VA = "0x1808902E0")]
		public FootprintTile GetTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041DF")]
		[Address(RVA = "0x8903E0", Offset = "0x88EDE0", VA = "0x1808903E0", Slot = "10")]
		public virtual void Hovered()
		{
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041E0")]
		[Address(RVA = "0x890D30", Offset = "0x88F730", VA = "0x180890D30", Slot = "11")]
		public virtual void Interacted()
		{
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041E1")]
		[Address(RVA = "0x8917D0", Offset = "0x8901D0", VA = "0x1808917D0")]
		public StoredItem()
		{
		}

		// Token: 0x04002E0F RID: 11791
		[Token(Token = "0x4002E0F")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform buildPoint;

		// Token: 0x04002E10 RID: 11792
		[Token(Token = "0x4002E10")]
		[FieldOffset(Offset = "0x38")]
		public List<CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs;

		// Token: 0x04002E11 RID: 11793
		[Token(Token = "0x4002E11")]
		[FieldOffset(Offset = "0x40")]
		private int footprintX;

		// Token: 0x04002E12 RID: 11794
		[Token(Token = "0x4002E12")]
		[FieldOffset(Offset = "0x44")]
		private int footprintY;

		// Token: 0x04002E15 RID: 11797
		[Token(Token = "0x4002E15")]
		[FieldOffset(Offset = "0x58")]
		protected InteractableObject intObj;

		// Token: 0x04002E16 RID: 11798
		[Token(Token = "0x4002E16")]
		[FieldOffset(Offset = "0x60")]
		protected List<CoordinatePair> coordinatePairs;

		// Token: 0x04002E17 RID: 11799
		[Token(Token = "0x4002E17")]
		[FieldOffset(Offset = "0x68")]
		protected float rotation;

		// Token: 0x04002E18 RID: 11800
		[Token(Token = "0x4002E18")]
		[FieldOffset(Offset = "0x6C")]
		public int xSize;

		// Token: 0x04002E19 RID: 11801
		[Token(Token = "0x4002E19")]
		[FieldOffset(Offset = "0x70")]
		public int ySize;
	}
}
