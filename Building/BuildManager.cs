using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x0200081E RID: 2078
	[Token(Token = "0x200081E")]
	public class BuildManager : Singleton<BuildManager>
	{
		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081A")]
		public Transform _tempContainer
		{
			[Token(Token = "0x6003931")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x0000F558 File Offset: 0x0000D758
		// (set) Token: 0x06003933 RID: 14643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700081B")]
		public bool isBuilding
		{
			[Token(Token = "0x6003932")]
			[Address(RVA = "0x4E6CD0", Offset = "0x4E56D0", VA = "0x1804E6CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003933")]
			[Address(RVA = "0x67F260", Offset = "0x67DC60", VA = "0x18067F260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06003934 RID: 14644 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003935 RID: 14645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700081C")]
		public GameObject currentBuildHandler
		{
			[Token(Token = "0x6003934")]
			[Address(RVA = "0x4573D0", Offset = "0x455DD0", VA = "0x1804573D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003935")]
			[Address(RVA = "0x5FD1C0", Offset = "0x5FBBC0", VA = "0x1805FD1C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003936")]
		[Address(RVA = "0x7F5200", Offset = "0x7F3C00", VA = "0x1807F5200", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003937")]
		[Address(RVA = "0x7F63A0", Offset = "0x7F4DA0", VA = "0x1807F63A0")]
		public void StartBuilding(ItemInstance item)
		{
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003938")]
		[Address(RVA = "0x7F61D0", Offset = "0x7F4BD0", VA = "0x1807F61D0")]
		public void StartBuildingStoredItem(ItemInstance item)
		{
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003939")]
		[Address(RVA = "0x7F6660", Offset = "0x7F5060", VA = "0x1807F6660")]
		public void StartPlacingCash(ItemInstance item)
		{
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393A")]
		[Address(RVA = "0x7F67E0", Offset = "0x7F51E0", VA = "0x1807F67E0")]
		public void StopBuilding()
		{
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x7F6090", Offset = "0x7F4A90", VA = "0x1807F6090")]
		public void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point)
		{
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393C")]
		[Address(RVA = "0x7F5C40", Offset = "0x7F4640", VA = "0x1807F5C40")]
		public void DisableColliders(GameObject obj)
		{
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393D")]
		[Address(RVA = "0x7F5CE0", Offset = "0x7F46E0", VA = "0x1807F5CE0")]
		public void DisableLights(GameObject obj)
		{
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393E")]
		[Address(RVA = "0x7F5F30", Offset = "0x7F4930", VA = "0x1807F5F30")]
		public void DisableNetworking(GameObject obj)
		{
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393F")]
		[Address(RVA = "0x7F5FF0", Offset = "0x7F49F0", VA = "0x1807F5FF0")]
		public void DisableSpriteRenderers(GameObject obj)
		{
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003940")]
		[Address(RVA = "0x7F5000", Offset = "0x7F3A00", VA = "0x1807F5000")]
		public void ApplyMaterial(GameObject obj, Material mat, bool allMaterials = true)
		{
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003941")]
		[Address(RVA = "0x7F5DD0", Offset = "0x7F47D0", VA = "0x1807F5DD0")]
		public void DisableNavigation(GameObject obj)
		{
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003942")]
		[Address(RVA = "0x7F5BA0", Offset = "0x7F45A0", VA = "0x1807F5BA0")]
		public void DisableCanvases(GameObject obj)
		{
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003943")]
		[Address(RVA = "0x7F5240", Offset = "0x7F3C40", VA = "0x1807F5240")]
		public GridItem CreateGridItem(ItemInstance item, Grid grid, Vector2 originCoordinate, int rotation, string guid = "")
		{
			return null;
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003944")]
		[Address(RVA = "0x7F5550", Offset = "0x7F3F50", VA = "0x1807F5550")]
		public ProceduralGridItem CreateProceduralGridItem(ItemInstance item, int rotationAngle, List<CoordinateProceduralTilePair> matches, string guid = "")
		{
			return null;
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003945")]
		[Address(RVA = "0x7F58C0", Offset = "0x7F42C0", VA = "0x1807F58C0")]
		public SurfaceItem CreateSurfaceItem(ItemInstance item, Surface parentSurface, Vector3 relativePosition, Quaternion relativeRotation, string guid = "")
		{
			return null;
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003946")]
		[Address(RVA = "0x7F57E0", Offset = "0x7F41E0", VA = "0x1807F57E0")]
		public void CreateStoredItem(StorableItemInstance item, IStorageEntity parentStorageEntity, StorageGrid grid, Vector2 originCoord, float rotation)
		{
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003947")]
		[Address(RVA = "0x7F6850", Offset = "0x7F5250", VA = "0x1807F6850")]
		public BuildManager()
		{
		}

		// Token: 0x040027AF RID: 10159
		[Token(Token = "0x40027AF")]
		[FieldOffset(Offset = "0x28")]
		public List<BuildManager.BuildSound> PlaceSounds;

		// Token: 0x040027B0 RID: 10160
		[Token(Token = "0x40027B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("References")]
		protected Transform tempContainer;

		// Token: 0x040027B1 RID: 10161
		[Token(Token = "0x40027B1")]
		[FieldOffset(Offset = "0x38")]
		public NetworkObject networkObject;

		// Token: 0x040027B2 RID: 10162
		[Token(Token = "0x40027B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Header("Prefabs")]
		protected GameObject storedItemBuildHandler;

		// Token: 0x040027B3 RID: 10163
		[Token(Token = "0x40027B3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected GameObject cashBuildHandler;

		// Token: 0x040027B4 RID: 10164
		[Token(Token = "0x40027B4")]
		[FieldOffset(Offset = "0x50")]
		[Header("Materials")]
		public Material ghostMaterial_White;

		// Token: 0x040027B5 RID: 10165
		[Token(Token = "0x40027B5")]
		[FieldOffset(Offset = "0x58")]
		public Material ghostMaterial_Red;

		// Token: 0x0200081F RID: 2079
		[Token(Token = "0x200081F")]
		[Serializable]
		public class BuildSound
		{
			// Token: 0x06003948 RID: 14664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003948")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public BuildSound()
			{
			}

			// Token: 0x040027B8 RID: 10168
			[Token(Token = "0x40027B8")]
			[FieldOffset(Offset = "0x10")]
			public BuildableItemDefinition.EBuildSoundType Type;

			// Token: 0x040027B9 RID: 10169
			[Token(Token = "0x40027B9")]
			[FieldOffset(Offset = "0x18")]
			public AudioSourceController Sound;
		}
	}
}
