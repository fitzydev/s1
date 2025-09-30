using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020008D3 RID: 2259
	[Token(Token = "0x20008D3")]
	[RequireComponent(typeof(BoxCollider))]
	public class TrashGenerator : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CE")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003E72")]
			[Address(RVA = "0x854B30", Offset = "0x853530", VA = "0x180854B30", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06003E73 RID: 15987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CF")]
		public string SaveFileName
		{
			[Token(Token = "0x6003E73")]
			[Address(RVA = "0x854AC0", Offset = "0x8534C0", VA = "0x180854AC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06003E74 RID: 15988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D0")]
		public Loader Loader
		{
			[Token(Token = "0x6003E74")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06003E75 RID: 15989 RVA: 0x00010C50 File Offset: 0x0000EE50
		[Token(Token = "0x170008D1")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003E75")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06003E76 RID: 15990 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E77 RID: 15991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D2")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003E76")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E77")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E79 RID: 15993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D3")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003E78")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E79")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x00010C68 File Offset: 0x0000EE68
		// (set) Token: 0x06003E7B RID: 15995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D4")]
		public bool HasChanged
		{
			[Token(Token = "0x6003E7A")]
			[Address(RVA = "0x4A4A60", Offset = "0x4A3460", VA = "0x1804A4A60", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E7B")]
			[Address(RVA = "0x4A4A90", Offset = "0x4A3490", VA = "0x1804A4A90", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x00010C80 File Offset: 0x0000EE80
		// (set) Token: 0x06003E7D RID: 15997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D5")]
		public Guid GUID
		{
			[Token(Token = "0x6003E7C")]
			[Address(RVA = "0x854AB0", Offset = "0x8534B0", VA = "0x180854AB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6003E7D")]
			[Address(RVA = "0x854BA0", Offset = "0x8535A0", VA = "0x180854BA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0x854530", Offset = "0x852F30", VA = "0x180854530", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x8535C0", Offset = "0x851FC0", VA = "0x1808535C0")]
		private void Awake()
		{
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E80")]
		[Address(RVA = "0x8546C0", Offset = "0x8530C0", VA = "0x1808546C0")]
		private void Start()
		{
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E81")]
		[Address(RVA = "0x854080", Offset = "0x852A80", VA = "0x180854080", Slot = "30")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E82")]
		[Address(RVA = "0x8543A0", Offset = "0x852DA0", VA = "0x1808543A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E83")]
		[Address(RVA = "0x854110", Offset = "0x852B10", VA = "0x180854110")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E84")]
		[Address(RVA = "0x854190", Offset = "0x852B90", VA = "0x180854190")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E85")]
		[Address(RVA = "0x853310", Offset = "0x851D10", VA = "0x180853310")]
		public void AddGeneratedTrash(TrashItem item)
		{
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E86")]
		[Address(RVA = "0x854400", Offset = "0x852E00", VA = "0x180854400")]
		public void RemoveGeneratedTrash(TrashItem item)
		{
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E87")]
		[Address(RVA = "0x6D1A10", Offset = "0x6D0410", VA = "0x1806D1A10")]
		[Button]
		private void RegenerateGUID()
		{
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E88")]
		[Address(RVA = "0x853470", Offset = "0x851E70", VA = "0x180853470")]
		[Button]
		private void AutoCalculateTrashCount()
		{
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E89")]
		[Address(RVA = "0x853690", Offset = "0x852090", VA = "0x180853690")]
		[Button]
		private void GenerateMaxTrash()
		{
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E8A")]
		[Address(RVA = "0x8545E0", Offset = "0x852FE0", VA = "0x1808545E0")]
		private void SleepStart()
		{
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E8B")]
		[Address(RVA = "0x8536E0", Offset = "0x8520E0", VA = "0x1808536E0")]
		private void GenerateTrash(int count)
		{
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x00010C98 File Offset: 0x0000EE98
		[Token(Token = "0x6003E8C")]
		[Address(RVA = "0x854590", Offset = "0x852F90", VA = "0x180854590")]
		public bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E8D")]
		[Address(RVA = "0x853EA0", Offset = "0x8528A0", VA = "0x180853EA0", Slot = "31")]
		public virtual TrashGeneratorData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E8E")]
		[Address(RVA = "0x854040", Offset = "0x852A40", VA = "0x180854040", Slot = "18")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E8F")]
		[Address(RVA = "0x854990", Offset = "0x853390", VA = "0x180854990")]
		public TrashGenerator()
		{
		}

		// Token: 0x04002BD6 RID: 11222
		[Token(Token = "0x4002BD6")]
		public const float TRASH_GENERATION_FRACTION = 0.2f;

		// Token: 0x04002BD7 RID: 11223
		[Token(Token = "0x4002BD7")]
		public const float DEFAULT_TRASH_PER_M2 = 0.015f;

		// Token: 0x04002BD8 RID: 11224
		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0x0")]
		public static List<TrashGenerator> AllGenerators;

		// Token: 0x04002BD9 RID: 11225
		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0x20")]
		[Range(1f, 200f)]
		[SerializeField]
		private int MaxTrashCount;

		// Token: 0x04002BDA RID: 11226
		[Token(Token = "0x4002BDA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<TrashItem> generatedTrash;

		// Token: 0x04002BDB RID: 11227
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public LayerMask GroundCheckMask;

		// Token: 0x04002BDC RID: 11228
		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0x38")]
		private BoxCollider boxCollider;

		// Token: 0x04002BE1 RID: 11233
		[Token(Token = "0x4002BE1")]
		[FieldOffset(Offset = "0x68")]
		public string StaticGUID;
	}
}
