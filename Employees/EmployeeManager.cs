using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x020005C1 RID: 1473
	[Token(Token = "0x20005C1")]
	public class EmployeeManager : NetworkSingleton<EmployeeManager>
	{
		// Token: 0x060022F8 RID: 8952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x6CC680", Offset = "0x6CB080", VA = "0x1806CC680")]
		public void CreateNewEmployee(Property property, EEmployeeType type)
		{
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x6CC5E0", Offset = "0x6CAFE0", VA = "0x1806CC5E0")]
		[ServerRpc(RequireOwnership = false)]
		public void CreateEmployee(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x6CBF80", Offset = "0x6CA980", VA = "0x1806CBF80")]
		public Employee CreateEmployee_Server(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid)
		{
			return null;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0000B0D0 File Offset: 0x000092D0
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x6CD120", Offset = "0x6CBB20", VA = "0x1806CD120")]
		private bool IsPositionValid(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0000B0E8 File Offset: 0x000092E8
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x6CD190", Offset = "0x6CBB90", VA = "0x1806CD190")]
		private bool IsRotationValid(Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0000B100 File Offset: 0x00009300
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x6CD0F0", Offset = "0x6CBAF0", VA = "0x1806CD0F0")]
		private bool IsFloatValid(float value)
		{
			return default(bool);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x6CD410", Offset = "0x6CBE10", VA = "0x1806CD410")]
		public void RegisterName(string name)
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x6CD310", Offset = "0x6CBD10", VA = "0x1806CD310")]
		public void RegisterAppearance(bool male, int index)
		{
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002300")]
		[Address(RVA = "0x6CCAA0", Offset = "0x6CB4A0", VA = "0x1806CCAA0")]
		public void GenerateRandomName(bool male, out string firstName, out string lastName)
		{
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002301")]
		[Address(RVA = "0x6CCC10", Offset = "0x6CB610", VA = "0x1806CCC10")]
		public EmployeeManager.EmployeeAppearance GetAppearance(bool male, int index)
		{
			return null;
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002302")]
		[Address(RVA = "0x6CD090", Offset = "0x6CBA90", VA = "0x1806CD090")]
		public VODatabase GetVoice(bool male, int index)
		{
			return null;
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002303")]
		[Address(RVA = "0x6CCF40", Offset = "0x6CB940", VA = "0x1806CCF40")]
		public void GetRandomAppearance(bool male, out int index, out AvatarSettings settings)
		{
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002304")]
		[Address(RVA = "0x6CCC90", Offset = "0x6CB690", VA = "0x1806CCC90")]
		public Employee GetEmployeePrefab(EEmployeeType type)
		{
			return null;
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002305")]
		[Address(RVA = "0x6CCDB0", Offset = "0x6CB7B0", VA = "0x1806CCDB0")]
		public List<Employee> GetEmployeesByType(EEmployeeType type)
		{
			return null;
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002306")]
		[Address(RVA = "0x6CDA80", Offset = "0x6CC480", VA = "0x1806CDA80")]
		public EmployeeManager()
		{
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002307")]
		[Address(RVA = "0x6CD270", Offset = "0x6CBC70", VA = "0x1806CD270", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002308")]
		[Address(RVA = "0x6CD220", Offset = "0x6CBC20", VA = "0x1806CD220", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002309")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230A")]
		[Address(RVA = "0x6CD750", Offset = "0x6CC150", VA = "0x1806CD750")]
		private void RpcWriter___Server_CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230B")]
		[Address(RVA = "0x6CD4C0", Offset = "0x6CBEC0", VA = "0x1806CD4C0")]
		public void RpcLogic___CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230C")]
		[Address(RVA = "0x6CD560", Offset = "0x6CBF60", VA = "0x1806CD560")]
		private void RpcReader___Server_CreateEmployee_311954683(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600230D")]
		[Address(RVA = "0x6CBF10", Offset = "0x6CA910", VA = "0x1806CBF10", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04001BAA RID: 7082
		[Token(Token = "0x4001BAA")]
		public const float MALE_EMPLOYEE_CHANCE = 0.67f;

		// Token: 0x04001BAB RID: 7083
		[Token(Token = "0x4001BAB")]
		[FieldOffset(Offset = "0x120")]
		public List<Employee> AllEmployees;

		// Token: 0x04001BAC RID: 7084
		[Token(Token = "0x4001BAC")]
		[FieldOffset(Offset = "0x128")]
		public Quest_Employees[] EmployeeQuests;

		// Token: 0x04001BAD RID: 7085
		[Token(Token = "0x4001BAD")]
		[FieldOffset(Offset = "0x130")]
		[Header("Prefabs")]
		public Botanist BotanistPrefab;

		// Token: 0x04001BAE RID: 7086
		[Token(Token = "0x4001BAE")]
		[FieldOffset(Offset = "0x138")]
		public Packager PackagerPrefab;

		// Token: 0x04001BAF RID: 7087
		[Token(Token = "0x4001BAF")]
		[FieldOffset(Offset = "0x140")]
		public Chemist ChemistPrefab;

		// Token: 0x04001BB0 RID: 7088
		[Token(Token = "0x4001BB0")]
		[FieldOffset(Offset = "0x148")]
		public Cleaner CleanerPrefab;

		// Token: 0x04001BB1 RID: 7089
		[Token(Token = "0x4001BB1")]
		[FieldOffset(Offset = "0x150")]
		[Header("Appearances")]
		public List<EmployeeManager.EmployeeAppearance> MaleAppearances;

		// Token: 0x04001BB2 RID: 7090
		[Token(Token = "0x4001BB2")]
		[FieldOffset(Offset = "0x158")]
		public List<EmployeeManager.EmployeeAppearance> FemaleAppearances;

		// Token: 0x04001BB3 RID: 7091
		[Token(Token = "0x4001BB3")]
		[FieldOffset(Offset = "0x160")]
		[Header("Voices")]
		public VODatabase[] MaleVoices;

		// Token: 0x04001BB4 RID: 7092
		[Token(Token = "0x4001BB4")]
		[FieldOffset(Offset = "0x168")]
		public VODatabase[] FemaleVoices;

		// Token: 0x04001BB5 RID: 7093
		[Token(Token = "0x4001BB5")]
		[FieldOffset(Offset = "0x170")]
		[Header("Names")]
		public string[] MaleFirstNames;

		// Token: 0x04001BB6 RID: 7094
		[Token(Token = "0x4001BB6")]
		[FieldOffset(Offset = "0x178")]
		public string[] FemaleFirstNames;

		// Token: 0x04001BB7 RID: 7095
		[Token(Token = "0x4001BB7")]
		[FieldOffset(Offset = "0x180")]
		public string[] LastNames;

		// Token: 0x04001BB8 RID: 7096
		[Token(Token = "0x4001BB8")]
		[FieldOffset(Offset = "0x188")]
		private List<string> takenNames;

		// Token: 0x04001BB9 RID: 7097
		[Token(Token = "0x4001BB9")]
		[FieldOffset(Offset = "0x190")]
		private List<int> takenMaleAppearances;

		// Token: 0x04001BBA RID: 7098
		[Token(Token = "0x4001BBA")]
		[FieldOffset(Offset = "0x198")]
		private List<int> takenFemaleAppearances;

		// Token: 0x04001BBB RID: 7099
		[Token(Token = "0x4001BBB")]
		[FieldOffset(Offset = "0x1A0")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001BBC RID: 7100
		[Token(Token = "0x4001BBC")]
		[FieldOffset(Offset = "0x1A1")]
		private bool NetworkInitialize__LateScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x020005C2 RID: 1474
		[Token(Token = "0x20005C2")]
		[Serializable]
		public class EmployeeAppearance
		{
			// Token: 0x0600230E RID: 8974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600230E")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public EmployeeAppearance()
			{
			}

			// Token: 0x04001BBD RID: 7101
			[Token(Token = "0x4001BBD")]
			[FieldOffset(Offset = "0x10")]
			public AvatarSettings Settings;

			// Token: 0x04001BBE RID: 7102
			[Token(Token = "0x4001BBE")]
			[FieldOffset(Offset = "0x18")]
			public Sprite Mugshot;
		}
	}
}
