﻿using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using XCommas.Net;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Misc
{
    public class XCommasClient : IXCommasClient
    {
        private readonly ILogger _logger;
        private readonly XCommasApi _3CommasClient;

        public XCommasClient(Keys settings, ILogger logger)
        {
            _logger = logger;
            _3CommasClient = new XCommasApi(settings.ApiKey3Commas, settings.Secret3Commas);
        }

        public async Task<XCommasResponse<Bot>> CreateBotAsync(int accountId, Strategy strategy, BotData botData)
        {
            return await _3CommasClient.CreateBotAsync(accountId, strategy, botData);
        }

        public async Task<XCommasResponse<Bot>> UpdateBotAsync(int botId, BotUpdateData botUpdateData)
        {
            return await _3CommasClient.UpdateBotAsync(botId, botUpdateData);
        }

        public async Task<XCommasResponse<Bot[]>> GetBotsAsync(int limit, int offset, Strategy strategy, BotScope botScope)
        {
            return await _3CommasClient.GetBotsAsync(limit, offset, strategy: strategy, botScope: botScope);
        }

        public async Task<XCommasResponse<Account[]>> GetAccountsAsync()
        {
            return await _3CommasClient.GetAccountsAsync();
        }

        public async Task<XCommasResponse<BotPairsBlackListData>> GetBotPairsBlackListAsync()
        {
            return await _3CommasClient.GetBotPairsBlackListAsync();
        }

        public async Task<XCommasResponse<Bot>> EnableBotAsync(int botId)
        {
            return await _3CommasClient.EnableBotAsync(botId);
        }
    }
}