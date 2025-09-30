using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.Graffiti
{
	// Token: 0x0200058D RID: 1421
	[Token(Token = "0x200058D")]
	public class SpraySurface : NetworkBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x0000A668 File Offset: 0x00008868
		// (set) Token: 0x06001FFB RID: 8187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000584")]
		public Guid GUID
		{
			[Token(Token = "0x6001FFA")]
			[Address(RVA = "0x682F10", Offset = "0x681910", VA = "0x180682F10", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6001FFB")]
			[Address(RVA = "0x682FC0", Offset = "0x6819C0", VA = "0x180682FC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FFD RID: 8189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000585")]
		public NetworkObject CurrentEditor
		{
			[Token(Token = "0x6001FFC")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FFD")]
			[Address(RVA = "0x5ADF40", Offset = "0x5AC940", VA = "0x1805ADF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000586")]
		public Drawing Drawing
		{
			[Token(Token = "0x6001FFE")]
			[Address(RVA = "0x672D40", Offset = "0x671740", VA = "0x180672D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FFF")]
			[Address(RVA = "0x672DD0", Offset = "0x6717D0", VA = "0x180672DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x0000A680 File Offset: 0x00008880
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000587")]
		public EMapRegion Region
		{
			[Token(Token = "0x6002000")]
			[Address(RVA = "0x682F20", Offset = "0x681920", VA = "0x180682F20")]
			[CompilerGenerated]
			get
			{
				return EMapRegion.Northtown;
			}
			[Token(Token = "0x6002001")]
			[Address(RVA = "0x682FD0", Offset = "0x6819D0", VA = "0x180682FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x0000A698 File Offset: 0x00008898
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000588")]
		public bool HasDrawingBeenFinalized
		{
			[Token(Token = "0x6002002")]
			[Address(RVA = "0x66EF20", Offset = "0x66D920", VA = "0x18066EF20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002003")]
			[Address(RVA = "0x66F070", Offset = "0x66DA70", VA = "0x18066F070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x17000589")]
		public Vector3 TopRightPoint
		{
			[Token(Token = "0x6002004")]
			[Address(RVA = "0x682F30", Offset = "0x681930", VA = "0x180682F30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x67FC30", Offset = "0x67E630", VA = "0x18067FC30", Slot = "22")]
		public virtual void Awake()
		{
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002006")]
		[Address(RVA = "0x682BB0", Offset = "0x6815B0", VA = "0x180682BB0")]
		private void Start()
		{
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002007")]
		[Address(RVA = "0x680BF0", Offset = "0x67F5F0", VA = "0x180680BF0", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x680CE0", Offset = "0x67F6E0", VA = "0x180680CE0")]
		private void ResizeProjector()
		{
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x67FD30", Offset = "0x67E730", VA = "0x18067FD30")]
		public bool CanBeEdited()
		{
			return default(bool);
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x680A00", Offset = "0x67F400", VA = "0x180680A00", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x680C60", Offset = "0x67F660", VA = "0x180680C60")]
		public void ReplicateTo(NetworkConnection conn)
		{
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x6821D0", Offset = "0x680BD0", VA = "0x1806821D0")]
		[ServerRpc(RequireOwnership = false)]
		public void SetCurrentEditor_Server(NetworkObject player)
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x6825C0", Offset = "0x680FC0", VA = "0x1806825C0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetCurrentEditor_Client(NetworkConnection conn, NetworkObject player)
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x67FA40", Offset = "0x67E440", VA = "0x18067FA40")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void AddStrokes_Server(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x67F8D0", Offset = "0x67E2D0", VA = "0x18067F8D0")]
		[ObserversRpc(RunLocally = true)]
		private void AddStrokes_Client(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x67FDE0", Offset = "0x67E7E0", VA = "0x18067FDE0")]
		[ServerRpc(RequireOwnership = false)]
		public void ClearDrawing()
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x67FEF0", Offset = "0x67E8F0", VA = "0x18067FEF0")]
		private void CreateNewDrawing()
		{
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x67FCF0", Offset = "0x67E6F0", VA = "0x18067FCF0")]
		public void CacheDrawing()
		{
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x680E40", Offset = "0x67F840", VA = "0x180680E40")]
		public void RestoreFromCache()
		{
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x682DC0", Offset = "0x6817C0", VA = "0x180682DC0")]
		public Vector3 ToWorldPosition(UShort2 coordinate, float offset = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x680590", Offset = "0x67EF90", VA = "0x180680590")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void MarkDrawingFinalized()
		{
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x681350", Offset = "0x67FD50", VA = "0x180681350")]
		[ObserversRpc(RunLocally = true)]
		private void SetFinalized()
		{
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x6828A0", Offset = "0x6812A0", VA = "0x1806828A0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Set(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized)
		{
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x680300", Offset = "0x67ED00", VA = "0x180680300")]
		private void DrawingChanged()
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x680330", Offset = "0x67ED30", VA = "0x180680330")]
		private float[] GetFalloffTable()
		{
			return null;
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x682830", Offset = "0x681230", VA = "0x180682830", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x680C10", Offset = "0x67F610", VA = "0x180680C10")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x682B40", Offset = "0x681540", VA = "0x180682B40")]
		public bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x6804E0", Offset = "0x67EEE0", VA = "0x1806804E0")]
		public SpraySurfaceData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x682E40", Offset = "0x681840", VA = "0x180682E40")]
		public SpraySurface()
		{
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x680700", Offset = "0x67F100", VA = "0x180680700", Slot = "23")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x6806E0", Offset = "0x67F0E0", VA = "0x1806806E0", Slot = "24")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x6806A0", Offset = "0x67F0A0", VA = "0x1806806A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x6821D0", Offset = "0x680BD0", VA = "0x1806821D0")]
		private void RpcWriter___Server_SetCurrentEditor_Server_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x6814B0", Offset = "0x67FEB0", VA = "0x1806814B0")]
		public void RpcLogic___SetCurrentEditor_Server_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002024")]
		[Address(RVA = "0x681870", Offset = "0x680270", VA = "0x180681870")]
		private void RpcReader___Server_SetCurrentEditor_Server_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002025")]
		[Address(RVA = "0x681B80", Offset = "0x680580", VA = "0x180681B80")]
		private void RpcWriter___Observers_SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player)
		{
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002026")]
		[Address(RVA = "0x681490", Offset = "0x67FE90", VA = "0x180681490")]
		private void RpcLogic___SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player)
		{
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002027")]
		[Address(RVA = "0x6815F0", Offset = "0x67FFF0", VA = "0x1806815F0")]
		private void RpcReader___Observers_SetCurrentEditor_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002028")]
		[Address(RVA = "0x682300", Offset = "0x680D00", VA = "0x180682300")]
		private void RpcWriter___Target_SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player)
		{
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002029")]
		[Address(RVA = "0x6818E0", Offset = "0x6802E0", VA = "0x1806818E0")]
		private void RpcReader___Target_SetCurrentEditor_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202A")]
		[Address(RVA = "0x681F50", Offset = "0x680950", VA = "0x180681F50")]
		private void RpcWriter___Server_AddStrokes_Server_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202B")]
		[Address(RVA = "0x67F8D0", Offset = "0x67E2D0", VA = "0x18067F8D0")]
		public void RpcLogic___AddStrokes_Server_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202C")]
		[Address(RVA = "0x681750", Offset = "0x680150", VA = "0x180681750")]
		private void RpcReader___Server_AddStrokes_Server_1511871282(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202D")]
		[Address(RVA = "0x681A00", Offset = "0x680400", VA = "0x180681A00")]
		private void RpcWriter___Observers_AddStrokes_Client_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202E")]
		[Address(RVA = "0x681090", Offset = "0x67FA90", VA = "0x180681090")]
		private void RpcLogic___AddStrokes_Client_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202F")]
		[Address(RVA = "0x681560", Offset = "0x67FF60", VA = "0x180681560")]
		private void RpcReader___Observers_AddStrokes_Client_1511871282(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002030")]
		[Address(RVA = "0x67FDE0", Offset = "0x67E7E0", VA = "0x18067FDE0")]
		private void RpcWriter___Server_ClearDrawing_2166136261()
		{
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x681180", Offset = "0x67FB80", VA = "0x180681180")]
		public void RpcLogic___ClearDrawing_2166136261()
		{
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x6817F0", Offset = "0x6801F0", VA = "0x1806817F0")]
		private void RpcReader___Server_ClearDrawing_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x6820C0", Offset = "0x680AC0", VA = "0x1806820C0")]
		private void RpcWriter___Server_MarkDrawingFinalized_2166136261()
		{
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002034")]
		[Address(RVA = "0x681350", Offset = "0x67FD50", VA = "0x180681350")]
		public void RpcLogic___MarkDrawingFinalized_2166136261()
		{
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002035")]
		[Address(RVA = "0x681820", Offset = "0x680220", VA = "0x180681820")]
		private void RpcReader___Server_MarkDrawingFinalized_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002036")]
		[Address(RVA = "0x681CC0", Offset = "0x6806C0", VA = "0x180681CC0")]
		private void RpcWriter___Observers_SetFinalized_2166136261()
		{
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002037")]
		[Address(RVA = "0x6814C0", Offset = "0x67FEC0", VA = "0x1806814C0")]
		private void RpcLogic___SetFinalized_2166136261()
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002038")]
		[Address(RVA = "0x681670", Offset = "0x680070", VA = "0x180681670")]
		private void RpcReader___Observers_SetFinalized_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002039")]
		[Address(RVA = "0x681DE0", Offset = "0x6807E0", VA = "0x180681DE0")]
		private void RpcWriter___Observers_Set_4105842735(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized)
		{
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x6814D0", Offset = "0x67FED0", VA = "0x1806814D0")]
		public void RpcLogic___Set_4105842735(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized)
		{
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x6816A0", Offset = "0x6800A0", VA = "0x1806816A0")]
		private void RpcReader___Observers_Set_4105842735(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x682460", Offset = "0x680E60", VA = "0x180682460")]
		private void RpcWriter___Target_Set_4105842735(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized)
		{
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x681960", Offset = "0x680360", VA = "0x180681960")]
		private void RpcReader___Target_Set_4105842735(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x67FBA0", Offset = "0x67E5A0", VA = "0x18067FBA0")]
		private void Awake_UserLogic_ScheduleOne.Graffiti.SpraySurface_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001A3B RID: 6715
		[Token(Token = "0x4001A3B")]
		public const float PIXEL_SIZE = 0.006666671f;

		// Token: 0x04001A3C RID: 6716
		[Token(Token = "0x4001A3C")]
		public const int PADDING = 8;

		// Token: 0x04001A42 RID: 6722
		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x140")]
		[Header("Settings")]
		public string BakedGUID;

		// Token: 0x04001A43 RID: 6723
		[Token(Token = "0x4001A43")]
		[FieldOffset(Offset = "0x148")]
		[Range(1f, 1000f)]
		public int Width;

		// Token: 0x04001A44 RID: 6724
		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x14C")]
		[Range(1f, 1000f)]
		public int Height;

		// Token: 0x04001A45 RID: 6725
		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0x150")]
		public AnimationCurve FalloffCurve;

		// Token: 0x04001A46 RID: 6726
		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x158")]
		[Range(0f, 100f)]
		public int FalloffRadius;

		// Token: 0x04001A47 RID: 6727
		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x160")]
		[Header("References")]
		public Transform BottomLeftPoint;

		// Token: 0x04001A48 RID: 6728
		[Token(Token = "0x4001A48")]
		[FieldOffset(Offset = "0x168")]
		public DecalProjector Projector;

		// Token: 0x04001A49 RID: 6729
		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x170")]
		private Drawing cachedDrawing;

		// Token: 0x04001A4A RID: 6730
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x178")]
		public Action onDrawingChanged;

		// Token: 0x04001A4B RID: 6731
		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x180")]
		private List<int> pastRequestIDs;

		// Token: 0x04001A4C RID: 6732
		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.Graffiti.SpraySurfaceAssembly-CSharp.dll_Excuted;

		// Token: 0x04001A4D RID: 6733
		[Token(Token = "0x4001A4D")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.Graffiti.SpraySurfaceAssembly-CSharp.dll_Excuted;
	}
}
