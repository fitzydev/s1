using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Dragging;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020008D5 RID: 2261
	[Token(Token = "0x20008D5")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Draggable))]
	[RequireComponent(typeof(PhysicsDamageable))]
	public class TrashItem : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06003E94 RID: 16020 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		// (set) Token: 0x06003E95 RID: 16021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D6")]
		public Guid GUID
		{
			[Token(Token = "0x6003E94")]
			[Address(RVA = "0x856800", Offset = "0x855200", VA = "0x180856800", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6003E95")]
			[Address(RVA = "0x8568F0", Offset = "0x8552F0", VA = "0x1808568F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06003E96 RID: 16022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E97 RID: 16023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008D7")]
		public Property CurrentProperty
		{
			[Token(Token = "0x6003E96")]
			[Address(RVA = "0x4E9B20", Offset = "0x4E8520", VA = "0x1804E9B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E97")]
			[Address(RVA = "0x5FD1D0", Offset = "0x5FBBD0", VA = "0x1805FD1D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06003E98 RID: 16024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D8")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003E98")]
			[Address(RVA = "0x856880", Offset = "0x855280", VA = "0x180856880", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06003E99 RID: 16025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D9")]
		public string SaveFileName
		{
			[Token(Token = "0x6003E99")]
			[Address(RVA = "0x856810", Offset = "0x855210", VA = "0x180856810", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06003E9A RID: 16026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DA")]
		public Loader Loader
		{
			[Token(Token = "0x6003E9A")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		[Token(Token = "0x170008DB")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003E9B")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06003E9C RID: 16028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E9D RID: 16029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008DC")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003E9C")]
			[Address(RVA = "0x4F1FB0", Offset = "0x4F09B0", VA = "0x1804F1FB0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E9D")]
			[Address(RVA = "0x639E30", Offset = "0x638830", VA = "0x180639E30", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06003E9E RID: 16030 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003E9F RID: 16031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008DD")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003E9E")]
			[Address(RVA = "0x4ACC40", Offset = "0x4AB640", VA = "0x1804ACC40", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E9F")]
			[Address(RVA = "0x639E50", Offset = "0x638850", VA = "0x180639E50", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		// (set) Token: 0x06003EA1 RID: 16033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008DE")]
		public bool HasChanged
		{
			[Token(Token = "0x6003EA0")]
			[Address(RVA = "0x639D80", Offset = "0x638780", VA = "0x180639D80", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003EA1")]
			[Address(RVA = "0x639E20", Offset = "0x638820", VA = "0x180639E20", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA2")]
		[Address(RVA = "0x854BB0", Offset = "0x8535B0", VA = "0x180854BB0")]
		protected void Awake()
		{
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA3")]
		[Address(RVA = "0x8564C0", Offset = "0x854EC0", VA = "0x1808564C0")]
		protected void Start()
		{
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA4")]
		[Address(RVA = "0x855550", Offset = "0x853F50", VA = "0x180855550", Slot = "30")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x8559F0", Offset = "0x8543F0", VA = "0x1808559F0")]
		protected void OnValidate()
		{
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0x855690", Offset = "0x854090", VA = "0x180855690")]
		protected void MinPass()
		{
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x855440", Offset = "0x853E40", VA = "0x180855440")]
		protected void Hovered()
		{
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA8")]
		[Address(RVA = "0x8555E0", Offset = "0x853FE0", VA = "0x1808555E0")]
		protected void Interacted()
		{
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0x8562D0", Offset = "0x854CD0", VA = "0x1808562D0", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0x856470", Offset = "0x854E70", VA = "0x180856470")]
		public void SetVelocity(Vector3 velocity)
		{
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0x855110", Offset = "0x853B10", VA = "0x180855110")]
		public void DestroyTrash()
		{
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0x855010", Offset = "0x853A10", VA = "0x180855010", Slot = "31")]
		public virtual void Deinitialize()
		{
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0x8558D0", Offset = "0x8542D0", VA = "0x1808558D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0x855B80", Offset = "0x854580", VA = "0x180855B80")]
		private void RecheckPosition()
		{
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0x8552D0", Offset = "0x853CD0", VA = "0x1808552D0", Slot = "32")]
		public virtual TrashItemData GetData()
		{
			return null;
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x855400", Offset = "0x853E00", VA = "0x180855400", Slot = "33")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "34")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0x855CF0", Offset = "0x8546F0", VA = "0x180855CF0")]
		private void RecheckProperty()
		{
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB3")]
		[Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
		public void SetContinuousCollisionDetection()
		{
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB4")]
		[Address(RVA = "0x856230", Offset = "0x854C30", VA = "0x180856230")]
		public void SetDiscreteCollisionDetection()
		{
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB5")]
		[Address(RVA = "0x856410", Offset = "0x854E10", VA = "0x180856410")]
		public void SetPhysicsActive(bool active)
		{
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB6")]
		[Address(RVA = "0x8560D0", Offset = "0x854AD0", VA = "0x1808560D0")]
		public void SetCollidersEnabled(bool enabled)
		{
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB7")]
		[Address(RVA = "0x8566D0", Offset = "0x8550D0", VA = "0x1808566D0")]
		public TrashItem()
		{
		}

		// Token: 0x04002BE4 RID: 11236
		[Token(Token = "0x4002BE4")]
		public const float POSITION_CHANGE_THRESHOLD = 1f;

		// Token: 0x04002BE5 RID: 11237
		[Token(Token = "0x4002BE5")]
		public const float LINEAR_DRAG = 0.1f;

		// Token: 0x04002BE6 RID: 11238
		[Token(Token = "0x4002BE6")]
		public const float ANGULAR_DRAG = 0.1f;

		// Token: 0x04002BE7 RID: 11239
		[Token(Token = "0x4002BE7")]
		public const float MIN_Y = -100f;

		// Token: 0x04002BE8 RID: 11240
		[Token(Token = "0x4002BE8")]
		public const int INTERACTION_PRIORITY = 5;

		// Token: 0x04002BE9 RID: 11241
		[Token(Token = "0x4002BE9")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody Rigidbody;

		// Token: 0x04002BEA RID: 11242
		[Token(Token = "0x4002BEA")]
		[FieldOffset(Offset = "0x28")]
		public Draggable Draggable;

		// Token: 0x04002BEB RID: 11243
		[Token(Token = "0x4002BEB")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public string ID;

		// Token: 0x04002BEC RID: 11244
		[Token(Token = "0x4002BEC")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 5f)]
		public int Size;

		// Token: 0x04002BED RID: 11245
		[Token(Token = "0x4002BED")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 10f)]
		public int SellValue;

		// Token: 0x04002BEE RID: 11246
		[Token(Token = "0x4002BEE")]
		[FieldOffset(Offset = "0x40")]
		public bool CanGoInContainer;

		// Token: 0x04002BEF RID: 11247
		[Token(Token = "0x4002BEF")]
		[FieldOffset(Offset = "0x48")]
		public Collider[] colliders;

		// Token: 0x04002BF2 RID: 11250
		[Token(Token = "0x4002BF2")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 lastPosition;

		// Token: 0x04002BF3 RID: 11251
		[Token(Token = "0x4002BF3")]
		[FieldOffset(Offset = "0x78")]
		public Action<TrashItem> onDestroyed;

		// Token: 0x04002BF4 RID: 11252
		[Token(Token = "0x4002BF4")]
		[FieldOffset(Offset = "0x80")]
		private bool collidersEnabled;

		// Token: 0x04002BF5 RID: 11253
		[Token(Token = "0x4002BF5")]
		[FieldOffset(Offset = "0x84")]
		private float timeOnPhysicsEnabled;
	}
}
