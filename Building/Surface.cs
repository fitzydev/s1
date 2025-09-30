using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000833 RID: 2099
	[Token(Token = "0x2000833")]
	public class Surface : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x0000F648 File Offset: 0x0000D848
		// (set) Token: 0x0600399D RID: 14749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700081F")]
		public Guid GUID
		{
			[Token(Token = "0x600399C")]
			[Address(RVA = "0x4A3B70", Offset = "0x4A2570", VA = "0x1804A3B70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x600399D")]
			[Address(RVA = "0x4A3B80", Offset = "0x4A2580", VA = "0x1804A3B80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000820")]
		public Transform Container
		{
			[Token(Token = "0x600399E")]
			[Address(RVA = "0x80BFC0", Offset = "0x80A9C0", VA = "0x18080BFC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x80BE00", Offset = "0x80A800", VA = "0x18080BE00")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x80BD30", Offset = "0x80A730", VA = "0x18080BD30")]
		private void OnValidate()
		{
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A1")]
		[Address(RVA = "0x80B870", Offset = "0x80A270", VA = "0x18080B870")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A2")]
		[Address(RVA = "0x80AFF0", Offset = "0x8099F0", VA = "0x18080AFF0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A3")]
		[Address(RVA = "0x80BE50", Offset = "0x80A850", VA = "0x18080BE50", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x0000F660 File Offset: 0x0000D860
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0x80B1B0", Offset = "0x809BB0", VA = "0x18080B1B0")]
		public Vector3 GetRelativePosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x0000F678 File Offset: 0x0000D878
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0x80B220", Offset = "0x809C20", VA = "0x18080B220")]
		public Quaternion GetRelativeRotation(Quaternion worldRotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x0000F690 File Offset: 0x0000D890
		[Token(Token = "0x60039A6")]
		[Address(RVA = "0x80B400", Offset = "0x809E00", VA = "0x18080B400")]
		public bool IsFrontFace(Vector3 point, Collider collider)
		{
			return default(bool);
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		[Token(Token = "0x60039A7")]
		[Address(RVA = "0x80B460", Offset = "0x809E60", VA = "0x18080B460")]
		public bool IsPointValid(Vector3 point, Collider hitCollider)
		{
			return default(bool);
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A8")]
		[Address(RVA = "0x80BEB0", Offset = "0x80A8B0", VA = "0x18080BEB0")]
		public Surface()
		{
		}

		// Token: 0x040027F3 RID: 10227
		[Token(Token = "0x40027F3")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public Surface.ESurfaceType SurfaceType;

		// Token: 0x040027F4 RID: 10228
		[Token(Token = "0x40027F4")]
		[FieldOffset(Offset = "0x38")]
		public List<Surface.EFace> ValidFaces;

		// Token: 0x040027F5 RID: 10229
		[Token(Token = "0x40027F5")]
		[FieldOffset(Offset = "0x40")]
		public Property ParentProperty;

		// Token: 0x040027F6 RID: 10230
		[Token(Token = "0x40027F6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x02000834 RID: 2100
		[Token(Token = "0x2000834")]
		public enum ESurfaceType
		{
			// Token: 0x040027F8 RID: 10232
			[Token(Token = "0x40027F8")]
			Wall,
			// Token: 0x040027F9 RID: 10233
			[Token(Token = "0x40027F9")]
			Roof
		}

		// Token: 0x02000835 RID: 2101
		[Token(Token = "0x2000835")]
		public enum EFace
		{
			// Token: 0x040027FB RID: 10235
			[Token(Token = "0x40027FB")]
			Front,
			// Token: 0x040027FC RID: 10236
			[Token(Token = "0x40027FC")]
			Back,
			// Token: 0x040027FD RID: 10237
			[Token(Token = "0x40027FD")]
			Top,
			// Token: 0x040027FE RID: 10238
			[Token(Token = "0x40027FE")]
			Bottom,
			// Token: 0x040027FF RID: 10239
			[Token(Token = "0x40027FF")]
			Left,
			// Token: 0x04002800 RID: 10240
			[Token(Token = "0x4002800")]
			Right
		}
	}
}
