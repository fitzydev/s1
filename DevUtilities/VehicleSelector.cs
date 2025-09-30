using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000770 RID: 1904
	[Token(Token = "0x2000770")]
	public class VehicleSelector : Singleton<VehicleSelector>
	{
		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06003380 RID: 13184 RVA: 0x0000E340 File Offset: 0x0000C540
		// (set) Token: 0x06003381 RID: 13185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000779")]
		public bool isSelecting
		{
			[Token(Token = "0x6003380")]
			[Address(RVA = "0x4BE260", Offset = "0x4BCC60", VA = "0x1804BE260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003381")]
			[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003382")]
		[Address(RVA = "0x78F4A0", Offset = "0x78DEA0", VA = "0x18078F4A0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003383")]
		[Address(RVA = "0x78F720", Offset = "0x78E120", VA = "0x18078F720", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003384")]
		[Address(RVA = "0x78EF30", Offset = "0x78D930", VA = "0x18078EF30", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003385")]
		[Address(RVA = "0x78EDB0", Offset = "0x78D7B0", VA = "0x18078EDB0")]
		private LandVehicle GetHoveredVehicle()
		{
			return null;
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003386")]
		[Address(RVA = "0x78ED70", Offset = "0x78D770", VA = "0x18078ED70")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003387")]
		[Address(RVA = "0x78F230", Offset = "0x78DC30", VA = "0x18078F230")]
		public void StartSelecting(string selectionTitle, ref List<LandVehicle> initialSelection, int _selectionLimit, bool _exitOnSelectionLimit, [Optional] Func<LandVehicle, bool> filter)
		{
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003388")]
		[Address(RVA = "0x78F550", Offset = "0x78DF50", VA = "0x18078F550")]
		public void StopSelecting()
		{
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003389")]
		[Address(RVA = "0x78FAC0", Offset = "0x78E4C0", VA = "0x18078FAC0")]
		public VehicleSelector()
		{
		}

		// Token: 0x040023B8 RID: 9144
		[Token(Token = "0x40023B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Settings")]
		protected float detectionRange;

		// Token: 0x040023B9 RID: 9145
		[Token(Token = "0x40023B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected LayerMask detectionMask;

		// Token: 0x040023BB RID: 9147
		[Token(Token = "0x40023BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<LandVehicle> selectedVehicles;

		// Token: 0x040023BC RID: 9148
		[Token(Token = "0x40023BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action onClose;

		// Token: 0x040023BD RID: 9149
		[Token(Token = "0x40023BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int selectionLimit;

		// Token: 0x040023BE RID: 9150
		[Token(Token = "0x40023BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool exitOnSelectionLimit;

		// Token: 0x040023BF RID: 9151
		[Token(Token = "0x40023BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LandVehicle hoveredVehicle;

		// Token: 0x040023C0 RID: 9152
		[Token(Token = "0x40023C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<LandVehicle> outlinedVehicles;

		// Token: 0x040023C1 RID: 9153
		[Token(Token = "0x40023C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Func<LandVehicle, bool> vehicleFilter;
	}
}
