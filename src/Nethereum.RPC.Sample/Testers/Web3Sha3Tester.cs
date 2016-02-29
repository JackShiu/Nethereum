using System;
using System.Threading.Tasks;
using edjCase.JsonRpc.Client;
using Nethereum.RPC.Web3;

namespace Nethereum.RPC.Sample.Testers
{
    public class Web3Sha3Tester : IRPCRequestTester
    {
        public async Task<dynamic> ExecuteTestAsync(RpcClient client)
        {
            var web3Sha3 = new Web3Sha3(client);
            return await web3Sha3.SendRequestAsync( "Monkey");
        }

        public Type GetRequestType()
        {
            return typeof(Web3Sha3Tester);
        }
    }
}