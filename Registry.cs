using System;
using System.Collections.Generic;
using EasyButtons;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000281 RID: 641
	[Token(Token = "0x2000281")]
	public class Registry : PersistentSingleton<Registry>
	{
		// Token: 0x06000D5F RID: 3423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0xAAF2B0", Offset = "0xAADCB0", VA = "0x180AAF2B0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0xAAE4D0", Offset = "0xAACED0", VA = "0x180AAE4D0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D61")]
		[Address(RVA = "0xAAEBA0", Offset = "0xAAD5A0", VA = "0x180AAEBA0")]
		public static GameObject GetPrefab(string id)
		{
			return null;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0xAAEB10", Offset = "0xAAD510", VA = "0x180AAEB10")]
		public static ItemDefinition GetItem(string ID)
		{
			return null;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0xAAECF0", Offset = "0xAAD6F0", VA = "0x180AAECF0")]
		public static bool ItemExists(string ID)
		{
			return default(bool);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D64")]
		public static T GetItem<T>(string ID) where T : ItemDefinition
		{
			return null;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0xAAFCE0", Offset = "0xAAE6E0", VA = "0x180AAFCE0")]
		public ItemDefinition _GetItem(string ID, bool warnIfNonExistent = true)
		{
			return null;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0xAAE900", Offset = "0xAAD300", VA = "0x180AAE900")]
		public static Constructable GetConstructable(string id)
		{
			return null;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x6000D67")]
		[Address(RVA = "0xAAEAD0", Offset = "0xAAD4D0", VA = "0x180AAEAD0")]
		private static int GetHash(string ID)
		{
			return 0;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D68")]
		[Address(RVA = "0xAAF590", Offset = "0xAADF90", VA = "0x180AAF590")]
		private static string RemoveAssetsAndPrefab(string originalString)
		{
			return null;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0xAAFBE0", Offset = "0xAAE5E0", VA = "0x180AAFBE0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0xAAE2E0", Offset = "0xAACCE0", VA = "0x180AAE2E0")]
		public void AddToRegistry(ItemDefinition item)
		{
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0xAAE7E0", Offset = "0xAAD1E0", VA = "0x180AAE7E0")]
		public List<ItemDefinition> GetAllItems()
		{
			return null;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		private void AddToItemDictionary(Registry.ItemRegister reg)
		{
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0xAAF7C0", Offset = "0xAAE1C0", VA = "0x180AAF7C0")]
		private void RemoveItemFromDictionary(Registry.ItemRegister reg)
		{
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0xAAF850", Offset = "0xAAE250", VA = "0x180AAF850")]
		public void RemoveRuntimeItems()
		{
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0xAAF640", Offset = "0xAAE040", VA = "0x180AAF640")]
		public void RemoveFromRegistry(ItemDefinition item)
		{
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D70")]
		[Address(RVA = "0xAAEDB0", Offset = "0xAAD7B0", VA = "0x180AAEDB0")]
		[Button]
		public void LogOrderedUnlocks()
		{
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0xAAFFD0", Offset = "0xAAE9D0", VA = "0x180AAFFD0")]
		public Registry()
		{
		}

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Registry.ObjectRegister> ObjectRegistry;

		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Registry.ItemRegister> ItemRegistry;

		// Token: 0x04000D90 RID: 3472
		[Token(Token = "0x4000D90")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Registry.ItemRegister> ItemsAddedAtRuntime;

		// Token: 0x04000D91 RID: 3473
		[Token(Token = "0x4000D91")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, Registry.ItemRegister> ItemDictionary;

		// Token: 0x04000D92 RID: 3474
		[Token(Token = "0x4000D92")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, string> itemIDAliases;

		// Token: 0x04000D93 RID: 3475
		[Token(Token = "0x4000D93")]
		[FieldOffset(Offset = "0x50")]
		public List<SeedDefinition> Seeds;

		// Token: 0x02000282 RID: 642
		[Token(Token = "0x2000282")]
		[Serializable]
		public class ObjectRegister
		{
			// Token: 0x06000D72 RID: 3442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ObjectRegister()
			{
			}

			// Token: 0x04000D94 RID: 3476
			[Token(Token = "0x4000D94")]
			[FieldOffset(Offset = "0x10")]
			public string ID;

			// Token: 0x04000D95 RID: 3477
			[Token(Token = "0x4000D95")]
			[FieldOffset(Offset = "0x18")]
			public string AssetPath;

			// Token: 0x04000D96 RID: 3478
			[Token(Token = "0x4000D96")]
			[FieldOffset(Offset = "0x20")]
			public NetworkObject Prefab;
		}

		// Token: 0x02000283 RID: 643
		[Token(Token = "0x2000283")]
		[Serializable]
		public class ItemRegister
		{
			// Token: 0x06000D73 RID: 3443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public ItemRegister()
			{
			}

			// Token: 0x04000D97 RID: 3479
			[Token(Token = "0x4000D97")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04000D98 RID: 3480
			[Token(Token = "0x4000D98")]
			[FieldOffset(Offset = "0x18")]
			public string ID;

			// Token: 0x04000D99 RID: 3481
			[Token(Token = "0x4000D99")]
			[FieldOffset(Offset = "0x20")]
			public string AssetPath;

			// Token: 0x04000D9A RID: 3482
			[Token(Token = "0x4000D9A")]
			[FieldOffset(Offset = "0x28")]
			public ItemDefinition Definition;
		}
	}
}
