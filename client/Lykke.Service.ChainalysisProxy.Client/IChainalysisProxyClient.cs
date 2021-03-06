﻿
using System.Threading.Tasks;
using Lykke.Service.ChainalysisProxy.Contracts;
using NewTransactionModel = Lykke.Service.ChainalysisProxy.Client.AutorestClient.Models.NewTransactionModel;
using NewWalletModel = Lykke.Service.ChainalysisProxy.Client.AutorestClient.Models.NewWalletModel;

namespace Lykke.Service.ChainalysisProxy.Client
{
    /// <summary>
    /// Chainalysis Proxy Client 
    /// </summary>
    public interface IChainalysisProxyClient
    {
        /// <summary>
        /// Resigter user for track
        /// </summary>
        /// <param name="userId">Lykke user Id (won't be use for Chainalisys)</param>
        /// <returns></returns>
        Task<UserScoreDetails> RegisterUser(string userId);

        /// <summary>
        /// Get Information about user
        /// </summary>
        /// <param name="userId">Lykke user Id (won't be use for Chainalisys)</param>
        /// <returns>Information about user</returns>

        Task<UserScoreDetails> GetUserScore(string userId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">Lykke user Id (won't be use for Chainalisys)</param>
        /// <param name="transaction">Transaction to be added</param>
        /// <returns>Information about user</returns>

        Task<UserScoreDetails> AddTransaction(string userId, Contracts.NewTransactionModel transaction);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId">Lykke user Id (won't be use for Chainalisys)</param>
        /// <param name="wallet">Wallet to be added</param>
        /// <returns>Information about user</returns>

        Task<UserScoreDetails> AddWallet(string userId, Contracts.NewWalletModel wallet);
    }
}
