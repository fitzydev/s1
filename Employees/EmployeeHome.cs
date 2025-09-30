using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Employees
{
	// Token: 0x020005C0 RID: 1472
	[Token(Token = "0x20005C0")]
	public class EmployeeHome : MonoBehaviour
	{
		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EF")]
		public Employee AssignedEmployee
		{
			[Token(Token = "0x60022ED")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60022EE")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x6CB200", Offset = "0x6C9C00", VA = "0x1806CB200")]
		private void Awake()
		{
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x6CBA60", Offset = "0x6CA460", VA = "0x1806CBA60")]
		private void Start()
		{
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x6CB7E0", Offset = "0x6CA1E0", VA = "0x1806CB7E0")]
		public void SetAssignedEmployee(Employee employee)
		{
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x6CBBA0", Offset = "0x6CA5A0", VA = "0x1806CBBA0")]
		private void UpdateStorageText()
		{
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F3")]
		[Address(RVA = "0x6CBA70", Offset = "0x6CA470", VA = "0x1806CBA70")]
		private void UpdateMaterial()
		{
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x0000B0A0 File Offset: 0x000092A0
		[Token(Token = "0x60022F4")]
		[Address(RVA = "0x6CB290", Offset = "0x6C9C90", VA = "0x1806CB290")]
		public float GetCashSum()
		{
			return 0f;
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x6CB5C0", Offset = "0x6C9FC0", VA = "0x1806CB5C0")]
		public void RemoveCash(float amount)
		{
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[Token(Token = "0x60022F6")]
		[Address(RVA = "0x6CB460", Offset = "0x6C9E60", VA = "0x1806CB460")]
		public static bool IsBuildableEntityAValidEmployeeHome(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F7")]
		[Address(RVA = "0x6CBEC0", Offset = "0x6CA8C0", VA = "0x1806CBEC0")]
		public EmployeeHome()
		{
		}

		// Token: 0x04001B9E RID: 7070
		[Token(Token = "0x4001B9E")]
		[FieldOffset(Offset = "0x28")]
		public string HomeType;

		// Token: 0x04001B9F RID: 7071
		[Token(Token = "0x4001B9F")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public GameObject Clipboard;

		// Token: 0x04001BA0 RID: 7072
		[Token(Token = "0x4001BA0")]
		[FieldOffset(Offset = "0x38")]
		public SpriteRenderer MugshotSprite;

		// Token: 0x04001BA1 RID: 7073
		[Token(Token = "0x4001BA1")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshPro NameLabel;

		// Token: 0x04001BA2 RID: 7074
		[Token(Token = "0x4001BA2")]
		[FieldOffset(Offset = "0x48")]
		public StorageEntity Storage;

		// Token: 0x04001BA3 RID: 7075
		[Token(Token = "0x4001BA3")]
		[FieldOffset(Offset = "0x50")]
		public MeshRenderer[] EmployeeSpecificMeshes;

		// Token: 0x04001BA4 RID: 7076
		[Token(Token = "0x4001BA4")]
		[FieldOffset(Offset = "0x58")]
		public Material SpecificMat_Default;

		// Token: 0x04001BA5 RID: 7077
		[Token(Token = "0x4001BA5")]
		[FieldOffset(Offset = "0x60")]
		public Material SpecificMat_Botanist;

		// Token: 0x04001BA6 RID: 7078
		[Token(Token = "0x4001BA6")]
		[FieldOffset(Offset = "0x68")]
		public Material SpecificMat_Chemist;

		// Token: 0x04001BA7 RID: 7079
		[Token(Token = "0x4001BA7")]
		[FieldOffset(Offset = "0x70")]
		public Material SpecificMat_Packager;

		// Token: 0x04001BA8 RID: 7080
		[Token(Token = "0x4001BA8")]
		[FieldOffset(Offset = "0x78")]
		public Material SpecificMat_Cleaner;

		// Token: 0x04001BA9 RID: 7081
		[Token(Token = "0x4001BA9")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onAssignedEmployeeChanged;
	}
}
