using System.Threading.Tasks;

namespace MAVN.Service.PrivateBlockchainFacade.Domain.Features.Wallets
{
    public interface IWalletsService
    {
        Task<CustomerWalletCreationResultModel> CreateCustomerWalletAsync(string customerId);
        Task<CustomerWalletAddressResultModel> GetCustomerWalletAsync(string customerId);
        Task<CustomerIdByWalletResultModel> GetCustomerIdByWalletAsync(string walletAddress);
    }
}
